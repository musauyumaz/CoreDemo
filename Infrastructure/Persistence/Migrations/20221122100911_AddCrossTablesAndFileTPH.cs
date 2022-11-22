using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AddCrossTablesAndFileTPH : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "ThumbnailImage",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Abouts");

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Storage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutImageFileAbout",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "int", nullable: false),
                    AboutImageFileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutImageFileAbout", x => new { x.AboutId, x.AboutImageFileId });
                    table.ForeignKey(
                        name: "FK_AboutImageFileAbout_Abouts_AboutId",
                        column: x => x.AboutId,
                        principalTable: "Abouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AboutImageFileAbout_Files_AboutImageFileId",
                        column: x => x.AboutImageFileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogImageFileBlog",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    BlogImageFileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogImageFileBlog", x => new { x.BlogId, x.BlogImageFileId });
                    table.ForeignKey(
                        name: "FK_BlogImageFileBlog_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogImageFileBlog_Files_BlogImageFileId",
                        column: x => x.BlogImageFileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WriterImageFileWriter",
                columns: table => new
                {
                    WriterId = table.Column<int>(type: "int", nullable: false),
                    WriterImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WriterImageFileWriter", x => new { x.WriterId, x.WriterImageId });
                    table.ForeignKey(
                        name: "FK_WriterImageFileWriter_Files_WriterImageId",
                        column: x => x.WriterImageId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WriterImageFileWriter_Writers_WriterId",
                        column: x => x.WriterId,
                        principalTable: "Writers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutImageFileAbout_AboutImageFileId",
                table: "AboutImageFileAbout",
                column: "AboutImageFileId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogImageFileBlog_BlogImageFileId",
                table: "BlogImageFileBlog",
                column: "BlogImageFileId");

            migrationBuilder.CreateIndex(
                name: "IX_WriterImageFileWriter_WriterImageId",
                table: "WriterImageFileWriter",
                column: "WriterImageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutImageFileAbout");

            migrationBuilder.DropTable(
                name: "BlogImageFileBlog");

            migrationBuilder.DropTable(
                name: "WriterImageFileWriter");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Writers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Blogs",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailImage",
                table: "Blogs",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Abouts",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Abouts",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");
        }
    }
}
