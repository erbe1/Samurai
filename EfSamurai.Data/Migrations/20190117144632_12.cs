using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class _12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BattleId",
                table: "Samurais",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Samurais_BattleId",
                table: "Samurais",
                column: "BattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Samurais_Battles_BattleId",
                table: "Samurais",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samurais_Battles_BattleId",
                table: "Samurais");

            migrationBuilder.DropIndex(
                name: "IX_Samurais_BattleId",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "BattleId",
                table: "Samurais");
        }
    }
}
