using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2023, 2, 22, 20, 16, 10, 578, DateTimeKind.Local).AddTicks(1711), new DateTime(2023, 2, 22, 20, 16, 10, 578, DateTimeKind.Local).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2023, 2, 22, 20, 16, 10, 578, DateTimeKind.Local).AddTicks(1716), new DateTime(2023, 2, 22, 20, 16, 10, 578, DateTimeKind.Local).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2023, 2, 22, 20, 16, 10, 578, DateTimeKind.Local).AddTicks(1718), new DateTime(2023, 2, 22, 20, 16, 10, 578, DateTimeKind.Local).AddTicks(1718) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2023, 2, 22, 20, 6, 28, 112, DateTimeKind.Local).AddTicks(9492), new DateTime(2023, 2, 22, 20, 6, 28, 112, DateTimeKind.Local).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2023, 2, 22, 20, 6, 28, 112, DateTimeKind.Local).AddTicks(9498), new DateTime(2023, 2, 22, 20, 6, 28, 112, DateTimeKind.Local).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2023, 2, 22, 20, 6, 28, 112, DateTimeKind.Local).AddTicks(9500), new DateTime(2023, 2, 22, 20, 6, 28, 112, DateTimeKind.Local).AddTicks(9500) });
        }
    }
}
