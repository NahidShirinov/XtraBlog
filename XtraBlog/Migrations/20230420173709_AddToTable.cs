using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XtraBlog.Migrations
{
    public partial class AddToTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagPosts_Tag_TagsId",
                table: "TagPosts");

            migrationBuilder.DropColumn(
                name: "TagID",
                table: "TagPosts");

            migrationBuilder.RenameColumn(
                name: "TagsId",
                table: "TagPosts",
                newName: "TagsID");

            migrationBuilder.RenameIndex(
                name: "IX_TagPosts_TagsId",
                table: "TagPosts",
                newName: "IX_TagPosts_TagsID");

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Created_By", "Date", "Description", "Image", "Slug", "Title" },
                values: new object[,]
                {
                    { 1, "Nahid Shirinov", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "img-01.jpg", "51145bba-02b8-44fc-b373-e9fd6682a7f6", "You can also have an image" },
                    { 2, "Nahid Sirinov", new DateTime(2023, 4, 30, 21, 37, 9, 440, DateTimeKind.Local).AddTicks(4223), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "img-02.jpg", "c2e084ec-733f-422e-ac02-8c20095b5d05", "He qaqa, ele mi olufff" }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Siyaset" },
                    { 2, "Idman" }
                });

            migrationBuilder.InsertData(
                table: "TagPosts",
                columns: new[] { "Id", "PostID", "TagsID" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "TagPosts",
                columns: new[] { "Id", "PostID", "TagsID" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.AddForeignKey(
                name: "FK_TagPosts_Tag_TagsID",
                table: "TagPosts",
                column: "TagsID",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagPosts_Tag_TagsID",
                table: "TagPosts");

            migrationBuilder.DeleteData(
                table: "TagPosts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TagPosts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "TagsID",
                table: "TagPosts",
                newName: "TagsId");

            migrationBuilder.RenameIndex(
                name: "IX_TagPosts_TagsID",
                table: "TagPosts",
                newName: "IX_TagPosts_TagsId");

            migrationBuilder.AddColumn<int>(
                name: "TagID",
                table: "TagPosts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_TagPosts_Tag_TagsId",
                table: "TagPosts",
                column: "TagsId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
