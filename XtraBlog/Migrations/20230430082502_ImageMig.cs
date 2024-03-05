using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XtraBlog.Migrations
{
    public partial class ImageMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Posts",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Posts",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Created_By",
                table: "Posts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "Craeateat",
                value: new DateTime(2023, 4, 30, 12, 25, 2, 206, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "Craeateat",
                value: new DateTime(2023, 4, 30, 12, 25, 2, 206, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                column: "Craeateat",
                value: new DateTime(2023, 4, 30, 12, 25, 2, 206, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Slug" },
                values: new object[] { new DateTime(2023, 4, 30, 12, 25, 2, 206, DateTimeKind.Local).AddTicks(7805), "389bfb81-f0ab-4e69-9502-f2c97e8291d0" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Slug" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 25, 2, 206, DateTimeKind.Local).AddTicks(7808), "13f1da21-bae0-4259-a47c-839fa32e0a7e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Created_By",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "Craeateat",
                value: new DateTime(2023, 4, 29, 18, 19, 26, 896, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "Craeateat",
                value: new DateTime(2023, 4, 29, 18, 19, 26, 896, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                column: "Craeateat",
                value: new DateTime(2023, 4, 29, 18, 19, 26, 896, DateTimeKind.Local).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Slug" },
                values: new object[] { new DateTime(2023, 4, 29, 18, 19, 26, 896, DateTimeKind.Local).AddTicks(5574), "c4d8663c-c5e7-48a8-837e-aa4ea2fe4c01" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Slug" },
                values: new object[] { new DateTime(2023, 5, 9, 18, 19, 26, 896, DateTimeKind.Local).AddTicks(5585), "5660e381-87f2-43c5-bb28-61cec4aa7887" });
        }
    }
}
