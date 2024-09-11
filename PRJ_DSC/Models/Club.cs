using System;
using System.Collections.Generic;

namespace PRJ_DSC.Models;

public partial class Club
{
    public int ClubId { get; set; }

    public int? SportId { get; set; }

    public int? UserId { get; set; }

    public int? LevelId { get; set; }

    public string ClubName { get; set; } = null!;

    public string? WeeklySchedule { get; set; }

    public string? Status { get; set; }

    public string? Rules { get; set; }

    public virtual Level? Level { get; set; }

    public virtual Sport? Sport { get; set; }

    public virtual User? User { get; set; }
}
