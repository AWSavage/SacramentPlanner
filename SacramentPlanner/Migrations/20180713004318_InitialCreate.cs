using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SacramentPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Program",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClosingPrayer = table.Column<string>(type: "TEXT", nullable: true),
                    ClosingSong = table.Column<string>(type: "TEXT", nullable: true),
                    Conducting = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FirstSpeaker = table.Column<string>(type: "TEXT", nullable: true),
                    IntermediateSong = table.Column<string>(type: "TEXT", nullable: true),
                    OpeningPrayer = table.Column<string>(type: "TEXT", nullable: true),
                    OpeningSong = table.Column<string>(type: "TEXT", nullable: true),
                    SacramentSong = table.Column<string>(type: "TEXT", nullable: true),
                    SecondSpeaker = table.Column<string>(type: "TEXT", nullable: true),
                    ThirdSong = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Program");
        }
    }
}
