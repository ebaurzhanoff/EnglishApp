using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPresentSimpleDataAndAddLevelEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sources",
                schema: "application",
                table: "Sources");

            migrationBuilder.AddColumn<long>(
                name: "LevelId",
                schema: "application",
                table: "Lessons",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sources",
                schema: "application",
                table: "Sources",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Levels",
                schema: "application",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Levels",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1L, "A1", "Beginner" },
                    { 2L, "A2", "Elementary" },
                    { 3L, "B1", "Intermediate" },
                    { 4L, "B2", "Upper Intermediate" },
                    { 5L, "C1", "Advanced" },
                    { 6L, "C2", "Proficient" }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Lessons",
                columns: new[] { "Id", "Description", "GroupToken", "LevelId", "SortOrder", "Title" },
                values: new object[] { 1L, "Present Simple Lesson - A1", "Grammar_PresentSimple", 1L, 1, "Lesson" });

            migrationBuilder.CreateIndex(
                name: "IX_Sources_UnitId",
                schema: "application",
                table: "Sources",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_LevelId",
                schema: "application",
                table: "Lessons",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Levels_Code",
                schema: "application",
                table: "Levels",
                column: "Code",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Levels_LevelId",
                schema: "application",
                table: "Lessons",
                column: "LevelId",
                principalSchema: "application",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Levels_LevelId",
                schema: "application",
                table: "Lessons");

            migrationBuilder.DropTable(
                name: "Levels",
                schema: "application");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sources",
                schema: "application",
                table: "Sources");

            migrationBuilder.DropIndex(
                name: "IX_Sources_UnitId",
                schema: "application",
                table: "Sources");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_LevelId",
                schema: "application",
                table: "Lessons");

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DropColumn(
                name: "LevelId",
                schema: "application",
                table: "Lessons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sources",
                schema: "application",
                table: "Sources",
                columns: new[] { "UnitId", "Id" });
        }
    }
}
