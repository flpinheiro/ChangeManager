using Microsoft.EntityFrameworkCore.Migrations;

namespace ChangeManager.Infra.Data.Migrations
{
    public partial class RegisterSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "register",
                columns: new[] { "Id", "name" },
                values: new object[] { 1, "Box 1" });

            migrationBuilder.InsertData(
                table: "register",
                columns: new[] { "Id", "name" },
                values: new object[] { 2, "Box 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "register",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "register",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
