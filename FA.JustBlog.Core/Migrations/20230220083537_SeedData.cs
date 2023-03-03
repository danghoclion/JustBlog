using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryName", "Description", "UrlSlug" },
                values: new object[,]
                {
                    { 1, "Thoi su", "Thong tin ve thoi su", "/thoisu" },
                    { 2, "Tin nong", "Thong tin ve tin nong", "/tinnong" },
                    { 3, "Xa hoi", "Thong tin ve xa hoi", "/xahoi" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Count", "Description", "TagName", "UrlSlug" },
                values: new object[,]
                {
                    { 1, 1, "Van de thoi su", "@thoisu", "/thoisu" },
                    { 2, 1, "Van de tin tuc", "@tinnong", "/tinnong" },
                    { 3, 1, "Van de xa hoi", "@xahoi", "/xahoi" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CategoryId", "Modified", "PostContent", "PostedOn", "Published", "ShortDescription", "Title", "UrlSlug" },
                values: new object[] { 1, 1, new DateTime(2023, 2, 20, 15, 35, 36, 851, DateTimeKind.Local).AddTicks(5472), "Ha noi: 20C", new DateTime(2023, 2, 20, 15, 35, 36, 851, DateTimeKind.Local).AddTicks(5472), new DateTime(2023, 2, 20, 15, 35, 36, 851, DateTimeKind.Local).AddTicks(5461), "du bao thoi tiet", "Ban tin buoi trua", "/thoisu" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CategoryId", "Modified", "PostContent", "PostedOn", "Published", "ShortDescription", "Title", "UrlSlug" },
                values: new object[] { 2, 2, new DateTime(2023, 2, 20, 15, 35, 36, 851, DateTimeKind.Local).AddTicks(5475), "1000 devoloper", new DateTime(2023, 2, 20, 15, 35, 36, 851, DateTimeKind.Local).AddTicks(5475), new DateTime(2023, 2, 20, 15, 35, 36, 851, DateTimeKind.Local).AddTicks(5474), "1000 nhan vien it", "Fsoft xa thai 1000 nhan vien", "/tinnong" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CategoryId", "Modified", "PostContent", "PostedOn", "Published", "ShortDescription", "Title", "UrlSlug" },
                values: new object[] { 3, 3, new DateTime(2023, 2, 20, 15, 35, 36, 851, DateTimeKind.Local).AddTicks(5477), "To chuc lai bo may nha nuoc", new DateTime(2023, 2, 20, 15, 35, 36, 851, DateTimeKind.Local).AddTicks(5476), new DateTime(2023, 2, 20, 15, 35, 36, 851, DateTimeKind.Local).AddTicks(5476), "Bo luat hinh su", "Thu tuong ban hanh nghi quyet 47", "/xahoi" });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId" },
                values: new object[] { 2, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: 2);
        }
    }
}
