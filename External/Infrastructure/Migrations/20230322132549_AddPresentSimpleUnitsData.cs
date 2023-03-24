using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPresentSimpleUnitsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "application",
                table: "Units",
                columns: new[] { "Id", "LessonId", "SortOrder", "Title" },
                values: new object[,]
                {
                    { 1L, 1L, 1, "Present simple “to be”" },
                    { 2L, 1L, 2, "Present simple “do/does”" }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "UnitId" },
                values: new object[,]
                {
                    { 1L, "Как переводится to be и когда используется?\r\n\r\n    'Be' мы используем в 3 случаях, когда мы хотим сказать:\r\n        Кто/что кем/чем является (она медсестра);\r\n        Кто/что каким является (мой кот серый);\r\n        Кто/что где находится (папа на работе).\r\n\r\n    То есть если мы хотим описать местоположение чего-либо, состояние чего-либо или то, чем является этот предмет/человек, то мы используем глагол to be.", 1, 1L },
                    { 2L, "Важно знать, как глагол to be меняется в зависимости от того, кто производит действие. Это можете быть вы, ваш друг или группа людей. В настоящем времени этот глагол имеет три формы: am, is, are. ", 2, 1L },
                    { 3L, "Давайте рассмотрим примеры употребления. ", 3, 1L },
                    { 4L, " Единственное число\r\n    I am a doctor. Я являюсь доктором.\r\n    He is clever. Он является умным.\r\n    She is at home. Она находится дома.\r\n    It is an interesting book. Это есть интересная книга.\r\n    You are a smart guy. Ты являешься сообразительным парнем.", 4, 1L },
                    { 5L, " Множественное число \r\n    We are good singers. Мы являемся хорошими певцами. \r\n    You are wonderful listeners. Вы являетесь отличными слушателями. \r\n    They are in the room. Они находятся в комнате.", 5, 1L },
                    { 6L, "Present simple - это простое настоящее время, оно употребляется когда говорим о действиях которые мы делаем регулярно, каждый или часто. Одним словом это действия который не заканчивается.", 1, 2L },
                    { 7L, "I go to work/university every day \r\n\r\nТакже оно употребляется, когда мы говорим про факты в настоящем.\r\n\r\nI like pizza/sushi", 2, 2L },
                    { 8L, "Конструкция предложений в present simple \r\n\r\n    Subject + Verb\r\n    You like ice cream\r\n\r\n    He / She / It + Verb(s)\r\n    He likes ice cream", 3, 2L },
                    { 9L, "В отрицательных предложениях\r\n\r\n    do + not - don’t\r\n    does + not - doesn’t\r\n\r\n    Subject + don’t/doesn’t + Verb\r\n\r\n    I don’t like ice cream \r\n    She doesn’t go to school", 4, 2L },
                    { 10L, "Чтобы сделать вопросительное предложение \r\n\r\n    Do/ Does + Subject + Verb \r\n\r\n    Do you go to university?\r\n    Yes, I do \r\n    No, I don’t \r\n\r\n    Does he go swimming? \r\n    Yes, he does\r\n    No, he doesn’t", 5, 2L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Units",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Units",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
