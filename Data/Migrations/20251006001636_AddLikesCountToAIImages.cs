using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetCoreMvcWebSite.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddLikesCountToAIImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "canIncreaseLike",
                table: "AIImages",
                newName: "CanIncreaseLike");

            migrationBuilder.AddColumn<int>(
                name: "LikesCount",
                table: "AIImages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LikesCount",
                table: "AIImages");

            migrationBuilder.RenameColumn(
                name: "CanIncreaseLike",
                table: "AIImages",
                newName: "canIncreaseLike");
        }
    }
}
