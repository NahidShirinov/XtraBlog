using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XtraBlog.Migrations
{
    public partial class AddComments2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "Comment", "Craeateat", "Name", "PostID" },
                values: new object[,]
                {
                    { 1, "Heri seni", new DateTime(2023, 4, 21, 10, 33, 55, 726, DateTimeKind.Local).AddTicks(9147), "Nahid", 1 },
                    { 2, "reyiz", new DateTime(2023, 4, 21, 10, 33, 55, 726, DateTimeKind.Local).AddTicks(9152), "Revan", 1 },
                    { 3, "Pak", new DateTime(2023, 4, 21, 10, 33, 55, 726, DateTimeKind.Local).AddTicks(9153), "Revan", 2 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3);

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
        }
    }
}
