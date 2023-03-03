using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class ReAddDb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17058974-4d00-45ce-8586-f95cd6c6c063", "b132fdba-68d8-453e-873c-d9b6fd440d6f", "Contributor", "CONTRIBUTOR" },
                    { "53a36c11-dd57-4ac1-98fa-2f4733e6f8a8", "f9a68955-d5eb-4d69-a647-d940e3bb7ee3", "User", "USER" },
                    { "bb6ae2c9-d38c-452f-9a3d-f31ed177a4b8", "086e451d-1b32-4176-80c3-e26baf8f590a", "BlogOwner", "BLOGOWNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1f4aadb2-930c-43f0-9c69-607b773113b1", 0, "888bab9b-2d35-4b92-96be-eadadb176c2c", "IdentityUser", "contributor@gmail.com", true, false, null, "CONTRIBUTOR@GMAIL.COM", "CONTRIBUTOR@GMAIL.COM", "AQAAAAEAACcQAAAAEDayHEPzATxMBEDizKKtSsBLAYfwIdv7pDbL53fCX9/yIgSG7DSDvrd5T7E8RpWY8Q==", null, false, "5900f777-f219-4c03-bf37-3ce282eefc9d", false, "contributor@gmail.com" },
                    { "ed4e835b-8d09-410d-a4b0-5bd78a52cc7c", 0, "e51fae02-1274-4269-adb7-b15d7db14472", "IdentityUser", "user@gmail.com", true, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEKJe6IWXuFsv86oO2UVg9+7Z9pzJCHa86uXB71s0iyyNxN4scn3V4AixS7QeimQ/gg==", null, false, "6a527228-feeb-409d-9a22-790ba68f08ec", false, "user@gmail.com" },
                    { "ee9fadb0-2257-4a12-9d9f-7488d29278e0", 0, "1b451d06-e5f5-436a-81fe-b31fe81f0f43", "IdentityUser", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEH94cATOhUNLH8S7mc4UJEFwUyZdz0eupGAAqMKUJdsLBrYSi7Yj5twjox9Wj5hwDQ==", null, false, "a120a451-603a-4407-b546-6894a7adb3a3", false, "admin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2023, 3, 3, 14, 44, 27, 940, DateTimeKind.Local).AddTicks(2516), new DateTime(2023, 3, 3, 14, 44, 27, 940, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2023, 3, 3, 14, 44, 27, 940, DateTimeKind.Local).AddTicks(2522), new DateTime(2023, 3, 3, 14, 44, 27, 940, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2023, 3, 3, 14, 44, 27, 940, DateTimeKind.Local).AddTicks(2524), new DateTime(2023, 3, 3, 14, 44, 27, 940, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "17058974-4d00-45ce-8586-f95cd6c6c063", "1f4aadb2-930c-43f0-9c69-607b773113b1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "53a36c11-dd57-4ac1-98fa-2f4733e6f8a8", "ed4e835b-8d09-410d-a4b0-5bd78a52cc7c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bb6ae2c9-d38c-452f-9a3d-f31ed177a4b8", "ee9fadb0-2257-4a12-9d9f-7488d29278e0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "17058974-4d00-45ce-8586-f95cd6c6c063", "1f4aadb2-930c-43f0-9c69-607b773113b1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "53a36c11-dd57-4ac1-98fa-2f4733e6f8a8", "ed4e835b-8d09-410d-a4b0-5bd78a52cc7c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb6ae2c9-d38c-452f-9a3d-f31ed177a4b8", "ee9fadb0-2257-4a12-9d9f-7488d29278e0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17058974-4d00-45ce-8586-f95cd6c6c063");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53a36c11-dd57-4ac1-98fa-2f4733e6f8a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb6ae2c9-d38c-452f-9a3d-f31ed177a4b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f4aadb2-930c-43f0-9c69-607b773113b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed4e835b-8d09-410d-a4b0-5bd78a52cc7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee9fadb0-2257-4a12-9d9f-7488d29278e0");

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
    }
}
