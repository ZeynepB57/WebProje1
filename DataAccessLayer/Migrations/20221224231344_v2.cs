using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticleID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WriterID",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleID",
                table: "Comments",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryID",
                table: "Articles",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_WriterID",
                table: "Articles",
                column: "WriterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Categories_CategoryID",
                table: "Articles",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Writers_WriterID",
                table: "Articles",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Articles_ArticleID",
                table: "Comments",
                column: "ArticleID",
                principalTable: "Articles",
                principalColumn: "ArticleID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Categories_CategoryID",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Writers_WriterID",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Articles_ArticleID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ArticleID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Articles_CategoryID",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_WriterID",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "ArticleID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "WriterID",
                table: "Articles");
        }
    }
}
