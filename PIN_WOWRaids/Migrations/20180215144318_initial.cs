using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PIN_WOWRaids.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    NickName = table.Column<string>(nullable: true),
                    NumAttended = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RaidDays",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PeopleAttended = table.Column<string>(nullable: true),
                    RaidDate = table.Column<DateTime>(nullable: false),
                    RaidName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaidDays", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "RaidDays");
        }
    }
}
