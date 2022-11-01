using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.DataBase.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
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
                columns: table => new
                {
                    StockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.StockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 6754m },
                    { 73, "Description for product 73", "Product 73", 7003m },
                    { 72, "Description for product 72", "Product 72", 5583m },
                    { 71, "Description for product 71", "Product 71", 5028m },
                    { 70, "Description for product 70", "Product 70", 7403m },
                    { 69, "Description for product 69", "Product 69", 831m },
                    { 68, "Description for product 68", "Product 68", 1312m },
                    { 67, "Description for product 67", "Product 67", 7911m },
                    { 66, "Description for product 66", "Product 66", 8447m },
                    { 65, "Description for product 65", "Product 65", 2420m },
                    { 64, "Description for product 64", "Product 64", 1663m },
                    { 63, "Description for product 63", "Product 63", 9835m },
                    { 62, "Description for product 62", "Product 62", 9925m },
                    { 61, "Description for product 61", "Product 61", 9471m },
                    { 60, "Description for product 60", "Product 60", 4735m },
                    { 59, "Description for product 59", "Product 59", 9583m },
                    { 58, "Description for product 58", "Product 58", 7729m },
                    { 57, "Description for product 57", "Product 57", 5558m },
                    { 56, "Description for product 56", "Product 56", 1668m },
                    { 55, "Description for product 55", "Product 55", 1045m },
                    { 54, "Description for product 54", "Product 54", 8413m },
                    { 53, "Description for product 53", "Product 53", 2684m },
                    { 74, "Description for product 74", "Product 74", 7637m },
                    { 52, "Description for product 52", "Product 52", 7086m },
                    { 75, "Description for product 75", "Product 75", 244m },
                    { 77, "Description for product 77", "Product 77", 568m },
                    { 98, "Description for product 98", "Product 98", 3153m },
                    { 97, "Description for product 97", "Product 97", 6248m },
                    { 96, "Description for product 96", "Product 96", 3678m },
                    { 95, "Description for product 95", "Product 95", 6169m },
                    { 94, "Description for product 94", "Product 94", 7443m },
                    { 93, "Description for product 93", "Product 93", 4339m },
                    { 92, "Description for product 92", "Product 92", 8899m },
                    { 91, "Description for product 91", "Product 91", 4478m },
                    { 90, "Description for product 90", "Product 90", 2055m },
                    { 89, "Description for product 89", "Product 89", 5546m },
                    { 88, "Description for product 88", "Product 88", 2504m },
                    { 87, "Description for product 87", "Product 87", 6978m },
                    { 86, "Description for product 86", "Product 86", 1150m },
                    { 85, "Description for product 85", "Product 85", 3985m },
                    { 84, "Description for product 84", "Product 84", 8329m },
                    { 83, "Description for product 83", "Product 83", 9416m },
                    { 82, "Description for product 82", "Product 82", 9141m },
                    { 81, "Description for product 81", "Product 81", 3113m },
                    { 80, "Description for product 80", "Product 80", 1650m },
                    { 79, "Description for product 79", "Product 79", 2655m },
                    { 78, "Description for product 78", "Product 78", 6759m },
                    { 76, "Description for product 76", "Product 76", 2203m },
                    { 51, "Description for product 51", "Product 51", 7466m },
                    { 50, "Description for product 50", "Product 50", 4343m },
                    { 49, "Description for product 49", "Product 49", 8423m },
                    { 22, "Description for product 22", "Product 22", 5185m },
                    { 21, "Description for product 21", "Product 21", 8188m },
                    { 20, "Description for product 20", "Product 20", 3748m },
                    { 19, "Description for product 19", "Product 19", 3278m },
                    { 18, "Description for product 18", "Product 18", 9082m },
                    { 17, "Description for product 17", "Product 17", 9406m },
                    { 16, "Description for product 16", "Product 16", 1657m },
                    { 15, "Description for product 15", "Product 15", 7340m },
                    { 14, "Description for product 14", "Product 14", 4355m },
                    { 13, "Description for product 13", "Product 13", 7704m },
                    { 12, "Description for product 12", "Product 12", 8729m },
                    { 11, "Description for product 11", "Product 11", 8011m },
                    { 10, "Description for product 10", "Product 10", 557m },
                    { 9, "Description for product 9", "Product 9", 3015m },
                    { 8, "Description for product 8", "Product 8", 2508m },
                    { 7, "Description for product 7", "Product 7", 7764m },
                    { 6, "Description for product 6", "Product 6", 2635m },
                    { 5, "Description for product 5", "Product 5", 7788m },
                    { 4, "Description for product 4", "Product 4", 2227m },
                    { 3, "Description for product 3", "Product 3", 9975m },
                    { 2, "Description for product 2", "Product 2", 8117m },
                    { 23, "Description for product 23", "Product 23", 2658m },
                    { 24, "Description for product 24", "Product 24", 2345m },
                    { 25, "Description for product 25", "Product 25", 2644m },
                    { 26, "Description for product 26", "Product 26", 3153m },
                    { 48, "Description for product 48", "Product 48", 4021m },
                    { 47, "Description for product 47", "Product 47", 139m },
                    { 46, "Description for product 46", "Product 46", 1093m },
                    { 45, "Description for product 45", "Product 45", 9690m },
                    { 44, "Description for product 44", "Product 44", 5899m },
                    { 43, "Description for product 43", "Product 43", 4716m },
                    { 42, "Description for product 42", "Product 42", 6084m },
                    { 41, "Description for product 41", "Product 41", 3604m },
                    { 40, "Description for product 40", "Product 40", 5641m },
                    { 39, "Description for product 39", "Product 39", 2178m },
                    { 99, "Description for product 99", "Product 99", 3578m },
                    { 38, "Description for product 38", "Product 38", 3922m },
                    { 36, "Description for product 36", "Product 36", 9936m },
                    { 35, "Description for product 35", "Product 35", 3624m },
                    { 34, "Description for product 34", "Product 34", 6491m },
                    { 33, "Description for product 33", "Product 33", 917m },
                    { 32, "Description for product 32", "Product 32", 9563m },
                    { 31, "Description for product 31", "Product 31", 8136m },
                    { 30, "Description for product 30", "Product 30", 1452m },
                    { 29, "Description for product 29", "Product 29", 2672m },
                    { 28, "Description for product 28", "Product 28", 7839m },
                    { 27, "Description for product 27", "Product 27", 3163m },
                    { 37, "Description for product 37", "Product 37", 6629m },
                    { 100, "Description for product 100", "Product 100", 1342m }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "StockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 72 },
                    { 73, 73, 50 },
                    { 72, 72, 95 },
                    { 71, 71, 33 },
                    { 70, 70, 83 },
                    { 69, 69, 77 },
                    { 68, 68, 68 },
                    { 67, 67, 75 },
                    { 66, 66, 90 },
                    { 65, 65, 8 },
                    { 64, 64, 61 },
                    { 63, 63, 93 },
                    { 62, 62, 59 },
                    { 61, 61, 44 },
                    { 60, 60, 97 },
                    { 59, 59, 88 },
                    { 58, 58, 78 },
                    { 57, 57, 82 },
                    { 56, 56, 18 },
                    { 55, 55, 53 },
                    { 54, 54, 66 },
                    { 53, 53, 15 },
                    { 74, 74, 44 },
                    { 52, 52, 64 },
                    { 75, 75, 77 },
                    { 77, 77, 47 },
                    { 98, 98, 45 },
                    { 97, 97, 29 },
                    { 96, 96, 55 },
                    { 95, 95, 81 },
                    { 94, 94, 56 },
                    { 93, 93, 39 },
                    { 92, 92, 80 },
                    { 91, 91, 62 },
                    { 90, 90, 95 },
                    { 89, 89, 20 },
                    { 88, 88, 12 },
                    { 87, 87, 86 },
                    { 86, 86, 17 },
                    { 85, 85, 40 },
                    { 84, 84, 76 },
                    { 83, 83, 87 },
                    { 82, 82, 9 },
                    { 81, 81, 24 },
                    { 80, 80, 21 },
                    { 79, 79, 25 },
                    { 78, 78, 73 },
                    { 76, 76, 49 },
                    { 51, 51, 39 },
                    { 50, 50, 29 },
                    { 49, 49, 90 },
                    { 22, 22, 54 },
                    { 21, 21, 71 },
                    { 20, 20, 92 },
                    { 19, 19, 69 },
                    { 18, 18, 4 },
                    { 17, 17, 24 },
                    { 16, 16, 91 },
                    { 15, 15, 28 },
                    { 14, 14, 90 },
                    { 13, 13, 42 },
                    { 12, 12, 54 },
                    { 11, 11, 91 },
                    { 10, 10, 88 },
                    { 9, 9, 41 },
                    { 8, 8, 98 },
                    { 7, 7, 37 },
                    { 6, 6, 65 },
                    { 5, 5, 55 },
                    { 4, 4, 44 },
                    { 3, 3, 27 },
                    { 2, 2, 28 },
                    { 23, 23, 45 },
                    { 24, 24, 48 },
                    { 25, 25, 55 },
                    { 26, 26, 57 },
                    { 48, 48, 12 },
                    { 47, 47, 34 },
                    { 46, 46, 35 },
                    { 45, 45, 24 },
                    { 44, 44, 72 },
                    { 43, 43, 7 },
                    { 42, 42, 22 },
                    { 41, 41, 15 },
                    { 40, 40, 25 },
                    { 39, 39, 53 },
                    { 99, 99, 65 },
                    { 38, 38, 28 },
                    { 36, 36, 45 },
                    { 35, 35, 14 },
                    { 34, 34, 73 },
                    { 33, 33, 78 },
                    { 32, 32, 2 },
                    { 31, 31, 80 },
                    { 30, 30, 79 },
                    { 29, 29, 6 },
                    { 28, 28, 77 },
                    { 27, 27, 21 },
                    { 37, 37, 58 },
                    { 100, 100, 33 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                table: "Stocks",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_StockId",
                table: "Stocks",
                column: "StockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
