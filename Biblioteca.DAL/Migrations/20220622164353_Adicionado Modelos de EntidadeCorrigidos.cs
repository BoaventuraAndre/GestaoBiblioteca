using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.DAL.Migrations
{
    public partial class AdicionadoModelosdeEntidadeCorrigidos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfCopies",
                table: "AtivosBiblioteca");

            migrationBuilder.AddColumn<int>(
                name: "NumberoDeCopias",
                table: "AtivosBiblioteca",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberoDeCopias",
                table: "AtivosBiblioteca");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfCopies",
                table: "AtivosBiblioteca",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
