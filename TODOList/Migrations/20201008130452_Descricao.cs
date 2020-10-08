using Microsoft.EntityFrameworkCore.Migrations;

namespace TODOList.Migrations
{
    public partial class Descricao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "TODOItem",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "TODOItem");
        }
    }
}
