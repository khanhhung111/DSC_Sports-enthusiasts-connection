using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PRJ_DSC.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Account__349DA5865917363F", x => x.AccountID);
                });

            migrationBuilder.CreateTable(
                name: "Level",
                columns: table => new
                {
                    LevelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Level__09F03C06677572E8", x => x.LevelID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Role__8AFACE3A4DBB3D5B", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Sport",
                columns: table => new
                {
                    SportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelID = table.Column<int>(type: "int", nullable: true),
                    SportName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Position = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Achievement = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Sport__7A41AF1C153DF369", x => x.SportID);
                    table.ForeignKey(
                        name: "FK__Sport__LevelID__286302EC",
                        column: x => x.LevelID,
                        principalTable: "Level",
                        principalColumn: "LevelID");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleID = table.Column<int>(type: "int", nullable: true),
                    SportID = table.Column<int>(type: "int", nullable: true),
                    AccountID = table.Column<int>(type: "int", nullable: true),
                    Fullname = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Address = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Gender = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    Avatar = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__User__1788CCACD1995F13", x => x.UserID);
                    table.ForeignKey(
                        name: "FK__User__AccountID__3E52440B",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "AccountID");
                    table.ForeignKey(
                        name: "FK__User__RoleID__3C69FB99",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID");
                    table.ForeignKey(
                        name: "FK__User__SportID__3D5E1FD2",
                        column: x => x.SportID,
                        principalTable: "Sport",
                        principalColumn: "SportID");
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ActivityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    LevelID = table.Column<int>(type: "int", nullable: true),
                    ActivityName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    Location = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    NumberOfTeams = table.Column<int>(type: "int", nullable: true),
                    Expense = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Activiti__45F4A7F1F0660450", x => x.ActivityID);
                    table.ForeignKey(
                        name: "FK__Activitie__Level__46E78A0C",
                        column: x => x.LevelID,
                        principalTable: "Level",
                        principalColumn: "LevelID");
                    table.ForeignKey(
                        name: "FK__Activitie__UserI__45F365D3",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    ClubID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SportID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    LevelID = table.Column<int>(type: "int", nullable: true),
                    ClubName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    WeeklySchedule = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Rules = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Clubs__D35058C70DD3684E", x => x.ClubID);
                    table.ForeignKey(
                        name: "FK__Clubs__LevelID__4316F928",
                        column: x => x.LevelID,
                        principalTable: "Level",
                        principalColumn: "LevelID");
                    table.ForeignKey(
                        name: "FK__Clubs__SportID__412EB0B6",
                        column: x => x.SportID,
                        principalTable: "Sport",
                        principalColumn: "SportID");
                    table.ForeignKey(
                        name: "FK__Clubs__UserID__4222D4EF",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    TournamentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    LevelID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true),
                    Location = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    NumberOfTeams = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: true),
                    Rules = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tourname__AC6313334A00B968", x => x.TournamentID);
                    table.ForeignKey(
                        name: "FK__Tournamen__Level__4AB81AF0",
                        column: x => x.LevelID,
                        principalTable: "Level",
                        principalColumn: "LevelID");
                    table.ForeignKey(
                        name: "FK__Tournamen__UserI__49C3F6B7",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    ActivityID = table.Column<int>(type: "int", nullable: true),
                    TournamentID = table.Column<int>(type: "int", nullable: true),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    Star = table.Column<int>(type: "int", nullable: true),
                    Level = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Image = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Comment__C3B4DFAA97EEE26D", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK__Comment__Activit__4E88ABD4",
                        column: x => x.ActivityID,
                        principalTable: "Activities",
                        principalColumn: "ActivityID");
                    table.ForeignKey(
                        name: "FK__Comment__Tournam__4F7CD00D",
                        column: x => x.TournamentID,
                        principalTable: "Tournaments",
                        principalColumn: "TournamentID");
                    table.ForeignKey(
                        name: "FK__Comment__UserID__4D94879B",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    NotificationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityID = table.Column<int>(type: "int", nullable: true),
                    TournamentID = table.Column<int>(type: "int", nullable: true),
                    Content = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Notifica__20CF2E32E879D70F", x => x.NotificationID);
                    table.ForeignKey(
                        name: "FK__Notificat__Activ__52593CB8",
                        column: x => x.ActivityID,
                        principalTable: "Activities",
                        principalColumn: "ActivityID");
                    table.ForeignKey(
                        name: "FK__Notificat__Tourn__534D60F1",
                        column: x => x.TournamentID,
                        principalTable: "Tournaments",
                        principalColumn: "TournamentID");
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "AccountID", "Email", "Password", "UserID" },
                values: new object[] { 1, "admin@gmail.com", "admin123", 1 });

            migrationBuilder.InsertData(
                table: "Level",
                columns: new[] { "LevelID", "LevelName" },
                values: new object[,]
                {
                    { 1, "Beginner" },
                    { 2, "Intermediate" },
                    { 3, "Professional" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleID", "RoleName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" },
                    { 3, "Organizer" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "AccountID", "Address", "Age", "Avatar", "Fullname", "Gender", "Height", "Phone", "RoleID", "SportID", "Status", "Weight" },
                values: new object[] { 1, null, "123 Admin St", 30, null, "Admin", "Male", 175m, "1234567890", 1, null, "Active", 70m });

            migrationBuilder.CreateIndex(
                name: "UQ__Account__A9D105348F3BCB55",
                table: "Account",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Activities_LevelID",
                table: "Activities",
                column: "LevelID");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_UserID",
                table: "Activities",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_LevelID",
                table: "Clubs",
                column: "LevelID");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_SportID",
                table: "Clubs",
                column: "SportID");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_UserID",
                table: "Clubs",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ActivityID",
                table: "Comment",
                column: "ActivityID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_TournamentID",
                table: "Comment",
                column: "TournamentID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserID",
                table: "Comment",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_ActivityID",
                table: "Notification",
                column: "ActivityID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_TournamentID",
                table: "Notification",
                column: "TournamentID");

            migrationBuilder.CreateIndex(
                name: "IX_Sport_LevelID",
                table: "Sport",
                column: "LevelID");

            migrationBuilder.CreateIndex(
                name: "IX_Tournaments_LevelID",
                table: "Tournaments",
                column: "LevelID");

            migrationBuilder.CreateIndex(
                name: "IX_Tournaments_UserID",
                table: "Tournaments",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_User_AccountID",
                table: "User",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleID",
                table: "User",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_User_SportID",
                table: "User",
                column: "SportID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Tournaments");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Sport");

            migrationBuilder.DropTable(
                name: "Level");
        }
    }
}
