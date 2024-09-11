using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PRJ_DSC.Models;

public partial class DSCDBContext : DbContext
{
    public DSCDBContext()
    {
    }

    public DSCDBContext(DbContextOptions<DSCDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Activity> Activities { get; set; }

    public virtual DbSet<Club> Clubs { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Level> Levels { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Sport> Sports { get; set; }

    public virtual DbSet<Tournament> Tournaments { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-3VMQCNG\\HUNGSERVER;Initial Catalog=DSC_DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK__Account__349DA5865917363F");

            entity.ToTable("Account");

            entity.HasIndex(e => e.Email, "UQ__Account__A9D105348F3BCB55").IsUnique();

            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Activity>(entity =>
        {
            entity.HasKey(e => e.ActivityId).HasName("PK__Activiti__45F4A7F1F0660450");

            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.ActivityName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Expense).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.LevelId).HasColumnName("LevelID");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("date");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Level).WithMany(p => p.Activities)
                .HasForeignKey(d => d.LevelId)
                .HasConstraintName("FK__Activitie__Level__46E78A0C");

            entity.HasOne(d => d.User).WithMany(p => p.Activities)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Activitie__UserI__45F365D3");
        });

        modelBuilder.Entity<Club>(entity =>
        {
            entity.HasKey(e => e.ClubId).HasName("PK__Clubs__D35058C70DD3684E");

            entity.Property(e => e.ClubId).HasColumnName("ClubID");
            entity.Property(e => e.ClubName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LevelId).HasColumnName("LevelID");
            entity.Property(e => e.Rules).HasColumnType("text");
            entity.Property(e => e.SportId).HasColumnName("SportID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.WeeklySchedule).HasColumnType("text");

            entity.HasOne(d => d.Level).WithMany(p => p.Clubs)
                .HasForeignKey(d => d.LevelId)
                .HasConstraintName("FK__Clubs__LevelID__4316F928");

            entity.HasOne(d => d.Sport).WithMany(p => p.Clubs)
                .HasForeignKey(d => d.SportId)
                .HasConstraintName("FK__Clubs__SportID__412EB0B6");

            entity.HasOne(d => d.User).WithMany(p => p.Clubs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Clubs__UserID__4222D4EF");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PK__Comment__C3B4DFAA97EEE26D");

            entity.ToTable("Comment");

            entity.Property(e => e.CommentId).HasColumnName("CommentID");
            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.Comment1)
                .HasColumnType("text")
                .HasColumnName("Comment");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Level)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TournamentId).HasColumnName("TournamentID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Activity).WithMany(p => p.Comments)
                .HasForeignKey(d => d.ActivityId)
                .HasConstraintName("FK__Comment__Activit__4E88ABD4");

            entity.HasOne(d => d.Tournament).WithMany(p => p.Comments)
                .HasForeignKey(d => d.TournamentId)
                .HasConstraintName("FK__Comment__Tournam__4F7CD00D");

            entity.HasOne(d => d.User).WithMany(p => p.Comments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Comment__UserID__4D94879B");
        });

        modelBuilder.Entity<Level>(entity =>
        {
            entity.HasKey(e => e.LevelId).HasName("PK__Level__09F03C06677572E8");

            entity.ToTable("Level");

            entity.Property(e => e.LevelId).HasColumnName("LevelID");
            entity.Property(e => e.LevelName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.NotificationId).HasName("PK__Notifica__20CF2E32E879D70F");

            entity.ToTable("Notification");

            entity.Property(e => e.NotificationId).HasColumnName("NotificationID");
            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.Content).HasColumnType("text");
            entity.Property(e => e.TournamentId).HasColumnName("TournamentID");

            entity.HasOne(d => d.Activity).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.ActivityId)
                .HasConstraintName("FK__Notificat__Activ__52593CB8");

            entity.HasOne(d => d.Tournament).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.TournamentId)
                .HasConstraintName("FK__Notificat__Tourn__534D60F1");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Role__8AFACE3A4DBB3D5B");

            entity.ToTable("Role");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sport>(entity =>
        {
            entity.HasKey(e => e.SportId).HasName("PK__Sport__7A41AF1C153DF369");

            entity.ToTable("Sport");

            entity.Property(e => e.SportId).HasColumnName("SportID");
            entity.Property(e => e.Achievement).HasColumnType("text");
            entity.Property(e => e.LevelId).HasColumnName("LevelID");
            entity.Property(e => e.Position)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SportName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Level).WithMany(p => p.Sports)
                .HasForeignKey(d => d.LevelId)
                .HasConstraintName("FK__Sport__LevelID__286302EC");
        });

        modelBuilder.Entity<Tournament>(entity =>
        {
            entity.HasKey(e => e.TournamentId).HasName("PK__Tourname__AC6313334A00B968");

            entity.Property(e => e.TournamentId).HasColumnName("TournamentID");
            entity.Property(e => e.CreatedDate).HasColumnType("date");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.LevelId).HasColumnName("LevelID");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Rules).HasColumnType("text");
            entity.Property(e => e.StartDate).HasColumnType("date");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Level).WithMany(p => p.Tournaments)
                .HasForeignKey(d => d.LevelId)
                .HasConstraintName("FK__Tournamen__Level__4AB81AF0");

            entity.HasOne(d => d.User).WithMany(p => p.Tournaments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Tournamen__UserI__49C3F6B7");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CCACD1995F13");

            entity.ToTable("User");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Avatar)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Fullname)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Height).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.SportId).HasColumnName("SportID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weight).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.Account).WithMany(p => p.Users)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("FK__User__AccountID__3E52440B");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__User__RoleID__3C69FB99");

            entity.HasOne(d => d.Sport).WithMany(p => p.Users)
                .HasForeignKey(d => d.SportId)
                .HasConstraintName("FK__User__SportID__3D5E1FD2");
        });

        modelBuilder.Entity<Role>().HasData(
            new Role { RoleId = 1, RoleName = "Admin" },
            new Role { RoleId = 2, RoleName = "User" },
            new Role { RoleId = 3, RoleName = "Organizer" }
);

        modelBuilder.Entity<Level>().HasData(
            new Level { LevelId = 1, LevelName = "Beginner" },
            new Level { LevelId = 2, LevelName = "Intermediate" },
            new Level { LevelId = 3, LevelName = "Professional" }
        );

        modelBuilder.Entity<User>().HasData(
            new User
            {
                UserId = 1,
                RoleId = 1, // Role là Admin
                Fullname = "Admin",
                Phone = "1234567890",
                Address = "123 Admin St",
                Gender = "Male",
                Age = 30,
                Height = 175,
                Weight = 70,
                Avatar = null,
                Status = "Active",
                SportId = null
            }
        );

        modelBuilder.Entity<Account>().HasData(
            new Account
            {
                AccountId = 1,
                UserId = 1,
                Email = "admin@gmail.com",
                Password = "admin123"
            }
        );

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
