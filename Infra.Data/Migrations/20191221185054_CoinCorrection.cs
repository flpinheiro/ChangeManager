using Microsoft.EntityFrameworkCore.Migrations;

namespace ChangeManager.Infra.Data.Migrations
{
    public partial class CoinCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "quantity",
                table: "coin");

            migrationBuilder.AddColumn<uint>(
                name: "quantity",
                table: "RegisterCoin",
                nullable: false,
                defaultValue: 0u);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "quantity",
                table: "RegisterCoin");

            migrationBuilder.AddColumn<uint>(
                name: "quantity",
                table: "coin",
                type: "int unsigned",
                nullable: false,
                defaultValue: 0u);
        }
    }
}
