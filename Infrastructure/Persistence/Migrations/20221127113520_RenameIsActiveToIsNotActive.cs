using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class RenameIsActiveToIsNotActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Writers",
                newName: "IsNotActive");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Files",
                newName: "IsNotActive");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Contacts",
                newName: "IsNotActive");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Comments",
                newName: "IsNotActive");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Categories",
                newName: "IsNotActive");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Blogs",
                newName: "IsNotActive");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Abouts",
                newName: "IsNotActive");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsNotActive",
                table: "Writers",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsNotActive",
                table: "Files",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsNotActive",
                table: "Contacts",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsNotActive",
                table: "Comments",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsNotActive",
                table: "Categories",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsNotActive",
                table: "Blogs",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsNotActive",
                table: "Abouts",
                newName: "IsActive");
        }
    }
}
