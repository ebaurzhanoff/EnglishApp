using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddGrammarGroups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "application",
                table: "Groups",
                columns: new[] { "Id", "CourseId", "Name", "SortOrder", "Token" },
                values: new object[,]
                {
                    { 1L, 1L, "Present simple", 1, "Grammar_PresentSimple" },
                    { 2L, 1L, "Present continuous", 2, "Grammar_PresentContinuous" },
                    { 3L, 1L, "Present simple or present continuous", 3, "Grammar_PresentSimpleOrPresentContinuous" },
                    { 4L, 1L, "Past simple", 4, "Grammar_PastSimple" },
                    { 5L, 1L, "Present perfect", 5, "Grammar_PresentPerfect" },
                    { 6L, 1L, "Past simple or Present perfect", 6, "Grammar_PastSimpleOrPresentPerfect" },
                    { 7L, 1L, "Past continuous", 7, "Grammar_PastContinuous" },
                    { 8L, 1L, "Future simple", 8, "Grammar_FutureSimple" },
                    { 9L, 1L, "Future forms", 9, "Grammar_FutureForms" },
                    { 10L, 1L, "Modal verbs", 10, "Grammar_ModalVerbs" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "application",
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Groups",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Groups",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Groups",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Groups",
                keyColumn: "Id",
                keyValue: 10L);
        }
    }
}
