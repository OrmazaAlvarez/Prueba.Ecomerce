using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.DataBase.Migrations
{
    public partial class UpdateDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Stocks");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Stocks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Price",
                value: 3058m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Price",
                value: 3278m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Price",
                value: 8820m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "Price",
                value: 1544m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "Price",
                value: 4463m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "Price",
                value: 2401m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "Price",
                value: 434m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "Price",
                value: 5124m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "Price",
                value: 9574m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "Price",
                value: 6289m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "Price",
                value: 5206m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "Price",
                value: 5516m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "Price",
                value: 7683m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "Price",
                value: 4093m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "Price",
                value: 8621m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "Price",
                value: 6158m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "Price",
                value: 1981m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "Price",
                value: 2944m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "Price",
                value: 7072m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "Price",
                value: 3654m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                column: "Price",
                value: 243m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                column: "Price",
                value: 417m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "Price",
                value: 7268m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                column: "Price",
                value: 8232m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                column: "Price",
                value: 3926m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                column: "Price",
                value: 5413m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                column: "Price",
                value: 7059m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                column: "Price",
                value: 5464m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                column: "Price",
                value: 1548m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                column: "Price",
                value: 3383m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                column: "Price",
                value: 8825m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                column: "Price",
                value: 4677m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                column: "Price",
                value: 9687m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                column: "Price",
                value: 8586m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                column: "Price",
                value: 1260m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                column: "Price",
                value: 9503m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                column: "Price",
                value: 791m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                column: "Price",
                value: 176m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                column: "Price",
                value: 7023m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                column: "Price",
                value: 6218m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                column: "Price",
                value: 103m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                column: "Price",
                value: 5218m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                column: "Price",
                value: 8227m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                column: "Price",
                value: 7407m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                column: "Price",
                value: 8121m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                column: "Price",
                value: 2367m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                column: "Price",
                value: 5398m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                column: "Price",
                value: 824m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                column: "Price",
                value: 6448m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                column: "Price",
                value: 6445m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51,
                column: "Price",
                value: 3643m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52,
                column: "Price",
                value: 2055m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53,
                column: "Price",
                value: 1535m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54,
                column: "Price",
                value: 9086m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55,
                column: "Price",
                value: 1223m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56,
                column: "Price",
                value: 2740m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57,
                column: "Price",
                value: 6009m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58,
                column: "Price",
                value: 688m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59,
                column: "Price",
                value: 7617m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60,
                column: "Price",
                value: 9049m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61,
                column: "Price",
                value: 5341m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62,
                column: "Price",
                value: 4970m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63,
                column: "Price",
                value: 3676m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64,
                column: "Price",
                value: 6290m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65,
                column: "Price",
                value: 7463m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66,
                column: "Price",
                value: 629m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67,
                column: "Price",
                value: 5829m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68,
                column: "Price",
                value: 9097m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69,
                column: "Price",
                value: 2933m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70,
                column: "Price",
                value: 9117m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71,
                column: "Price",
                value: 5466m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72,
                column: "Price",
                value: 1905m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73,
                column: "Price",
                value: 5921m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74,
                column: "Price",
                value: 953m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75,
                column: "Price",
                value: 3651m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76,
                column: "Price",
                value: 5025m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77,
                column: "Price",
                value: 2189m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78,
                column: "Price",
                value: 9860m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79,
                column: "Price",
                value: 210m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80,
                column: "Price",
                value: 1659m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81,
                column: "Price",
                value: 115m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82,
                column: "Price",
                value: 6335m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83,
                column: "Price",
                value: 9016m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84,
                column: "Price",
                value: 5102m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85,
                column: "Price",
                value: 9740m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86,
                column: "Price",
                value: 6870m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87,
                column: "Price",
                value: 3242m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88,
                column: "Price",
                value: 701m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89,
                column: "Price",
                value: 7462m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90,
                column: "Price",
                value: 8519m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91,
                column: "Price",
                value: 3594m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92,
                column: "Price",
                value: 203m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93,
                column: "Price",
                value: 2558m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94,
                column: "Price",
                value: 7973m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95,
                column: "Price",
                value: 976m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96,
                column: "Price",
                value: 5133m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97,
                column: "Price",
                value: 1641m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98,
                column: "Price",
                value: 2037m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99,
                column: "Price",
                value: 9944m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100,
                column: "Price",
                value: 7592m);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 1,
                column: "Count",
                value: 61);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 2,
                column: "Count",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 3,
                column: "Count",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 4,
                column: "Count",
                value: 64);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 5,
                column: "Count",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 6,
                column: "Count",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 7,
                column: "Count",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 8,
                column: "Count",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 9,
                column: "Count",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 10,
                column: "Count",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 11,
                column: "Count",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 12,
                column: "Count",
                value: 97);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 13,
                column: "Count",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 14,
                column: "Count",
                value: 84);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 15,
                column: "Count",
                value: 69);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 16,
                column: "Count",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 17,
                column: "Count",
                value: 94);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 18,
                column: "Count",
                value: 78);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 19,
                column: "Count",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 20,
                column: "Count",
                value: 79);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 21,
                column: "Count",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 22,
                column: "Count",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 23,
                column: "Count",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 24,
                column: "Count",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 25,
                column: "Count",
                value: 98);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 26,
                column: "Count",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 27,
                column: "Count",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 28,
                column: "Count",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 29,
                column: "Count",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 30,
                column: "Count",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 31,
                column: "Count",
                value: 51);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 32,
                column: "Count",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 33,
                column: "Count",
                value: 52);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 34,
                column: "Count",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 35,
                column: "Count",
                value: 83);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 36,
                column: "Count",
                value: 91);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 37,
                column: "Count",
                value: 68);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 38,
                column: "Count",
                value: 89);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 39,
                column: "Count",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 40,
                column: "Count",
                value: 68);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 41,
                column: "Count",
                value: 58);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 42,
                column: "Count",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 43,
                column: "Count",
                value: 89);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 44,
                column: "Count",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 45,
                column: "Count",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 46,
                column: "Count",
                value: 73);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 47,
                column: "Count",
                value: 91);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 48,
                column: "Count",
                value: 69);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 49,
                column: "Count",
                value: 62);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 50,
                column: "Count",
                value: 94);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 51,
                column: "Count",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 52,
                column: "Count",
                value: 59);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 53,
                column: "Count",
                value: 97);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 54,
                column: "Count",
                value: 94);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 55,
                column: "Count",
                value: 62);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 56,
                column: "Count",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 57,
                column: "Count",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 58,
                column: "Count",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 59,
                column: "Count",
                value: 66);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 60,
                column: "Count",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 61,
                column: "Count",
                value: 91);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 62,
                column: "Count",
                value: 69);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 63,
                column: "Count",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 64,
                column: "Count",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 65,
                column: "Count",
                value: 73);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 66,
                column: "Count",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 67,
                column: "Count",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 68,
                column: "Count",
                value: 82);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 69,
                column: "Count",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 70,
                column: "Count",
                value: 77);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 71,
                column: "Count",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 72,
                column: "Count",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 73,
                column: "Count",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 74,
                column: "Count",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 75,
                column: "Count",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 76,
                column: "Count",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 77,
                column: "Count",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 78,
                column: "Count",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 79,
                column: "Count",
                value: 94);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 80,
                column: "Count",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 81,
                column: "Count",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 82,
                column: "Count",
                value: 69);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 83,
                column: "Count",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 84,
                column: "Count",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 85,
                column: "Count",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 86,
                column: "Count",
                value: 91);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 87,
                column: "Count",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 88,
                column: "Count",
                value: 58);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 89,
                column: "Count",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 90,
                column: "Count",
                value: 61);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 91,
                column: "Count",
                value: 76);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 92,
                column: "Count",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 93,
                column: "Count",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 94,
                column: "Count",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 95,
                column: "Count",
                value: 76);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 96,
                column: "Count",
                value: 89);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 97,
                column: "Count",
                value: 96);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 98,
                column: "Count",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 99,
                column: "Count",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 100,
                column: "Count",
                value: 6);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Stocks");

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Price",
                value: 6754m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Price",
                value: 8117m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Price",
                value: 9975m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "Price",
                value: 2227m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "Price",
                value: 7788m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "Price",
                value: 2635m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "Price",
                value: 7764m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "Price",
                value: 2508m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "Price",
                value: 3015m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "Price",
                value: 557m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "Price",
                value: 8011m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "Price",
                value: 8729m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "Price",
                value: 7704m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "Price",
                value: 4355m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "Price",
                value: 7340m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "Price",
                value: 1657m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "Price",
                value: 9406m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "Price",
                value: 9082m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "Price",
                value: 3278m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "Price",
                value: 3748m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                column: "Price",
                value: 8188m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                column: "Price",
                value: 5185m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "Price",
                value: 2658m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                column: "Price",
                value: 2345m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                column: "Price",
                value: 2644m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                column: "Price",
                value: 3153m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                column: "Price",
                value: 3163m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                column: "Price",
                value: 7839m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                column: "Price",
                value: 2672m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                column: "Price",
                value: 1452m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                column: "Price",
                value: 8136m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                column: "Price",
                value: 9563m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                column: "Price",
                value: 917m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                column: "Price",
                value: 6491m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                column: "Price",
                value: 3624m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                column: "Price",
                value: 9936m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                column: "Price",
                value: 6629m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                column: "Price",
                value: 3922m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                column: "Price",
                value: 2178m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                column: "Price",
                value: 5641m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                column: "Price",
                value: 3604m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                column: "Price",
                value: 6084m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                column: "Price",
                value: 4716m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                column: "Price",
                value: 5899m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                column: "Price",
                value: 9690m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                column: "Price",
                value: 1093m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                column: "Price",
                value: 139m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                column: "Price",
                value: 4021m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                column: "Price",
                value: 8423m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                column: "Price",
                value: 4343m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51,
                column: "Price",
                value: 7466m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52,
                column: "Price",
                value: 7086m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53,
                column: "Price",
                value: 2684m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54,
                column: "Price",
                value: 8413m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55,
                column: "Price",
                value: 1045m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56,
                column: "Price",
                value: 1668m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57,
                column: "Price",
                value: 5558m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58,
                column: "Price",
                value: 7729m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59,
                column: "Price",
                value: 9583m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60,
                column: "Price",
                value: 4735m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61,
                column: "Price",
                value: 9471m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62,
                column: "Price",
                value: 9925m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63,
                column: "Price",
                value: 9835m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64,
                column: "Price",
                value: 1663m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65,
                column: "Price",
                value: 2420m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66,
                column: "Price",
                value: 8447m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67,
                column: "Price",
                value: 7911m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68,
                column: "Price",
                value: 1312m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69,
                column: "Price",
                value: 831m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70,
                column: "Price",
                value: 7403m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71,
                column: "Price",
                value: 5028m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72,
                column: "Price",
                value: 5583m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73,
                column: "Price",
                value: 7003m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74,
                column: "Price",
                value: 7637m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75,
                column: "Price",
                value: 244m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76,
                column: "Price",
                value: 2203m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77,
                column: "Price",
                value: 568m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78,
                column: "Price",
                value: 6759m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79,
                column: "Price",
                value: 2655m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80,
                column: "Price",
                value: 1650m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81,
                column: "Price",
                value: 3113m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82,
                column: "Price",
                value: 9141m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83,
                column: "Price",
                value: 9416m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84,
                column: "Price",
                value: 8329m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85,
                column: "Price",
                value: 3985m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86,
                column: "Price",
                value: 1150m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87,
                column: "Price",
                value: 6978m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88,
                column: "Price",
                value: 2504m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89,
                column: "Price",
                value: 5546m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90,
                column: "Price",
                value: 2055m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91,
                column: "Price",
                value: 4478m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92,
                column: "Price",
                value: 8899m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93,
                column: "Price",
                value: 4339m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94,
                column: "Price",
                value: 7443m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95,
                column: "Price",
                value: 6169m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96,
                column: "Price",
                value: 3678m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97,
                column: "Price",
                value: 6248m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98,
                column: "Price",
                value: 3153m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99,
                column: "Price",
                value: 3578m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100,
                column: "Price",
                value: 1342m);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 1,
                column: "Stock",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 2,
                column: "Stock",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 3,
                column: "Stock",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 4,
                column: "Stock",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 5,
                column: "Stock",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 6,
                column: "Stock",
                value: 65);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 7,
                column: "Stock",
                value: 37);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 8,
                column: "Stock",
                value: 98);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 9,
                column: "Stock",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 10,
                column: "Stock",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 11,
                column: "Stock",
                value: 91);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 12,
                column: "Stock",
                value: 54);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 13,
                column: "Stock",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 14,
                column: "Stock",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 15,
                column: "Stock",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 16,
                column: "Stock",
                value: 91);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 17,
                column: "Stock",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 18,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 19,
                column: "Stock",
                value: 69);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 20,
                column: "Stock",
                value: 92);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 21,
                column: "Stock",
                value: 71);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 22,
                column: "Stock",
                value: 54);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 23,
                column: "Stock",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 24,
                column: "Stock",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 25,
                column: "Stock",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 26,
                column: "Stock",
                value: 57);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 27,
                column: "Stock",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 28,
                column: "Stock",
                value: 77);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 29,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 30,
                column: "Stock",
                value: 79);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 31,
                column: "Stock",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 32,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 33,
                column: "Stock",
                value: 78);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 34,
                column: "Stock",
                value: 73);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 35,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 36,
                column: "Stock",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 37,
                column: "Stock",
                value: 58);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 38,
                column: "Stock",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 39,
                column: "Stock",
                value: 53);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 40,
                column: "Stock",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 41,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 42,
                column: "Stock",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 43,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 44,
                column: "Stock",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 45,
                column: "Stock",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 46,
                column: "Stock",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 47,
                column: "Stock",
                value: 34);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 48,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 49,
                column: "Stock",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 50,
                column: "Stock",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 51,
                column: "Stock",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 52,
                column: "Stock",
                value: 64);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 53,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 54,
                column: "Stock",
                value: 66);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 55,
                column: "Stock",
                value: 53);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 56,
                column: "Stock",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 57,
                column: "Stock",
                value: 82);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 58,
                column: "Stock",
                value: 78);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 59,
                column: "Stock",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 60,
                column: "Stock",
                value: 97);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 61,
                column: "Stock",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 62,
                column: "Stock",
                value: 59);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 63,
                column: "Stock",
                value: 93);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 64,
                column: "Stock",
                value: 61);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 65,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 66,
                column: "Stock",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 67,
                column: "Stock",
                value: 75);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 68,
                column: "Stock",
                value: 68);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 69,
                column: "Stock",
                value: 77);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 70,
                column: "Stock",
                value: 83);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 71,
                column: "Stock",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 72,
                column: "Stock",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 73,
                column: "Stock",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 74,
                column: "Stock",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 75,
                column: "Stock",
                value: 77);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 76,
                column: "Stock",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 77,
                column: "Stock",
                value: 47);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 78,
                column: "Stock",
                value: 73);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 79,
                column: "Stock",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 80,
                column: "Stock",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 81,
                column: "Stock",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 82,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 83,
                column: "Stock",
                value: 87);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 84,
                column: "Stock",
                value: 76);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 85,
                column: "Stock",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 86,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 87,
                column: "Stock",
                value: 86);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 88,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 89,
                column: "Stock",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 90,
                column: "Stock",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 91,
                column: "Stock",
                value: 62);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 92,
                column: "Stock",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 93,
                column: "Stock",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 94,
                column: "Stock",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 95,
                column: "Stock",
                value: 81);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 96,
                column: "Stock",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 97,
                column: "Stock",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 98,
                column: "Stock",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 99,
                column: "Stock",
                value: 65);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 100,
                column: "Stock",
                value: 33);
        }
    }
}
