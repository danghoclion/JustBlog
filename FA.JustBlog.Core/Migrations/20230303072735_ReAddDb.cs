using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class ReAddDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2023, 3, 3, 14, 27, 34, 951, DateTimeKind.Local).AddTicks(4856), new DateTime(2023, 3, 3, 14, 27, 34, 951, DateTimeKind.Local).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2023, 3, 3, 14, 27, 34, 951, DateTimeKind.Local).AddTicks(4860), new DateTime(2023, 3, 3, 14, 27, 34, 951, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2023, 3, 3, 14, 27, 34, 951, DateTimeKind.Local).AddTicks(4862), new DateTime(2023, 3, 3, 14, 27, 34, 951, DateTimeKind.Local).AddTicks(4862) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2023, 3, 3, 14, 15, 49, 800, DateTimeKind.Local).AddTicks(5604), new DateTime(2023, 3, 3, 14, 15, 49, 800, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2023, 3, 3, 14, 15, 49, 800, DateTimeKind.Local).AddTicks(5608), new DateTime(2023, 3, 3, 14, 15, 49, 800, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2023, 3, 3, 14, 15, 49, 800, DateTimeKind.Local).AddTicks(5610), new DateTime(2023, 3, 3, 14, 15, 49, 800, DateTimeKind.Local).AddTicks(5609) });
        }
    }
}
