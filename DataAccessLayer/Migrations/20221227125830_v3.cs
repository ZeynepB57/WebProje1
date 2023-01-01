using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommendUserName",
                table: "Comments",
                newName: "CommentUserName");

            migrationBuilder.RenameColumn(
                name: "CommandID",
                table: "Comments",
                newName: "CommentID");

            migrationBuilder.AddColumn<string>(
                name: "ArticleImage",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticleImage",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "CommentUserName",
                table: "Comments",
                newName: "CommendUserName");

            migrationBuilder.RenameColumn(
                name: "CommentID",
                table: "Comments",
                newName: "CommandID");
        }
    }
}
