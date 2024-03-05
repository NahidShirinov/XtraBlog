using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XtraBlog.Migrations
{
    public partial class AddComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Slug" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 8, 19, 593, DateTimeKind.Local).AddTicks(2086), "e986a3d1-edfd-4391-89e6-eddeae7dac48" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Slug" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 8, 19, 593, DateTimeKind.Local).AddTicks(2108), "f9abcd26-23af-4d71-90fb-21c333a1cd8a" });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Blog" },
                    { 4, "Hava" }
                });

            migrationBuilder.InsertData(
                table: "TagPosts",
                columns: new[] { "Id", "PostID", "TagsID" },
                values: new object[] { 3, 2, 4 });

            migrationBuilder.InsertData(
                table: "TagPosts",
                columns: new[] { "Id", "PostID", "TagsID" },
                values: new object[] { 4, 2, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TagPosts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TagPosts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Slug" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51145bba-02b8-44fc-b373-e9fd6682a7f6" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Slug" },
                values: new object[] { new DateTime(2023, 4, 30, 21, 37, 9, 440, DateTimeKind.Local).AddTicks(4223), "c2e084ec-733f-422e-ac02-8c20095b5d05" });
        }
    }
}
