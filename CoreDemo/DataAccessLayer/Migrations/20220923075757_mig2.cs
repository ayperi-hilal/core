using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogID",
                table: "YorumComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_YorumComments_BlogID",
                table: "YorumComments",
                column: "BlogID");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryID",
                table: "Blogs",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categories_CategoryID",
                table: "Blogs",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_YorumComments_Blogs_BlogID",
                table: "YorumComments",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categories_CategoryID",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_YorumComments_Blogs_BlogID",
                table: "YorumComments");

            migrationBuilder.DropIndex(
                name: "IX_YorumComments_BlogID",
                table: "YorumComments");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CategoryID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "YorumComments");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Blogs");
        }
    }
}
