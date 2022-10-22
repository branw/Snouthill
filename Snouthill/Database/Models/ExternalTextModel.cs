using System.ComponentModel.DataAnnotations;

namespace Snouthill.Database.Models;

public class ExternalTextModel
{
    [Key] public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;
}