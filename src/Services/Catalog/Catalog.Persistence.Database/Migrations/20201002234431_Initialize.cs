using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description of product 1", "Product 1", 390m },
                    { 73, "Description of product 73", "Product 73", 502m },
                    { 72, "Description of product 72", "Product 72", 638m },
                    { 71, "Description of product 71", "Product 71", 820m },
                    { 70, "Description of product 70", "Product 70", 770m },
                    { 69, "Description of product 69", "Product 69", 627m },
                    { 68, "Description of product 68", "Product 68", 736m },
                    { 67, "Description of product 67", "Product 67", 573m },
                    { 66, "Description of product 66", "Product 66", 529m },
                    { 65, "Description of product 65", "Product 65", 611m },
                    { 64, "Description of product 64", "Product 64", 277m },
                    { 63, "Description of product 63", "Product 63", 959m },
                    { 62, "Description of product 62", "Product 62", 408m },
                    { 61, "Description of product 61", "Product 61", 291m },
                    { 60, "Description of product 60", "Product 60", 473m },
                    { 59, "Description of product 59", "Product 59", 290m },
                    { 58, "Description of product 58", "Product 58", 584m },
                    { 57, "Description of product 57", "Product 57", 490m },
                    { 56, "Description of product 56", "Product 56", 674m },
                    { 55, "Description of product 55", "Product 55", 420m },
                    { 54, "Description of product 54", "Product 54", 187m },
                    { 53, "Description of product 53", "Product 53", 180m },
                    { 74, "Description of product 74", "Product 74", 526m },
                    { 52, "Description of product 52", "Product 52", 605m },
                    { 75, "Description of product 75", "Product 75", 141m },
                    { 77, "Description of product 77", "Product 77", 725m },
                    { 98, "Description of product 98", "Product 98", 812m },
                    { 97, "Description of product 97", "Product 97", 570m },
                    { 96, "Description of product 96", "Product 96", 509m },
                    { 95, "Description of product 95", "Product 95", 581m },
                    { 94, "Description of product 94", "Product 94", 516m },
                    { 93, "Description of product 93", "Product 93", 280m },
                    { 92, "Description of product 92", "Product 92", 378m },
                    { 91, "Description of product 91", "Product 91", 496m },
                    { 90, "Description of product 90", "Product 90", 710m },
                    { 89, "Description of product 89", "Product 89", 453m },
                    { 88, "Description of product 88", "Product 88", 151m },
                    { 87, "Description of product 87", "Product 87", 127m },
                    { 86, "Description of product 86", "Product 86", 919m },
                    { 85, "Description of product 85", "Product 85", 494m },
                    { 84, "Description of product 84", "Product 84", 636m },
                    { 83, "Description of product 83", "Product 83", 182m },
                    { 82, "Description of product 82", "Product 82", 727m },
                    { 81, "Description of product 81", "Product 81", 739m },
                    { 80, "Description of product 80", "Product 80", 177m },
                    { 79, "Description of product 79", "Product 79", 388m },
                    { 78, "Description of product 78", "Product 78", 134m },
                    { 76, "Description of product 76", "Product 76", 461m },
                    { 51, "Description of product 51", "Product 51", 949m },
                    { 50, "Description of product 50", "Product 50", 274m },
                    { 49, "Description of product 49", "Product 49", 983m },
                    { 22, "Description of product 22", "Product 22", 715m },
                    { 21, "Description of product 21", "Product 21", 891m },
                    { 20, "Description of product 20", "Product 20", 859m },
                    { 19, "Description of product 19", "Product 19", 299m },
                    { 18, "Description of product 18", "Product 18", 392m },
                    { 17, "Description of product 17", "Product 17", 109m },
                    { 16, "Description of product 16", "Product 16", 683m },
                    { 15, "Description of product 15", "Product 15", 657m },
                    { 14, "Description of product 14", "Product 14", 912m },
                    { 13, "Description of product 13", "Product 13", 510m },
                    { 12, "Description of product 12", "Product 12", 712m },
                    { 11, "Description of product 11", "Product 11", 637m },
                    { 10, "Description of product 10", "Product 10", 136m },
                    { 9, "Description of product 9", "Product 9", 621m },
                    { 8, "Description of product 8", "Product 8", 769m },
                    { 7, "Description of product 7", "Product 7", 475m },
                    { 6, "Description of product 6", "Product 6", 236m },
                    { 5, "Description of product 5", "Product 5", 627m },
                    { 4, "Description of product 4", "Product 4", 474m },
                    { 3, "Description of product 3", "Product 3", 665m },
                    { 2, "Description of product 2", "Product 2", 942m },
                    { 23, "Description of product 23", "Product 23", 551m },
                    { 24, "Description of product 24", "Product 24", 181m },
                    { 25, "Description of product 25", "Product 25", 284m },
                    { 26, "Description of product 26", "Product 26", 254m },
                    { 48, "Description of product 48", "Product 48", 316m },
                    { 47, "Description of product 47", "Product 47", 514m },
                    { 46, "Description of product 46", "Product 46", 207m },
                    { 45, "Description of product 45", "Product 45", 792m },
                    { 44, "Description of product 44", "Product 44", 517m },
                    { 43, "Description of product 43", "Product 43", 990m },
                    { 42, "Description of product 42", "Product 42", 530m },
                    { 41, "Description of product 41", "Product 41", 818m },
                    { 40, "Description of product 40", "Product 40", 772m },
                    { 39, "Description of product 39", "Product 39", 890m },
                    { 99, "Description of product 99", "Product 99", 905m },
                    { 38, "Description of product 38", "Product 38", 470m },
                    { 36, "Description of product 36", "Product 36", 886m },
                    { 35, "Description of product 35", "Product 35", 384m },
                    { 34, "Description of product 34", "Product 34", 774m },
                    { 33, "Description of product 33", "Product 33", 239m },
                    { 32, "Description of product 32", "Product 32", 208m },
                    { 31, "Description of product 31", "Product 31", 525m },
                    { 30, "Description of product 30", "Product 30", 443m },
                    { 29, "Description of product 29", "Product 29", 810m },
                    { 28, "Description of product 28", "Product 28", 166m },
                    { 27, "Description of product 27", "Product 27", 944m },
                    { 37, "Description of product 37", "Product 37", 862m },
                    { 100, "Description of product 100", "Product 100", 363m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 87 },
                    { 73, 73, 22 },
                    { 72, 72, 98 },
                    { 71, 71, 99 },
                    { 70, 70, 73 },
                    { 69, 69, 87 },
                    { 68, 68, 58 },
                    { 67, 67, 79 },
                    { 66, 66, 66 },
                    { 65, 65, 84 },
                    { 64, 64, 59 },
                    { 63, 63, 19 },
                    { 62, 62, 40 },
                    { 61, 61, 69 },
                    { 60, 60, 3 },
                    { 59, 59, 62 },
                    { 58, 58, 27 },
                    { 57, 57, 22 },
                    { 56, 56, 18 },
                    { 55, 55, 38 },
                    { 54, 54, 55 },
                    { 53, 53, 5 },
                    { 74, 74, 81 },
                    { 52, 52, 74 },
                    { 75, 75, 78 },
                    { 77, 77, 37 },
                    { 98, 98, 71 },
                    { 97, 97, 28 },
                    { 96, 96, 96 },
                    { 95, 95, 28 },
                    { 94, 94, 18 },
                    { 93, 93, 89 },
                    { 92, 92, 55 },
                    { 91, 91, 91 },
                    { 90, 90, 19 },
                    { 89, 89, 61 },
                    { 88, 88, 74 },
                    { 87, 87, 27 },
                    { 86, 86, 2 },
                    { 85, 85, 96 },
                    { 84, 84, 17 },
                    { 83, 83, 14 },
                    { 82, 82, 23 },
                    { 81, 81, 77 },
                    { 80, 80, 94 },
                    { 79, 79, 71 },
                    { 78, 78, 34 },
                    { 76, 76, 4 },
                    { 51, 51, 71 },
                    { 50, 50, 96 },
                    { 49, 49, 96 },
                    { 22, 22, 68 },
                    { 21, 21, 52 },
                    { 20, 20, 15 },
                    { 19, 19, 79 },
                    { 18, 18, 44 },
                    { 17, 17, 50 },
                    { 16, 16, 82 },
                    { 15, 15, 87 },
                    { 14, 14, 25 },
                    { 13, 13, 58 },
                    { 12, 12, 9 },
                    { 11, 11, 0 },
                    { 10, 10, 61 },
                    { 9, 9, 27 },
                    { 8, 8, 33 },
                    { 7, 7, 51 },
                    { 6, 6, 6 },
                    { 5, 5, 34 },
                    { 4, 4, 37 },
                    { 3, 3, 41 },
                    { 2, 2, 45 },
                    { 23, 23, 22 },
                    { 24, 24, 14 },
                    { 25, 25, 74 },
                    { 26, 26, 31 },
                    { 48, 48, 14 },
                    { 47, 47, 54 },
                    { 46, 46, 79 },
                    { 45, 45, 43 },
                    { 44, 44, 88 },
                    { 43, 43, 31 },
                    { 42, 42, 48 },
                    { 41, 41, 37 },
                    { 40, 40, 97 },
                    { 39, 39, 21 },
                    { 99, 99, 4 },
                    { 38, 38, 52 },
                    { 36, 36, 13 },
                    { 35, 35, 37 },
                    { 34, 34, 0 },
                    { 33, 33, 29 },
                    { 32, 32, 33 },
                    { 31, 31, 77 },
                    { 30, 30, 67 },
                    { 29, 29, 14 },
                    { 28, 28, 11 },
                    { 27, 27, 37 },
                    { 37, 37, 82 },
                    { 100, 100, 76 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
