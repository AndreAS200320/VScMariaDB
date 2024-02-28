using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VScMariaDB.Migrations
{
    /// <inheritdoc />
    public partial class AddPromo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Promoções",
                table: "Produto",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Promoções",
                table: "Produto");
        }
    }
}
