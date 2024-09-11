using System;
using System.Collections.Generic;

namespace PRJ_DSC.Models;

public partial class Level
{
    public int LevelId { get; set; }

    public string LevelName { get; set; } = null!;

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<Club> Clubs { get; set; } = new List<Club>();

    public virtual ICollection<Sport> Sports { get; set; } = new List<Sport>();

    public virtual ICollection<Tournament> Tournaments { get; set; } = new List<Tournament>();
}
