using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoitureAPi2.Migrations
{
    public partial class newmig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCerculation",
                table: "voitures",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "voitures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCerculation",
                table: "voitures");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "voitures");
        }
    }
}
