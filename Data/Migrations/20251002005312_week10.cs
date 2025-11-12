using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetCoreMvcWebSite.Data.Migrations
{
    /// <inheritdoc />
    public partial class week10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiscussionForum");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "AIImages",
                newName: "UploadDate");

            migrationBuilder.RenameColumn(
                name: "TopicTitle",
                table: "AIImages",
                newName: "Prompt");

            migrationBuilder.RenameColumn(
                name: "PostDate",
                table: "AIImages",
                newName: "ImageGenerator");

            migrationBuilder.RenameColumn(
                name: "MessageContent",
                table: "AIImages",
                newName: "Filename");

            migrationBuilder.AddColumn<int>(
                name: "Like",
                table: "AIImages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "canIncreaseLike",
                table: "AIImages",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Like",
                table: "AIImages");

            migrationBuilder.DropColumn(
                name: "canIncreaseLike",
                table: "AIImages");

            migrationBuilder.RenameColumn(
                name: "UploadDate",
                table: "AIImages",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Prompt",
                table: "AIImages",
                newName: "TopicTitle");

            migrationBuilder.RenameColumn(
                name: "ImageGenerator",
                table: "AIImages",
                newName: "PostDate");

            migrationBuilder.RenameColumn(
                name: "Filename",
                table: "AIImages",
                newName: "MessageContent");

            migrationBuilder.CreateTable(
                name: "DiscussionForum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MessageContent = table.Column<string>(type: "TEXT", nullable: false),
                    PostDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TopicTitle = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscussionForum", x => x.Id);
                });
        }
    }
}
