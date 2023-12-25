using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Game.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MediaType",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "MediaContent",
                table: "Questions",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "MediaContent", "MediaType", "Text" },
                values: new object[,]
                {
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), null, null, "Как называется наибольшая планета в Солнечной системе?" },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), null, null, "Какое животное является символом мудрости в многих культурах и философии Востока?" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Name" },
                values: new object[,]
                {
                    { new Guid("e5e3498b-48f0-4c12-a97e-f7baa9f0b6c7"), "ChatGPT" },
                    { new Guid("f2d1b0a4-76c5-11ec-87d0-0242ac130003"), "Houkiro" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerId", "QuestionId", "Text", "UserId" },
                values: new object[,]
                {
                    { new Guid("7fc9d268-89a3-4e6d-bbd7-5f0c6e872a9a"), new Guid("00000000-0000-0000-0000-000000000000"), "Сова", new Guid("f2d1b0a4-76c5-11ec-87d0-0242ac130003") },
                    { new Guid("a0b5f6e7-cd23-4a89-b12d-98e97f561234"), new Guid("00000000-0000-0000-0000-000000000000"), "Юпитер", new Guid("e5e3498b-48f0-4c12-a97e-f7baa9f0b6c7") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_UserId",
                table: "Answers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Users_UserId",
                table: "Answers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Users_UserId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_UserId",
                table: "Answers");

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: new Guid("7fc9d268-89a3-4e6d-bbd7-5f0c6e872a9a"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: new Guid("a0b5f6e7-cd23-4a89-b12d-98e97f561234"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("e5e3498b-48f0-4c12-a97e-f7baa9f0b6c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("f2d1b0a4-76c5-11ec-87d0-0242ac130003"));

            migrationBuilder.AlterColumn<string>(
                name: "MediaType",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "MediaContent",
                table: "Questions",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);
        }
    }
}
