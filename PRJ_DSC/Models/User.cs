using System;
using System.Collections.Generic;

namespace PRJ_DSC.Models;

public partial class User
{
    public int UserId { get; set; }

    public int? RoleId { get; set; }

    public int? SportId { get; set; }

    public int? AccountId { get; set; }

    public string Fullname { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? Gender { get; set; }

    public int? Age { get; set; }

    public decimal? Height { get; set; }

    public decimal? Weight { get; set; }

    public string? Avatar { get; set; }

    public string? Status { get; set; }

    public virtual Account? Account { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<Club> Clubs { get; set; } = new List<Club>();

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual Role? Role { get; set; }

    public virtual Sport? Sport { get; set; }

    public virtual ICollection<Tournament> Tournaments { get; set; } = new List<Tournament>();
}
