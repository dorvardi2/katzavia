using Microsoft.EntityFrameworkCore.Migrations;

namespace Katzavia.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Desc", "Image", "Name", "Price" },
                values: new object[] { "  שניצל דק מהמשק לצרכן, מהמשק לצרכן", "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/0a8c59b4-750d-11eb-9ca0-22bcbb5f5130_chickenschnitzel.001.jpeg", "שניצל דק ללא אנטיביוטיקה", 55.0 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Desc", "Image", "Name", "Price", "UserId" },
                values: new object[,]
                {
                    { 2, 1, "  עוף מעולה שגדל במשק כפרי ויגרום לכם להרגיש אירופה", "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/03a06f58-750f-11eb-a1bf-e2c2878d6758_chicken_quarter.001.jpeg", "כריים עוף ללא אנטיביוטיקה", 55.0, null },
                    { 3, 1, "  כבד עוף טחון שנטחן באהבה", "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/a0c5e4dc-767e-11eb-8e1a-1e4144159da5_chicken_liver.001.jpeg", "כבד עוף טחון", 29.0, null },
                    { 4, 1, "  עוף טחון שגודל במשק כפרי ומעניק לארוחה נינוח אירופאי", "https://imageproxy.wolt.com/menu/menu-images/6005573773650cccaa260b6d/d41fc3ba-63a6-11eb-9a11-f204402e8831_ground_chicken.001.jpeg", "עוף טחון", 25.0, null },
                    { 5, 1, "שוקיים יפים של עוף יפה", "https://imageproxy.wolt.com/menu/menu-images/6005573773650cccaa260b6d/2204ad7a-63a7-11eb-98ce-c66654228715_chicken_leg.001.jpeg", "שוקיים עוף", 47.0, null },
                    { 6, 2, " בשר שנטחן במקום במכונה מיוחדת ומתאים לכל אוהב בשרים", "https://imageproxy.wolt.com/menu/menu-images/6005573773650cccaa260b6d/86f6c36c-63a7-11eb-b059-8e95cfb0afa3_groundbeef.002.jpeg", "בשר טחון", 39.0, null },
                    { 7, 2, "סינטה איכותית, שמתאימה רק לאנשים יוקרתיים", "https://imageproxy.wolt.com/menu/menu-images/6005573773650cccaa260b6d/86f6c36c-63a7-11eb-b059-8e95cfb0afa3_groundbeef.002.jpeg", "מארז סינטה פרוסה (800 גרם)", 159.0, null },
                    { 8, 2, "גולש איכותי שארוז היטב כדי לייצר ארוחה בנינוח חמים", "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/af12e5da-7516-11eb-8259-7e368d1a5f1e_beefbites.001__1_.jpeg", "מארז קוביות לבישול גולש (800 גרם)", 89.0, null },
                    { 9, 2, "אסאדו ארגינטאי שמחזיר אתכם לדרום אמריקה", "https://imageproxy.wolt.com/menu/menu-images/6005573773650cccaa260b6d/ef0a04d8-63ab-11eb-ba0c-16593b832e51_short_ribs.001.jpeg", "אסאדו (1 ק", 99.0, null },
                    { 10, 2, "צלי כתף איכותי מרמת הגולן!", "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/0b82f486-7517-11eb-be52-d2b6ff40ab95_beef_soulder.001__2_.jpeg", "צלי כתף (900 גרם)", 116.0, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Desc", "Image", "Name", "Price" },
                values: new object[] { "נתח שוק טרי מהגולן!", "https://www.israelhayom.co.il/sites/default/files/styles/566x349/public/images/articles/2019/10/01/15699621369034_b.jpg", "שוקיים", 7.0 });
        }
    }
}
