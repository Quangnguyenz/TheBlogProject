using Microsoft.EntityFrameworkCore.Migrations;

namespace TheBlogProject.Data.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_BlogUSerId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "BlogUSerId",
                table: "Posts",
                newName: "BlogUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_BlogUSerId",
                table: "Posts",
                newName: "IX_Posts_BlogUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_BlogUserId",
                table: "Posts",
                column: "BlogUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_BlogUserId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "BlogUserId",
                table: "Posts",
                newName: "BlogUSerId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_BlogUserId",
                table: "Posts",
                newName: "IX_Posts_BlogUSerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_BlogUSerId",
                table: "Posts",
                column: "BlogUSerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
