using Microsoft.EntityFrameworkCore.Migrations;

namespace TheBlogProject.Data.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_AspNetUsers_AuthorId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_AuthorId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Tags");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_BlogUserId",
                table: "Tags",
                column: "BlogUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_AspNetUsers_BlogUserId",
                table: "Tags",
                column: "BlogUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_AspNetUsers_BlogUserId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_BlogUserId",
                table: "Tags");

            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Tags",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_AuthorId",
                table: "Tags",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_AspNetUsers_AuthorId",
                table: "Tags",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
