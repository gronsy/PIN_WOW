using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PIN_WOWRaids.Migrations
{
    public partial class id02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MainRole",
                table: "Member",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainSpec",
                table: "Member",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OffRole",
                table: "Member",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OffSpec",
                table: "Member",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainRole",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "MainSpec",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "OffRole",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "OffSpec",
                table: "Member");
        }
    }
}
