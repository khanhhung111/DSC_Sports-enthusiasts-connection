using System;
using System.Collections.Generic;

namespace PRJ_DSC.Models;

public partial class Sport
{
    public int SportId { get; set; }

    public int? LevelId { get; set; }

    public string SportName { get; set; } = null!;

    public string? Position { get; set; }

    public string? Achievement { get; set; }

    public virtual ICollection<Club> Clubs { get; set; } = new List<Club>();

    public virtual Level? Level { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
