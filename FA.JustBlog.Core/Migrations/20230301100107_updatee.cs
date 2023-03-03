using Microsoft.EntityFrameworkCore.Migrations;
using System;


#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class updatee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2023, 3, 1, 17, 1, 6, 721, DateTimeKind.Local).AddTicks(1663), new DateTime(2023, 3, 1, 17, 1, 6, 721, DateTimeKind.Local).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2023, 3, 1, 17, 1, 6, 721, DateTimeKind.Local).AddTicks(1670), new DateTime(2023, 3, 1, 17, 1, 6, 721, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2023, 3, 1, 17, 1, 6, 721, DateTimeKind.Local).AddTicks(1672), new DateTime(2023, 3, 1, 17, 1, 6, 721, DateTimeKind.Local).AddTicks(1671) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
