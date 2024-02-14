using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VScMariaDB.Migrations
{
    /// <inheritdoc />
    public partial class novatabela2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "preco",
                table: "Produto",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Produto",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Produto",
                newName: "preco");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Produto",
                newName: "id");
        }
    }
}
