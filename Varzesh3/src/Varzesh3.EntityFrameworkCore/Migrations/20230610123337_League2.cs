using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Varzesh3.Migrations
{
    /// <inheritdoc />
    public partial class League2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Av",
                table: "LeagueDetails",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Av",
                table: "LeagueDetails");
        }
    }
}
