using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Copa.Migrations
{
    public partial class MigrationPalpite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Palpites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CriadoEm = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SelecaoAId = table.Column<int>(type: "INTEGER", nullable: true),
                    SelecaoBId = table.Column<int>(type: "INTEGER", nullable: true),
                    PlacarA = table.Column<int>(type: "INTEGER", nullable: false),
                    PlacarB = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palpites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Palpites_Selecoes_SelecaoAId",
                        column: x => x.SelecaoAId,
                        principalTable: "Selecoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Palpites_Selecoes_SelecaoBId",
                        column: x => x.SelecaoBId,
                        principalTable: "Selecoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Palpites_SelecaoAId",
                table: "Palpites",
                column: "SelecaoAId");

            migrationBuilder.CreateIndex(
                name: "IX_Palpites_SelecaoBId",
                table: "Palpites",
                column: "SelecaoBId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Palpites");
        }
    }
}
