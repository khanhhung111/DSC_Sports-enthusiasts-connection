using System;
using System.Collections.Generic;

namespace PRJ_DSC.Models;

public partial class Tournament
{
    public int TournamentId { get; set; }

    public int? UserId { get; set; }

    public int? LevelId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Location { get; set; }

    public int? NumberOfTeams { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Rules { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual Level? Level { get; set; }

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual User? User { get; set; }
}
