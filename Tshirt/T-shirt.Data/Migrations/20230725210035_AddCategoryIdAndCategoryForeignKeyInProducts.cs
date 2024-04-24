#nullable disable

namespace T_shirt.Data.Migrations
{

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddCategoryIdAndCategoryForeignKeyInProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ListPrice", "Size" },
                values: new object[] { 28.0, "XL" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ListPrice", "Size" },
                values: new object[] { 19.0, "XXL" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ListPrice", "Size" },
                values: new object[] { 23.0, "L" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ListPrice", "Size" },
                values: new object[] { 23.0, "L" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ListPrice", "Size" },
                values: new object[] { 28.0, "XS" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ListPrice", "Size" },
                values: new object[] { 23.0, "S" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ListPrice", "Size" },
                values: new object[] { 28.899999999999999, "XS, S, M, L, XL, XXL" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ListPrice", "Size" },
                values: new object[] { 19.989999999999998, "XS, S, M, L, XL, XXL" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ListPrice", "Size" },
                values: new object[] { 23.809999999999999, "S, M, L" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ListPrice", "Size" },
                values: new object[] { 23.809999999999999, "S, M, L" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ListPrice", "Size" },
                values: new object[] { 28.899999999999999, "XS, S, M, L, XL, XXL" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ListPrice", "Size" },
                values: new object[] { 23.809999999999999, "S, M, L" });
        }
    }
}
