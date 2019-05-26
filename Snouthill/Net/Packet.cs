using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace Snouthill.Net
{
    class PropertyAttribute : Attribute
    {
        public int Order => _order;
        private readonly int _order;

        public string Prefix { get; }
        public string Suffix { get; }

        public bool Optional { get; }

        public PropertyAttribute([CallerLineNumber]int order = 0, string prefix = null, string suffix = null, string delim = null, bool optional = false)
        {
            _order = order;

            if (!string.IsNullOrEmpty(delim))
            {
                prefix = suffix = delim;
            }
            Prefix = prefix;
            Suffix = suffix;

            Optional = optional;
        }
    }

    public abstract class PacketComponent {
        protected IOrderedEnumerable<PropertyInfo> Properties =>
            GetType().GetProperties()
                .Where(p => p.IsDefined(typeof(PropertyAttribute)))
                .OrderBy(p => p.GetCustomAttribute<PropertyAttribute>().Order);

        public override string ToString()
        {
            var props = new List<string>();

            foreach (var prop in Properties)
            {
                string value;
                if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                {
                    var elements = new List<string>();
                    foreach (var element in (IEnumerable)prop.GetValue(this))
                    {
                        elements.Add(element.ToString());
                    }

                    value = $"{{{String.Join(", ", elements)}}}";
                }
                else
                {
                    value = prop.GetValue(this)?.ToString();
                }

                props.Add($"{prop.Name}: {value}");
            }

            return $"{this.GetType().Name} {{{String.Join(", ", props)}}}";
        }
    }

    public abstract class Packet : PacketComponent
    {
        public abstract string Operation { get; }

        private static Dictionary<string, Type> _byOperation = null;
        public static Dictionary<string, Type> ByOperation => _byOperation ??
            (_byOperation = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.IsSubclassOf(typeof(Packet)) && !t.IsAbstract)
                .ToDictionary(t => ((Packet)FormatterServices.GetUninitializedObject(t)).Operation.ToUpper()));

        public string Raw
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append($"#{Operation}");

                foreach (var prop in Properties)
                {
                    Serialize(sb, prop, this);
                }

                sb.Append("##");
                return sb.ToString();
            }
        }

        public static Packet Parse(string rawPacket)
        {
            var splitPacket = rawPacket.TrimEnd().Split(' ', count: 2);
            var hasBody = splitPacket.Length == 2;

            var operation = splitPacket[0].ToUpper();
            var body = hasBody ? splitPacket[1] : null;

            if (ByOperation.ContainsKey(operation))
            {
                var packet = (Packet)Activator.CreateInstance(ByOperation[operation]);
                if (body != null)
                {
                    packet.Populate(body);
                }

                return packet;
            }

            return null;
        }

        private void Populate(string packet)
        {
            foreach (var prop in Properties)
            {
                var attrib = prop.GetCustomAttribute<PropertyAttribute>();

                if (string.IsNullOrEmpty(packet))
                {
                    if (attrib.Optional)
                    {
                        continue;
                    }

                    throw new Exception("Required property is missing");
                }

                //Log.Debug("packet={packet} prefix={prefix} suffix={suffix}", packet, attrib.Prefix, attrib.Suffix);

                if (!string.IsNullOrEmpty(attrib.Prefix))
                {
                    if (!packet.StartsWith(attrib.Prefix))
                    {
                        throw new Exception("Prefix not found");
                    }

                    packet = packet.Substring(attrib.Prefix.Length);
                }

                var length = packet.Length;
                var lengthWithSuffix = length;
                if (!string.IsNullOrEmpty(attrib.Suffix) && packet.Contains(attrib.Suffix))
                {
                    length = packet.IndexOf(attrib.Suffix);
                    lengthWithSuffix = length + attrib.Suffix.Length;
                }

                var propValue = packet.Substring(0, length);
                if (prop.PropertyType == typeof(string))
                {
                    prop.SetValue(this, propValue);
                }
                else if (prop.PropertyType == typeof(int) || prop.PropertyType == typeof(int?))
                {
                    prop.SetValue(this, Convert.ToInt32(propValue));
                }
                else
                {
                    throw new NotImplementedException("Unknown property type");
                }

                packet = packet.Substring(lengthWithSuffix);
            }
        }

        private void Serialize(StringBuilder sb, PropertyInfo prop, object instance)
        {
            var attrib = prop.GetCustomAttribute<PropertyAttribute>();

            // Property is an IEnumerable
            if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(IEnumerable<>))
            {
                var list = (IEnumerable)prop.GetValue(instance);
                foreach (var element in list)
                {
                    sb.Append($"{attrib.Prefix ?? ""}");
                    foreach (var subprop in element.GetType().GetProperties()
                        .Where(p => p.IsDefined(typeof(PropertyAttribute)))
                        .OrderBy(p => p.GetCustomAttribute<PropertyAttribute>().Order))
                    {

                        Serialize(sb, subprop, element);
                    }
                }

                sb.Append($"{attrib.Suffix ?? ""}");
            }
            // Property is a singular value
            else
            {
                sb.Append($"{attrib.Prefix ?? ""}{prop.GetValue(instance)}{attrib.Suffix ?? ""}");
            }
        }
    }

    public abstract class OutboundPacket : Packet { }

    public abstract class InboundPacket : Packet { }

    interface IPacketHandler
    {
        void Handle(Client client);
    }
}
