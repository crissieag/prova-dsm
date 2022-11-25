using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Copa.Migrations
{
    public partial class MigrationPalpiteJogo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JogoId",
                table: "Palpites",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Palpites_JogoId",
                table: "Palpites",
                column: "JogoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Palpites_Selecoes_JogoId",
                table: "Palpites",
                column: "JogoId",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Palpites_Selecoes_JogoId",
                table: "Palpites");

            migrationBuilder.DropIndex(
                name: "IX_Palpites_JogoId",
                table: "Palpites");

            migrationBuilder.DropColumn(
                name: "JogoId",
                table: "Palpites");
        }
    }
}
