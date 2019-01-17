using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class MyFirstMigration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samurais_Quotes_QuoteId",
                table: "Samurais");

            migrationBuilder.DropIndex(
                name: "IX_Samurais_QuoteId",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "QuoteId",
                table: "Samurais");

            migrationBuilder.AddColumn<int>(
                name: "SamuraiId",
                table: "Quotes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_SamuraiId",
                table: "Quotes",
                column: "SamuraiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Samurais_SamuraiId",
                table: "Quotes",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Samurais_SamuraiId",
                table: "Quotes");

            migrationBuilder.DropIndex(
                name: "IX_Quotes_SamuraiId",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "SamuraiId",
                table: "Quotes");

            migrationBuilder.AddColumn<int>(
                name: "QuoteId",
                table: "Samurais",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Samurais_QuoteId",
                table: "Samurais",
                column: "QuoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Samurais_Quotes_QuoteId",
                table: "Samurais",
                column: "QuoteId",
                principalTable: "Quotes",
                principalColumn: "QuoteId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
