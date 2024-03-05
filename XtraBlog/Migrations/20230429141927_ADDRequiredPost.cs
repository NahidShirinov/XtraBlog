using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XtraBlog.Migrations
{
    public partial class ADDRequiredPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tag",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tag",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "Craeateat",
                value: new DateTime(2023, 4, 21, 10, 33, 55, 726, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "Craeateat",
                value: new DateTime(2023, 4, 21, 10, 33, 55, 726, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                column: "Craeateat",
                value: new DateTime(2023, 4, 21, 10, 33, 55, 726, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Slug" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 33, 55, 726, DateTimeKind.Local).AddTicks(8512), "7f06c5db-fc2b-438a-a515-25073f7285cc" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Slug" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 33, 55, 726, DateTimeKind.Local).AddTicks(8524), "4b8b75b3-08c8-41c8-aece-a057964359f8" });
        }
    }
}
