using Microsoft.EntityFrameworkCore.Migrations;

namespace back_end.Migrations
{
    public partial class personaje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Personaje",
                table: "PeliculasActores",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Personaje",
                table: "PeliculasActores");
        }
    }
}
