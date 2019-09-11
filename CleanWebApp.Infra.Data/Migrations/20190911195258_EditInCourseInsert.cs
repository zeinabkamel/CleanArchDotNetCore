using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanWebApp.Infra.Data.Migrations
{
    public partial class EditInCourseInsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseID", "Credits", "Imge", "Title" },
                values: new object[] { 1, 1, null, "test 1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 1);
        }
    }
}
