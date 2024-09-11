using System;
using System.Collections.Generic;

namespace PRJ_DSC.Models;

public partial class Notification
{
    public int NotificationId { get; set; }

    public int? ActivityId { get; set; }

    public int? TournamentId { get; set; }

    public string Content { get; set; } = null!;

    public virtual Activity? Activity { get; set; }

    public virtual Tournament? Tournament { get; set; }
}
