using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class ReSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Published",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "Modified", "PostedOn", "Published" },
                values: new object[] { new DateTime(2023, 2, 22, 18, 53, 41, 277, DateTimeKind.Local).AddTicks(4471), new DateTime(2023, 2, 22, 18, 53, 41, 277, DateTimeKind.Local).AddTicks(4460), "1" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "Modified", "PostedOn", "Published" },
                values: new object[] { new DateTime(2023, 2, 22, 18, 53, 41, 277, DateTimeKind.Local).AddTicks(4477), new DateTime(2023, 2, 22, 18, 53, 41, 277, DateTimeKind.Local).AddTicks(4476), "0" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "Modified", "PostedOn", "Published" },
                values: new object[] { new DateTime(2023, 2, 22, 18, 53, 41, 277, DateTimeKind.Local).AddTicks(4479), new DateTime(2023, 2, 22, 18, 53, 41, 277, DateTimeKind.Local).AddTicks(4478), "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Published",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "Modified", "PostedOn", "Published" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 35, 36, 851, DateTimeKind.Local).AddTicks(5472), new DateTime(2023, 2, 20, 15, 35, 36, 851, DateTimeKind.Local).AddTicks(5472), new DateTime(2023, 2, 20, 15, 35, 36, 851, DateTimeKind.Local).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "Modified", "PostedOn", "Published" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 35, 36, 851, DateTimeKind.Local).AddTicks(5475), new DateTime(2023, 2, 20, 15, 35, 36, 851, DateTimeKind.Local).AddTicks(5475), new DateTime(2023, 2, 20, 15, 35, 36, 851, DateTimeKind.Local).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "Modified", "PostedOn", "Published" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 35, 36, 851, DateTimeKind.Local).AddTicks(5477), new DateTime(2023, 2, 20, 15, 35, 36, 851, DateTimeKind.Local).AddTicks(5476), new DateTime(2023, 2, 20, 15, 35, 36, 851, DateTimeKind.Local).AddTicks(5476) });
        }
    }
}
