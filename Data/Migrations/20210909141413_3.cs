using Microsoft.EntityFrameworkCore.Migrations;

namespace TheBlogProject.Data.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BlogUserId",
                table: "Tags",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogUserId",
                table: "Tags");
        }
    }
}
