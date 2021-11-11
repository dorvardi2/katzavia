using Microsoft.EntityFrameworkCore.Migrations;

namespace Katzavia.Migrations
{
    public partial class Initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Password", "Type", "Username" },
                values: new object[] { 8, "aasssa@aaa.com", "123456", 0, "Liel" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
