using System;
using System.Collections.Generic;
using System.Text;

namespace Snouthill.Db.Models
{
    class FloorPlanModel
    {
        /// <summary>
        /// Name of the floor plan
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Name of cast file (.cct or .cst) containing the floor plan
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Position and orientation of the entrance
        /// </summary>
        public (int X, int Y, int Z, int Direction) Door { get; set; }
        /// <summary>
        /// Dimensions of X (Length) and Y (Width) directions
        /// </summary>
        public (int Length, int Width) Size { get; set; }
        /// <summary>
        /// Space-delimited height map of tiles; 'x' indicates an inaccessible tile,
        /// while numbers 0 through 9 indicate ascending levels of height (+Z)
        /// </summary>
        public string HeightMap { get; set; }
        /// <summary>
        /// The room features a pool, i.e. swimsuit figures must be sent
        /// </summary>
        public bool HasPool { get; set; }
    }
}
