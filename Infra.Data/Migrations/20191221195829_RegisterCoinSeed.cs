using Microsoft.EntityFrameworkCore.Migrations;

namespace ChangeManager.Infra.Data.Migrations
{
    public partial class RegisterCoinSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RegisterCoin",
                columns: new[] { "RegisterId", "CoinId", "quantity" },
                values: new object[,]
                {
                    { 1, 1, 0u },
                    { 2, 10, 0u },
                    { 2, 9, 0u },
                    { 2, 8, 0u },
                    { 2, 7, 0u },
                    { 2, 6, 0u },
                    { 2, 5, 0u },
                    { 2, 4, 0u },
                    { 2, 3, 0u },
                    { 2, 2, 0u },
                    { 2, 1, 0u },
                    { 1, 12, 0u },
                    { 1, 11, 0u },
                    { 1, 10, 0u },
                    { 1, 9, 0u },
                    { 1, 8, 0u },
                    { 1, 7, 0u },
                    { 1, 6, 0u },
                    { 1, 5, 0u },
                    { 1, 4, 0u },
                    { 1, 3, 0u },
                    { 1, 2, 0u },
                    { 2, 11, 0u },
                    { 2, 12, 0u }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "RegisterCoin",
                keyColumns: new[] { "RegisterId", "CoinId" },
                keyValues: new object[] { 2, 12 });
        }
    }
}
