using Microsoft.EntityFrameworkCore.Migrations;

namespace ChangeManager.Infra.Data.Migrations
{
    public partial class intCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.AlterColumn<int>(
                name: "quantity",
                table: "RegisterCoin",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int unsigned");

            migrationBuilder.AlterColumn<int>(
                name: "value",
                table: "coin",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int unsigned");

            migrationBuilder.InsertData(
                table: "coin",
                columns: new[] { "Id", "value" },
                values: new object[,]
                {
                    { 12, 10000 },
                    { 11, 5000 },
                    { 10, 2000 },
                    { 9, 1000 },
                    { 8, 500 },
                    { 7, 200 },
                    { 6, 100 },
                    { 5, 50 },
                    { 4, 25 },
                    { 3, 10 },
                    { 2, 5 },
                    { 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "RegisterCoin",
                columns: new[] { "RegisterId", "CoinId", "quantity" },
                values: new object[,]
                {
                    { 1, 12, 0 },
                    { 2, 2, 0 },
                    { 1, 2, 0 },
                    { 2, 3, 0 },
                    { 1, 3, 0 },
                    { 2, 4, 0 },
                    { 1, 4, 0 },
                    { 2, 5, 0 },
                    { 1, 5, 0 },
                    { 2, 6, 0 },
                    { 1, 6, 0 },
                    { 2, 7, 0 },
                    { 1, 7, 0 },
                    { 2, 8, 0 },
                    { 1, 8, 0 },
                    { 2, 9, 0 },
                    { 1, 9, 0 },
                    { 2, 10, 0 },
                    { 1, 10, 0 },
                    { 2, 11, 0 },
                    { 1, 11, 0 },
                    { 2, 12, 0 },
                    { 1, 1, 0 },
                    { 2, 1, 0 }
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

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "coin",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.AlterColumn<uint>(
                name: "quantity",
                table: "RegisterCoin",
                type: "int unsigned",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<uint>(
                name: "value",
                table: "coin",
                type: "int unsigned",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "coin",
                columns: new[] { "Id", "value" },
                values: new object[,]
                {
                    { 12, 10000u },
                    { 11, 5000u },
                    { 10, 2000u },
                    { 9, 1000u },
                    { 8, 500u },
                    { 7, 200u },
                    { 6, 100u },
                    { 5, 50u },
                    { 4, 25u },
                    { 3, 10u },
                    { 2, 5u },
                    { 1, 1u }
                });

            migrationBuilder.InsertData(
                table: "RegisterCoin",
                columns: new[] { "RegisterId", "CoinId", "quantity" },
                values: new object[,]
                {
                    { 1, 12, 0u },
                    { 2, 2, 0u },
                    { 1, 2, 0u },
                    { 2, 3, 0u },
                    { 1, 3, 0u },
                    { 2, 4, 0u },
                    { 1, 4, 0u },
                    { 2, 5, 0u },
                    { 1, 5, 0u },
                    { 2, 6, 0u },
                    { 1, 6, 0u },
                    { 2, 7, 0u },
                    { 1, 7, 0u },
                    { 2, 8, 0u },
                    { 1, 8, 0u },
                    { 2, 9, 0u },
                    { 1, 9, 0u },
                    { 2, 10, 0u },
                    { 1, 10, 0u },
                    { 2, 11, 0u },
                    { 1, 11, 0u },
                    { 2, 12, 0u },
                    { 1, 1, 0u },
                    { 2, 1, 0u }
                });
        }
    }
}
