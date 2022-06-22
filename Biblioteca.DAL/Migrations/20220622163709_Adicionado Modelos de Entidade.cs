using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.DAL.Migrations
{
    public partial class AdicionadoModelosdeEntidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BibliotecaSurcusalPrincipalId",
                table: "Membros",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartaoMembroId",
                table: "Membros",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BibliotecaSurcusais",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 30, nullable: false),
                    Morada = table.Column<string>(nullable: false),
                    Telefone = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    HoraAbertura = table.Column<DateTime>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BibliotecaSurcusais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartoesMembro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cotas = table.Column<decimal>(nullable: false),
                    Registo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartoesMembro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HorasSurcusais",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurcusalId = table.Column<int>(nullable: true),
                    DiaDaSemana = table.Column<int>(nullable: false),
                    HoraAbertura = table.Column<int>(nullable: false),
                    HoraFecho = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorasSurcusais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HorasSurcusais_BibliotecaSurcusais_SurcusalId",
                        column: x => x.SurcusalId,
                        principalTable: "BibliotecaSurcusais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AtivosBiblioteca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: false),
                    Ano = table.Column<int>(nullable: false),
                    EstadoId = table.Column<int>(nullable: false),
                    Preco = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    NumberOfCopies = table.Column<int>(nullable: false),
                    LocalizacaoId = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    ISBN = table.Column<string>(nullable: true),
                    Autor = table.Column<string>(nullable: true),
                    DeweyIndex = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtivosBiblioteca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtivosBiblioteca_Estados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtivosBiblioteca_BibliotecaSurcusais_LocalizacaoId",
                        column: x => x.LocalizacaoId,
                        principalTable: "BibliotecaSurcusais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Checkouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtivoBibliotecaId = table.Column<int>(nullable: false),
                    CartaoMembroId = table.Column<int>(nullable: true),
                    Desde = table.Column<DateTime>(nullable: false),
                    Ate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Checkouts_AtivosBiblioteca_AtivoBibliotecaId",
                        column: x => x.AtivoBibliotecaId,
                        principalTable: "AtivosBiblioteca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkouts_CartoesMembro_CartaoMembroId",
                        column: x => x.CartaoMembroId,
                        principalTable: "CartoesMembro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Esperas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtivoBibliotecaId = table.Column<int>(nullable: true),
                    CartaoMembroId = table.Column<int>(nullable: true),
                    EsperaPedida = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Esperas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Esperas_AtivosBiblioteca_AtivoBibliotecaId",
                        column: x => x.AtivoBibliotecaId,
                        principalTable: "AtivosBiblioteca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Esperas_CartoesMembro_CartaoMembroId",
                        column: x => x.CartaoMembroId,
                        principalTable: "CartoesMembro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoricosCheckout",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtivoBibliotecaId = table.Column<int>(nullable: false),
                    CartaoMembroId = table.Column<int>(nullable: false),
                    Saiu = table.Column<DateTime>(nullable: false),
                    Entrou = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricosCheckout", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricosCheckout_AtivosBiblioteca_AtivoBibliotecaId",
                        column: x => x.AtivoBibliotecaId,
                        principalTable: "AtivosBiblioteca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoricosCheckout_CartoesMembro_CartaoMembroId",
                        column: x => x.CartaoMembroId,
                        principalTable: "CartoesMembro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Membros_BibliotecaSurcusalPrincipalId",
                table: "Membros",
                column: "BibliotecaSurcusalPrincipalId");

            migrationBuilder.CreateIndex(
                name: "IX_Membros_CartaoMembroId",
                table: "Membros",
                column: "CartaoMembroId");

            migrationBuilder.CreateIndex(
                name: "IX_AtivosBiblioteca_EstadoId",
                table: "AtivosBiblioteca",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_AtivosBiblioteca_LocalizacaoId",
                table: "AtivosBiblioteca",
                column: "LocalizacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_AtivoBibliotecaId",
                table: "Checkouts",
                column: "AtivoBibliotecaId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_CartaoMembroId",
                table: "Checkouts",
                column: "CartaoMembroId");

            migrationBuilder.CreateIndex(
                name: "IX_Esperas_AtivoBibliotecaId",
                table: "Esperas",
                column: "AtivoBibliotecaId");

            migrationBuilder.CreateIndex(
                name: "IX_Esperas_CartaoMembroId",
                table: "Esperas",
                column: "CartaoMembroId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricosCheckout_AtivoBibliotecaId",
                table: "HistoricosCheckout",
                column: "AtivoBibliotecaId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricosCheckout_CartaoMembroId",
                table: "HistoricosCheckout",
                column: "CartaoMembroId");

            migrationBuilder.CreateIndex(
                name: "IX_HorasSurcusais_SurcusalId",
                table: "HorasSurcusais",
                column: "SurcusalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Membros_BibliotecaSurcusais_BibliotecaSurcusalPrincipalId",
                table: "Membros",
                column: "BibliotecaSurcusalPrincipalId",
                principalTable: "BibliotecaSurcusais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Membros_CartoesMembro_CartaoMembroId",
                table: "Membros",
                column: "CartaoMembroId",
                principalTable: "CartoesMembro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Membros_BibliotecaSurcusais_BibliotecaSurcusalPrincipalId",
                table: "Membros");

            migrationBuilder.DropForeignKey(
                name: "FK_Membros_CartoesMembro_CartaoMembroId",
                table: "Membros");

            migrationBuilder.DropTable(
                name: "Checkouts");

            migrationBuilder.DropTable(
                name: "Esperas");

            migrationBuilder.DropTable(
                name: "HistoricosCheckout");

            migrationBuilder.DropTable(
                name: "HorasSurcusais");

            migrationBuilder.DropTable(
                name: "AtivosBiblioteca");

            migrationBuilder.DropTable(
                name: "CartoesMembro");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "BibliotecaSurcusais");

            migrationBuilder.DropIndex(
                name: "IX_Membros_BibliotecaSurcusalPrincipalId",
                table: "Membros");

            migrationBuilder.DropIndex(
                name: "IX_Membros_CartaoMembroId",
                table: "Membros");

            migrationBuilder.DropColumn(
                name: "BibliotecaSurcusalPrincipalId",
                table: "Membros");

            migrationBuilder.DropColumn(
                name: "CartaoMembroId",
                table: "Membros");
        }
    }
}
