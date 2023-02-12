using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoitureAPi2.Migrations
{
    public partial class newmig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCategorie",
                table: "voitures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_voitures_IdCategorie",
                table: "voitures",
                column: "IdCategorie");

            migrationBuilder.AddForeignKey(
                name: "FK_voitures_categories_IdCategorie",
                table: "voitures",
                column: "IdCategorie",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_voitures_categories_IdCategorie",
                table: "voitures");

            migrationBuilder.DropIndex(
                name: "IX_voitures_IdCategorie",
                table: "voitures");

            migrationBuilder.DropColumn(
                name: "IdCategorie",
                table: "voitures");
        }
    }
}
