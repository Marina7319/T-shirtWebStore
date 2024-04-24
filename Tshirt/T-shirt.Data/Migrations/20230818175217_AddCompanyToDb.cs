#nullable disable

namespace T_shirt.Data.Migrations
{

    using Microsoft.EntityFrameworkCore.Migrations;


    public partial class AddCompanyToDb : Migration
    {
        
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAuthorizedCompany",
                table: "Companies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

 
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAuthorizedCompany",
                table: "Companies");
        }
    }
}
