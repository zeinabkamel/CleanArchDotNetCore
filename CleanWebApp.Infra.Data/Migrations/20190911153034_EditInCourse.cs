using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanWebApp.Infra.Data.Migrations
{
    public partial class EditInCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imge",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imge",
                table: "Courses");
        }
    }
}
