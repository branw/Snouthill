﻿using System.ComponentModel.DataAnnotations;

namespace Snouthill.Database.Models;

public class CatalogPageModel
{
    [Key] public int Id { get; set; }

    public int SortIndex { get; set; }

    public int MinRole { get; set; }

    public string NameIndex { get; set; } = null!;

    public string LinkList { get; set; } = "";

    public bool IndexVisible { get; set; }

    public bool ClubOnly { get; set; }

    public string Name { get; set; } = null!;

    public string Layout { get; set; } = null!;

    public string ImageHeadline { get; set; } = "";
    public string ImageTeasers { get; set; } = "";

    public string Body { get; set; } = "";

    public string LabelPick { get; set; } = "";
    public string LabelExtraS { get; set; } = "";
    public string LabelExtraT { get; set; } = "";
}