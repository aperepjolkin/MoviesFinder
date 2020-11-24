using Microsoft.EntityFrameworkCore.Migrations;

namespace data.Migrations
{
    public partial class AddedPosteField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Poster",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Poster",
                table: "Movies");
        }
    }
}
