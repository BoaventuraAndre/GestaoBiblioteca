using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.DAL.Migrations
{
    public partial class AdicionadoModelosdeEntidadeCorrigidos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberoDeCopias",
                table: "AtivosBiblioteca");

            migrationBuilder.AddColumn<int>(
                name: "NumeroDeCopias",
                table: "AtivosBiblioteca",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroDeCopias",
                table: "AtivosBiblioteca");

            migrationBuilder.AddColumn<int>(
                name: "NumberoDeCopias",
                table: "AtivosBiblioteca",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
