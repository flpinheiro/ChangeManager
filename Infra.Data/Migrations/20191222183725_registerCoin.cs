using Microsoft.EntityFrameworkCore.Migrations;

namespace ChangeManager.Infra.Data.Migrations
{
    public partial class registerCoin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegisterCoin_coin_CoinId",
                table: "RegisterCoin");

            migrationBuilder.DropForeignKey(
                name: "FK_RegisterCoin_register_RegisterId",
                table: "RegisterCoin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RegisterCoin",
                table: "RegisterCoin");

            migrationBuilder.RenameTable(
                name: "RegisterCoin",
                newName: "register_coin");

            migrationBuilder.RenameIndex(
                name: "IX_RegisterCoin_CoinId",
                table: "register_coin",
                newName: "IX_register_coin_CoinId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_register_coin",
                table: "register_coin",
                columns: new[] { "RegisterId", "CoinId" });

            migrationBuilder.AddForeignKey(
                name: "FK_register_coin_coin_CoinId",
                table: "register_coin",
                column: "CoinId",
                principalTable: "coin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_register_coin_register_RegisterId",
                table: "register_coin",
                column: "RegisterId",
                principalTable: "register",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_register_coin_coin_CoinId",
                table: "register_coin");

            migrationBuilder.DropForeignKey(
                name: "FK_register_coin_register_RegisterId",
                table: "register_coin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_register_coin",
                table: "register_coin");

            migrationBuilder.RenameTable(
                name: "register_coin",
                newName: "RegisterCoin");

            migrationBuilder.RenameIndex(
                name: "IX_register_coin_CoinId",
                table: "RegisterCoin",
                newName: "IX_RegisterCoin_CoinId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegisterCoin",
                table: "RegisterCoin",
                columns: new[] { "RegisterId", "CoinId" });

            migrationBuilder.AddForeignKey(
                name: "FK_RegisterCoin_coin_CoinId",
                table: "RegisterCoin",
                column: "CoinId",
                principalTable: "coin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegisterCoin_register_RegisterId",
                table: "RegisterCoin",
                column: "RegisterId",
                principalTable: "register",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
