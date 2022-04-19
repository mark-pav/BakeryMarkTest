using Microsoft.EntityFrameworkCore.Migrations;

namespace BakeryMarkTest.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "ImagePath",
            //    table: "MenuItem",
            //    nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "MenuItem");
        }
    }
}
