using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class RebuildPhotoError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phots_AspNetUsers_AppUserId",
                table: "Phots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phots",
                table: "Phots");

            migrationBuilder.RenameTable(
                name: "Phots",
                newName: "Photos");

            migrationBuilder.RenameIndex(
                name: "IX_Phots_AppUserId",
                table: "Photos",
                newName: "IX_Photos_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photos",
                table: "Photos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_AspNetUsers_AppUserId",
                table: "Photos",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_AspNetUsers_AppUserId",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photos",
                table: "Photos");

            migrationBuilder.RenameTable(
                name: "Photos",
                newName: "Phots");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_AppUserId",
                table: "Phots",
                newName: "IX_Phots_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phots",
                table: "Phots",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Phots_AspNetUsers_AppUserId",
                table: "Phots",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
