using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VScMariaDB.Migrations
{
    /// <inheritdoc />
    public partial class Promocoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Promoções",
                table: "Produto",
                newName: "Promocoes");

            migrationBuilder.AddColumn<decimal>(
                name: "PromocoesPreco",
                table: "Produto",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PromocoesPreco",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "Promocoes",
                table: "Produto",
                newName: "Promoções");
        }
    }
}
