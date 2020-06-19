using Microsoft.EntityFrameworkCore.Migrations;

namespace DataContextLayer.Migrations
{
    public partial class sample2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "EFCore",
                table: "Department",
                type: "varchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "EFCore",
                table: "Department");
        }
    }
}
