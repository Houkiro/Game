using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game.Migrations
{
    /// <inheritdoc />
    public partial class DataChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: new Guid("7fc9d268-89a3-4e6d-bbd7-5f0c6e872a9a"),
                column: "QuestionId",
                value: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: new Guid("a0b5f6e7-cd23-4a89-b12d-98e97f561234"),
                column: "QuestionId",
                value: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: new Guid("7fc9d268-89a3-4e6d-bbd7-5f0c6e872a9a"),
                column: "QuestionId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: new Guid("a0b5f6e7-cd23-4a89-b12d-98e97f561234"),
                column: "QuestionId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
