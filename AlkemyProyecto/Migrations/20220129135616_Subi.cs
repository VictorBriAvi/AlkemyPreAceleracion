using Microsoft.EntityFrameworkCore.Migrations;

namespace AlkemyProyecto.Migrations
{
    public partial class Subi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostsId",
                table: "Posts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CommentsId",
                table: "Comments",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "User",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Posts",
                newName: "PostsId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Comments",
                newName: "CommentsId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);
        }
    }
}
