using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Copa.Migrations
{
    public partial class addJogoIdSelecao3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoAId1",
                table: "Jogos");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoBId1",
                table: "Jogos");

            migrationBuilder.DropIndex(
                name: "IX_Jogos_SelecaoAId1",
                table: "Jogos");

            migrationBuilder.DropIndex(
                name: "IX_Jogos_SelecaoBId1",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "JogoId",
                table: "Selecoes");

            migrationBuilder.DropColumn(
                name: "SelecaoAId1",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "SelecaoBId1",
                table: "Jogos");

            migrationBuilder.AlterColumn<int>(
                name: "SelecaoBId",
                table: "Jogos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "SelecaoAId",
                table: "Jogos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_SelecaoAId",
                table: "Jogos",
                column: "SelecaoAId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_SelecaoBId",
                table: "Jogos",
                column: "SelecaoBId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoAId",
                table: "Jogos",
                column: "SelecaoAId",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoBId",
                table: "Jogos",
                column: "SelecaoBId",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoAId",
                table: "Jogos");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoBId",
                table: "Jogos");

            migrationBuilder.DropIndex(
                name: "IX_Jogos_SelecaoAId",
                table: "Jogos");

            migrationBuilder.DropIndex(
                name: "IX_Jogos_SelecaoBId",
                table: "Jogos");

            migrationBuilder.AddColumn<int>(
                name: "JogoId",
                table: "Selecoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SelecaoBId",
                table: "Jogos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SelecaoAId",
                table: "Jogos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SelecaoAId1",
                table: "Jogos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SelecaoBId1",
                table: "Jogos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_SelecaoAId1",
                table: "Jogos",
                column: "SelecaoAId1");

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_SelecaoBId1",
                table: "Jogos",
                column: "SelecaoBId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoAId1",
                table: "Jogos",
                column: "SelecaoAId1",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoBId1",
                table: "Jogos",
                column: "SelecaoBId1",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
