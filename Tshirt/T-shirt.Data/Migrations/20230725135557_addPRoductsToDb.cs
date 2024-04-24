#nullable disable

namespace T_shirt.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class addPRoductsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TshirtName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "Description", "ListPrice", "Size", "TshirtName" },
                values: new object[,]
                {
                    { 1, "Green", "High quality printed t-shirt. Made of 100% cotton, soft and comfortable to wear. DTG printing of the prints - they don't stay like patches, they don't peel and they don't crack. Free customization. Inspection included upon delivery. ", 28.899999999999999, "XS, S, M, L, XL, XXL", "Men T-shirt Awesome Since 1982" },
                    { 2, "Black", "If you're a fan of the hilarious sitcom Friends, then you'll love this cool t-shirt from Plastic Head. It has a wonderful design that is inspired by iconic elements associated with the beloved series. The series, which follows the six inseparable friends, has become one of the most loved comedy series of all time. The sitcom follows their daily lives, the development of their relationships, their professional and personal lives, with a mixture of joys and disappointments.\r\n\r\nThe t-shirt is unisex and made of cotton. It is soft, comfortable and available in different sizes. The t-shirt is officially licensed and will become a great addition to any Friends collection and wardrobe.\r\n\r\n", 19.989999999999998, "XS, S, M, L, XL, XXL", "T-shirt Plastic Head Television: Friends - Icons" },
                    { 3, "Pink, White", "", 23.809999999999999, "S, M, L", "Lola Bunny Dreams Women's T-Shirt* DTG" },
                    { 4, "pink, Yellow", "High quality printed t-shirt. Made of 100% cotton, soft and comfortable to wear. DTG printing of the prints - they don't stay like patches, they don't peel and they don't crack. Free customization. Inspection included upon delivery. ", 23.809999999999999, "S, M, L", "Women's Butterfly 2022 DTG T-Shirt" },
                    { 5, "Black", "Men's T-Shirt The Game (Squid Game)\r\nThe newest addition to our series fan t-shirts collection!", 28.899999999999999, "XS, S, M, L, XL, XXL", "Men's T-Shirt The Game (Squid Game)" },
                    { 6, "White", "", 23.809999999999999, "S, M, L", "Women's Powerpuff Girls / Buttercup DTG T-Shirt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
