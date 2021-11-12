using Microsoft.EntityFrameworkCore.Migrations;

namespace Katzavia.Migrations
{
    public partial class mezave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "עופות טריים");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "בשר בקר טרי");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "מזווה" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Desc", "Image", "Name", "Price", "UserId" },
                values: new object[,]
                {
                    { 16, 4, "חרדל דיז'ון צרפתי היישר מפריז הרחוקה", "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/a277f7fc-7b51-11eb-8ca8-aaf19c238eb9_______.014.jpeg", "חרדל דיז'ון חלק", 13.0, null },
                    { 17, 4, "מחית עגבניות מתקתק למנגל מושלם", "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/136039ac-7b52-11eb-8d85-6ea0a7595342_______.020.jpeg", "מחית עגבניות", 16.0, null },
                    { 18, 4, "רוטב חריף בסגנון מקסיקו", "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/69965ff4-7b52-11eb-9b3a-564c812693f5_______.024.jpeg", "רוטב חריף סרירצ'ה", 40.0, null },
                    { 19, 4, "לחמניות עגולות להמבורגר", "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/7aba352e-7bf4-11eb-9865-e28c87392c16_hamburgerbun.001.jpeg", "לחמניות המבורגר", 18.0, null },
                    { 20, 4, "רוטב טבסקו חריף ומטריף", "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/e4444560-7b50-11eb-9911-aaf19c238eb9_______.001.jpeg", "רוטב טבסקו", 17.0, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "פרה");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "כבש");
        }
    }
}
