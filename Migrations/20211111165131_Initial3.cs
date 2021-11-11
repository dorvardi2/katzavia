using Microsoft.EntityFrameworkCore.Migrations;

namespace Katzavia.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "קפואים" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Desc", "Image", "Name", "Price", "UserId" },
                values: new object[,]
                {
                    { 11, 3, "מארז מיוחד שמתאים רק לאנשים שרוצים להרגיש בעלי המבורגריה לארוחת אחת", "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/9b66e99e-7680-11eb-8659-ee36a0dc7fdc_hamburger.001.jpeg", "מארז המבורגרים קצבים (1 ק", 75.0, null },
                    { 12, 3, "מארז פרגיות מתובלנות למנגל עסיסי ", "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/e025ce6a-7680-11eb-b68a-2e498c24de36_chicken_kebab.001.jpeg", "שיפודי פרגית קפוא (1 ק", 85.0, null },
                    { 13, 3, "נקניקיות מרגז חריפות במיוחד! ", "https://imageproxy.wolt.com/menu/menu-images/6005573773650cccaa260b6d/349943be-63ad-11eb-9bc4-7e82d472ce14_chorizo.002.jpeg", "מארז נקניקיות מרגז חריפות (15 יחידות)", 79.0, null },
                    { 14, 3, "קבב עסיסי וטרי מהיצרן לצרכן", "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/60c39b70-7680-11eb-b5ee-ce9ee9811c90_kebab.007.jpeg", "מארז קבב (15 יחידות)", 85.0, null },
                    { 15, 3, "נקניקיות מרגז חריפות במיוחד! ", "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/75ebeef8-7680-11eb-86c6-ee36a0dc7fdc_kebab.007.jpeg", "מארז קבבוני אנטריקוט (15 יחידות)", 75.0, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
