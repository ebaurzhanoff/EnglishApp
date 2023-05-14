﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPastSimpleLesson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("04b56578-b6d6-4a64-a16e-45b316edae90"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("05db3ef8-3ef0-425b-814b-e12ba941af9d"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("0718f39b-125b-4bbe-96d2-362ac1a9f272"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("22cc46e7-20c5-4b80-b73c-f61769a9e0f8"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("2e4647ae-6101-490f-8cd1-e8e49b830907"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("357da888-2f29-4e4a-bb31-aec88bd0fac1"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("3a6b4ed8-3709-48ef-b694-c2faee88902a"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("3c042ca2-f150-488d-a9af-c1738009dcb5"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("3fec39d3-5209-4ffd-a935-5d617a4621b0"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("5908ba4d-8971-4b33-826e-23e4ab41b6ca"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("5a5b0abe-f106-494c-a279-e0249578e74d"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("659e8555-bc91-495e-95e8-6e3473f6657f"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("66fb2e24-ce94-441f-80a9-7fc5515acc86"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("69f1408b-191e-4654-a036-08718f9ae31f"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("8098e799-1d4f-444e-8a6d-a3be6cbca208"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("88c0ea7c-32ff-40ed-839e-0f7e3b16ae3f"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("9324d995-ffb2-4cab-8b4e-1a987d56303e"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("956769d4-bfda-445f-a34b-f2354c9232c1"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("9fc028bb-7c88-4729-914b-da448bf9a2a4"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("b87f1c47-5fa3-434b-bc05-e37665e08fcd"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("c0607a9b-4840-460d-9259-96f76de69d3f"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("c160e770-7c36-46ac-a38f-44c3434d896d"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("c520930e-a413-4a2f-87d8-39339a3ffb45"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("e661631f-71f3-4fbe-87b7-2cd824395c65"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("eee4388d-57e5-4704-9aaa-a40a1cd47caa"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("f723b9c3-5eac-4aa8-8458-f2b6fe27a2b0"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("f915ddb7-e335-441d-ad60-f5ad649197cc"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("fcb87c5e-568e-45d8-bfc1-a7371eaf8730"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("08890b74-4a0e-417f-a606-3342cd04769a"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("0e0584d5-275c-4d2a-93ca-96e9f86a8126"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("10640ec1-33d6-4f8d-b451-bf6cb080062c"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("10c2bb0c-1fcd-469f-8e31-41de53118b88"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("38344196-e30f-430f-9516-4522542b342a"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("39732ac8-44cf-4e9d-a77a-7e9c7f5ac48f"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("3a5b8cba-e95f-4b4f-a6d0-e5ab491d796b"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("44328dd9-f81a-4318-a558-552ac63082c9"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("4b7ca567-febd-4916-b7c5-5fb2cbca3f3b"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("68df48c7-537f-4283-8e42-cb85f40feb44"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("6b51537c-ebee-45c6-8369-a8b3b0e0e920"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("72799524-bd0c-46ec-badd-5a57fa633327"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("784b5e0d-b852-4a0f-8415-008ffb7a631e"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("7caddc31-49eb-4caa-83ce-bc3466d34ca7"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("7cec4f8c-47df-4d05-b9c2-863e24a426f9"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("8ec15ed8-c520-4bd8-a0bd-e7033d5b2bb0"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("942b66e9-893e-4efe-9629-5f4fd13c9481"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("ab2a43e7-fa47-4956-90db-8b68fdc39933"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("c7887c71-eb34-4340-96ad-adf9b532ca16"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("e4944504-eb23-463d-9594-404ec64e3e83"));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "application",
                table: "UnitTaskSource",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(4096)",
                oldMaxLength: 4096);

            migrationBuilder.InsertData(
                schema: "application",
                table: "Lessons",
                columns: new[] { "Id", "Description", "GroupToken", "LevelId", "SortOrder", "Title" },
                values: new object[,]
                {
                    { 6L, "Present Simple or Present Continuous Lesson - A1", "Grammar_PresentSimpleOrPresentContinuous", 1L, 3, "Lesson" },
                    { 7L, "Past Simple Lesson - A1", "Grammar_PastSimple", 1L, 4, "Lesson" }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "UnitId" },
                values: new object[] { new Guid("06043623-1d40-4c4e-a236-7223fc38fc05"), "Present simple - это простое настоящее время, оно употребляется когда говорим о действиях которые мы делаем регулярно, каждый или часто. Одним словом это действия который не заканчивается.", 1, 2L });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "Type", "UnitId" },
                values: new object[] { new Guid("079d9af6-fd5b-4c0c-aef8-74b938474881"), "YlqRjy_Z3GQ", 7, 1, 1L });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "UnitId" },
                values: new object[,]
                {
                    { new Guid("0814c7e3-0a29-4d78-9990-0d08d3b5ba20"), "Конструкция предложения\r\n\r\n	1.	Формула: I am + глагол-ing.\r\n		Пример: I am singing - Я пою.\r\n\r\n	2.	Формула: He/She/It is + глагол-ing.\r\n		Примеры: \r\n			He is smiling — Он улыбается.\r\n			She is dancing — Она танцует.\r\n			It is shining — Оно светит.\r\n\r\n	3.	Формула: We/You/They are + глагол-ing.\r\n		Примеры: \r\n			We are listening — Мы слушаем.\r\n			You are reading — Вы читаете.\r\n			They are swimming — Они плавают.\r\n\r\n	1.	Глагол заканчивается на —е \r\n		Правило: последняя буква отбрасывается \r\n		Пример: make — making (делать)\r\n\r\n	2.	Глагол оканчивается на —ie\r\n		Правило: -ie заменяется на -y\r\n		Пример: lie — lying (лежать)\r\n\r\n	3.	Односложный глагол, оканчивающийся на гласную с согласной\r\n		Правило: последняя согласная удваивается\r\n		Пример: get — getting (получать)", 3, 3L },
                    { new Guid("10edac5d-e531-409b-9b9c-209f6a3be7e0"), "Здесь могут стоять ключевые слова такие как: now/ right now/ at the momen", 2, 3L },
                    { new Guid("19ab0d39-5d56-40dc-9e1e-043c1e0f707a"), "В отрицательных предложениях\r\n\r\n    do + not - don’t\r\n    does + not - doesn’t\r\n\r\n    Subject + don’t/doesn’t + Verb\r\n\r\n    I don’t like ice cream \r\n    She doesn’t go to school", 4, 2L },
                    { new Guid("1a0eb7ff-6853-497d-a686-388ff8cf0c93"), "My Family - Learning English Speaking", 1, 6L },
                    { new Guid("3c767fcc-c226-437d-9bf1-aaaca1846ec1"), "Таким образом мы описали ее внешность, и ее действия", 3, 4L },
                    { new Guid("3ece1f60-e71f-487c-9b00-dd38158ec4ce"), "I go to work/university every day \r\n\r\nТакже оно употребляется, когда мы говорим про факты в настоящем.\r\n\r\nI like pizza/sushi", 2, 2L },
                    { new Guid("3effdea4-bdab-4d80-98fe-bec535ebf751"), "Например: \r\n	She is wearing a black dress.\r\n	She is smiling in the picture", 2, 4L },
                    { new Guid("49752f6f-4ded-4e54-a2c6-9a6a885e8a73"), " Множественное число \r\n    We are good singers. Мы являемся хорошими певцами. \r\n    You are wonderful listeners. Вы являетесь отличными слушателями. \r\n    They are in the room. Они находятся в комнате.", 5, 1L }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "Type", "UnitId" },
                values: new object[] { new Guid("4e512d6a-db5c-4f6f-ae75-d8a7b04929a3"), "b-WOj931zSU", 2, 1, 5L });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "UnitId" },
                values: new object[,]
                {
                    { new Guid("51619e43-d6f2-448c-aec8-33cc2b09080b"), "Чтобы сделать вопросительное предложение \r\n\r\n    Do/ Does + Subject + Verb \r\n\r\n    Do you go to university?\r\n    Yes, I do \r\n    No, I don’t \r\n\r\n    Does he go swimming? \r\n    Yes, he does\r\n    No, he doesn’t", 5, 2L },
                    { new Guid("5f2e31b8-d5d1-48a3-a949-11d399acc51f"), "Конструкция предложений в present simple \r\n\r\n    Subject + Verb\r\n    You like ice cream\r\n\r\n    He / She / It + Verb(s)\r\n    He likes ice cream", 3, 2L },
                    { new Guid("6219a07b-7397-455b-bae0-29e077c52a3e"), "Present continuous - настоящее длительное время, оно употребляется когда говорим о действиях которые происходит сейчас, на данный момент времени.", 1, 3L },
                    { new Guid("7181d80b-70c5-45ea-8102-99f180f30172"), "Например: \r\n	I am meeting with Daniel tomorrow. \r\n	Здесь в этом предложении соответсвенно показано, что встреча запланирована!", 6, 4L },
                    { new Guid("7be67aae-f92a-473b-b6df-5cf4fac85e46"), "Слова-маркеры: \r\n\r\n	This/next week (на этой/следующей неделе)\r\n	Tonight (вечером)\r\n	Today (сегодня)\r\n	Tomorrow (завтра)\r\n	This/next year (в этом/следующем году)\r\n	This/next weekend (в эти/следующие выходные).", 5, 4L },
                    { new Guid("7cd59d4e-f66b-49a3-bd51-0119501bbe4d"), "Следующий случай употребление времени «present continuous» - это когда говорим о запланированных и обязательно происходящих событий в ближайшем будущем", 4, 4L }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "Type", "UnitId" },
                values: new object[] { new Guid("81d356cf-cfc4-4c27-b0a7-eb56569f2333"), "uVYP8U2I8NA", 2, 1, 7L });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "UnitId" },
                values: new object[,]
                {
                    { new Guid("8d29ac06-f9e0-4291-b50a-3e90cfef8090"), "My Family - English Vocabulary Lesson", 1, 7L },
                    { new Guid("b0a904f6-cbee-44cd-8fcc-f275735431df"), "Важно знать, как глагол to be меняется в зависимости от того, кто производит действие. Это можете быть вы, ваш друг или группа людей. В настоящем времени этот глагол имеет три формы: am, is, are. ", 2, 1L },
                    { new Guid("b4645b8f-f6ea-4f10-870e-db9145e9bda9"), "Так же посмотрите это видео!", 6, 1L },
                    { new Guid("c26c77c4-9d51-4c50-abcd-0cdca35bdd48"), "My Family", 1, 5L },
                    { new Guid("c3841649-1898-46f4-826f-446f1f8e00e8"), " Единственное число\r\n    I am a doctor. Я являюсь доктором.\r\n    He is clever. Он является умным.\r\n    She is at home. Она находится дома.\r\n    It is an interesting book. Это есть интересная книга.\r\n    You are a smart guy. Ты являешься сообразительным парнем.", 4, 1L },
                    { new Guid("cf8a9b97-368b-4b72-88e2-53391c094554"), "Как переводится to be и когда используется?\r\n\r\n    'Be' мы используем в 3 случаях, когда мы хотим сказать:\r\n        Кто/что кем/чем является (она медсестра);\r\n        Кто/что каким является (мой кот серый);\r\n        Кто/что где находится (папа на работе).\r\n\r\n    То есть если мы хотим описать местоположение чего-либо, состояние чего-либо или то, чем является этот предмет/человек, то мы используем глагол to be.", 1, 1L }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "Type", "UnitId" },
                values: new object[] { new Guid("d217091a-ce50-45e7-a7cf-bd2926d1507f"), "kZhCip4wCKM", 2, 1, 6L });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "UnitId" },
                values: new object[,]
                {
                    { new Guid("dc39971f-e037-4cd6-8e32-9a0dba309d93"), "Present continuous - также мы можем использовать когда описываем, \r\nкакое то действие или же фото, так как описание происходит сейчас, \r\nмы должны соответсвенно использовать время «present continuous»", 1, 4L },
                    { new Guid("e90a4020-7faf-4fd3-a50c-f044a8bcbad7"), "Отрицательные предложения\r\n\r\n	1.	Формула: I am not + глагол-ing.\r\n		Пример: I am not singing - Я не пою.\r\n\r\n	2.	Формула: He/She/It is not + глагол-ing\r\n		Примеры:\r\n			He is not smiling - Он не улыбается. \r\n			She is not dancing - Она не танцует.\r\n			It is not shining - Оно не светит.\r\n\r\n	3.	Формула: We/You/They are not + глагол-ing.\r\n		Примеры: \r\n			We are not listening - Мы не слушаем.\r\n			You are not reading - Вы не читаете.\r\n			They are not swimming - Они не плавают.", 4, 3L },
                    { new Guid("fb11249a-3079-4260-b115-5e96778e37b6"), "Давайте рассмотрим примеры употребления. ", 3, 1L }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "UnitTaskSource",
                columns: new[] { "Id", "Content", "Key", "SortOrder", "Type", "UnitTaskId", "Value" },
                values: new object[,]
                {
                    { new Guid("08a838cd-93ab-4497-a87b-481f7125e21c"), "She is in America", null, 6, 1, 2L, "She is not in America" },
                    { new Guid("1ad48af1-927a-414b-b0db-777bca7a8da1"), "They are Brazilian", null, 9, 1, 2L, "They are not Brazilian" },
                    { new Guid("28e7095b-a059-4744-b842-c3f95c871b3d"), "It * my school. ", "*", 10, 0, 1L, "is" },
                    { new Guid("2e2b3aaa-490c-4c94-89af-b3cfd12ea065"), "She * late for work.", "*", 6, 0, 1L, "is" },
                    { new Guid("3bed01dd-80be-4dd4-85d9-940eea058cc3"), "You * Kazakh.", "*", 7, 0, 1L, "are" },
                    { new Guid("3e5834bb-a728-471d-844a-c2d6e018ef3b"), "He * early.", "*", 5, 0, 1L, "is" },
                    { new Guid("42aae30a-7478-441e-8d25-c24ed7c41f66"), "You are French", null, 8, 1, 2L, "You are not French" },
                    { new Guid("44eb7539-315a-4539-838e-1fa631dc6a06"), "It is from China", null, 7, 1, 2L, "It is not from China" },
                    { new Guid("45a69ef7-7903-45b7-9295-5fc776fb8276"), "I am British", null, 1, 1, 2L, "I am not British" },
                    { new Guid("59dea1c8-e763-4e12-9ed7-7c73a28b0c73"), "He is Kazakh", null, 10, 1, 2L, "He is not Kazakh" },
                    { new Guid("5c61c923-5afc-4d3a-a58d-1f1fc28ba830"), "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wBDAAMCAgICAgMCAgIDAwMDBAYEBAQEBAgGBgUGCQgKCgkICQkKDA8MCgsOCwkJDRENDg8QEBEQCgwSExIQEw8QEBD/2wBDAQMDAwQDBAgEBAgQCwkLEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBD/wAARCAF5BNADASIAAhEBAxEB/8QAHQABAQACAwEBAQAAAAAAAAAAAAEHCAIFBgMECf/EAGgQAAECBQEEAwkNAwYHDQYDCQEAAgMEBQYRBwgSITETQVEUFRYXImGSk9MJMlRVVldxgZGV0dLiI0KhGCQzgrGyJTVSYnJ1wSYnNDY4Q0Vkc3SElKIZN2V2s/BEo8IoRkdTWGNmw/H/xAAWAQEBAQAAAAAAAAAAAAAAAAAAAQL/xAAeEQEBAQADAAMBAQAAAAAAAAAAEQEhMUECUWFxEv/aAAwDAQACEQMRAD8A/qlyUBJVRAREQEVUQEREBFVEBERARVRAREQEVUQFwBGcHBXNMDngINatse29TtT9OaxppYloQJ6JOljWzEeb6FoaWnePvTnBK9PsrUW+LO0tpNkXlQIUhM0mEYZfDj9IH8SeHALN2BnOEDWjkB9iLmpDzu8Tkqp9CIgiqiAiIgIqogcEzxwETA7EBFVEBERARVRAREQEVUQEREAhCcKqIAPBE+hEBFVEBERARVRAREQEVUQEREBFVEBERARVRAREQEVUQEREBFVEBERARVRAREQEwqogmeKqcEQEVUQEREBFVEBERARVRAREQEVUQEREBFVEBERARVRAREQEVUQEREBFVEBERARVRAREQEVUQEREBFVEBERARVRAREQEVUQEREBFVEBERARVRAREQEVUQEREBFVEBERARVRBVEVQRERBVEVQRERBVEVQRTfbx48lV8seQSRkDJ5YQfRr2uJA6lV8YEWDMARoERr2jLSWnPEcwvugiIiCqIqgiIiCqIqgiKZKZKDkopkqg5QEREFURVBxLwDjB+xN8ZxxXCIcO4A56z1BGvhvfjiHAcB5kH0ByicAgOUBcQ8EE8eC5HkV8zudee3gg5hwJx1qr5wntc53DrX1QRFMlATyQclEVQRERBVEVQRERBVEVQRERBVEVQcBEaSRxGO1XfGcda+bt4kkEAKtcGnDhhB9N4LiXjJHHgrvs/yguJeC7DcHt8yDlvtyB28VV895oIy4E8sBfRBVEVQcOkbnGDn6Fy3hnHWoSAN4qNIcd4FBzURVBEREFURVBEREFURVBEREAkBEwOaE4QFC7BHA8UyVHOxjjjj9qDkDlF8zvucQ1wIzx7QubeXPKCoiIBIHElMri7d5OC4OeffEgMHMlBzMRoIGeJ5Kl47Cvi+LCZuCI9rS84aOs/QuRcG58sNGP/soPrvDOOK474zjrXEB2+ST5PUgJdxdy7EHNzg3n1o54bjPWvk8tLSAcY5k9SjYsOKxr4Tw4HiCOOfoQfYPBOFVwbnG8Rg9iu+g5IiIKoiqCIiIKoiHiMIOO+0nAyrvBfNmWkgnAC5Nc0czglBz3gpkJvs/ygm+z/KH2oG8E3xnHWOpcXuBb5JBPZlRri7i3HL6wUHMPB4hVcQCBxHHrQvwg5IpkpkoOSimSqOKAiIgqiIeAQEUyVQepBVEVQRERBVEVQRERBVEVQRERBVEVQRERBVEVQRERBVEVQRERBVEVQRERBVEVQRERBVEVQRFVEBERARVRAREQEVUQF4/VatGgaaXTWmRHNfI0majtIO6QWw3EHPVyXsFgzbHqzqXonUZcf8ATE3L0gDfLSe6CWY4czx5daD9WyRS5+m6JUqLUpycjx6jHmKl0k1Ec9+7Hf0gGXEndAdw8yzLvObgnLuH2rzemdJZQtPbbo7GbvclKlIJB55bCaOP2Lz+t98X1pxYdRvGybYka7EpUGJNTEtMzToGYbAXO3S1riTgckGRA5xJOSBwPEJv5Od44PVhYH2TNoqs7SVhxbyqtuyNDeyZiS5lYE26M9ha4t8rLQRnC/dbereqdwaz1vToWFR2US32wnTNVZUnuf8AtW7zAGbmM4Bzx6kGag52TvOAzyVy7ON48OfnWE7o19n5nU9ukemNFlq5WpeD09SizEYwoEmzAPvwHZdg5DSBnBXSapa3aqaFSkvdN62nI1S1nxWsnZyVmXGYk89kJrcObgHJJHIdqDYcv45B+pTefvcliK+9bZ2laTu1W06oUtckkJPu4tMwWDcDcuGWg8Rywum2Xtoava/6ZT1+TttwKdNQJh8GHJwozojTuucMFxAP7vYgzvvOJw3kOfaq7ePAHC1Usza7vS4Npd+z9cWnkrSOgl3zL5xk2+I9wBYWjdLQMEP7VtUXZIIPDOEGsO2tfmsmjOnM/qXYmoMOUhwJiHDZIRKVBita0tcT5buJ4t7Otft0qo20NqJp9R7yj7QrpSLVJdsZ0FtsSrgzPVnPFdT7pKHv2ZKs0fC4e9ns3Hr9Wz7tAWJSNH7ap03KVvpJeSax5hyWW8Ow7yNO5qkltDaf3paEWp6uQrloNTqsGRqMGJRZeVc1ryeIczJ5BbBb5LWuBOD5lh3TbW+3NY72q9GoUlNNl7f3WRBOywYTGc0Oa5uc8gTxC/ftC6sXPozYc9fFCtGHXJely7pibY6M5m4xvMjdBRllUFw8pzgAepcS543QDnJ4laoWBtQ646zaVyd5aX6S0+NUJwvbFZPz0SDAhYc4Aw4nRu3+AHMDjlTZl2wLn1N1MrGiuqdowLeuijw3RHNZGc4RAC3hxa3B8oY4ckI2wL3tIJH044rk15ceRH0rGOuWuVE0ao0pGjyzp+r1WMJWmyDPfR4xBIBxxA4HjgrG2tGtO0BpBp4/VPwEo1XkYEER52Q7vczuWHjO8HCGSernjmg2AuamTNboU1IQZ98jFjQ3NbFYMln0LSvYjuW85zaE1Ite5bsnqzBo29BgGO92B/Rng3JA98s67OGs+qGtNsC7rwsOiUOjTss6PIR6fVHzT4vHGHNcxu7xB6zyWv8AsT7x2qNXS0HdEU5yOvEJGo2A2q7s2gLXtqlTOhFFhT07Fn2snCYfSObBwc4aWnhnHFZhtearU3b9PmLggMl6jEgNdNQ2HLQ/HEA4C1y2tdqy+9nBshMSmncpVKbUppsnBnYs2+HuxDk4wGEcgetZvr+pFLtDTKNqPckTueTkpBs9MbozgEDgPrcAia9nknjvcF4zVegT9x2dPyNNrkxSo8OXiRWzMBuXAhpOOY7FiG3tVto2/bQg6mWhZFuvpM5BdM06Tj1NzIkeGHEeX+zJaeB4cepZUtC7apfGjsK7a9RmUqoVCmRokxJseXiC8B7cAkAnl2daI1s9zMvG67zsC96ndNem6lNQ7jfDbEjxHPLWiEzgATwH0Lc8uecFpBHXxX82Pc+by1EtvSq+ZHTey4Vfq77jjRQJuM6XlgOjaADFa13lebHJZs0O2wr7res0xoVrXZErbtePCSiS8d0Rsy7sGWtyMA8fMi6yPtRVHaWlKRSoezvBpwnY0yWzkWbDXBkPdPIOa4c8LzVpXTtaac2yy49YpSg1+Xg7rp8ykZsOJAYSBvMYxnl8SOHDhlZw1I1FtrSyz6het2Tpl6fToXSRXAAuPEDAGRk5IWht87VGu21gImnGhum87IW5VIjYMetxobxvQd4HJJaQzlzBRX9DqHWpG4qXLVmlTDY0pOQhFhRG8Q5pXYNJOQergvH6S2ZG0+05t+y48wY8WkSTZd8UnJeRk5/ivXwwQPK5oy5IiICKqICIiAiqiAiIgIqog0/1MseY1Y2tajZlVvCt0ulSlCk5iFBkJ6LAG+5sTJwxw57oXo5/Y4sykysaoVPVC74EvBZvxIsStTLWsa0ZJJ6XgML9Mi3e24q5nBAtqQI9GKshbQ+llY1j0znbAo9fjUWJUI0ExZuEfLbDa8FzRxHvhkc0aayS1rbK89XWW9K7StUM29/RNHhJG3HPzgNB6bmTwCytA2MLUmILZiBqReL4cVocxza1M4I7QelWONpbQ/QPSDZn7wVWWkZWsysCDDkp1gaybmZtgG64OGHEl4aTx61n3ZRi3NE0DtKLdPTOnjIQQDFzvGFuN3Sc8zjrQY02W7fm7G141QsEXJVarT6bI0uNLCfmokcw3ROl3sF7jjOAtrFrbotn+VlrH2d7KL//ALlskiaIhc0EAniVxdEhtaXOeABxJRGMdojWOl6JaXVe9Z+Ya2NAhOZKNIB3o5B3BjszhdHskaxT2uOjVNv6rRofds1MzEKIGNDQAx5bjAXiLpoA2mq1ds09vdFp0SQm6RTmOb5MxOljocZxHLMOIzyTx59Sxn7mBX4MjRb50rizBa+2KzFhQoTxyzFi5I7feovje1z8cBnP0KBxJ4HgRx8y8RqnqRD05tibq8CQiVKoQZeLHgSUEFzooYMknHENHDJ6srU6X90NuAaGVHUaPYUv38E/HlpKnwZhz2mHDiPa+I87uRu4HUeaI3nLjxIdy8yoeSAeI8yw9ZO0BIzGhdP1j1Ckm0RkxBDnwA7eL3kZa1mcbxd1BeD1X171xs6xYuq9Nseiw7dlGtmeimJ5zY8eXILgS0sO67dHIHrQbO7xJJzhoU3ng8CHcOXYvM6a3pL6jWTSLwgSz5ZtTlYccwnDG45zQSPOMnmsKbSe1Hc2k9Anqzp/YcW4oVIitbUJqIXw4ENuCTuvaCHYwc8sEINkWuLgcOP04VDzgjByOC8TprqZTdS9NqbqBRWGJCnpQRjDZxPSAeWwduHZC8Vs669zmr1p1+5bnpcGiwaPUo8nvGIS0w4cR7d4kgY94MoM07zx2ZV3nEjz/wBqwZKa23xqfMzzNELYkp+kycR0u+r1CZMBj4oOD0WGubEAIIJyMELrLD2hrxp+rbdFNZLekKVWZ2A6apc1JzJjQpuG0tByS1oDsvAwM9aDYcRM4xyPWpvk5xnI7VrjtabVc5oFbESete2RW57uhko/pHlkKDEe0lo3gD5WBkDHFZPuLUt9l6LTeqdYkWF8hRm1SLLBxwSYYcW559aDIQBySTzRwyDx6ljTZ31Vqus+ltL1Fq9El6S6qmK6HLwo5iAMbEc0Ekgc93KyYSMZyg0b2g9ZtoWyto+xNGbF1NlHwbw3hGL6TAc+UJiFoHHOeHHjhZ3Gme0EYTHv2kYnSbu8Wi1pXgev95ajXdeVMnvdFI1Tq7ZmZkrNDXMMtB6RzTiG7gM/5xW0t7bT1qRJOWt22INZh12vx2yFNMaS3W9O7JGTk9hRrXbbOM5qVEjXrTtTbiFZmqdV4cGXmhLMgB0MwWn3reHMrM+XAhrf/sLz9TrVHs62oterDWQN2C2LH6NgD4r90Z4cMla46bbaFTvvXm5dNJyzxS6VbUmYkSPFe4TEaJlhDRDI98Wv5Z5Iy2uJcQS1+PqV3nA7uc8M5WsFZ2ndSaTtA2TpfP6fScrRbvfvwZrup5mYcDec3fiwizDDlp4Z5YWwt1XZQrLt+cue4JxktTpGEYsaK48hnzoO5LnEgEDzr4zktCm5d0pGc4MiNLSGuIOPMQtfrj1Z1yqtnT2oljWhR5SiwoLpqU75zpgxo8EHGYjCw7hJB5E8Mdq7LZd1nvDWvTWb1CuqiS9LMWM8SkCBEMRrYTW8SHEAnygUGALDo85ObeVTtygXFXotItKF3bMSkefjRYQeXBvEOcQRh4Wx+0+ddX2bIQtBhKCqRJ1onnTIHky2Mndy05OcLBexU11za06zawzMYmBNVR0hvPGCGtZCf9XLkvW3vtj1an67WTpNadoRZmm3LHINRmN5nSw8P4whgh7cs557UXWzFsird4ae2vvESo9ztEy9gw0v6+XBdjvOJxjIPB3aF4jWHVSmaRWLM3dUYXTRYe4yXlwf6WK5wAb/AB/gsbOvbathXdRX+Lq249AqcQd0mFVHF8q0gnJ/ZceQ5nrRGOfdC6VCtnTuUuehV+r0yszk+2VhOgVSNDa/JHAMDgDwJWx+h1Inbd0mtehVOJHizclTocOK+NEdEiF3H3zncSePWtXPdCp1lz3LpTpsIrBEm66JyPBLsZhthPOSeYGWL3evW0/eWl1rSdxWLZMnP0UzEKTfOzky6C95LmjegsDXCI3iOOR19iLmNmp4zbKfMmSA7o6J/Qhx4F+75OfNnC1OtOV90EnrrnJu46va8nSIEQmDJs6JxjNzy3+jBH0rZ6m15sxasC4avD7iDpbumM15x0fDJzn6Fqdf239KV+fm7M2e7Kqd41tjugEVsu4QGOJxvh7N7IHbhBszptfs1dsnPSdZlpeUrVImXSc/LQIvSMZFaBktdgZHHnhe1Y5xO6RwA5+dYP2WtMb0sq1KjcOpc2I903TPPqk+1p8mA54b+zby4At7BzWcGDGTjiiOSKqICIiAhVUPIoNZtsaWnqvMWBbcvXajSoFUqseFHiSUd8Jz27sPhlpB619oexRbO6N/UW8s5P8A0zNcvWr67VY3rr0sDnHhWo/92GtiA3D8E8D1ZRfGuQ2KbYDjnUW8jngB34mfaroK1sy6T25UYFKr+tdw0+bmnNZAgzFwTDHxHOOAGgxeJzhZr1z1hoGienlTvWuRm78FhhysLm6NHdwY0D/SLcrXHZE0duzUi4ZvaX1sEaLUau8xKNS4znOhScEklrww8CSHDBx+6hj6XdpD4ktV9Oolv3xck3DrE3MQpmDN1GPFY9rQzHBzyP3itztxvMDmtddpf/3paSkA/wCMJvn9ENbGY4ImuLiR9AWBNqua17tmxqnfGjl3Q5WNS4QjRKdEp0KM18NoJiP33AngATjCz04HeBacE81+WoU+XqsjM0ydhb8vNQ3QYrDycxwwR9hQa5bD2r9763aaMvO874bVJ8TMaXmJNtOhS/QlrsDizj/DqXebS936p0iJR7f0buxkvclUm4UNkkZCHHb3PvNEaK4uyQGtOeS1QtC4apsVbU1yWPGk5qatu7mRJunQYLS4OmYm86DCYOobz2gkcvOt2tJrFqUGPG1Gvj9tc1baHEPHCUl8Ho4TW8mkNduuIAJxxRrcem09pF9Uaisg35dra9UXNaXxWybJdrDjygAzgeK9U156jnPUeCxrfusTKBcstp3aUhCrV2zsMxock6IWQ4MIAHeivAJYCDkcOOCsX0vaG1StbXel6R6oWtS4cG4JeJHlJinTRjuguaGndc3cbw8scc9SMtmwX4OT181A6I3jkOH2YWFr11lu+JqPM6TaYUan1GsycmJqcizsyYLIG8wOhgENdnIzzxyXZaF3LrhXW1aBrLaNKo75SPuScaSnHRhMMy7JILGgch280GWmkkZIR/vTxx51GO5gniCq8t3Tk44INJNprWfXrTjXWwtNLG1IhOlrwmHMjh9HgOMqzpGNGCc73B/XjktvLPpty0ulsgXRcprM6QC6P3IyB/6W8Fo9e2/qD7pHRKAA2JL2xTO7Q6Gd8NduwX8exb+EgADeA4jmi65FxAPE8ewclGufjBGXLyWpmpVv6X24+4LgiuDXxWy8vBhjMSPGdnchsGeLjg4CwZrLrbtC6eWDMaqytlW7Do8nCEw+Vj1NzIr4WC4cOjzvkDl2ojaEucRwdhOkI4jyhhYp091Wqs9o5TdSL+pvcU5OQunMnLZiOeXZMNjBgFzi3HBYg0s21Kpfep1w2vWrL710iigw4O49z5qYjkAw2CEQPKIzwyg20a528ck4HNAX7vHiStUqntcXvbWu9J08vaz6bR6FUZKLOiZbOOfHZCa9g3ojC0bh8rllfo1Z2qtRrIuC1m0jT+Wi0K4apCkoUeamHwpuIHE8oO6eBxkHPZ2oNpi9w6hw5krk3OOPFfkp8w+akZeZis6N8aG2I5nPBIzhfqhe945yg5IqogIiICKqICIiAiqiAiIgIqogIiICKqICIiAiqiAiIgIqogqiKoIiIgqiKoIiIgqiISQgLWLbBizFcrenOnkvD6UVK4JWoxYYPldHLR2OcQOvg5bOjitZrwc26ttG0aLGDXy9uUSejxWh3vXxYcN0Mns96UGyEtBhwZeHAhNLWQ2hrQTxAHJcKhIy9RlY0hOwmRJePDMOKx3EOaRggr7Yw0bo3hyJ61XNcGHAyOsIP526R3K3Y/2l7703uCN0dt1yFFrkm9x8nfwYghszwHGJjgtx9CrfnpG15i460WxKjcMy+efExxdAc4ugA/QxwCw5tQaHULVXXLTOZh4bUZGJEm4zGnAjy0KJDMQPxzwMDC2olJWDIysKTghrYUCG2HDaBjDQMAfUAi1oxsFVmYi62azSlzf41jVsmCYw/adAx0UDGeIG7uraHaSp8jVdDL3kZ2FDfCiUWZyXAHd/ZniM8ise3rsz12j6wM120cn4EpXY0PoJ+mTLujlZ2H5IJc7junDeYbniV319Wjrfq1bExYl0U6g23Sqozop+cp1QdMxujIw5jWuY0YIJ45yMItYM2Tu/EPYRuODPRXvlIUtU4cmYpySwPiZ4n6AvTe5oOZ4lJ8MHA1WNk46+liLYej6Q2zQ9LzpTTIPQ0h0i6Sdu8C7ebhz+fMnJ+taq6L7N+1poLcVXt2zK/b0SyqjPOmWRI0yO6IQLnHgwwyP3j1om7w6eES/3UKeMFpO7RfKBH+ZA4rfgO8nLRnjyWl8LZf2gqPtUHXSWqtFrcm6WZLvfNTAl4rwWs3huMYRwLMDjxW5svEjugw3R2NZELAYgYcgOxxAPZlDWrXulAd/JkqpBOe64fAdfkPWS9mmj0aLolakZ1Kk4j3SLN4vgNJ5fQvI7XGkerevFnzGnNrydGlqVFjsjGcjTpbGOGkEFm6QPfHr6l+TTa09rDTizaZZkvTLSn4NNhdE2YiVJzHPGeGQIWAheGan21a9nVKfvlsKBT4ZgOdNiFBaxrsY8skY4gBeH2op6VquzBqBOygiGHGt+YczeGCRheNv2ydqjVKkC0q14OUOkzjuiqESSnzFixIByHNGYYxnhxBXt9dLC1DvDSSd0tsiRpb2Vak97Jibm5ow3wfJDd5rQ0h3LPHCJjwHudAJ2YqA1zSOMb6/2r+SxHRYEOF7pbWCyG1rnSgJIbgu4QuazZst6U606FWJC09rFPoU7IyTHulphs+7fLy4u3S0MwB5R45XhpPZ118kdpaf2g2U+23xJtvRinOqTgxrfJ/f3M/udnWjVfk2+LSueUvTTrWSm02aqNKtObb3dLQA5263ee7pHAdgOMrJWuOq1g3Ls01uNS65KVKJV6R0MrKy7mxYkaKQP2bWZ4ngeHmXn9uGpa003SKVn7Lo8hGDIg78yoimIXw8OyxmWkkcuPArBlj7Ul0WLQYLq/skztOZBDWQ3dBFjQnDGS8b7cA5zyQxs1sVad3Dpvs/0al3J00OdmYT48SWi5zLgufhoB5cCD9awVsSAjas1iad7dEYgejBWfNGNqS3toK1apE0ypwFfpY6KLTaie5mh+ByI3ju8RxwsZ6H7OuvOkWsFz6l9yW7OsuokzMq6oOaIGd3i0hmXcGdeOaFdR7qzujSGzsZP+6iFz/7J62Mu6z7e1D0GNgXPOiSk7gpMKTdEJwQS0OGOPmWKdsTQLV/aQpFLtKky1EkKZSKiyow5l867pYrgwjdLSzAHlHr6l7ar2Fq9dWjUzaNXk6PTrlkoLGUqZlp50Rm+3dw95LQBw3hjBRK1QpU3tb7EEvFk49EhXppxI8Ye5Ec58vL5984hhLefLPWtz9NdTrb1c0abedrsECSnabFeZctDTBduuy0hedrdF2hrxsmasSv2xaktCn5cScachVN0V7W8Mv6N0MNJ4cl2duaUVrSHSGU020upshUI8GE+XiPn5h0AODg7L8gO45djHmQrXf3KNgOmt9vO8QLpi8+3o2Lq9WoTIXul2mL2BrTEgEuwPfHEZZP2PtnzV/ZukatblVlKHP06tVJ9RjTDZ53SQXFgAa1oZgjyRzPWulvHZy17ujaRt/aA7htxkS3iWQJDvi7cezy+btzI9+epFrPu0Jpj42NL6rasOXhxJuMIbpdr3lrN5sVjjvdo3QQvW2ZbdLt+iSUpIUGRpbmQWh8KVhNY0OHDHADK8dq1Yl86p6Oz1qQK0LYr9SlgyJFkYpiNhv3gcNiHBxw5r7bPWmty6Waa0207sumYrtQlWAPmIx3iPNvc3fSUZZNAwiIgIiIKoiqCIiIKoiqCIiIKoiqDW2nf8uCuf/LUh/dirY6JyK1vkIgbtwV0EHPg1IYzyPkxlscXl7CWtznhhFjSmDpJX9edrKt1zVuiVVtsWoyD3mlosNzZSaiAvw/PAHBaw8jlbpysvAlJaHKy0JkKFCYGMYxoDWtHIADkFrzpFs4Xbp3rddGpdYvqfqVNrkWLFgSEWO50OBvl5ADScADeH2LYcucAeAwEVrtox/ysNYv9WUX+yMtkFrZovE3trDWID4roh/hGWyaJri/n70HhzWJderyn5KkyWn1sPLrjumJ3NBhtOHQ5XIbHjDHHLGvz/tCyNdFXFCo0zUuklWOhQ3FhmYvRwt/HAOd1DPWtSLUuO6YOtczqjeF32DPQYzGSkCCK5nvfBxuvMMbnlEjHPGSERmm2tmLTSgUKBS2sq/SBvSTDoNUmIYixjxe8ta/GXOyT9K1I0ClZLQXb0uLTMsiylPrkm6dYIji4ue9u8zJdxJO+t3ZjWnS8S0Qyt+UGJFDSWB060NLurJ6lpfqnZVwX3tA07XWn3xYdNmKU6C1ku2tZbMQ4e6MOcWZGQ0fai/H9bZ7T1ckra0OvGsxoUERu9E1LwYjuDmufDcMNPMZ8ywzsLaJSMDQKWmL3pUpOxq9EiTBgxGB4hwnOJGCR+8HZP+1dxtDVaja36JRbGg6h2rS6vPzMB0yGVIOhNhNzv7ryMngexZUsbUnSa07OodsHUCgDvXTpaTc9sywBzocJrSeHaW5QrXTaqn6tWdc9MdD7MkJSJKyZ75xpCNE6GBE6B8IwwcA8g7HJZ4q+jFU1FkIEtqnXg6jwHQ4veOUYGwGlnAAxW4c5vmIwsHbTtt0y9b/tvWDR/VS1pW57fJY6Xnqg2FBmIZLTgvw4jgwDgOte4ty/qxe1PhyWrmqdo0SX3NyZk6NU2xxNDr/alrHM6+Xai1sjS6dTqRTpan02Xhy8rLQ2QoMNgw0NAwAMeZeY1TsWn3jpzcNntkoLW1eSjQcNYAC5zSM8OvivyyGrmkNMkYNPl9QKL0UuwQmb04HENaMDJJyTgL7P1r0pafL1CoYaBk5mm8kTtqpsJaoQLQ0LvKiVaIHvsarx5SDALvLiOMSK4QwOeTu8Aueu8jO6B7GVQkqS58GeuypvhRHsOXMM66LEbx6sB2F5TZ4t6z5fWe+bnql90WVsuZrEOel5N0y0CbmWB2IvnDSXDHI73FbGbQETRLXHTCe0/ntR6JKiNiLKxWzTf2UZrSGPAz1bxRa9/oZaFNsjSu3KHT4TWsFPgxn7gxvPiMD3E/WStctWJVuoG3pp1T6FEO/aFMjzNSczju/toTw130tK/bZmr2sduUWXsmNcOmUzKSUJsrArBuI90mG0Ya4wei3cgAcMr3GkcnoppvUqldVR1To9auetvESoVKNMMa4nGAxoBIa0DA4YzgFErHW2/DgXXqhpPpCGQWQrjrcCcmg1oD3shvLC49uN7C/f7oTqTTtO9nePYUvNYqVelm0yDAbgvdC3C0nH0gLrdaKZBu3aJtDVqz9SrQfIUKViQIgnKi1r4L3RGuDobcHPvT2LptpnTqiauWzQ6HQ9XbYmJ1lUhT9Tnp2bhse0NDhiGMEYAcPJGAcZKLW02gdrQLL0iti3YYaGwKfCiFo6t8b5/vL38TDYL3F2QBkYWGdMrq0usWiiUn9WaZVajHhw2zM1Fm2tDnMYGgNYCWtAAA4c8ZTUzWWmzNAj0/T28LSjT0wwwy+cqogiFnrGGnKM61n2JJGV1C2k9U9S5uXhTTGzL5AGMwE5AZ+6eA96t2bgsG3K3Hpc5GpkpCiUicbPQXsgNDt9oI5gcOZWkOzpb9+bOktcMtQr209qnhDPmoRnzFaDHMeRjAIYSQsm3Nq5rTXqNHpNOvPTmkxJhpZ3VDrgiOh56w10PBKNa2cp1coV1UmYmZWC2alIG83fjQwWPIByW5yCMghaUbEdlUzU/WXU3Xeqw96IytdySrQ87nkw2cSOR96RxC2Bkrt02oOkjrEoeptB7tbJPgsjxJ1ozGcS5ziePWSvK7L8HTnQ/TWJa1S1ItyLUpuYiTEzFhTjC1z3F2Dnr4EImPPWnN0nUTbRuu5qpMA0/TqR72wYjjiHCjEw4uc/REK/ftd3XL3NeelmjEjPQxL3lWmGZLH8IssGRAR5xvMCx9pbpdR6dfd8VLUPWmgeDtzVUVAyklPN6SZIhsYA94w5gw3kDjguW1TL6f6iagae1LTPVul0647bcIUs+G+HEhS8MF/7R7ifJ99jl1orKe2lqxQdMdDKrZkjG/w1VpBslJQZdoJhDeaOkcP3W8CM9pXf6bUw6NbI8iyYYWR6XQnxI53cEuc5xzj+uta9tCVseU0PpDrevaQuGtyFThTNXnO6Q6NFYG4OGgnAyR5IwOGVsPed/wCmmsmzvO2tR9R6RTI1wUaHLQXRJlrXQnAtzkdXvSh/Hm9gCi0+1tCZOq1KPDhRryn3zjOnPlRnnLcDPM4YvKTMnJ39t/SkGWgwYUtp7SOkDIIG6w9K4chwb/SL12ztbumWkVrUiRu7WqlV6epMDoJRjphjIUqzeJw0NOHHJJ3iM8cLxFtWTK0/aRvnU+b1rtuTtm54/CBAmob40aX8g9G4kAw/Kbngerzombyz7tH6SQdf9Jpy26RVXQZ0jp6dMwjloitIxnzcCFiTY714v19bn9n7WqSdK3Vb0MCXmHD/AIXCBABGQM8z9i53/qJqnQNQZCqaRap2HUbShDcjUap1KHLcOPKI1jndi76yY1gR9So+tOo97WpK3I+TEhLScjPtiQYMMO389Jhpcck8xyRbmsXarWzA13276Bbs0X97LNp7Y03DhxC1xdvxG5yOI98F7Ta1hyN46o6S6FykNkCXj1Uz04xjQGiXbBiFvD/TYF+jSSl2PZmvOoesNw6m25HbdR6OSYyea4woe+1w+jiCvN6rWzLX7tH0nU+k61W1SqDJUxso+IJuG+Yad5+Q1hHLDvfZzxRM37bSXlS5K+rErFq0efbEc+H3FEdAfxhuGCWnHI4/tX4NGdJLZ0zsqi0WnW7T5SckpZsONFhwG9K5wzzfjeP1rGV8v0ydonVdMtM9XaXRp+bhNhwJ91QDou/vNJeXuJOSARnK7/RK8LC060uoVnXJq/SavUabKMgzE3FnmudEcOZ3s5P0ojOiLzluah2Vdsw+Ttu5qdUY8JgiRIcvHDy1p4AkBeia4OOAg5KIqgiIiCqIhOBlBrptWf8AGvSz/XUf+7DX4tuDaBvnZ8tGgXDZ1JgzEKdqHRVCZecmWhAs5NwQS7ecOOF+zascPCnSx3UK1H/uw1lDWDSW1NcLGm7Fu2C58hOFj95o8pjmuBBB4dY7UMaT2ZXq3t8ayUaeqMlMQNOrSgsmY7HZY2YncHhjk4bzGZGeGV/QmmU6UpMlCkJKCyDAgNEOHDYMBrRyAC8NororaOhdnQbMs+DiVhvdFdEez9pEc7GSTxPV2r37ojwMkDAwi6142mDjVHSUds/N/wB2Gti+pa47TUT/AH0dJTj/AKQm+J5e9hrYwO3hjsRHIDKOPA9qhcW8wMLwV8auW3bMGPIyVx2/38h4LZOfn+gGP84gEj7EGn+sLZfUP3RO1bJaGxDRKayonI4Athtf9Z8lb4VGehUynTM/G4slYTorsDqaMn+xaE2ba1027tHTu0JU7xsGenpuBFlRJPrmGwobmloAduZ4A9nUtvTq9pbUqOZOrX3QIcSal+jmYcKdDmtc5uHgHhkcTxRqtWNlKPqbqTqDqNqdT2U8CoVWNTYFSjx96PKwYEWJDaGQi3HvcdY5LZq0tFaDQ7yiX9cdRiV6548IQmzswwM3GYwQyGCWt4Y4jsWp+mtG1A0B1AuLxZ6j2DWLOr07FnQyoVkQI0B73udhrQx2cF3bxws9S1wW7NSE5cVY1wpEW6nScaDIPbMw2wJF8RuMbo8mJg4wXDq86FYn2sbA1Y0i1aG1ZpCyJUWQ5VkrWaaXEgwWsDS4Nwcjda7JxwW0GiOq9G1m04pV+0drmwZ2HuRWEY6OYYAIrfoD8jPmWs9rai65x7fqlial35ppVafUmx5bv0K01szDgvyAegEIMJ3SOBPUsn2+/RrT7ROb0wtXVij07pJSYInWzLN6HMRgS+KBnA8okolbEN8vly4FHEN3nPI3cfYtN9hvUGVtGw6zJ6kaoyE451YmYci+bnd6K+E2M8b/AB5NcN0jjjBWadQdbKIaNFgWBeVpTU9GY6GDO1QQmwyf3hgHOOxEaxbJjm6jbYmpGprCYwpLn0gRcYA4FuMcv+bW/eN0jOD5itFtk+3p3Z+rt1zVWvmxqjLXhVG1CcjisARJbi8u3Ghvle/PMjkttBrPpW5oxf8ARC7/AL23l2o1ca93nPt1d22Lf0/mYzn0eyaZGqUxALstiTeYUSCS3kcAu4+ddX7oVqFTahbFC0Mo0aMapcdYlYcboIYc2FC8ppY7jwLg4EDrwvOXbZdadtT1PWHT/XG1qNRa5Kw5SajGZhRI7GiGxjt2G4EH3p61+bXPR217wvTT+r6eau27KQbejOmarUZupCJMPjmI13SNhuyHfvYBOByHBCtzKFLUi29OqZLz0GC+DRqbLue17QQxzITePHkeC1E2AdPabdV0X9rXX4BizszXIkGngvJhthtc9u9jlnyRg4yFmKqzmnUlo3X7DoWrFJmKxWJCLAbNzVQA3o7wcOzk7oyepfDZlmdNdENJ6bZFU1Ft2JPwYkaNMxIc40h73xHO59fvkKxXbFtU3WLbxuWuVQunKZaEo2BLQ93MHpHMhuw49YyDwPBdvrs519bZOlViSj2OkrfhuqszBZyDocVm6MDzPXdbNNOs7Se4r8ue7dTrbm526qo2bgmDOtd0cJrS0Nzw6sLyF2WRJXLtRTWq0rrNblNtybpzqfE6KdY6Y6N3R7zGgjyclnvgchCt15GdkZ6VZGp0eHGgZLA+Gd4cOBH2jC/VCzg5HDPBa26yx7IurR2a06051hpNDm4kIw4Uw2oBrnZBzl+ctyTnIWVtDYUlIad0yhy16Q7ni02EIUefZEDy9548SP8A74IyyAoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIqogIiICKqICIiAiqiDi44K1r0ehG7NqHUu9ntY+XkJaQp8q8HOHNhvZEH2tC2W4L80rTafJPiRZOQl4D4x3ojoUJrS89pIHH60H1GRgH+CxhrrrnRNCbXh3NXaTUp5kWYZLthSUDpDlxwOsLKeF+aeplNqkMQanT5abhghwZHgtiNBHI4cDxQYZ0NNyahVWe1ku2hPpRqMNkKjyMcERJeXAw5xB5b43XYWas8nbhyOGMLnDhQoLGw4MNjGMADWtAAA7AFyQfPBcM5cBnlhXHVnHnX0UQfPdDWHBJ+hCMkEgcsL6fQhA7EHywM4LjwIXIgEDhgZXPATmg+YI3Ceori4u3RuAY85X2wOpMDsQcCAGgELiODsh2QRx+lfVMDsQfIgh7XbxOOfBMNDjhhPHOV9foRBqJtd3Hfln6wac3TEok9UtPaZFEetQ5WGYgbED3Yc9vJw3eonCyxTNetC7nkmwqJXKXWZkww8U6BDhxY44e96Pt6ll2akpOehGBOykGYhu5siww9p+o8F+CUtO1pCN3RI21SpaL/AJcGThsd9oCLWEdnjR2JbV7XrqtPURtFiXXOtiylPZD3BBlxDY0hzeG6S5mcedZ+4P4Y4YX1AA4AJgdiI+Q96Rx4riN5zWtycdfDmvvhMBB8zkg8cfUpvHmBk9WQvqmB2IPiRl288kOA5BRp8kYJJHPd4r74CAAchhB8og6RvW0BcgMOySSTy8wXNOHYgIqogIiICKqICIiAiqiAiIgIqogwtqdstafap3k6+q9NVSWqjpdksYsnORYP7NmcA7jh2leWGw/pox2WXNdZ3jn/ABzNe1WyWAmAOQRa1wZsR6bseSbjuvB6u/E17VQ7EWnDsnwnurH+uZrh/wDmLZDCYHYhWJtGtniydEqjWKrajp2LN1xsFs3HnJmJGe9sMndGXuJ/eKyymAiGvjNy0tNwjAmoMOLDcPKY9ocD9IK6xtp2sIeG23SeJ4/zOHx/gu5wmBywiOnNqWuPKNuUoDsEnD/BcXWpajmki26WRjHCTh/gu6TAHIBB07bVtbDW+DdKyBy7jh/guJtS2HHPg5SiB1CTh/gu6xxTAHUg6cWna2S423ST/wCDh/gobStce+tmlE+aSh/lXc4CIMW6tXppjo7RZevXRaMKLKR5mHLDuOmQojg5xOCRw4cF4gVCS14kHUWzLAiUegTIxO1OfpjIESJDPNkDgQ7Izk5BBAWwM7TafUoYg1GQl5qGDkMjwmvbntwQvpLystKQ2wZWXhQYbfeshsDWj6gi15m3tOrLt2ly9Jkbapogy8NrRvyjCTgcSSRzK7A2nbHPwapTsf8AU4f5V3WAmB2IjpvBS1sZ8GqWCeH/AAKHw/ghtS1+Xg3Ss9nccPj/AAXcpgIOk8EraA3fBylFruvuOHkH7FyNqWyCN62aVw/6nD/Ku5RB05tS1g3hbVLP/g4f4KG07XLeNt0sf+Dh5P8ABdynNB1AtS18f8W6X/5OH+CjrVtfhi26Xz+Bw/wXcJgdiDpBaVrNcB4M0rlz7jh/guYtS2A4AW3SSOZ/mcP8F3CYHYg6WJadsO3g23aU04yP5lDP+xabWdT4+jW1Re1S1WtWGbZux4i0qrGRYZWBhsNu48kBsP3jjwW8eBzX5pymU2osDKhT5aaaOTY0JrwPtCLWuOvFw6ZX7phXLG04pVKuOtVuB3HLwqZLQ4hhPJB3nloy0YHP6F7jZ80Wp2mOkNtWZW6VTpufp8ruTMR8uyId4uc7G8Rk8wsoylBodPidNIUaRlon+VBlmMP2gL92B2IV03gpagGRbVK4njmTh/gp4J2vlo8GqWf/AAcP8F3WB2Jw7ER0xtS1Qd3wZpf/AJOH+Cj7Ttot4W3SfNmTh/lXdYRB0rLStcBgdbVKOOvuOH+CeCVquLmm26UQTx/mcP8ABd19CYHYg6U2rajMk21SiR1CTh/ghtG1gc+DlLH/AIKH+C7rA7EQdbJUWjU15jyFJk5VzhgugQGQyR58BfvYRkho4LngJgDkEBFVEBERAQqqIMbaxaH2hrVT5Cm3Z3WGU6O6PAiS0V8NzHOxni1wP7oWOm7EOmwy0XJdQGeH+GZr2i2O+hEGuf8AIh02+Ut1ffM17VfP+RBpuOHhLdZGckd+Zr2q2QwmAi1gC1djvTS1bnkbsgzlanZumOc6WE5UI0drC7ngPeR2LPTMNhgY6l9cDqTA7ER83ZI3cdfFdfMW7b85GMxNUSnR4h5viSzHOP1kZXaJgdiDphadrB294O0vPPHccP8ABXwUtfOfBqlcf+pw/wAF3GBnKYHYg6c2papaWm2qWP8AwcP8FBadrYDRbdKJ/wC5w+P8F3KYHYg6UWnamNx1uUok5OO44f4Lp7p0us26pFlNnqHIQ5QODokOHKsaYmOQ3gAQF7LAznAz2oQD1IOglLIs2nycGSlLXpUKFCa1jAJOGcADHWF9XWnbG7ltt0o54f8AA4f4LusBMBB0ptS1yMC2qVxxn+Zw/wAFfBK13HhblL8/8zh/gu54cwmB2IOn8E7VJI8GqZw/6nD4/wAFPBK1snFuUrz/AMzh/gu5TA7EHSG1LZf5TrapRweGJSH+C5G0rWySLbpRJHEdxw/wXc4HUmB2IOmFq2yMZtulY6z3HD/BPBK1nOx4OUsD/ucPj/BdzgJgIOn8EbXB3fBul8vgcPh/Bfup8jIyEIwpCQgSrCclsGEGA+fAC/UiAiqiAiIgIqogIiICKqICIiAiqiAiIgIqogIiICKqICIiAiqiCqIqgiIiATgZwpvZJGOIR/vV+ePEmGS0QyzGujBpDGvOBnHDJ7EH36QZxghBEBz5loTtiam7R2nt2WVKRrgkqbRrhrsCWMtIv3y6GI0MHec5oIyHdRW8tBe6JRpIuBLjAhkk9fBFjtFEVREXzizEODCfHjODGQwXOJ6gOtfReH1qrUO29KLtrcaL0ZlaPNxGEH94QnEIPTUO4qLckkanQalAn5YRXwTFgv3m77DuubntBGCuw3weSw7snW++gaIUJkbfJqW/VMuJJPdBEX/9SyTdNtyl00iLRZmLFhMiEOD4Ty1wI84IQdyIjXHA+1Xf4kY5L+fOySLs1C1yv23LwvWqT1Mtqdiy8nLF+6Mbzw3JaQeG6Fv/AC0BkCFDlg4kQWNYMnPADAQfbpB1g8soHg8lr/tP2ZtCXfNWyNFbglabLys0IlSbGdul4DxgjyTwAys5USFOwaRJQKnFESdhS0Jky8cnRQ0BxH15QdggOVx3sIDnlwQcicIDlOBTOEDKLjnJKueCDkoThTJTmgqIThTJQUnCm8m9g8Vd4doQAcopvc8ICeSDkuLnhpwVVwijIBLsAHOO1By3uOMIHgnAPHmsObRNS1iplqTlT00mabIwZKTdHmJmPEIjNcDjDW7pBGMLHnufd/3hqNpPVbjvWqvqFRi1VzXRn45Bg5ADACDaTpRnGCr0g7PsWI9pjXCT0L09iV3o2R6rUIgk6XAecCNMEjhw48Bk/UuotvReqXRYsCr6i3DUI92zst0zpqDFdDbLRTxAa1pDXAcOY60GculYTgHJHNOlHHtHUtX9lfWW7Z+/by0D1InzO12zon7Cec0NdNy+WtDiAAM5cerqXx160J2jtRdTJeqWRqqKHazIQD4LN3pob948WtLTvcCOZRY2oDwePUqCDyPJa3StY1C2eJ23ZC/NQIl20KsTPcUWbn4MOBHlX7pPkthgBwyAOJ61sfCc17d5vJ3FEckREFURVBEREFURVBEREFURVB09Uu+2qJMiTq1alZSMQHbkWIAcHrX4jqRY/LwmkCQeXSjK1qu/Tq1NUdsmr0O85WZnJOWt6SiQpds3FhNDi2Ll3kOHYF7a59mPZps6hTVw3JQoknIScN0SNGi1aZDWgDPPfRYy+dSLFB43RTx1f0wQaj2MTgXRT/WhaNyuomwFNTsKUdRavDlI0fudtQiVCOJbeJAHl9Ny4rY+lbKOzrWabK1emW7FmJOahiJBjQ6tMlsRjhlpB3+sIRmak3LQq70go9Ul5swsb/RP3t3PLK7Nap7M9rUWx9o7Vq1LahzEClydPpD4UvEmHxQxz+m3iC8k8cfwW1iGqoiqIiIiCqIqgiIiCqIqgiIiCqIqgiIiCqIqgiIiCqIqgiIiCqIqgiIiCqIqgiIiCqIqgijnBvNVY617tbUS8dOqhQtL7hZRq7HAECZfjdHlDOSQccM9SDIYiNdyQRAc8COOFqVppoFtJWBRY1wVzXaam5+BBMV9M6CE+VjFoyQYhbvgcOpZ40a1IZqhZUCuRGQIU9LxDKVCFAeXMhTLAC9rSeJAyOaLuPfBwKq4tAyf7FyRFUJxkojs7p+hB19VuCjUOA2Zq9RgSkN53WuiuwCV1Z1IsYEZuin8eX7ULA+2RSpC4J/TehVZscyU9V40OPDhxnQ98Yh8CWkFeuGx7oGSQ60ponn/AI0mfzosZLOo9ig48Kaf64KDUixXHAumn5/7YLGx2O9AB5brTmvvSa/Osf3NpfseWvdslYtQli+4Z9zRBpsGrTDo5af3y3pOXX9SExshK3zaE9MMlJO4ZKLGie9Y2KCT9C7ze8y041Q0asPSXVrTGbsGQmqdEn52ZhzGZ6NFERoDMAh7iOsrcXkcg8wiOYORnCKNzjiuSCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIqogIiII5ocMFUtB4FHODRlxwmR28kGiPumDQ24NGg3gPCOH/9eAt3aD/iWQP/AFeH/dC0i90yiMFw6NeUONxs/wDrwFu9QeNEkP8Au8P+6EV2CKqIgsCbaFVFP0XjyBe7NYqklSgG8z07yzH8Vntax7WLYtxX1plYbC892VmFVHw2DO82VjQ3cftQZ509pLKNY1v0gQyzuKmy0DHL3sJo/wBi9CBnIK4QQIbQ3kAMDzDsXJrgCclBoTsMAO2i9XweqqxP78Vb7PYAd8DiBwWhGws5p2jdX8H/AKVif34q34JBGQUGn21ntAa3aOXfbVPpclSINDrk7DgNmWRnOjjLw07zS3A59q2KuasX03TdlZsmUp05W4klCjNbORXQ4TiYeXHLQTnPLgtVPdISBUdNyGku77wuOOH9K1bf0wDwCkxg8aXB/wDpNRfpqPs2bQm0jr7I33JSUhQpecodSbINjxI7wyXcBEDtzyfK4tzx7F1NI2htojRXaMoOkWt0/I1mn3fGbCp0zDON0lzWndw1ucF3Wvv7mKGF+swYCP8AdXgelHXXbczhD2wdnUENwZt+Ser+cwkXhvxDiF4Ds8DyK1+2wNVNXtH9PJq9rBp1JjyckwmZfMRntjM4E5a0Ag8B1rP0Ejo2cQOA/sWvW3w7GzPdIJAAgOJP9RyJ6wlN697XWpOllr3hozQe7xHjCFPx4LN+JFeXO963dI3Bghx4EHC2D1Z18rGktlW1JTlMl52+7m6CTkaYXkNfMvbxLscQ0OGDgda47FMrKy2zhaEOFDawdC9+AMZJeTlYE21os5QNq7Qu8Kk97bfp080zLz7xjunBB+nAKL+NjYlna3z9tiry+p8eWrT4IjNp4l4Rlt8jPRl5bvY6s810OzTtLzmq1Vrmn17UuFR7ytqMYU3JtcT0sMDPStzxxgt6utZ6k5mFOS0CYl35hx4bYjCOtpGQtFdLqNH/APaQ33O0Ath0+DTsTTmk7pcWQTu/ShxrOl3a7125NZvEPpgJbvhKy5maxUIjjmRYC3g0cQXYe0gEL8usUzrto5aMbUS27tiXfCpA7on6ZPwWQQ+CPfbhhtyTy7FhDZzn5qg7eepNDuYuh1CoSxiwHRBgPbuwgGtPbyW6WosKlxrJrUvWt10k+Tf04f73c68ojwVl6z1XWXSCFfmk8vTo1TjwiIkrPxnQ2y8UZBaS0E8wsCbNu0ftE68xLzp0pT6HLzlDnzJh0WO8Q4WGj3p3eJz2r9vuaNGrVO0pu+cn3udIT9ajRad/k9CA5vD6wV5r3NTDrm1YdgE+EL+XV5DUXh8KrtB7UegWvNCsbViLK3DSbnduyfQDyWguxwIa3JyCvc7QFf2ybUtid1OtyrUWUptMhd1xqZKvMQuhdmXQ854jrXk9vIhu0Noy7JDhMDq/z4i2i1yLRoNdBitG6aPnPPPBqGR1myzrbMa8aS0u9J6Xhy1Rczo56FDJLWRQTyz5gPtWYR5QIcFqR7mvu+ImI0AgGef9XNbbQxu5BOfP2ozvbxOtbG+Ke529Qp8T+0LXH3MbholVQ14Oaw/+6FshrVx0qucdtPif7Frb7mLueJCqhn7tYfx/qhFx5zb0qkWoa06Q2VOwmRKa+qCcewuPlHcit4j6gt4ZFu5KwmhuGiG0D7AtK/dFaDM0Wp6c6uyUjEmO8VYZCmojRkMglr+J7BvOC3LodQl6tRJOoSkZsSDMQGRGPacgjAQ4aNycw+he6Nx5anM6JtZl/wCd8T5flOP/AOkLO21LtOeIGk06n0S3olduWuRTAp0gwHynYJycHOMArGWltFiX9tz6gXb3KWyNpwO4IcdgyHzIiNJaT1HdflZx1gsmh1W8LHvGpzdOlYtv1J8YmdOBHaYT2Bg4Hjl2fqRWqth6W7VW0vqPRL710l4ts2rR5nuyBSYrSxxOCAGgty4cRzPUv6CS4DYYhg53BhfKXDIkJhhPBYRkbo4YX6GY44RFRERBFVEBERARVRAREQEVU+lBrdTiDtwV3PyakP7sZZN1w0hp2t9hzWn1Yqk3ISc3HgRokWWHl4hvDt3j1HGCsYSBaNuCuOBz/uakf7sVbHvILffbvXlDtp7tdO0W0l0AZpZGkKdGqs1LwafSZZkFjZqPFaA1rxjByCWnms1bK9v3FbOg9qUm6d8T0OQhOLXk7zGljcNOesLBFhaXwdRNry6b01FbL1OBR2MhUaC55c2EWmICd3lng3t5Lc5jWMYIbGhrRwAAwAEW+NdNGADtYawuPMUyi4+yMtkFrfoxw2sNYh197KKf4RlsghoijnNaRvHGUD2E43kRUTITIQETI7UyO1ARMhMhARMjtTI7UBEyEyEBEyO1MjtQETITIQETI7UyO1ARMhMhARMjtTI7UBEyEyEBEyO1MjtQETITIQETI7UyO1ARMhMhARMjtTI7UBdVdFwSFrUKdr9TibktIwHx4hPY0E4XaBwPIrqrrpspWbdqNKni0QJqWiQnudyaHNIyUH8+ri2kNqzakix6DoPYE3RLUnHmCK2+GcPhO4HeyHBvDs7Vt7syaNzOhel8jZVQn+7ahvGZno4cXNfMOaA4g9Y8kLsNAqBSLQ06pVm0qekJ2HQ4QkhGk8HeDQOLzgeUskgOA3gM9gRd3xyYc5BIzzXNcIYIJ8nGSuaIIeSqn0oNc9qsf7q9LM/HUfn/AKMNbEcBnBA+la77Vjm+FWlhDuHfqP8A3Ya8z7oPqhqhpLp5Q7s06qT5KBAqINUe1ocXQt6Hut4g8zkfWi5lZM2n9dKXobpvM16YeH1adcZOlyrffxo7sNbujrwXNKxXsZbP1bpkOa1x1Wa+avG6HGaa2ON7uSE/LmhueRw4gjHDCxRs7C79tjVan6wai01zLOtaXbCkZJ+ehmJ1oIdE+kEMPNf0IhQ2woTWNAYGcAGDAA7EL4162mG72qOkp4YbUJvP2Q1sZgbuO1a57S5b40tJjn/8fNn6fJhrY3huhEVowAOxFA4YzlXIPWgImQmQgImR2pkdqAiZCZCAiZHamR2oCJkJkICJkdqZHagImQmQgImR2pkdqAiZCZCAiZHamR2oCJkJkICJkdqZHagImQmQgImR2pkdqAiZCZCAiZHamR2oCJkJkICJkdqZHagImQmQgIgIPIqBzScA8UFREQEVUQVRFUEREQRwBacr5PDwwtYSMtIyOJHnX2IBGCo1oaMDkg1f122Rbi14rtHq1b1RqEpBt+cM5IQYUCE4MeHNcDxb2tCzpp9blzW5SWU+5bjiVaJAY2HDiva1pwBjJ3QBxXqzDHDBxhOjHaUHNRFUEWs1wMiXRttW7AdCL4FrUObc8g5bvTEJhbvdh8ngtmVrxozQa9U9oLUrUGu0SZkZeOySkae6I3yIrYTHse5h+oZQbBYaT5R58yOS6i65Ct1KjxJKgVY06cc5u5MNAJaOOeBBH8F3DcOPk43eIXIMOcl2exBqppLsdXRpBf1Yv6i6qVGama9GiR52DFgQQyI5xJ5hueG8cLaWAIrIEJkZ+YjWND3drscT9q+whgDA4dadGN4lBrbtEbKlb1/qdNmp/UWoUqFR4vTScKXgwnAPBBDvKb1ELJklY19SlgttZ98R3T8NkOBDnejh73Rtbu8Ru4yeHUsjBgAwqG46+HYg1j2f9ku4tAK3VqhRtS5+clLgqQqFRlYkCEGxHbzieIbn94r5av7Idd1c1QtnU2samT0tOWjGdFpcCHBhFkPLw/iS3PNoW0AhgE4JwepDCDhh3HHFB01rU6r0ykwpOu1M1CbYMOjuABd2ZAACxvtDaK1XXK141l+F01SqXOMLJkQIbHF+cj94HqJWYejHHinRjGMoMMaD6L3Zovb0haT78nKzSKeHNhQ5iDDa4Auz+60L02sWi9l632nGtW8JYOY49JAmIf8ASS8QAgPac8xkrIPRt3t7jnkghAEnPHtQYYtXT7WOz6BDs+TvSBUqfBZ0MOpTZDZqFD6t1rW7pIHDj2L0GkejNA0pgVKYlJh9Qq1Zj901CpR2jpo8TGBnHAADhgY5LI+43OSE3OwoML6s7Ntv6h3TTtRaDUpm3LvpTg+DVJRrS94H7jw7LSDw6upcrg031Q1Ct6LZV43PBp1Mjs6Gaj0878aah9bXbzcDPM4wszOh7wLSeYwoITQA3jw5IPEyenkO1rElrJsCMKLBlYfRw3w2jIBzknOeJJJWFtBNkev6D3LVa5Q9SahNwK3NGZnpWLBhBj3n97IbnkMLaDowSCTnHHCu7xyg1e1z2R7i1svqh3vO6oz9Li284OkYUCBCc0HJOfKbnPErI186X3td+msawo18zECLOS/csachwoZeW9uC3GeAWWjCYeBHDnhUsaRg8kGBNnHZyrWz7RxbspfM3VaY+N0zoUeHDac/1Qs8EEYdvDexgrl0YwADgBAzgN45I60GPNXrBujUOgzlu0O7o9Egz8uYEaJBYxzhk++AcCOXBY42cNmS49niVfRaZqLOVGkRZ0zcaWmIMNocS3GMtbnHXzWxQhgZ48+aFgPMoPP3vZdv6gW1PWnc8jDnKdUIXRxIbx5wcjrBBAWMLW0h1DsSgNsG3L8jRKHuGBAmZgN7pkoZ/dYN0h3X77tWb2Q93mc/SqWAnOOKDxGlulFu6VUSLTaMXxpmbimYnZ2KP2s1GIAL3efAH2Lw+0Vsx0jaFFEdVLqqtFdRpoTLTIuGYmARukE4xxWb9wHmfMp0flZ3jywg663qPBt+jSlHloz4kKTgiC1z/fOx1nzrsmHI7E3eOcqgY4ICIiCqIqgiIiCqIqgiIiCriVUIyg1YnLnolr7bNZj1+qwJODEtyR3HxjgE7sXICzk/V3TPAzetLwf/AO7yX5L00E0n1CrXhDeFowKhUejbC6d0WIx24OQ8lw7V0X8k3QInjYME45fzuP8AnRaxxpnp1olphqtcOrMprI+dm7gjRY0SSmIjehhF5cSG448N7+CzhD1e0yeOF60zOBw6VeWbsm6BMB/3AwTntmo/51HbJmgLv/3Agf8Am5j86FY90Cq9Nru1RrBUaROwZuXiUyitbGhOy046bgtoF4uwNHNOtL487M2NbcGlxaiGNmXMiPeYgbndBLnHlkr2iI/BXKpAo1OiVCYhPiMh82sGSV4hutVulu62l1LezjhDb+KyI+GyIN2I0Ob1gjIK+Pe6SxjuWD6sfgg8J46beHA0yo5/7Mfinjqt34sqHqx+K92KfJYx3JB9WFe98l8EgerCDwfjqt34sqHqx+KeOq3fi2oerb+K953vkvgcD1YTuCS+CQPVhB4Px1W78WVD1Y/FPHVbvxZUPVj8V7zvfJfBIHqwne+S+CQPVhB4Px1W78WVD1Y/FPHVbvxbUPVt/Fe873yXwOB6sJ3BJfBIHqwg8H46rd+LKh6sfinjqt34sqHqx+K953vkvgkD1YTvfJfBIHqwg8H46rd+LKh6sfinjqt34tqHq2/ived75L4HA9WE7gkvgkD1YQeD8dVu/FlQ9WPxTx1W78WVD1Y/Fe873yXwSB6sJ3vkvgkD1YQeD8dVu/FlQ9WPxTx1W78W1D1bfxXvO98l8DgerCdwSXwSB6sIPB+Oq3fiyoerH4p46rd+LKh6sfived75L4JA9WE73yXwSB6sIPB+Oq3fiyoerH4p46rd+Lah6tv4r3ne+S+BwPVhO4JL4JA9WEHg/HVbvxZUPVj8U8dVu/FlQ9WPxXvO98l8EgerCd75L4JA9WEHg/HVbvxZUPVj8U8dVu/FtQ9W38V7zvfJfA4HqwncEl8EgerCDwfjqt34sqHqx+KeOq3fiyoerH4r3ne+S+CQPVhO98l8EgerCDwfjqt34sqHqx+KeOq3fi2oerb+K953vkvgcD1YTuCS+CQPVhB4Px1W78WVD1Y/FPHVbvxZUPVj8V7zvfJfBIHqwne+S+CQPVhB4Px1W78WVD1Y/FPHVbx4Cm1DP/Zt/Fe873yXwOB6sJ3BJfBIHqx+CDwXjloDQ4upVRy3jwhj8V+yDW6VqfbtSosODOykKal3Qnvc0BzQ4buRg8xlev73SXVLQQOzoxxX0hSkCAT0MJjARya0BBhbZv2aaLs706pSFMueqVo1CKXmJPO4tHDgMHzLNrc7ozjPmUDAFyAwMBAREQVcXcj9CqEZGEGtG13UafTK9phO1CbhwIEKsxi57zgDyYayHfFxaDakW9HtW9q1RanTJwNMWWixiA7ByOIwRxXqr70usbUuSl6fe9ChVSBKvMSCyI5zdxxxkgtIPUF4z+SboDwBsCBw/wCtzH50ar62BWdANMrfh2nYlZo1Jpku4uZLQ4xIDjzOTknkOtelGrumYGDelM9avK/yTdAskmwYPHq7rmPzp/JN0DznwCg+Yd1x+H/rRKxnr5edrXLqtpVL0Cuyk9EhT82XiE/JYCIeM/ThbStaM7xJBAwVjWgbNOils1mXuCjWRLwKhKEmDHMeK8sJ5kBzyFkwQyBjfOENcBgcQOHavGVzVWhUGpOpszJzz4rf3obAW/2r24aA3C+L5GUiHeiS0Jx7XMBKI8H46rd+LKh6sfinjqt34sqHqx+K953vkvgkD1YTvfJfBIHqwg8H46rd+LKh6sfinjqt34tqHq2/ived75L4HA9WE7gkvgkD1YQeD8dVu/FlQ9WPxTx1W78WVD1Y/Fe873yXwSB6sJ3vkvgkD1YQeD8dVu/FlQ9WPxTx1W78W1D1bfxXvO98l8DgerCdwSXwSB6sIPB+Oq3fiyoerH4p46rd+LKh6sfived75L4JA9WE73yXwSB6sIPB+Oq3fiyoerH4p46rd+Lah6tv4r3ne+S+BwPVhO4JL4JA9WEHg/HVbvxZUPVj8U8dVu/FlQ9WPxXvO98l8EgerCd75L4JA9WEHg/HVbvxZUPVj8U8dVu/FtQ9W38V7zvfJfA4HqwncEl8EgerCDwfjqt34sqHqx+KeOq3fiyoerH4r3ne+S+CQPVhO98l8EgerCDwfjqt34sqHqx+KeOq3fi2oerb+K953vkvgcD1YTuCS+CQPVhB4Px1W78WVD1Y/FPHVbvxZUPVj8V7zvfJfBIHqwne+S+CQPVhB4Px1W78WVD1Y/FPHVbvxbUPVt/Fe873yXwOB6sJ3BJfBIHqwg8H46rd+LKh6sfinjqt34sqHqx+K953vkvgkD1YTvfJfBIHqwg8H46rd+LKh6sfinjqt34tqHq2/ived75L4HA9WE7gkvgkD1YQeD8dVu/FlQ9WPxTx1W78WVD1Y/Fe873yXwSB6sJ3vkvgkD1YQeD8dVu/FlQ9WPxTx1W78W1D1bfxXvO98l8DgerCdwSXwSB6sIPB+Oq3fiyoerH4p46rd+LKh6sfived75L4JA9WE73yXwSB6sIPB+Oq3fiyoerH4p46rd+Lah6tv4r3ne+S+BwPVhO4JL4JA9WEHg/HVbvxZUPVj8U8dVu/FlQ9WPxXvO98l8EgerCd75L4JA9WEHiaZq3QKnPskYEjPsfFOAXQwGj+K9zCO9zPEcVwEhJtO82VgtI5EQxlfZrN3GDy/igqIiCqIqgiKqICIiAij844Lg3OCCOvKD6ZHamQumn7modOmoctUavKy0WKd2G18QAuPmXYy8RkbESFEDm9oIIPnRY/QiqiIL4dFCYSYUNoPPgMfavuvyzk3L06WjTk3FbBl4LHRIsR3JrQMkoPuwtyMOHnXPPnXm7Hvm2NRKEbhtGqQqhTu6Y0r08M8DEhPLXj6iCvQYAJLncP7MIPpkdqZX5oc1Cjbz4EVjwwkO3XAr6tySCXHkg+iKr4TMxBgNDo0RrBn3znYAQfZMhfjbUJKI525PQX7vHDYjSf7V+lvFoPaMoOaKqIGR2pkLg4EuyDjH8V468tXtONPnOh3ldkjSXMG9iYeRkfUEHtMpnzr80lNQJ2VhTktFESFMQ2xYbweDmuGQfsKQpiDGiuYyKx7mHyt1wOEH6cjtRfP3vDsPDzr6DkgIqogZHamVwdzJaDntX54k1KyxDZqbhwy7kYjgMoP15RfmhRocw0ul4zInX5LgQfsX3ZnHlc0HJERARVRAREQEVUQEREBFVEBERARVRAREQEVUQMjtTIWPr2110i05q4oV7X7TaRUCwRe55hzt/cdyOADwK8/wDyr9nLHHViiYzw8qJ+VFjMOUz51iH+Vfs5tODq3RRw5b0T8q4/ysdnMkf77FEPHgd6J+VCMwZHai8ZYWr+mup8achWDeMhW308NM02WcSYO9ndzkDng/YvZogiqiAiIgIqogIiICKqICIiAiqiAiIgIqogIiICKqICIiAiqiAiIgIqogIiICKqICIvnMRGQmbz3hgH7xOAEH0Rfkgz0pGfiBNQIjnHGGvB/sX6AS7OQQeXFBzRcWBzeGeAXJARVQ8igZHamV5S+dTbC00k4FQv26JOiy8w8sgxJlxAiOGMgYB7QvGfytNnPA/32aIPpdE/Kgy9lM+dYh/lZ7OfztUT0on5VxG1ls6Bwb426Jl3+dE/KixmDI7UysXUHaU0NuirS9Ct/Uykz0/MuLYUvCc/eeR2Zasmtycc+H8UR9ERvLiiAiIgIqogIiICKqICIiAiqiAiIgIqogIiICKqICIiAiqiAiIgIqogIiICKqICIiAiqiAiIgIqogIiICKqIKoiqCIiIBxjivF6qVe46HaMaNZ8g6Yqs3GhScEt49D0rgwxf6m9vfUvZvxjicL5Hdc3LsY3uvig09vv3PajXvRpysVrUe4pm7o0N8wZ0RGhpmMEhoAAG5vcOWcLofc6tTb7i1O9NE74n5mpRrNnDAgTMY5ON97SCewbgwtxryuaStG2KncM9GZChyUtEijfON5zWkho85IwsC7GOlE3a1NufVOtwOhqV+1ONUBCI97LOiOfB+stejTZtRFUZRY815r0K19Hbwq7ophuh0iaEM9fSGE7dx9ayGtf9tWrukNIIVKhxd2NW65T6Xuj95kaLuO+rjxQek2XrcNuaJ23AdDY18/AbUnbnDLo4EQk+fLuKyNcdMjVaiT9Kkpt8pGmpd8JkdnOEXAgOGesZyvhZ1Nh0a0aLSMNDZKny0uAO1kNrf8AYul1clbnmrGqkS1a/Go1Rl5d8eFMwt04LWkgHIPD6kGOdlrQG7NC4N0QbqvyNcXfyf7rl2xHbwl2lzyQOA4neGerhwWYXXZQm3HBtXvhCNTiwnx2y4d5W43GSR9YWqWwDqNqdqbb1+Pv28Jqs1KQqbpOXmI+7+z3XxW8N0Dh5I6upYa0ktnUi6tsm8qPD1WrUpPysCIRPw+jL9wjIhgOaW4AwOWcBFj+lnStzgnC8xqJZ1u3rbM5TLkpwm4HRuIYYjm4IBwctIKliW9cFrURtOuO6Zy4ZzeJM5NhgecngPIAHD6Opd3V896Zsu4HonZ+xEaC+5w2Nbt01XU6qXFKRZ+Zt+5BLU50aZiu6CHvRfJA3sfut555Le6sXVQLbiSUpVJ+FLxJ2MyVlYbneVEiO4NaAtMfcxP6bWf/AObB/ejrxe1DT78ndtTT63YV/wBQl4c9FD5IQy3dkSIkMZYC3BJJzxyjU5f0a6UYB3TyR0ZjBvRHBue0rwOnFlXjaTpl90akVS5xG/o2zrYY6PAxw3GNWNLQ011wvC4rhqurd+zNPpb4z4dKpNO3ehZD47sVxe3e3xgdePKKMthyWxfKbEw3zcQVoh7qXbVFlbAoVzwJBrKo+rwIDplrnbxhkPyMZx1DqXo9ijVbUGsai35pndVzzdekqJOuEnMTe70kJgz5PkgDHH+C/B7qhk6R0ABuf8Ny5PZyiIs+239kND7HoW6CwupcrxPP+iasLbO2zreej15XVc1yaiTNeg1yZdGgy735bDB5F3kjBHIY6lk+XpNarullIp9BrcSkz0WkyzYU1CALmfsW8RkH+xaybCOqmqd93xqDRtR7yma6aJPmWljFDd1jQByw0fxQjdAbmMmLjhnP+1coceHEzuPa7d4HBysFXVZ+vF7aww2eF3g/p/JM8qDI/wBNPHgS1+80jHEjgRyCwlSr3v3TLbUktJpa9qjVbYr7Q50nN7m5Bdloy3dAOefM9aGN5C/GMAlTpRk73ADrysN7UMS/aRpNXbqsK7I1EnqLJPmQYYaRFI5A5ae1YD2b5bX3aJ0QgVGs62VSlR3ve187JCGY8bynDD9+GWgcOodQQjd3pQ7eMNwdwzzyFr3tMbKUfaHrdEnomotYoMnTGdHFlpFzWiJlxO/xB8rjjnjCwjs4aja06Y7UFa2fNT7wnbopjm/4Pm5jdyCdziN0N4cT1c1sLtWa1XLorYkpN2dQXVm4K9Oim0yXHvemLC4E4I4YaUIx9dFkDZGsyVvWhanViZkKS9pmaXPOhls83OMct7e4jkRyW09GnxVKXK1JuN2agsijH+cMr+flpbKu0ptB3LIXXtK3nHlaBLRmzUKi5w9o/wAnG7gjj1nK/oNS5SFT5GDIwARCl4bYbAeoAYCG4/UiIiKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqDVeetmgXTtr1qSuGkwZ+Cy3JFzYcZuWg7sXiPsWSNSqDoXpTZ09e12WnS4NPpzcuxD4ucfetHHmTwHnK8ZTTjbfroPybkf7sZZi1M00tXVa2Yto3lTWT9KjxoUaJAcThzobt5p4EdYRppw7aj0qk5SXumsbMFZkrPmorGMrEWXhiG1ryAHnET3vEHktrLXsHRm8bfkLnoNqUmZkKhAZMQIjGZDmOaCOvsKwPti6lWBYWm8LZ7tWhQqpcNXgQpCnUqXYHGBDIDGPdx6gQRx6lnDZpsar6daK21ateyJ+Vk4ZjsPOG8sblp+gjCDGegFFptB2otXqXSJKFKScKm0ZzIMIYa0kRskLZ9a36Mf8q/WL/VlF/sjLZBE1VEVREREQVRFUEREQVRFUEREQVRFUEREQVRFUEREQVRFUEREQVRFUEREQVRFUEREQVRFUEWPddtL5rV/TyoWTKXNO0OJOgDuqUIDx5QOMkHsWQl0d73DDtO1anccSC6K2nS0SY6No98WtJAQax6e7FEnoxbk5UqVrHdEGqwYT5gzcWJDcAWjOPKaRu8Mcs4JWYdnfUyLqhp9Dqs1PMnZ2RjukJmahnLI0VgBc9vmO92LS5o2zttBrapLTzrFsGrAPgt4hkxLu6wcOOcLd/QTRqi6F6c06wKJMxJpko3MeYi4340XABecdZwEGR2HIzniuS4MAzjsXNBVOfBFUGtO13TJKp3BpjT6hLsjy0asxw+G8ZDhuw+azANHNL2jHgPTPVn8Virat/42aWf66j/3Ya2HiEtBxn6kGMZC1tAqpXZu15GjUKNVZFofMSjWnpIbTnBI+o/YujpJ2bq9fU5pzR6RRJqu09nSTMvDYSYY48/RK0y267srugm0hJagadXBDlKjcVOFNmpXfOG7zHNEVw+mISPoW2Ox1ohSdOdP5e85ydFYuS7ITalUao85fEMQb+6Dw8kEnHDrRrx5zXax7RtbVbSqYtygykhEjz80HugtxvACHzW1OCDnAWue0vx1T0l8nlPzf92Gtjv3UTRoAHBVByVREREQVRFUEREQVRFUEREQVRFUEREQVRFUEREQVRFUEREQVRFUEREQVRFUEREQVRFUEREQVRFUEREQVRFUEREQVRFUERVRAREQcYmd3gvjMzECVl3zUzFEKHCYXve84DQBkkr9B5Ly2oNjQdQrXm7UnKpO0+WnmmHGiSpAeWnmOIPAgkINe61qdp9rrfjqbVr1kpWzLamQXwHRcCoTkJ2ePmY9oPVz61nqh6m6aVCPAo9EuymRopaGQpeE/jgcgBha1f8Asv8AQ1uWw6vXBvOLiQ9o4n6l6zTLYH0p0svCRvOh1asxp2Rz0bY72lnHtwEVs4iqiILWHakbFufVbS2wocw7cj1A1aIwcR/NYsN4z9q2eyFrPNuNy7cEkwM32WnQIoJ5taZqC0j+4g2RaGgENOOAXU3q1ptGsb/LuKKT6BXcNYACA08eJIXQXvace86HFoMOvT9IhzI3YsaT3d8s62+UCMHKDT33Mc/4O1L3SDi4ouMHq6aMuk2fJ2XhbfF8y8eK1jnycRzN44JwzjhbE6QbJdt6JVObqFkXnXpdlRmhNT0uei6OZfvE+V5Of3jyxzX4r22MLCuzVRur9NuGs29XXMEOM6nGGGxmgAEO3geeEaZ+gTEKM5xhRWRGjgS054r8tZc0UyaiPdugwnZB+hfmtm1qdaVMh0qlQ3CG3i9zjkvd1uPnJ4r8V82fNXlR30eXuWp0YROD4sjub5b1jygRhExp17mJEBj60N4A+FYI48xvR+K6raemYUpt5aQxZmKIUMvxl3AZ6WEtgNKtkC29G6pOVSxb4uKRNTmRNz8Nphbk0/J9/wCTnjk8sc12Ou+ylY+vNSo1dr09P0ys0IfzOpSO70zOIP7wI5gdXUisr1y4ZChUacrUeIHwJKC6PEDCCd0DPJayaCam3VtRTdw3RNX5MW7SqXPukYVJpzmftGAuG9F6QE5O5+6etZ+sfS+k2XTDTzNTVVjRobYcxNzhBixwBgb2MDlw4BYjoOw7YNpX7NXtaVz1yjwp6I+JNUqWcwSsYuOSXAgu7eR6yhwwRsItg0raD1NknTzXMbNPAiRXgF2BzXp/dT4rXaQ2+1xA3q3LkOz5oiytT9h7SikamRdSaTHqEoZgYmKXDcBKxjwyXfvccdvWV3OsuypbOuDIcjdt01ttJgOY+XpkLozAguYMAty3e7eZ60GUbIiMbZFAc5waO9krj1TVpR7no6EdVdWeiLT/AIZeefH3q22oGlVUt2032pKajXA9gDGy82/oumlmNbuhjPJxj6QeSx/pvse21pXdE3dto3xcUrOT8UxZ3HRYmiTk7/k9fmRM44eNga9XDrJtD1vRO3bliWpIW1CMSNOSxaJqadhhw0PBbu+X2A8FhyrUiHa/uglpyMevx6k5zQXTU05u+Xbzee7gLZLUTYvsC/L/AGanSVcq9uXCXNdMTlMLGvmcADy94EcgOXYvzXtsO6ZXpc1AvCJUqpI1qhlrnTsBzekmyDziEg+bljkivcbTMVkTZ+vl8GI17TSIvlMdnsWKPc44jP5PUgGuHCO8OHZ5b1mC8NDaXdNkjT6WuKqUejvlzLTEGTLCI7Ccne3weZ7F0ukOzVTNFpCLR7QvSvQ6dFcX9yv6Lo2v/wAoeTnKHDWuceHe6SwWkjd6AYP1sW02v8bT2RtaTrGod1y9uS1NnWzEpPxv+bjhpAI4HjgnqXjnbG9uP1HOq/h7cQuYv3u7v2W+PN73HUF7vU/QWztYrJlrJ1CEerQJZ4ismIxHS9IMjf4YGcEhB7W2a1R6/QZKr0Spwp+RmYIdBmYfvYreW8PsXbMBDRnn1robNs+j2HatOtC2pQStNpUHoZaC391uScfaSV3zc4wUZVERARVRAREQEVUQEREBFVEBERARVRAREQEVUQa208g7cFcB+TUh/dirY548nGcfQtSrq1JsnTTbPq9YvmvQ6TJR7dkocOPFhRHNc4Ni5HktPaFlJ21/s2nlqrTv/LzHs0aYb0UteyK9tcX1eFTvygXHWYLRKykhDEV0zTwwxA9rg5oZy4cCeS3HaMDBGFqbZN77E9g37V9SLe1DpsGs1qJEizcXueY8pzySf+b/AM4rJ7dsDZtx/wC9anZA4/zeY9mg8toyR/Ky1hA+K6L/AGRlsgtVdmq8Ldv3aU1buq0ak2o0mYp1HhwppkN7WPc3pt4DeAPDK2qRNcX55gkfQoC4jiSCvxV6oTVLpsWek6RM1OND97LS5bvv+jeIC8CNVrxDf/cfd+c499Le0RGTgeHNMhYxGrF4/Mbd5/ry3tFfGxePzG3f6Ut7RBk3KZ86xl42Lx+Y27/TlvaJ42Lx+Y27/TlvaIMm5HamQsZeNi8fmNu/05b2ieNi8fmNu/0pb2iDJuUz51jLxsXj8xt3+nLe0TxsXj8xt3+nLe0QZNyO1MhYy8bF4/Mbd/py3tE8bF4/Mbd/pS3tEGTcpnzrGXjYvH5jbv8ATlvaJ42Lx+Y27/TlvaIMm5HamQsZeNi8fmNu/wBOW9onjYvH5jbv9KW9ogyblM+dYy8bF4/Mbd/py3tE8bF4/Mbd/py3tEGTcjtTIWMvGxePzG3f6ct7RPGxePzG3f6Ut7RBk3KZ86xl42Lx+Y27/TlvaJ42Lx+Y27/TlvaIMm5HamQsZeNi8fmNu/05b2ieNi8fmNu/0pb2iDJuUz51jLxsXj8xt3+nLe0TxsXj8xt3+nLe0QZNyO1MhYy8bF4/Mbd/py3tE8bF4/Mbd/pS3tEGTcpnzrGXjYvH5jbv9OW9onjYvH5jbv8ATlvaIMm5HamQsZeNi8fmNu/05b2ieNi8fmNu/wBKW9ogyblDy5rGXjYvH5jbv9OW9onjYvH5jbv9OW9ogyUN7B8riutuNslFoM/DqsZkKSfKxWzER/JsMtO876gvDeNS8XEg6IXdjGffy3P1i7ej1Gb1FpU9SrqsGrUWUmILoL4NQdDPSNcMHG448eKDzmztcemU7YstbOmd7StyU2hNEnDiQM/s2NAAactCyyAC0cOCxlovs+adaDSc/J2FSe5hUIpiRXHng4w0eYYWTWAhoBQUADkEREBFVEGuW1aT4WaWcf8ApqP/AHYayhrhqlStHNN6vftVILJCCeiYeT4rhhgP0uwsQ7ZVcpVt1bTWu1qaEtISVYjvmI5Y5zYbd2HxO6CV2GoOvuyLqhbMa07y1DpM/S5l7IkSDEl5nDixwcOTO0BD+tTdINmS5NsOh3frlqvEjw5ytiK235d3/MObvOaBn9zymgdfBbk7INsak2No7I2hqdAdCqVKmYspADuO9Ks3RDcPMQCvjbW09sqWjRJS3bf1HpUnT5CE2DAgw5aYDWNAwAP2fYF2H8sHZsH/APFWnc/g8x7NFrzW0tkap6TB2Ae75v8AshrY7qWnWqetWmOquremUrp/dkCtxZGdmXzDYEGKOiaQzBO80c8FbiEgNBJQ1DvAhwdgdib5BHAkI4E+UOJC8HcOoVz0iqvkZHSe5arCh+9mpV0AQ3fRvPB/giPf5HamQsZeNi8fmNu/05b2ieNi8fmNu/0pb2iDJuUz51jLxsXj8xt3+nLe0TxsXj8xt3+nLe0QZNyO1MhYy8bF4/Mbd/py3tE8bF4/Mbd/pS3tEGTcpnzrGXjYvH5jbv8ATlvaJ42Lx+Y27/TlvaIMm5HamQsZeNi8fmNu/wBOW9onjYvH5jbv9KW9ogyblM+dYy8bF4/Mbd/py3tE8bF4/Mbd/py3tEGTcjtTIWMvGxePzG3f6ct7RPGxePzG3f6Ut7RBk3KZ86xl42Lx+Y27/TlvaJ42Lx+Y27/TlvaIMm5HamQsZeNi8fmNu/05b2ieNi8fmNu/0pb2iDJuUz51jLxsXj8xt3+nLe0TxsXj8xt3+nLe0QZNyO1MhYy8bF4/Mbd/py3tE8bF4/Mbd/pS3tEGTcpnzrGXjYvH5jbv9OW9onjYvH5jbv8ATlvaIMm5HamQsZeNi8fmNu/05b2ieNi8fmNu/wBKW9ogyblM+dYy8bF4/Mbd/py3tE8bF4/Mbd/py3tEGTcjtTIWMvGxePzG3f6ct7RPGxePzG3f6Ut7RBk3KZ86xl42Lx+Y27/TlvaJ42Lx+Y27/TlvaIMm5HamQsZeNi8fmNu/05b2ieNi8fmNu/0pb2iDJuUz51jLxsXj8xt3+nLe0TxsXj8xt3+nLe0QZNyO1MhYy8bF4/Mbd/py3tE8bF4/Mbd/pS3tEGSi5wceBOezqVYereysd03Ui656oQpWNo9dEkyMcOmIzpfchjtOHkrIMJrg7DgcAZBQfVERARVRBVEVQRERBVEOermuIL84OEHJFxLnBxGMjs60BO9g8upBzURVBxPNYI0fsW7JPWrUTUS6qNHkYVXEnLSDopaekhwWvZvDBPDBH2rPBGV890jyc9eeCCs99kk8epc1waWufkN5ZGV9EERcDEIcQWnGcZVy7OARhBzUXDpOB4YI4cVyacjKCoiIKoiqCIiIKoiqCIiIKoiqCIuOXEnkpvOwcY4IPoouAe49WPMuTHFw4hBUREFURVBERDwHBBVEHnUJOcBBUXEu4LkOSCqIqgiIiCqIqgiIiCqIqg6KqWha9cmTO1ehyk5HADekiw8uwOpfhZprYLc71qU/yjnjCXpiCCQ4fWqMYHHIxwQea8Wun/yUp3qVxOmmn7Xb/gpTh2nol6jh2Lg7eznAwEI6yjWxb9uviOodHlpIx8dIYLN3eA5ZXcL5Eczu9i+qCqIqgiIiCqIqgiIiCqIqgiIiCqIqgiIiCqIqgiIiCqIqgiIiCqIqgiIiCqIqgiIiCqIqgiIo57W4B6+SDkooXY6uKoJIyRhAREQVQ9fHCIc4OOxB1dXt6jV2C2DWabAnYcNxc1sZm8GnrIXVjTSwRxNqU7zfsV6Rm8MB2eIwR1BXI3i0DgAg814tdP8A5KU71K5DTSwMf8VKb6oL0nDsUG8ffYA8yLHQStgWbTZhk7TrakYEeGctiMhAELvXcRhwzj+1cgTjGR9a4nBbgEjBRH0acjOMKo0YHFVBEREFURVBEREFURVBEREFURVBEREFURVBEREFURVBEREFURVBEREFURVBEREFURVBEREFURVBEREFURVBEREFURVBEVUQEREA5xwOFwfEENuXdQ4qxM7vA4XWXFIz1Uo83ISE4ZSLNQHwRGHvoW80jeHnGchB5G7Nf9HrGqDabdl+U6nTLy1ohvLncScAEtBAXr6HcFDumQh1e36nLz8pFGWRYT95pWFbg2RdDp6yJ+nV+0JCdnHykSLHqcdpMZ8fcJ6Yn/K3vKzjmsQ+5r0W7Ldp1+UeajzEW15KsxpajuiHySWRntiFv04aixu4iqiIL8FVqEGj02cqs2/dhSkJ0eIR1NaMn+C/esa7Q9wMtrRi7qoXbsU0qZgwQf3ojoTg0fag7jSnUilaqWt4WUWXjwZR03MSjWxiCSYTywuGOo4yF7JYt2brc8GNGbXk3Aw3zUjCnojW/wCXGY17v4uKyPPT0vT5WLOzkzDgQYLS6JEecNaBxJJQfoeQ3yieCxbq1tI6R6LZbfl0MkZno99kB0KId/IyAHBpbnl1r0Wn+p9qal0yPWbVqcGakoM1FlOnDuDokJ5Y8DPYQVrH7qfJSjtmWJNulmGM2tyLWvI4tBL88ewosbeUGsSlfosjW5M78tUJeFNQj2se0Ob/AAIXYMyHOzwHUvC6W1GQkNK7NM7OS0sO8UhjpYrWZ/m7O0r2sKNBmoYiQYjIjHcQ5rsg/WEI/RkdqZX548zLyjQ+Yjw4QOAC9waPtK+UCpyEzlsrOQIzhxPRRA7H2FEftyO1M+dfiiVKnwXOZHnpeG49T4rWn+JVdNwBL90GYYIfMP3gB9vJB+zI7UX5IM5JzXGWmoUThgmG8OIP1L7ZIwx7s57UH1yO1F1szW6PJx+hmqrJQYo/ciR2tdj6CV9hOS75czjJqEYOMl++C0D6eSD9mR2pkdq8VZeqVoX9N1iXt2rQpltDmmykxEY/yTELd7AXrHx4LIfTxIjGBvHec4Afai7kfpymR2r80KZgzDWR4MZkWG/3r4bg5p+scFxhTklGjGBCmYTojObWxAXAecIj7uDiSMhoPH6lj/VTXHTjRmQE7ftwMpjIzDEhb0KI7eAOObWkDkea95FiQ4GXx4zGMxkue7AA+la3bdtRt2qbMF8iDUJGZiwac50PcjMe9rt5vEYOUMZxsC+6LqXZlJvm24xi02rwjHln/wCW0OLc/a0r0zMAcysE7EHkbKWm7A7OKU7if+3iLNceoyMphk5OwIT8bw34gacdvFDe37UyvywJyBMs6SXmIcVjeO8x4cD9YR85Kwy2CZmEx7+DWGIAfsQfqzhF1kat0iDGEtHq0pDidUN0docT2YzlfsiRWshCO+I0Mb5TnZ4AdqD75TgvE2fqvZl9VWsUu26xCmXUSZMpNvY/yWxgASzznDgeHBewL2nJDwBjOc/xQfYnC6e4rot+05R1UuSry9OlWjBix37rVzFfonS9zCtyPTE43e6Wb2foyvB67aDWXtC2vAte8I02yVgRunhRZZwa9ruGcEg9SD1VtakWJd7DEtu6adPtDt3EKMM730HivTgjqK1Xruzjs66EWLPVulsl7eqdMgOiwas2KGze+3i0decnhy6ysrbNuo07qro1bN7VOC5k9UJGHFmCf3nnmR5kXcZSRRoxwyqiCIiAiqiAiIgIqogw9qZtO6caW3b4GXBHmYlT6BkwYEGG55DH5weAPYV5j+WxpU04fK1VuOQ7kicvRX45GFCibb9dbFhtePBuRPlAH92Ksna36nW1onp1Ur/rsg2LAkg2GyGyGC6JFed1jRw63YCLGP8A+W1pR8Fqv/lYn5Vxdts6Vc2y9V4cx3LE4f8ApWIJzas2j6DastqnXdBJaDZUYw4pc1jO6Gy0Qjdif0mPenPLqW3WnV227qRZdLvSiSsPuSpy7I7GuYCW7zQd08OYyi7jzekm0FYmtU9VqbaEeOZiithPmoUVha5oiZ3eBA/ySsorW3RVjIe1drE2GxrQKZReAGByjLZJE3IIqoiCIiAiqiAiIgIqogIiICKqICIiAiqiAiIgIqogIiICKqICIiAiqiAiIgIqogL8FbrdJt6QiVWt1CDJykEZiRort1rQv3rw+smktt602TN2JdT47JGcxvvgOAe3DgeBP0IP125qrpzdz3Mtu8abPPacFrIwB+w4XrGuDmh28DnrC1eldkPZz0dtOan4NPlpSoSUu+LCrEzFDZpjmtyC08Bnh2L3GylqZH1T0rh1aNPRZ/vdNxKdDno3v5tkNrSIrj1k73YEXcZqRcGh2QCQcBc0QQ5wqogx9q5rRZ2jFNkaleEd8OHUYroMAQ2lxc5uCQAAe0LHDdtnSkc5Sqj/AMJE/KvltYNa66tLA9oINaj8COfkw1sG+SlCMdyQe33gQxgP+W1pT8Fqv/lYn5VBts6VE/8ABatj/usT8qyHStXNL6vfVS04lKnJCv0qEI8zJuh7rmwzveVxGCPJdyPUugsnXywNQNT6tpvaUi+ovojMzk/DY3ueG/ygYfEZJBaRwRp1VsbYGlt2XNJWnJCdhTk+4tg9NBcwOI+loWdDgNDjxWuO0lChQNUtJuggMhh8/Nk7rQP3Ya2RwN0ImqEQIiCIiAiqiAiIgIqogIiICKqICIiAiqiAiIgIqogIiICKqICIiAiqiAiIgIqogIiICKqICIiAiqiAiIgIqogqiKoIiIgj87vBufMuB4Dda3OeGFzdnHk814LWnVil6K2LHvutU2bnZWWmIEvEZLNy9oiPDS/lybnJ8wQeN2p5TW2e06mpHReHIRZ6Mx7JmHFa7pIkHGHNYQQBkZBz2rD2xDtLS9Xm3aBXtacG17rpAiHoIbNxkzug77sZJ3vJyTnBzwW0lnah2hfNuyVz0SvScaUm4DYrHGO0EZGcEHiCPOtP5uzIF/e6ES90WPLs7golKb3zqcuP2RiGGcM3usktIOEa8b3KIqjKLXbbXqnR6ZU2gQ/+EVu46ZIthk++hxI24/8AgVsStYtpGH4Xa56V6fs3XtfGj1eJDPUZV8J7T/FBsNbNObSLbpdL962SkoMADsDGBv8AsWOtqWhGtaEXpiqzkkJWjTUz/NnhpeWQnENdkHgetZXbjeDQ0Hd5rHu0G1z9D7+ZDLi42/PBjWjJz0LuSGNSPc89Hxd+gVMuR18XFT398Zv+bScdrYJLYzuOC0njjjxXsfdQ4Bltlcy3TOiGBWKczefxc4jfGfpXw9zLu+3pTZsgUqbrEtAnJCozhmIL4gbEbvRnlvk8zkdi+3upM1LTOy8+FAnYXSRK3T4gaXeUWkvOcc+RRrreXZVPZbZqpofRJ+t6g3EZ9luysSRhmO3oJd4l2buBu5xy61+L3N3UG7bpsi7rWu6tTNTfaNXNOgR4zt4ubvRR9nkBZ/sGo08aGW/FfUJfchW5Jse8xBhp7mZzPVyWrXuZE/KhurjHzUJpfdBMMGIMvG/H5dqJ3X6Y20VTNR9oGuUW55ycfZ1qjuZlMgQ3PhzUwQD0kUAHJaWuA5cHFdbed+xLR1XtG6NBqfV5WlRJoS1cpMOA9sCLCe9uYmCBxAB6/wB4rxulN1u2T9rm67T1Fc6ToF3R3zkGeiNPRuivOWDPm6Qj6lvjUNV9PZCmwqgyvyEyI5aIEOViCK+I53IANyR9aGtXvdBbMuiHprJ6xWLMTcnN00wn1GXl3bvSwHNLnOf/AKIAH1rMVA1Gs+6Nl6DekrAhzFM7y+XBHEvjMZh4HnLg5ZPu+1qVqJZNRtiqQWvka3JugRWvH7r29f1FaB7J0O/Je+KrssVqSjQaVbtc77CM3+jbKMc53QEf54iA/UhjcvZ101dYVhyrp2aiTdRqBdNxY0bi7ce4uY36muA+pey1KrlVtixK7cNGlTNT1PkokeXgAZ6R4HAL0UpAZLwGQYY3WQ2hrR2AcAvPalXZCsWxq5d8eXdHh0iSiTToTebw0cgh60y2XZ/RfaBok9Mau1WHU9QGTkZs02pxN2LLDfduNh5AGA3d7VsBJaWT1u6EVWx5m5qg5kKFHMObgxR0hhOc4huSOQBA5dSxHqrsV6MaqU46q6f1ttp3BGlxNw5qTjNbL9M4B29FABJIPYV3GyPeOpF5bO9ws1AiTU5M0yJGkpOcigmJNQ2Oc3e848nA8yHTD3ue+krr3s28p2JfNxUx8vXXQt2Rjta1+N7i7LTk8FsBtn21XKVs73DX6Dflep0zbNLiTDRAjtaJpzeuL5PHn1YWKPcyrpoEhad/0uoViUlpqFcTnmBFiBjsYdyB581njbFDq5ss6hilw3zBj0OP0bWNOXHhyCLvcdRsZOqd2bH1nCcrc7Cm6hT44dPQX4jtd08TygSOf1LCGyFUbqktsXUuzbhu2p1uVpMo5sB09FD3cTCdngAP3ismbAuo1lDZetShTFxSMCfosvFl5qWjR2tiMeY0R2MHieBHJYl2Ta1S6jtz6rTsKcgGBNyruhc47hef2I4B2D1FCMpXtqJX9c9pd+z1blWmKbb9sQO7LhfAeA+Z4t/ZZ5bpbEaeXMLo9szZy0wtHZzu647Wt2HSZyQkjGL5byTG4gYfnOc5yvAW5XRs++6BXVVr2xI0S9YQgyc7GaejOej47w4Diw8+xZ626Lrt6d2Wr0bIVyTmBM013R9BHa8uyR1AlCPvst3XJWVsS2dds+f5vSqDEjv6uUeIB/asP6J61WlqfS6re+s0CdrkepzLhIynQRHwJGXHDcZgHrBPM8yvf6FW03UP3Pyh2TTZphmahbkWXAa8FzXdO93EDkeCxt7n7rjQLPpVT0H1IjwaNXKNOuhyTJz9mHwuHWeHMnrQ7em0Hvy6KNtCVWzbfZV5qwa4zpJAR4bgyQi8ButyBgYaT9JXgtfJG+7Y24tMrIp+plxxqfcoM7EbHmGnoHHpW4bhvLDfOt4hqVZsSvyluU2pS85PTTuUs4RGsbx8pzm5A5dq0y2n6hI/+0M0Njd3S4hMkyHxOkG6078fgT1fWhHabX2y+62dNK1rRbeoFxOuO3oYnhMR5hpL/Ka3HBo/yll7QO4q5rJsmUmqV+uT0CoTlEeZqbgxAIr3gOOckHsC7jbInpF2y7fwdOS4MWlDcAiN8r9qzlx4rx+xJNQH7IdFl4caE+MKPFBYHgu96/mOaEa+e53aVi+bcvCciXpX6Y6WrkRgEjHa1sTDWeU7LTkrZba9vW8NGdn+I60J2fiTEPclpio53piDB3270QkdZBIzjrWE/cwbiodLoN90Sp1eXk55laixzAjRBDf0eGDOD51tbqreNnQ5G36FckpLz1DvObfTo74+OiawQ3PBdnqy0BCMH6daa7Pms+nElW9PqxLOucwocV9UEUNnemDgTvZAySOHLrWbdUbtufTDQ2o3FSpJ89W6ZJMbBgu4l8Rzgzjx6t7P1LUHaK2RaDoNRZrXDQG85q3qhIPhxjT5eMNyO0xGtDITWj/O7eWVtlR73gRdnKRvXV2CZUxaQ2PVmOYSWPJxy4nOcIcNTbO2NNcNomZpl/bQuqEeLSZsidbR2Pdvwgf3AcFuPrW+1l2bRLCtqn2lbkq2WptLl2y8tCaMbrByC8Hs26k2JqRptJTdgT01N02njuIPmf6TeaM+UcDJ4jkssjkiajW4OckqoqiIiIgqiKoIiIgqiKoNbKeP/wBuGuH/APxqQ/uxVnW7LQty9aYaLddIlqnTnRGRXS0w3eYXsOWnHaCMrBdO/wCXBXf/AJakP7sZbHRM4OOaLjTPa71pfFbD2WdJbbdVLgrEGFLRGy4HRU+VdwJdkjk0uxx/dWxWgenMTSnSegWPMRzGmJCUhtmHH/8Am7gDsebIWu2ztNWDPbWmoc9Tas6drbyZaJDew5g9G6KHAEjlz61uUBhpycorXPRj/lYaxf6sov8AZGWyC1v0Y/5V+sX+rKL/AGRlsgiaqiKoiIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCLz2oFcnLbs+rVynyjpmak5SLGgwm83ODSQvQrqrqnqbTreqE5V3FslClopj4Gf2e6d7+GUH877Q2cdo3bDk5DUPWDUuJTrUqgbOy9Fa52RBdxAZzAH09i310s0vtfSOypCxrRl+ip8hDDGk434hAxvOxwJOAsf7L+rGleoNqRqTpbPR41PozzAbDisI6JgwAB5I4eZZwaMNAGEK4tYW9YXJEQVRFUGuW1cP91elf+uo/wDdhrYh4PUM+Za87Vv/ABs0s/11H/uw17vaQ1Ufo1pHXb6gysaYjysHopdkIcRFieSx31OIKD+f3uidwylgbQtNurTu7u9lyTsgJCqulXHMGWcxzMvIHWHPGOa3Y2P9MLQsDR6iT1tPZNzNelmVGeqBwXzEWI0OOT2ZJIB7VrHsy7InjusG5dWNcpDuqu3s2K+UbNNy6XyC6HGbzwCX57eC2u2VNK7r0b0pg2JdlY74xpCcjNlYnHhL+SIYGeoAIteX2mMjVLSUZ/8Ax831f5sNbG9S1y2lg7xo6Tbxz/hCc/uw1sb+6iKOSIOSqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIqogIiII7OOBwvxVWlU+tyEamVeUhzMnMw3Q4sKIMte0jBBH0FftcN4YyuDobnNLSeHUgwxA2S9JpGLEFCpT6PJxnufElJEhkGJvHystwefWsh2Rp1ZunNNNJs2gSlNlnOL3tgM3S955uPnK9M0EADsCEYOQ3j2oOShzlclEBazwmPuXbemJgPbFh2fQhDDSCdwzUEHh2Z3Fsuc54LDulOk9x2zqdfWoVzT0GZiXM6Whywa078ODBD2tDj18HBBmAcMAcM8cr8tQp8rUpaNIz0FkeWjw3Q40J4yHNIwQv1BjgADxwgZhxOOJ60GGrS2StCrMuGbuaiWRT4U1NRxM46IbrIgJO8B25OV6DUbQHTDVVzfDm2ZSrQsMHRR2BzctGGnHmWRCIhxgAjKroeTkH6kHgpbRWxJK1ItkylFhQ6RFcwvl8DdIYCA3HZg4XU2Vs0aP6fTzqjZtoSdJjvjCYiGWhhu/EHEOPn4lZTe0kBvHnk4V3ePEIMe6r6GaX60U9kjqFasnVu52lsCNGhh0SBnmWnq7V0el2y1ono/MCqWjZkjBn2ZxOOhgxmjsBHVy+xZdwckNaPpQNB5w0HwmY8CVgGLGiw4UNrS5zncA0dpPUsPaF2/T6rct26t974cKLc042HBeG+W1kAGCePYS0Fec1d0Z171H1OhwqZqm6jafTMHcnafL77YsRvkhzCc4yfKxwWeLZt2RtiiylDpkLopaUhNhsb24HFx85PH60HasI3eB4L8FfoVMuWjzlCrEqyZkp6EYMeE8Za9h5gr97RgdaOGWkIMVyGzrp/TJJ1Gp8GYg0VxJiUpjgJaJnnluPp6+tZCotCpNvU6DSKLIw5KTl24ZAhNw1o+hdkGnC4lric8AgwzT9kTQOl3VNXdKWBThOTkQxIo6IbhcTkux2rLE3R6ZUKY+jTkpCjyUSF0D4Dxljmf5OOxfu3XHIH2p0Zz+7gIMB0XYg2daJcz7mldP6dEmHRTGayJCBZDfzyB1Feho2y5o5RL+mtR5O1pfv5NPa90wWDLcNAAHDlhoWXAzn1HzdagY4EkkebCDwmp+iOmusNMhUnUC2pSqQJf+gMZgc6Ee1vZzK8lK7Iehcra0e0GWTIPlZmEYL3uhgvMPOd3PZlZnw7AOM8etUsy4EcO1B4zTbSawtKKUKFY1vy1Ml282wmYBXjdUtkrQ7V2sm4brsmSi1V7t6NOMhgRIn+kTzWZiOJw3j2riGuBLsHOMBB4nTbRnTXSWmxaZYdo0+kQowxHdLw90xfO7tPJeYr+ypoldNcZc1fsuQnapBO9AmosMGJC6+B6uZWXmtOBw580LASeB4oMe3PoRpxedBhWrctvwp2lQYfRCXitBYW88EdmV9bC0P060zg9yWZQJenS4YYYgwWhrQ3sx2L32HDjknhyULTgFrQCgwzB2SNB4F6zV9tsKnsqE87ejN6Ibj35zvEdvLrXuLx0usrUCiQbcuaiS83Iyrt6FCe3IY4dYXrXtcd3IDu1UtJ6kGOZXQmxmPlm1WDMVeBIuDpWXnXB8OARy3RgYXta5btIuSkTFBrUjCnKfNM6OPLRm5Y9vYR2LsgzBTdJBGetB5qxNObL00pAoVkW/JUenh2/wBzyjNxm91nHbgBenXAQ8HOc8crmgIqogIiICKqICIiAiqiDUHUO+zpTtc1K76rQKnO06boMnAhxJaC5432tiZGQD/lBexO2hZYGH2jcRJJ4dyxPyLYjozvE4GD5uKoh9vHHaitSqBrxoFa1yzt429o5UKfWqi5zpuegU97YsYuzkuO7xzk/avWDbQs0nDbPuIkDkZV/wCRbF7vmU3TnlwQrVjZduKPfGveqd9QaJPyFOqMjSoMAzUIsLnQ+l3sZAzzC2qXzEPHve3K+iGuvrsWqQabEiUeE2JND3jXcivCd/dYceTQJM8ez9SyU8OcMA4UAOOXL+KIxv371k+IZH0f1K9+9ZPiCR9H9SyQP9FP6qDG/fvWT4gkfR/UnfrWT4gkfR/UskfUn1IMb9+9ZPiGR9H9Sd+9ZPiCR9H9SyRnsCf1UGN+/esnxBI+j+pO/WsnxBI+j+pZI+pPqQY3796yfEMj6P6k796yfEEj6P6lkjPYE/qoMb9+9ZPiCR9H9Sd+tZPiCR9H9SyR9SfUgxv371k+IZH0f1J371k+IJH0f1LJGewJ/VQY3796yfEEj6P6k79ayfEEj6P6lkj6k+pBjfv3rJ8QyPo/qTv3rJ8QSPo/qWSM9gT+qgxv371k+IJH0f1J361k+IJH0f1LJH1J9SDG/fvWT4hkfR/UnfvWT4gkfR/UskZ7An9VBjfv3rJ8QSPo/qTv1rJ8QSPo/qWSPqT6kGN+/esnxDI+j+pO/esnxBI+j+pZIz2BP6qDG/fvWT4gkfR/UnfrWT4gkfR/UskfUn1IMb9+9ZPiGR9H9Sd+9ZPiCR9H9SyRnsCf1UGN+/esnxBI+j+pTv1rJ8QSPo/qWSfqT6kGNhWdZvK/wDI/5vD9S7ygQ7pr0jNSF8UyVZAjQiwwmjg8HgQeJ4YXrCCBwJOVGMLTxyT2lB5Ow9LLC0xlo8lY1qU+iS808xI0OThbge44yT9gXrmgBoAGAmXZ4tVQEREBDkggHqVU5oNZdsufm6FM6e3HDpc5PwKZVY0WYbLwy9zWbsPjwB86+dwbV2l120p9IuTTqt1GQiua90CPJvcxxacgkbvUQCtmtwtfni76epct3tCDW+Q2wtP6bJQadIWPX4EtLsEKFCZKPDWNHAADd5L6/wAs+zCWtZZ9xADPDuV/5VsXu+ZcTD45AxnmjTTO99YJbWnVfTiDb1r1mWZSpyYizMWPAc1rQ4MxxLQP3StzQ7HkniuBhOIDTh3HOTyXPdJxn60Z0Od7AJwvD16ramy9UfCotKlI0mB5L3jyj/6l7ks4cMZULDgZAygxz371k+IZH0f1J371k+IJH0f1LJGewJ/VQY3796yfEEj6P6k79ayfEEj6P6lkj6k+pBjfv3rJ8QyPo/qTv3rJ8QSPo/qWSM9gT+qgxv371k+IJH0f1J361k+IJH0f1LJH1J9SDG/fvWT4hkfR/UnfvWT4gkfR/UskZ7An9VBjfv3rJ8QSPo/qTv1rJ8QSPo/qWSPqT6kGN+/esnxDI+j+pO/esnxBI+j+pZIz2BP6qDG/fvWT4gkfR/UnfrWT4gkfR/UskfUn1IMb9+9ZPiGR9H9Sd+9ZPiCR9H9SyRnsCf1UGN+/esnxBI+j+pO/WsnxBI+j+pZI+pPqQY3796yfEMj6P6k796yfEEj6P6lkjPYE/qoMb9+9ZPiCR9H9Sd+tZPiCR9H9SyR9SfUgxv371k+IZH0f1J371k+IJH0f1LJGewJ/VQY3796yfEEj6P6k79ayfEEj6P6lkj6k+pBjfv3rJ8QyPo/qTv3rJ8QSPo/qWSM9gT+qgxv371k+IJH0f1J361k+IJH0f1LJH1J9SDG/fvWT4hkfR/UnfvWT4gkfR/UskZ7An9VBjfv3rJ8QSPo/qTv1rJ8QSPo/qWSPqT6kGN+/esnxDI+j+pO/esnxBI+j+pZIz2BP6qDH9Lq+qsWpQ2VOjycKWP8ASOaOIHpL3zCeAJzlDDySXNBypDYW8eQPV2IPoiIgIqogqiKoIiIgqiHggygIvnFidGC4va1rRlxd1BdPal40O85KYqFvz0Oal5abjSUR7DkCLCduvH1FB3qiKoIgGEXW3BV20Chz9ajgOhyEvEmHDOMta0nGT9CDssjKLH2i2qD9W7JZePeWLSw+dmpZsGK4PLmwohaHgjhhwGQu41BvuFp9bE5c83TJidhScMxHwoAy4gDPYexB6lFhvZ22lbf2i5Gs1G3aLNU+DSI7Zd4mHhxe47wPAAYwWrMQL8FpwD1FBzUXHLmjysKOicPJOCO1BzRcXOwN7PBcHRSwOJ6uSD7KLGGoWtLrZno9vWbas1dlel4Do8WRlI7IZhNAB8pzvJB4jAzkryGz7tK3PrNcFVoFb0nrNrOpmWujzr2ljnDqGAM/SEGfkXDpMHDv4BTpCCQRkdSD6qLjvODS4t49iNc54zu7qDkicguBeQOXE8gg+ii4OdEy3GB25XLJQVFwc9wIOMA81A6Jyx9B6kH1UXV3BWzb9Imas+UiTAlmF7ocPi5wHYsN6HbWlsa6X5XbFoVvT1PmKBBMSYfMvByQ5oxjAI98Cgzwi47/AAzkKgkDyv4IOSi4l4zgHB84Tf3Rl3X2IOSLoLvvSiWPTXVm4Y8aFKNzxhS74ruAyeDATyWLbW2zdAr2qsSh2vds1PzsLHSQodLmSYeTjyvI4ce1DOWclF8JeaZMwRGh5IcMjIxkLGV+bSulGmtT703hXJuTmHRegYG06PEa5/YHNYQfqQZURdNbd0U66KW2sUt8R0q8Za+LCdCJ8+64AheCufaR07t2rR6BBnJip1GWOI0GRlokYQ/MXsaW582UGV1Fhqk7VmlVTuCn2lHqE7T61U3mHLyszT47OkIGSA8sDeQPWsx9Jz8niOpCRyRfiqtUgUenTdVnIjWS8nAfHiEnHktaSf4BeY0r1WtXV+1YV3WjOCYkojzDyObXAAkfxCEe1UXHfAzw4hYi1P2rdE9H7gh2zf13sptQjQ2xIcES8SKSHZx7xpxyQZfReRsfVSydQ5CFULWrkCabGG81hO5Ex27jsO/gvXIKoiqCIsE6nbT8ewtSIumND0yq10VODJwp17pOahw2tY8Ejg4f5pXUfyqtQMAjZqujl8Yy/wCCGctjlFrkNqjUA+X/ACbLnDeIx3xl8/2J/Kp1B/8A6arnHaO+Uv8Agixsaiw1ohtFeOG47jtSbsOo21U7chS8WYgTkwyKXNjb26RuD/NKzKiKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIi85f1/Wxprbczdd31WHT6ZKDMWO9pcGjIHIcTzQekUWHdPNrPQnU+b7itC+IU1E5ZiS8SCzP+k8ALLsCYhzMMRZeKx7HDLXNOQ4doIQj6ouAc7IBGc9i5oKoiE4BKAixVrprtC0VkaPMG052vzFamXy0CWlYzIbt5oaebhj94Lwx2qdQiBjZruduf8A4jLn/Yixseotc3bVN+tzvbNtzjHL/CMuc/wXEbVl/l2Bs13Rj/WMv+CEbHItc6Vtc1KLd1EtO59G65bz69FfCl48zOQojctAzkNGesLYnecACSER9FEHLiqgiIiCqIqgiIiCqIqgiIiCqIqgiIiCqIqgiIiCqIqgiIiCqIqgiIiCqIqgiIiCqIqgiIiCqIqgiIiCqIqgiIiCqIqgiKqICIiAhPVlR4BHFYh2jtd6DoPYkeuVF0WLPzWYEjChQ3PcIjuAeQ0E4aSCR1gIPN7UOpdyytq1+zNM5mE2uw6RNTk3Nu8tkpAZBc8ggEYe5ocGnPAjkvE+5gzU5PbLkrUKhMRI81M16pRYsWIcuc50UEknrOSsUw9qvQGk6Q3XJxaxVZ+8LnpU02em4tNmAXRokJ4EMOLOENrnEAE8Aea/L7nftP6ZWDoxR9Ka5Nz7q/M1qZdDhwZKLEZ+2iN3Mva0tHn48Ea8f0Zz2IvlCd0sEPA3C7jxX0aMDBOUZVYq2mq8+39D7tmoTWuizFOjykIdr4kNzW/xWVVrltrVB7rAoFqSp/nNauilQN0HBdCMcB+PqPNBkfZ+t5tuaPWrTmgtfEpctMxWu6okSE1zv4kr097AttGsAkn+Zxf7pX7rfkRS6LIUwAjuSWhweJyRutA/2L8t6f8AFKs/9yjf3Sg0s9zdrNIodE1LnKvU5WSgw7hjExJiM2G3jGjdbiAtyLZ1Csu8osWFbVy06oxYBIcyBMNe5uOfAHOFofsCaU2hqRS9SoN4yT6jJivx2mSiuDpd2Y0bi5hHEj/avxixaXs67edCoWmDXU+j3BJ7saSaf2Y3hDDuAwP3jhGpX9GY85LSUMxpuZhwoYGXRIjw1rR5yeC6FuoNnPnO4H1+Sa9zg1pfGa1ryeQaScO+paobZer9wQNVbG0Yt+Rmp2WqUYTVVkpaMIL5pjXsxB3ncMOa8g5yvtrPQbkv3TmNbls7NE5SqzJwQ+kT7KnLB8rHa3yHAgZ54JRI3LhuhuYNxwLSMg9RC625bgplr0WarNYmoECWl4Ze58WIGN4Dlk8F4XZziaiu0nosPVCRfJ3DLw+hmWRIgiHDPJad4Eg5ABXbay2jQL009rNGuOnwpyTMu6KIUVoc0uAOCR9aI1c2D9Trdrk7qhet43ZTpao1G4Gsa6cnocMvgw+kYzd3iMjdDVuJUrptikthxapclMk2RGdKx0eaZDD29oJIyF/Pj3P3Z80e1Lt2+pi+7EpVXi02umXl3TEu13Rw96J5IyOXkj7Fkv3SjTe1YegBuCDThBm6VGgSkq9mAIcEMd5HLlhreHmRZzG1lU1LsSimTdUrspcuJ9wbLB8ywdJk8xk8R5+S758/IQJR0/HmoMOXc0PMV8QBm7jnk8MYWj9lbF1va66a2Rel+VWeh1SWhQndHBjYhNlxw3GDB3S4Bp5816HaNvWZn9ZtLdmWjVCPL0OpPhGs9G4tfFgQ3CH0WexzXA8jyRf8ton6l2M2a7lfcckwAcYrorRC9Mnd/iu/lp6UnIDZuUmoMWA8Za9jgWkfSOC8LVdB9LKvZ8SyJi0JDvY6F0QY2E0EZ/eBx77nx861l2NNRbipOp177Nl11KNUW0KI+PTosYkmHLcDucf9MfYiRuKLxtd033vZcVMfNHlBbOQzEP8AVzldFN6v6ZyNYbQ5u+qOydindbC7rh5B7Dx4LRC6tOaHJe6B0WhU2NPyUnNNESIIEcN4lzM44cBxXr9vLZb0lt3SKoakWrb0GkV2lv7pM5Lta18bAOd8gZJzhCN1LivyzrVlO7rhuWnSMPdyDFmWMLm9oBOT9S/Tbt125dlPbUbZrcnUYB/fl4zYmPMcHgtbNE9DdPda9BrWuPVSleEs/OSOenqBEV0LDnNG4SOAwAsQbCEjN6abS2pmjNOnHmhU3emIEIkkb2IWPsDyEI/oNv4aN7gCsUXLtHaf29qbSNLH1qTfVqi/MUdO1rJeHxBLyeAOccM54rKzjveRniRlfzguTTGyan7oNCoM/QYMeUnh0kwx7QREfkDJ4cTjghmV/RCUq9Jq0vGdS6pKzohgteZeM2IGnHWQVorsgzsnS9rzWibqEzCl4LMl0WNEDGgfseJJ4LdC0NN7O07p07KWfRZenQ5kmJFbBYGhzt3GeHmAWiOzVYVGv3a/1hpdyGYjyMMkxJURP2UYfsfJe3B3hx5IRvjRdSrAuSpxaTRbtpM7NwXbpgwZpjn58wB4/UvSvisgNMWLEaGjmScBv09i/m3tP6SWrs47Qem17aSybaG6fnGsjy0uA2E5x6TjujHUFm/bs1puWwLFtq17TfGbVLumocrGdBf0b2wiwuJa7qJLcfWhGys1qDZsvNdyzNwyTQ4f0hjNEP0icfxXoJeLAmYDXy8VkWE9uWPY4EEdoI4Fak1SnR63pwbI/kuTj4b5PchR3VSWL2xMZETO7zyvcbGNP1hoOlTbc1fpkeUqFNmDClHRplsZzpfAIyWk9ZIRGdKw2G6kzjnDIbLxMZ/0Sv5++50Q4Q2h9XmswMQsbo6v2zF/QSrtHeqcJP8AzEQkf1Sv5/e50hp2itYHtaADC5D/ALZiL8en9DQ126QSFg/aakJWZlrRdGl2xC2r5bvDkd3ms5gYWE9pgkwbSa3OTV+YOP3UR6/WOoV2j6W3BOWzl9RhU+I6AMZPLiR9WStY/c2dQbHqmmc5T5uqSjLuizj31Lp3BkeYcQ3Ljni7JW50WDAjy5lo8MRIUdhY5ruRBGCPsWkOufud7pm45rUzZ6uaLaVd3jMGUhuIhvfnlD3cBn1lFxtff2mdEveapFWjykI1KgzPdElGc3JYSN12P6uV7bjxGV/PHR3bF1l0Y1AktG9qGkRyyZitlpaqkEuDycAufl2/kjHDtX9CTFaWGN0o6McQR/aiMHbWFdq01ZMtpnaswZevXrFdIysRvHo2tAfEJA44LN4LWjYAuye0h1ZvHZgueYc1khNxH0wkFvSxATvuGerdYssTV0X/AHVtFVe9rT01mLtotqs70yghz8GW6CfYXCNEHScwWPaOH2rXHapj6j6ba92jtHTOmk1abIszDkpt756FMh+D+0cej97lsQ8SjT+oOWveXAnHJYzvfZ60Vva52XzfNlUioT8vDDOnm4TS3dbnGc9mSea9vaNyUu77bp1z0OIIsjU5dsxAiA5yxwyCtc9tGlaq3pN2Tphp9c5t2VuidmoM9UASN1kOE1+6cEc+I+tDMeS131G0a0wvez6do/K0xl4R6nClXw6Q0EdzPe1rhELMggNL8DPBbqLVzZ82DdL9FqpCu+ffHuC5hxdOTLt6G1/W5jSMtPE9fYto0TRFVERrbIFzdt6uhpA3rbkOr/NirIO0RqvPaMaXVS+KXR49VnZcw4EvLQmF5MWK7dYS0cSA4gnzLHkgCNuKuHq8GpD+7FWw89TJCow+jnpWHHhgh248ZGRyP1IutGqrqFtyWjp9A10q9WtmPSzDhzkxRBTojYjZd+HOGTFwHBuermOS250g1DktVdOaHfknCdCFTlYcV7Hc2PLQXN+onC1e2o9Vry1WvgbKui0g0xo7Ibq3PluYcvLu98AeGCGh/DPFbTaRaeSmlendFsaUiiKKZKw4T4gGA94aA5w+khFYg0XaIe1nrE3Oc0yin+EZbJrW/Rf/AJV+sX+rKL/ZGWyCJoiqiIIiICKqICIiAiqiAiIgIqogIiICKqICIiAiqiAiIgIqogIiICKqICIiAiqiAvN6gaf2lqXbsa170o0Cp02YxvwYzQ4cCD1/QF6Rec1FnKzT7JrU9bzQ6oQJKNEgA/5QYTlDGGbzsLZV0VsOfhVG3LXpUvLyz8MLIfTOeB5JDRx3s444X69jG/ZnULR2XqzmzHcUvNxJaQfMEmI+Va1u44k8+Z4rWzRbYhqOv9NpGsu0Hf03Xn1mGyoNp8KI5pgh3Ho3F28DjsW+VnWbbli0CVtm1qXCp9NkYYhwIMIBrWtHLgEXdd2wN3gWk8l9FxBBdkZ4rkiCHkqoUGuW1bu+FOlzd7H+GY/92Gth2lrWjAOMcFrztVjF2aWH/wCNR/7sNZivrUezNOZOWqF51yBTYM3GbLwDEPF73EAADmeJH0Itd9OTsvIS0abm47YMGBDMSK95wGtAyT9QC1etLafvvWvWabsjRmnSjbXoMXcqlanYJiw4haSHMh4LeJ3SM8eYXT7YGs9XumNSdn/SCodPcF17hmo0B2e55J2C5xI6izfGM9Szns9aIW7oVp3I2fRJZndDGCJOTDRh0aMQN4nzZCHTwO0t5OqOkrt8tzUJvj9UNbGOh72ADgA5Wuu0uf8AfT0lDgQRPzeOw+TDWxuOCINcHZI6jhVByRAREQEVUQEREBFVEBERARVRAREQEVUQEREBFVEBERARVRAREQEVUQEREBFVEBERARVRAREQEVUQEREBFVEFURVBEREAjIXn7isKz7ufCiXPblPqboGejMzBD9zPPGV6BVBr9r5p7otbOll1xXWnbkpO95pzuYCAxsUxDBfubo5k5xyWGPcxbdsCb0Fko1WolM8KIFWnXkx4TWzTYe+NwjPlYwtxrjsKy7sjNjXNa9Oqb2DDXTMBry0ebK/NQNMtPrXnRU7ds2k0ybaC0RpeWax+Dz4hC+PUbhI3XclR5IwqmMoHNax69wvC3aO0tsRsMRmQmTlWijPFroBhPafNjitnCcLWijMdc22pW6g1ofAtCiwIIcD70zUHj9PvEGybDu5HAnzcF5/UCpSVPs6rxZ2agwGOlIrQYsQMBJaeHHmfMvQNIxlrRk/autrtt2/c8n3tuOkylSlt7f6KYhh7cjlwKDSn3NGoSkjJ6kS07MQpeJGr8SJCbGcGOe0xYxy0Hi4cRy7V0Wtdbp0Tb6s+eZPQHS0rBYyLMNeDCYT0XAuHAHgevqW7FL0m03okwJulWNR5SMM4fAlmtd9oX54+jGk0zHfOTmndBiR3uL3PdJsLiSc5PBFrT7bvsy7rc1AsraasKXfVpW3I7TPw5U9KXMD2kY3erDDlZ1sDbX0TvS2YFXbXpiHOtgNM1JCViOjQ4m75TQwNyeOeQWcIVu0SBSu8UCkSrKY5jobpUQx0e6eY3exeWpGhejtCqxrlE00t6RqBdvGZgyTGxCe3IGUSu8sq5/C2hwq73sjyECOXGFDjny3MzwdjAIyOOD2r82o9Sp9OsysR52agyw7kiAOivDQ4kcAM8yvTMYxsMQmQxujgAOQXXV+2aDc0j3suGjSlSlt4ROhmIQezI5HB+lBpP7mhcdGp9Ev6mVCoQpWamLhdEhQ5hwhGI3ei8W72M8xy7V7f3SmfkI2zdUKfCmocSafOwXNl4bg6IRuP47o4kcexbASmjelFPmGTcjp/RYExDcHMiMk2hzXDrBwv3V3TewbpitmLhtGl1GIxu418zLtecdnH6ELzXhdl646FVNG7XkJKpy0SYhyDA6C2I3pG4AByzOR9iwJtj2Fc1m63af7SNv02Ynqbbkw0VmFAYXxNzfDsgDJxut7Cttrf03sO0pru+2LQpdMmdws6WXl2scGnmMj6l303LwJuXfKzkBsaDFG69jhkOb15HWEWvK0TVWxaxbcvcTLjkIcGLAbFdDfMNERmRkgsJzn6lrXsrafVKua5agbRU/JOkKdWYpk5FsxDLHxIIa1rn8cYG9D6x1rZAaL6UMc+INPqGHPJcXCUZknt5L1kOnyUGVbT4crCbKtZuCEAN0N7MIVoFe1apMP3Q+3KoZ2F3CGiE6Za4GE07zOBfyHLtWY/dAq3So+zdXZGWnoEaNOQiIMOFED3RBg8gOYWbYuiuk8SO6Zi6fUN8Rzi7eMozOe3kv2VPS/TysQZaXqllUmahSzDDgsiyzXCG0nOBw4DKFYv2QLgoZ2b7SYanKsdJSD+6IcSK1hhDpHcXAnLfrWuWy9WqXD25dVKpOT8CBJzUuRLx4jwyHF4QRhrjwPI8lu5T9LdOqTAmZSmWXSZWXnYZgTEOFKta2Kw82uA5jgvyQNFNJYEQR4OnlAZFbyeJJmc/ThCvZsLHhpGCObSORC/nvqhcMnp37oHQrjulkaTpc80NhzTmEQ+fMnGOor+g8KGIbWsh4axg3Q0dQHJeaunTewb9iQJi9LPpVYiSw/YOnZdsUwxk8s8uZRM2OVFvy2rlps7PU2f3pOVBD5iMww4Z4ZyHOwCOPNaTbHlXkZfa/1gnIs1AhS03nueK94a2KcweDSeDuR5LevwWtwUI213lkxStzou4+iHRFnZu8sLoJPRvSynTTZ6RsCiS8ww7wfDlGBwPbnCLjTj3QmrSM1qdpjAlZyDGfK1BkSP0ZD+jb+099j3vMc16jb60trupultu37p3FFQnrRjw52KyUiiI50JrMYaGn32XfYtoKnpBphWZuJP1awaJNR4p3okWLKMc4ntJXfUS2rftuRdTqHR5WQlX++hS8MNYerkPMhWt+hW3FpRednU+Xuepx6RckrAbDnqfGl3h4iN4cOHHhjks72Ff0pqFLRarSaXNy9Oa/dgR5hhhmOMe+3HAOA58+xde3QTRk1fv+7TG3DUi7fM13AzpCe3OMr3MOBCl2NgS0JsOGxu61jRgNHmRCagCYl40uR5MVhafrGF/O204NX2Ndry5KzdVNnDZl8ndgz0vLviMlmb28C/dB62Y6ua/ovjiCDnt4rr65blCuWUdT6/SZWflnDjCmIYe0/UUOnTSOq+m1SkYNQlr3onRx2b7Q+ehNfjztLsg+ZYkva5BrTqLbFq2XBiTFJoE86erM86GRC6Msc1rYbjgOO/u8s8Cve/yc9B3RTFOk1s9JvZ3u97M57c4XtqNb9EtyUbT6HS5WRlWe9gwIYa0fUEGPtoy5avY+l9QvOiRJjp6M+FHLIOSXsMRjXDA4nySV+ywtetMb8tySuKn3XTpNk1DDzBnZlkCI0nqLXkH+C95UabIVaTiU+pSkKZlY7d2JCiN3muHnC8NNbPWhs6d6Z0qtqM8ci+QYT/AGINZdr63pHaO1J0/wBPtP5UT07SKqKhUatCZvQIMuG8G9IPJdxaRwPWtjda9RaBpFplUZyaqLWzEOVMCWhB+9ELn+SCGjicF2eXUva23Ztq2dLiTtagSNKgYx0UpBENv2BfG49P7Iu+OyYui1abUokMYY+agNeQOwZQeC2XJGQlNHaFNQZuXmqjUoDZ2pRobgXRJp7Rvud15OBz4rrtr/T2lak6F3BbtUmZOWmBAdMSsSO9oIfDw8huTzIbjgssW/aVsWnL9xW1Q5Omy5JduS0MMbntwFbgta3Lql2ydx0SUqMFh3msmIQe0HtGUK079zX1yh3BpeNMbpmHy1Vtx25LiYywPlsBsNrd7mRh3JZb2pdcbW0agW3M3HYNQuaLPz/RSxlGE9yu8nLyd13b5uSyhTtItMKROw6jSLEokrNQjlkaFKND2n6Qu/q9Co9egsg1qmSs5DgvERjY7A4NcDkEZ68gIV87YrjLkt+m1+DLRYEOoQGTAhxWlr2hwzggjIK7dfFjd0MDAA0dS+yCqIqg1qpzi3bhroOMeDUic/1Yy2P3mlp5HzLVfUcal2HtPz+pNt6YTd00udo0pJfsJ6HLlr2CIDxcD/lBeg/lH6wMdj+S3Wcjsr0v+RGnhNnS5rGndqLUSVoentzUyrxIjoM5UZ2aD5SP0TouDDZ0Yxnj+8eYW4bTlhI4kjOFrRKa46iSE5GqEjslVGBMxiTEjMrcsHuJ55O4uxbtJ6wFvDZerWR216X/ACImvjowXDax1ha5mM0uiH+EZbIrWXZspuoFV1o1G1MvCxZm15auydNl5WVjzjJhxdB6QOOWAD94dS2aQ1HOLeO7kKNeXfur8FfgVqYpsWHQJ2XlJ4/0cWYhGIxv0tBGftWPzQNoNzM+MS1m4J5UOJy9YiMobwTeWMW29tAEA+MS1fuOJ7VXwd2gfnEtT7jie1QZO3gpkLGXg7tA/OJan3HE9qng9tA/OJan3JE9qgybvBN5Yy8HdoH5xLU+5IntU8HdoH5xLU+44ntUGTt4KZCxl4O7QPziWp9xxPap4PbQPziWp9yRPaoMm7wTeWMvB3aB+cS1PuSJ7VPB3aB+cS1PuOJ7VBk7eCmQsZeDu0D84lqfccT2qeD20D84lqfckT2qDJu8E3ljLwd2gfnEtT7kie1Twd2gfnEtT7jie1QZO3gpkLGXg7tA/OJan3HE9qng9tA/OJan3JE9qgybvBN5Yy8HdoH5xLU+5IntU8HdoH5xLU+44ntUGTt4KZCxl4O7QPziWp9xxPap4PbQPziWp9yRPaoMm7wTeWMvB3aB+cS1PuSJ7VPB3aB+cS1PuOJ7VBk7eCmQsZeDu0D84lqfccT2qeD20D84lqfckT2qDJu8E3ljLwd2gfnEtT7kie1Twd2gfnEtT7jie1QZO3gpkLGXg7tA/OJan3HE9qng9tA/OJan3JE9qgybvBN5Yy8HdoH5xLU+5IntU8HdoH5xLU+44ntUGTt4KbwWMvB3aB+cS1PuOJ7VDb20Dj/3iWp9xxPaoMmGIMEgZI6srp7sq8pR7cqNUnZV8zBlZaJEiQYbd5z2hpy0AZ58l4kW9tBAE+MO1CSMD/AcTh/+avRWfTL8lIUeDfdfpNVc9uG9xSDpdozzzvOdlBi7ZP13tfWS356WtfTyp2lLUmKYbZabaQ0jgPJO40dfJZ9a0499ldbS6FSKDAiQKNTpaThxopiRBBYGguOMk46+C7QckEw7hxHnVREFURDyQa5bVr/91Wljg04Faj59GGuh90G0QrusOk0pN2rKPma5bs2JmShMOHEuLA4g+YNyvR7WNFvWoPsmvWXa8avPodTizExKw47YLnNIZjyncOor5N2j9YBkfyYKyQM5Hf6X/IjXTHmwTs11+y5KNq3qsyJHu+eZ3HAEyd58tLtzu7pPLIeQfoW5QOXkDIcMfYteG7SWrzuDdlytAY+Ppfl6Cfyk9XweOzDWR1f49l/yIkcNpgu8aWkuBxNRnOGerENbHE4H0LUK5avq1rNqdYk7P6Mz1syFvzceNMTMxU4UcODw3GGtAI96tvASX45eZE1WvJwN3gRxOeSOeGnB/wD+Lg7geDS45PXheEuCjayTVVfGtu87fkpB3vIMzSnxog+l4eM/Yg9/vBN5Yy8HdoH5xLU+5IntU8HdoH5xLU+44ntUGTt4KZCxl4O7QPziWp9xxPap4PbQPziWp9yRPaoMm7wTeWMvB3aB+cS1PuSJ7VPB3aB+cS1PuOJ7VBk7eCmQsZeDu0D84lqfccT2qeD20D84lqfckT2qDJu8E3ljLwd2gfnEtT7kie1Twd2gfnEtT7jie1QZO3gpkLGXg7tA/OJan3HE9qng9tA/OJan3JE9qgybvBN5Yy8HdoH5xLU+5IntU8HdoH5xLU+44ntUGTt4KZCxl4O7QPziWp9xxPap4PbQPziWp9yRPaoMm7wTeWMvB3aB+cS1PuSJ7VPB3aB+cS1PuOJ7VBk7eCmQsZeDu0D84lqfccT2qeD20D84lqfckT2qDJu8E3ljLwd2gfnEtT7kie1Twd2gfnEtT7jie1QZO3gpkLGXg7tA/OJan3HE9qng9tA/OJan3JE9qgybvBN5Yy8HdoH5xLU+5IntU8HdoH5xLU+44ntUGTt4KZCxl4O7QPziWp9xxPap4PbQPziWp9yRPaoMm7wTeWMvB3aB+cS1PuSJ7VPB3aB+cS1PuOJ7VBk7eCmQsZeDu0D84lqfccT2qeD20D84lqfckT2qDJu8E3ljLwd2gfnEtT7kie1Twd2gfnEtT7jie1QZO3gpkLGXg7tA/OJan3HE9qng9tA/OJan3JE9qgybvBN5Yy8HdoH5xLU+5IntU8HdoH5xLU+44ntUGTOlaOarXb3Zn6Vjmm0LXODUIUWr33bMxJNP7SFCoz2PcPM7pDhZChNx5QIOftQfVERBVEVQRFVEBERARVcXRGtOCfsQUgHmE3QepQvaOtN4IKiqiBgLF2mej01Y18XdfFRrUKoTVzxYRwyEWGFDhbwY05Jzwdj6llFfPGMjewOtAZjeyRxXMMaOQ581GcSDkHqyuSBgKbrc5xzVRATAzlVRAGByREQMBTdb2LkogEAjiEwOxEQCAeYTdAGMc+aqiBgYREQMD7VN0AYA4LkogYA6lCxp4FoIQuA5pvDGcoKQDjhyU3R2KdI3nxXJBC1pGCBgqgAchjKIgJgKqIIGtHIBXAznCIgHim6OxVRAwOxTdbnOFUQQNa0kgYzzVIB5jKqiCFrSMEDCvm6kRADQOQwoWtIwRwXJRAIB4kIiICKqIGB2Jgdi49I3OOP2K77UDcaOTQrgKbwUMVgOOP2IOQAByAMlFA9pGR1qoBAPAjITGOCqiBgJgdiIgYCYCqiBgJgdiIgYCYCqiBgJgdiIgYCYCqiBgJgdiIgYCYCqiBgJgdiIgYCYCqiBgJgdiIgYCYCqiBgJgdiIgYCYCqiBgJgdiIgYCYCqiBgBCARgjgijnNbzQNxvLdGFVA4HiE325xlBUUDgSQDxVQEPYVVEELGkYLRhXdHLCge0q5CCboAxjgm63kQrvBcREa4kDPDzILuMOMtHDkqo17XcRnmge0kgZyEFIB5jKYGMIiBgJgdiIgYCYCqiBgJgdiIgYCYCqiBgJgdiIgYCYCqiBgJgdiIgYCYCqiBgJgdiIgYCYCqiBgJgdiIgYCYCqiBgJgdiIgYCYCqiBgJgdiIgYCYCqiBgJgdiIgYCYCqiBgJgdiIgYwmAFVEBERARVRBVEVQRERBInvSc4wvmfKhjDgHHicL6OAIwcfWvyz81DkJOPPRQ3EvCfFPVkNaSeP1INYr528rJsy66jangTcdQiU2M6A6PKSEaLDc9pIcA5rCM8O1dxo7tnW1q9fctYtOsm4qfHmIUWKJidkI0KE0MbnBc5gGT9KxnohtT7NknU7gsi5J2HLVuLctQjl05Kl0PESMSP2zgG4+tbc29LWZPwIVatqFS48OIMw5mT3HtI8zm5H8Ua8ekURVGUXS3dWhb1s1WvuwW06TizJH+g0n/AGLuliLanr0S39DrofAcRGqEnEp8Ld578Vjmt/iUH7tna/rg1K05hXVckOFDmpiemmw2w4e4OgbEIhnHbu44rJ68BoXQG23pLatNa3EUUmUiRcjiXugtLj9uV298ai27p3ICr3VHjS0iM78ZkFz2t87iODfrQeoReMsDViz9UJF9Usqovn5NjiwxxCIhkjnh3I4x1L8kprdYc7eD7Dl5ycdWoRw+X7jflo7Tw4Drzywix79ReSu7U60rJe2XrVUa+biEbklLM6aZI7RCblxHLjhdFR9oHTms1mFQXVOZpU5GGYUOqyj5PpuXBhihu8ePUiZjJSLorlvW3LOpL63ctYlZCUYN7fjRWtBHmyeK6yxNU7N1Gose4bUrMGbp8B5Y+PkNY0gkc+XUUWPYqLHtL1200rd5NsSjXRJztZw5xl4ERryACATkE8shZAcXEZaQiOSLzF66iWvp/TTU7mqbZdhcGQ4TRvRYzjyDGDynnhyAXjLV2mNNrurUC36fGrErOzkQQpeHUKTGlOkceHk9I0b31IsZbUWO77170v04mochdV1ycvORDhssx7XxSf8AQB3v4L0Nw39atq0Vlx3DXJWn0+JCbFbEmIjWZaRkHyiOpEj0aLylhamWnqXTYtWs6qsnpSE/o3RWDyc+Y9fJdJNa/aWyd3SViOu6Ri1qfjiXhS8KK153z1HB4IsZHUWLbY2ktJbzv2Y03ty6YM3XJUExITBlhwQCGvzhx4jkvS3XqhadnxmylTnokabLTEMrJwjMRwwcN7o2ZdjPXhEj1biATv8ALqWAdeNsSwtB7kkrTrdHq1QqU7DMaFDlZSI8buS3gWtIJyFkey9XrHv2cj02iVRzJ6XOXyc5CMvMNHb0b8OxxHHC/ddNtadzcSHct40iiOfINJZPVCHDHQtzng9/vRx7UI8fpXtJaf6rCHLU6HVaTOxsCHLVWQiyZiO7IZitbvn6POsssJI444LRraT2m9OK/cls6eaRCFWbwg1NncsxKQN5ksMOBc2I0EY4nketbuUkxnU2VdMHMUwYZif6W6M/xQfrREQVRFUEREQVRFUEREQVRFUEREQVRFUEREQVRFUGumpmtmrclrLMaUaYWfJ1eNLU+BPRHx5qHBwIgcceX/olcG3htiFpDtJ6P9VXl+a+NNY7+XDXXH5NyP8AdjL3O0te182DpPVa3ptRYtUr7okKVloLIZiFvSu3C/AHJuc/UjWPFi8dscYHipowGMf42l+anhltlbvDSeijH/xeW/FYQufTPad0/wBK2a2zWtszMVqWgw6lM0mM2IyA1pAe+FuuiYyACP8AYtttAdRY2q+ktBvebhBkzPyzDMADAMXdBcQOoZJQeQ0E1n1Avq/bv0+1ItiXo9TtiXk5jECOyM14j7/W3h+4s7rW3RZgG1hrE7jnvZRef0RlskiaqiKoiIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCLw+sWq9u6M2VN3zc8GZiSUmBvNl4LojskgDg0E8yF7hdbX6JRbgpz6XX6ZLT8lF/pJeZhh8NwHHiDwQa66a7eGmWokdsN1vXPTYcQ4hzMSkTLpcjtdF3A1o85K2Op9QlKrJQKlTpmFMy8w0RIcSG8Oa9p5EEcCsC6z657Omg1pVC36nM0aH0sB8FlKp8NkV3SEYDXQ4eS3jjmFz2I65cNzaKQKzW5B8jAjzkR1LlnjBhSe63o2gdQ5outggYZcHDGT9q5rgxo59eTlc0RVDyKIgwztF6t3fpdL23K2XQIFWqVenHysOFFithgboac5dw/eXmTeW2MHEM0no2Of+N5dXaubm69LeJGa1H5H/ADYa2ILd0ENPn4oNdvDLbI+aijfe8uoLz2x3HA0oowA5/wCFpdc5za3o9s681fRm+6YyiMkqb3zlajHmGiHMQw17iBkAA4ZwGcklfn2fNfL+16v+4KvTKNDktPKc4y0jMRGftJuK0uBc0nBA96cceaNPxs1016tO+7atvU/T+QpslccaJBgx5edhRiCwDOQziPfBbMgkYBdggcQtddpXDtUdJxk8J+b/ALsNbG7jeeOKJqtxjgqgAA5KoiIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIiIKoiqCIqogIiII/GPKPDK+EaAyZhugRmsiQ4gLXsc3Ic0jBC+0TO7wbvHzrHuuV23vZGn81cun9vCuVaSjQXGS3t0vgbw6UjgckNzgY4lB4jVbYv0G1Vps3LTVmydLnI+XNmqfCbLvETmHEtGTx59q1o2SKvqBs+bUVR2WLnrMWoUWZlYs/IB5L+ihhrnsI4ndyMZW0trbU1h1m3JaqVWUrNOqLoG9MU+LTYrYzIgblzQ0gOdx4AgcVj7RfTCv6hbRdY2obnpb6bLvkxS6PLR4ZbGdBa1zOkew4c0lpacEItbXIqoiC1r21qrEj2vadly7Yjo9buqljMMnPRNmGh+QOrDlsotZ9Y4fhdtSaZWbDYSyUlJ+pR8HgDD6J7Mjq8yDYmlSQp1LlJBnvZaDDgg56mtA/2LptRbMp+oFlVizanDa+XqkrFl3l4zub7SN4ecZXoxuk44jHUmACXg5B5hBoj7n/dsTTK4712dLmf3K6hTsebpojeSXSxe9znnPVgtOfOtgtIZOQqtbvDXKep0OHHqkYykElgL2QpTehEg88OABWue19o/dUjtI2hfOnTokCJd7O81VfDJDmQHGHDJGOPvc8VvBb9tyNCtmTt2HBZ0UCVhy8QBvB5DQHOPnJBJKNNR9iWsHWPUvVDUy7g2dqVOq4psg+IzhLy7TEZhgPvchjc45kLIm3Tp3IXXobWrjl5dkKs2xCNTk51hDI0Homucd1/MDOOAPUFijSW2bn2QddroptbpM7N2RfU4Z2XqErCdHEtHJJDYgaDuNzEPEkDAWX9pa92XnpvUNNNPoEas1q7Zd1PhmDBL4MGHEBa50SIMtZjI4Ejr7EHitProltedhePdN5SEtUJqHRpyBvx4Qc4Og5YHAnkfJzlfk9zSkZSJoTUafFgMiwHVKMxzHty0t6SJwI7FlWzNDYunuzFMaQUksM4+kRoRI4N6eK3Lv8A1E8VqzsW6+0vQam1vSTUmz7slqlDqsQy75SizMyIwL3nPkM4DyhxQfsodt0e3PdN5uTotPlpCX70OeYUvDDGZLYJJwPOV/QtoOTx4Hkv5wyd01CF7oVFvquWpXJWlzdNbLwnw5GLF4vZC3S7DfJ4Djnkv6MysdsaGyMzeEN7Q5u8MHBGeKJrSjboffdlanafaySNuzFw2tbT3d3yEFpf+1MQOa7cAPINd5WOGVkTS3XnQLaamaJPUaagSNx0KchTLJSahiDHa9ufIZvYLhk9QXrLu1QlrW1dhWJe1Im5ug16TfMQJjuF8WWglha0sivwWtyXE8SOS1/1H0Nti49pSwbl0LoD6XHkZts5V52TgmDJCC143uLQGOceHDOTxRcfh90fte3ZSt2JXpSkSkGox6lDZEmWQQ2I9pLuBdjJ5BbK6221Q7j2dapDrtIlJsQLfa+EY8Nr9wiEOIzyKwf7pDZ11T1i21eFApUxV/B2dhPmIMtDc95wHEuw0E4XZzW1Pbmqmh9Tti07OuqJWhRO540Gao8xAgsc1gaf2zmbpOUH09zRgsh6JTsFjQ1rKg9oAGBjeesP7UFgUmW259JKVbEhLUl9YfmYiyrBDLn9KRvndxxx1rJ/ubNa7h0zqVt1Ol1eTqEKffEe2ZkYsNhG873r3DDhx6l4DaKugTW2xpXfcnblwzVEtyJioTEGkx3iHiKTww3ig2htTZd0f00vCd1UoFCMtWjAO85rsQmnAJcGYwCSM585WsOyRfOrept4ajalW7bklXZ5lbMgI07OQ4TpWEGD9nDa/iGndB4cMlb3US4aTe1FfNSEOZEvFbuFseC6G7iOx3Ffz0t+JqDsF66V0zdpVKs6f3THdNMjyEF8cwSSMvcGB2CMOGDxwgzXXNGdfbo16tHV8W/SqAKM4Qqm2WnoRM7B3i4h4aRvH3vPPJd5tpWBdOplPsezZa4I9LodZrbJSrvguc09EYbyd4gjyeA5r11kbTdO1cnJeR0utC4Ywikd1TdWpsaQhQGdbmmK0CIQccAV+Xaw1UvjS+0aXP2fp1EuyZizjGRobJcxegBacv3Q13Zz86JX69E9j7RTQ0w6lalA6eoBoPds64R4jT2sLhlv1FZygghuMYA5LorGq1Qr1o0ur1mnGnzkzLtiRpZ3/NuPUeAXfsORjAGOxE3lUREBFVEBERARVRAREQEVUQEREBFVEBERARVRBrbTnH+XBXePDwbkf7sZbGPDMb/Dh1la408Bu3FXABwNtSJOf9GKtjfI3N2IOBPJGmj+vFzai7TmsM1s26ezsKn23Suhj3BO8ohbkkw2nIPHccPrW4Gnll0rTuzKXZtHhtZK0uWhy7CBgu3Wgbx85wtZ9nuqXBF2mb+E5pnOUaVjR4kIVWJAcyHNNhuibhBLQDn6TzW3ROB5Qwg100XI/lX6xDP/AEZRf7Iy2QWtmjBH8rPWMB4IFLohxjjnEZbJomhIHNMjtUcFwG+Rk4yOSI+iLgC/rVy5ByRccuTecg5IuOXJlyDki45cm85ByRccuTLkHJFxy5N5yDki45cmXIOSLjlybzkHJFxy5MuQckXHLk3nIOSLjlyZcg5IuOXJvOQckXHLky5ByRccuTecg5IuOXJlyDki45cm85By3hjOV5rUeHU41j1tlFj9DOmRj9A/ra7cPLzr0ILSS0rqbrqExS7aqVSk6eZ6LLS0SJDlxziuDThvXzQaY7MOw1pnX7Xouq+qb5+5bqqkJk3N92R3OZCiniWPY/O8Qe1bs0ulU+jSMOnUqThSkrAAZCgwWBjGNHIADgAsF7Jmr986o0Sqxry0zjWj3JMObDhvgGF0nL90tb9q2CaQWgjKDi0OBOes/wAFzREBFVDyKDXTatIN2aWYP/TUf+7DWw0d8OHDdEiPDGMG85zjgADmSVrttWFrbr0sJJGa1Hx6MNes2qqjqDTdE674tZGJN16aDJWAyGwuO7EduPOB2Anj1Isfzt90Gvyhat6uudp7RpuqNtANhVqflYTnBzQS0w8tB4Ddd5WccV/RDZPqNoVXQa1JyyZaBLyPcMJkWFCAw2OGN3845uzzPNY52Q9lWR020fm5S/JKFPXDdsB76tEigOcGxG+8JOeLS53FZm0Y0et3RK03Wdaro3e4zkabYyI8u3DEI4D6MIvjGm0scapaTDGAZ+bP8Ia2O6lrltMEt1U0laORn5z+7DWxuOCJoHDO7nj2K5GcL5n328W/QUJOQBgkefCI+iLjlyZcg5IuOXJvOQckXHLky5ByRccuTecg5IuOXJlyDki45cm85ByRccuTLkHJFxy5N5yDki45cmXIOSLjlybzkHJFxy5MuQckXHLk3nIOSLjlyZcg5IuOXJvOQckXHLky5ByRccuTecg5IuOXJlyDki45cm85ByRccuTLkHLeBJweXNAQeRyuA4k8OfA8Eh4GWjqQc0REBFVEFURVBEREAjI4Lg+EH++xnC5qoOniWnbcebFQj0GnxJof886XYX/bjK7NsHowBD3WgdWF9EQVRFUHEnC1otNoufbQu2sQyXwrZpEnLwnNfvN3o8Eh47MgtWy55rwFh6R0GwLluO66W6NEnbkisizbokQuwGb26Gg8vfHkg944uA4tDnfTjguvqtdoduyhn63VZSny+8GdLNR2wmZPIZcQF+/Ae8OwePWsb636G2xrxbUK1rrj1CDKw5hkf+aTT4JO6c4JbzQeeoFSpWrusT7lpU0ycolnwDLS8aEQ+BMxowBcWuHkuLHMxwzjPUs1BvHJAC81p/p7bGmdsStp2lINlJCUaABzc49biesk8SV6QZAHl8PoQr5zVOlJ+EYM7Lwo8Nww5kRoc0/SCvzU63KHSDENKpMnJmL77oILWZ+wLslUK+boW9jJPBdf4M0Hvh3270SndvD9v0Lek9LGV2aItde6gUd846oOpksZp4w6MYQ3z9eMr9jYIaN1pwOxfRVEfinqRTalDMGoSMCZYWlpEWGH8D1cVKdRaXSIHc1MkYMrCHEMhMDW5+gL9qIPhMyMtNwHS0xAhxYUQYex7QWuHnBX5ZW3aJJQXy0nSpSBBiDD4cOC1rXfSAOK7FVCvwydGptObuU+RgSzf8mFDDR/BR9FpsTO/Iy5zzPRjK/ciFfCBJQJZnRy8NkNnY0YXzn6TTqpCMvUpKXmoR5sjQw8H6iv1qoPxyNLkKZBbLU+UhS0FvKHCYGtH0AL7mBDcww3NDmnmDxX0RBxMNpAGOCrW4J481VUEREQVRFUEREQVRFUEREQVRFUEREQVRFUEREQVRFUGsupWm+uchr7N6q6YUumTstN0uXkS2amWQyHQw8Hg7q8pfrFW20S4tdZts5AGD3wgfX1LYvADiOP2qNyTg4HmQrXYVTbQ4h1m2yR1f4QgD/Yo2rba2XDwNtk9f8AjGB+C2OwOxcH8Dns7EWtetnfTHVmgao3xqTqpIU+UmLllpGBBhycyyKP2G/nO7y9+FsQvk3ezngB/avqiOvrtOi1amxZGDNvlnxBwisJBH2Lwg0proGBfdQ559+/8yyWqgxp4qK4ePh3UPTf+ZPFRXPl3UPTf+ZZKRBjXxUVz5d1D03/AJk8VFc+XdQ9N/5lkpVBjTxUVz5d1D03/mTxUVz5d1D03/mWSkQY18VFc+XdQ9N/5k8VFc+XdQ9N/wCZZKVQY08VFc+XdQ9N/wCZPFRXPl3UPTf+ZZKRBjXxUVz5d1D03/mTxUVz5d1D03/mWSlUGNPFRXPl3UPTf+ZPFRXPl3UPTf8AmWSkQY18VFc+XdQ9N/5k8VFc+XdQ9N/5lkpVBjTxUVz5d1D03/mTxUVz5d1D03/mWSkQY18VFc+XdQ9N/wCZPFRXPl3UPTf+ZZKVQY08VFc+XdQ9N/5k8VFc+XdQ9N/5lkpEGNfFRXPl3UPTf+ZPFRXPl3UPTf8AmWSlUGNPFRXPl3UPTf8AmTxUVz5d1D03/mWSkQY18VFc+XdQ9N/5k8VFc+XdQ9N/5lkpVBjTxUVz5d1D03/mTxUVz5d1D03/AJlkpEGNfFRXPl3UPTf+ZPFRXPl3UPTf+ZZKVQY18VNb+XM/n/Sf+ZejtG0Z23GxWzldmKh0gA/auJx9GSV6ZEHzbAbDGIeGlc2ggYJyVVUEREQVQohzhBgjab011EvvwSq2m0tJzFQt+fizT4c3FaxpDgwDBdw/dK6llX21d079nWyTnge+EAcPsWxA3y475w3qXNmDkceaFa6d9dtQDybPtnPWe+ED8EFW21f3rPtk/RUIH4LY3A7Ex5kWtU57TzaY1C1DtG4L/odEkqdbceNGJl52E9zt8N6hx/dW1Ac/iCzkMjj1rk9oIwcrieeMkdmERyw4ty04JXia7p7VaxUok9BuyblWvHCHDc4AfYV7dmMcFyQY08VFc+XdQ9N/5k8VFc+XdQ9N/wCZZKRBjXxUVz5d1D03/mTxUVz5d1D03/mWSlUGNPFRXPl3UPTf+ZPFRXPl3UPTf+ZZKRBjXxUVz5d1D03/AJk8VFc+XdQ9N/5lkpVBjTxUVz5d1D03/mTxUVz5d1D03/mWSkQY18VFc+XdQ9N/5k8VFc+XdQ9N/wCZZKVQY08VFc+XdQ9N/wCZPFRXPl3UPTf+ZZKRBjXxUVz5d1D03/mTxUVz5d1D03/mWSlUGNPFRXPl3UPTf+ZPFRXPl3UPTf8AmWSkQY18VFc+XdQ9N/5k8VFc+XdQ9N/5lkpVBjTxUVz5d1D03/mTxUVz5d1D03/mWSkQY18VFc+XdQ9N/wCZPFRXPl3UPTf+ZZKVQY08VFc+XdQ9N/5k8VFc+XdQ9N/5lkpEGNfFRXPl3UPTf+ZPFRXPl3UPTf8AmWSlUGNPFRXPl3UPTf8AmTxUVz5d1D03/mWSkQY18VFc+XdQ9N/5k8VFc+XdQ9N/5lkpVBjTxUVz5d1D03/mTxUVz5d1D03/AJlkpEGNfFRXPl3UPTf+ZPFRXPl3UPTf+ZZKVQY08VFc+XdQ9N/5k8VFc+XdQ9N/5lkpEGPqbprWpGehTUW856OyGcmG5z8O/wDUvfMbu4HXjGVzVQRERBVEVQRFVEBERARVRAREQEVUQMBAADkBEQAMckVUQMDsTdHLHDmiICKqICIiAiqiAiIgIqogIiICKqICIiAiqiAiIgIqogIiICKqICIiAiqiAiIgIqogIiICKqIGBnOOKYGc4REBMccqqIG6OwIiICKqICIiAiqiAiIgIqogIiICKqICIiAiqiAiIgIqogIiICKqICIiAiqiAiIgIqogIiICKqICIiAiqiAQDzCckRARVRATA7ERA5ckVUQEREBFVEBERARVRAREQEVUQEREBFVEBERARVRAREQEVUQEREBFVEBERARVRAREQEVUQEREBFVEBERARVRBVE61UERO1ByQVROtVBETtQckFUTrVQRE7UHJBVE61UERO1ByQVROtVBETtQckFUTrVQRE7UHJBVE61UERO1ByQVROtVBETtQckFUTrVQRE7UHJBVE61UERO1ByQVROtVBETtQckFUTrVQRE7UHJBVE61UERO1ByQVROtVBETtQckFUTrVQRE7UHJBVE61UERO1ByQVROtVBETtQckFUTrVQRE7UHJBVE61UERO1ByQVROtVBETtQckFUTrVQRE7UHJBVE61UERO1ByQVROtVBETtQckFUTrVQRE7UHJBVE61UERO1ByQVROtVBETtQckFUTrVQRE7UHJBVE61UERO1ByQVROtVBETtQckFUTrVQRE7UHJBVE61UERO1ByQVROtVBETtQckFUTrVQRE7UHJBVE61UERO1ByQVROtVBETtQckFUTrVQRE7UHJBVE61UERO1ByQVROtVBETtQckFUTrVQf/2Q==", null, 1, 3, 3L, null },
                    { new Guid("63b5d2df-6b4a-413c-85e4-202f502018fd"), "My name * Yernur.", "*", 9, 0, 1L, "is" },
                    { new Guid("7499f3a0-3fab-485a-921e-4a13c9efbc3e"), "You are Russian", null, 2, 1, 2L, "You are not Russian" },
                    { new Guid("7e31392b-ace0-415a-8d5e-6a1c077b4163"), "They are in the office", null, 3, 1, 2L, "They are not in the office" },
                    { new Guid("7e93dc75-fdc8-4f97-b375-123702931519"), "They * at work.", "*", 4, 0, 1L, "are" },
                    { new Guid("8759ee76-9669-4cc7-a1cc-a844158167bd"), "I * at school.", "*", 1, 0, 1L, "am" },
                    { new Guid("a081291f-9a40-4af9-bd87-4d9570d73cda"), "You * beautiful.", "*", 2, 0, 1L, "are" },
                    { new Guid("a756eebb-f33e-41f1-8203-8f7d4609ae8b"), "We * in Kazakhstan ", "*", 8, 0, 1L, "are" },
                    { new Guid("b96670b3-6af1-4fe1-8167-8d66035662ac"), "We * in the office.", "*", 3, 0, 1L, "are" },
                    { new Guid("ba7b9dff-11b0-4404-8d55-54be10c14a17"), "He is from Turkey", null, 4, 1, 2L, "He is not from Turkey" },
                    { new Guid("ec488aca-176f-499a-9cf6-bfb10a65723c"), "We are from Egypt", null, 5, 1, 2L, "We are not from Egypt" }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Units",
                columns: new[] { "Id", "LessonId", "SortOrder", "Title" },
                values: new object[] { 8L, 2L, 3, "Present Continuous. Video" });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "UnitId" },
                values: new object[] { new Guid("a4718013-851e-4144-a1fe-e07fda39f5c9"), "Present Continuous Video", 1, 8L });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "Type", "UnitId" },
                values: new object[,]
                {
                    { new Guid("c2bb58f8-cc80-4b1c-806c-0b20d6331672"), "CM6ZCrms5qw", 2, 1, 8L },
                    { new Guid("cb6f7aa9-9c3d-4658-bd42-2a8214ee8c83"), "rVQ1K3pgbco", 2, 1, 8L }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Units",
                columns: new[] { "Id", "LessonId", "SortOrder", "Title" },
                values: new object[,]
                {
                    { 9L, 6L, 1, "Present Continuous. Video" },
                    { 10L, 7L, 1, "Past Simple to be (was / were). Video" },
                    { 11L, 7L, 2, "Past Simple (did). Video" }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "Type", "UnitId" },
                values: new object[] { new Guid("49db8817-019e-4d20-b198-d8f88003d6bb"), "C58y_VX6iuk", 2, 1, 10L });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "UnitId" },
                values: new object[,]
                {
                    { new Guid("9c1d7251-c254-4095-b271-a572805a8de3"), "Present Simple or Present Continuous video", 1, 9L },
                    { new Guid("a844fbf7-d8b9-48e1-863d-7667910ed418"), "Past Simple to be (was / were).", 1, 10L },
                    { new Guid("bcf5d70e-f6e0-43f1-a2fe-643e50b4c875"), "Past Simple (did)", 1, 11L }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "Type", "UnitId" },
                values: new object[] { new Guid("ed3d3513-eca3-4afe-a95a-05ecf774d501"), "wOLckypfQWY", 2, 1, 11L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("06043623-1d40-4c4e-a236-7223fc38fc05"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("079d9af6-fd5b-4c0c-aef8-74b938474881"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("0814c7e3-0a29-4d78-9990-0d08d3b5ba20"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("10edac5d-e531-409b-9b9c-209f6a3be7e0"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("19ab0d39-5d56-40dc-9e1e-043c1e0f707a"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("1a0eb7ff-6853-497d-a686-388ff8cf0c93"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("3c767fcc-c226-437d-9bf1-aaaca1846ec1"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("3ece1f60-e71f-487c-9b00-dd38158ec4ce"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("3effdea4-bdab-4d80-98fe-bec535ebf751"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("49752f6f-4ded-4e54-a2c6-9a6a885e8a73"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("49db8817-019e-4d20-b198-d8f88003d6bb"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("4e512d6a-db5c-4f6f-ae75-d8a7b04929a3"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("51619e43-d6f2-448c-aec8-33cc2b09080b"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("5f2e31b8-d5d1-48a3-a949-11d399acc51f"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("6219a07b-7397-455b-bae0-29e077c52a3e"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("7181d80b-70c5-45ea-8102-99f180f30172"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("7be67aae-f92a-473b-b6df-5cf4fac85e46"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("7cd59d4e-f66b-49a3-bd51-0119501bbe4d"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("81d356cf-cfc4-4c27-b0a7-eb56569f2333"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("8d29ac06-f9e0-4291-b50a-3e90cfef8090"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("9c1d7251-c254-4095-b271-a572805a8de3"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("a4718013-851e-4144-a1fe-e07fda39f5c9"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("a844fbf7-d8b9-48e1-863d-7667910ed418"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("b0a904f6-cbee-44cd-8fcc-f275735431df"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("b4645b8f-f6ea-4f10-870e-db9145e9bda9"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("bcf5d70e-f6e0-43f1-a2fe-643e50b4c875"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("c26c77c4-9d51-4c50-abcd-0cdca35bdd48"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("c2bb58f8-cc80-4b1c-806c-0b20d6331672"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("c3841649-1898-46f4-826f-446f1f8e00e8"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("cb6f7aa9-9c3d-4658-bd42-2a8214ee8c83"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("cf8a9b97-368b-4b72-88e2-53391c094554"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("d217091a-ce50-45e7-a7cf-bd2926d1507f"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("dc39971f-e037-4cd6-8e32-9a0dba309d93"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("e90a4020-7faf-4fd3-a50c-f044a8bcbad7"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("ed3d3513-eca3-4afe-a95a-05ecf774d501"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("fb11249a-3079-4260-b115-5e96778e37b6"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("08a838cd-93ab-4497-a87b-481f7125e21c"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("1ad48af1-927a-414b-b0db-777bca7a8da1"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("28e7095b-a059-4744-b842-c3f95c871b3d"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("2e2b3aaa-490c-4c94-89af-b3cfd12ea065"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("3bed01dd-80be-4dd4-85d9-940eea058cc3"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("3e5834bb-a728-471d-844a-c2d6e018ef3b"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("42aae30a-7478-441e-8d25-c24ed7c41f66"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("44eb7539-315a-4539-838e-1fa631dc6a06"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("45a69ef7-7903-45b7-9295-5fc776fb8276"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("59dea1c8-e763-4e12-9ed7-7c73a28b0c73"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("5c61c923-5afc-4d3a-a58d-1f1fc28ba830"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("63b5d2df-6b4a-413c-85e4-202f502018fd"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("7499f3a0-3fab-485a-921e-4a13c9efbc3e"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("7e31392b-ace0-415a-8d5e-6a1c077b4163"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("7e93dc75-fdc8-4f97-b375-123702931519"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("8759ee76-9669-4cc7-a1cc-a844158167bd"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("a081291f-9a40-4af9-bd87-4d9570d73cda"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("a756eebb-f33e-41f1-8203-8f7d4609ae8b"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("b96670b3-6af1-4fe1-8167-8d66035662ac"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("ba7b9dff-11b0-4404-8d55-54be10c14a17"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "UnitTaskSource",
                keyColumn: "Id",
                keyValue: new Guid("ec488aca-176f-499a-9cf6-bfb10a65723c"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Units",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Units",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Units",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Units",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "application",
                table: "UnitTaskSource",
                type: "character varying(4096)",
                maxLength: 4096,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "UnitId" },
                values: new object[,]
                {
                    { new Guid("04b56578-b6d6-4a64-a16e-45b316edae90"), "Здесь могут стоять ключевые слова такие как: now/ right now/ at the momen", 2, 3L },
                    { new Guid("05db3ef8-3ef0-425b-814b-e12ba941af9d"), "Конструкция предложений в present simple \r\n\r\n    Subject + Verb\r\n    You like ice cream\r\n\r\n    He / She / It + Verb(s)\r\n    He likes ice cream", 3, 2L }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "Type", "UnitId" },
                values: new object[] { new Guid("0718f39b-125b-4bbe-96d2-362ac1a9f272"), "b-WOj931zSU", 2, 1, 5L });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "UnitId" },
                values: new object[,]
                {
                    { new Guid("22cc46e7-20c5-4b80-b73c-f61769a9e0f8"), "Например: \r\n	I am meeting with Daniel tomorrow. \r\n	Здесь в этом предложении соответсвенно показано, что встреча запланирована!", 6, 4L },
                    { new Guid("2e4647ae-6101-490f-8cd1-e8e49b830907"), " Единственное число\r\n    I am a doctor. Я являюсь доктором.\r\n    He is clever. Он является умным.\r\n    She is at home. Она находится дома.\r\n    It is an interesting book. Это есть интересная книга.\r\n    You are a smart guy. Ты являешься сообразительным парнем.", 4, 1L },
                    { new Guid("357da888-2f29-4e4a-bb31-aec88bd0fac1"), "My Family - English Vocabulary Lesson", 1, 7L },
                    { new Guid("3a6b4ed8-3709-48ef-b694-c2faee88902a"), "Present continuous - также мы можем использовать когда описываем, \r\nкакое то действие или же фото, так как описание происходит сейчас, \r\nмы должны соответсвенно использовать время «present continuous»", 1, 4L },
                    { new Guid("3c042ca2-f150-488d-a9af-c1738009dcb5"), "Например: \r\n	She is wearing a black dress.\r\n	She is smiling in the picture", 2, 4L },
                    { new Guid("3fec39d3-5209-4ffd-a935-5d617a4621b0"), " Множественное число \r\n    We are good singers. Мы являемся хорошими певцами. \r\n    You are wonderful listeners. Вы являетесь отличными слушателями. \r\n    They are in the room. Они находятся в комнате.", 5, 1L },
                    { new Guid("5908ba4d-8971-4b33-826e-23e4ab41b6ca"), "I go to work/university every day \r\n\r\nТакже оно употребляется, когда мы говорим про факты в настоящем.\r\n\r\nI like pizza/sushi", 2, 2L }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "Type", "UnitId" },
                values: new object[] { new Guid("5a5b0abe-f106-494c-a279-e0249578e74d"), "kZhCip4wCKM", 2, 1, 6L });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "UnitId" },
                values: new object[] { new Guid("659e8555-bc91-495e-95e8-6e3473f6657f"), "Present simple - это простое настоящее время, оно употребляется когда говорим о действиях которые мы делаем регулярно, каждый или часто. Одним словом это действия который не заканчивается.", 1, 2L });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "Type", "UnitId" },
                values: new object[] { new Guid("66fb2e24-ce94-441f-80a9-7fc5515acc86"), "YlqRjy_Z3GQ", 7, 1, 1L });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "UnitId" },
                values: new object[,]
                {
                    { new Guid("69f1408b-191e-4654-a036-08718f9ae31f"), "Таким образом мы описали ее внешность, и ее действия", 3, 4L },
                    { new Guid("8098e799-1d4f-444e-8a6d-a3be6cbca208"), "Чтобы сделать вопросительное предложение \r\n\r\n    Do/ Does + Subject + Verb \r\n\r\n    Do you go to university?\r\n    Yes, I do \r\n    No, I don’t \r\n\r\n    Does he go swimming? \r\n    Yes, he does\r\n    No, he doesn’t", 5, 2L },
                    { new Guid("88c0ea7c-32ff-40ed-839e-0f7e3b16ae3f"), "My Family", 1, 5L },
                    { new Guid("9324d995-ffb2-4cab-8b4e-1a987d56303e"), "Так же посмотрите это видео!", 6, 1L },
                    { new Guid("956769d4-bfda-445f-a34b-f2354c9232c1"), "Конструкция предложения\r\n\r\n	1.	Формула: I am + глагол-ing.\r\n		Пример: I am singing - Я пою.\r\n\r\n	2.	Формула: He/She/It is + глагол-ing.\r\n		Примеры: \r\n			He is smiling — Он улыбается.\r\n			She is dancing — Она танцует.\r\n			It is shining — Оно светит.\r\n\r\n	3.	Формула: We/You/They are + глагол-ing.\r\n		Примеры: \r\n			We are listening — Мы слушаем.\r\n			You are reading — Вы читаете.\r\n			They are swimming — Они плавают.\r\n\r\n	1.	Глагол заканчивается на —е \r\n		Правило: последняя буква отбрасывается \r\n		Пример: make — making (делать)\r\n\r\n	2.	Глагол оканчивается на —ie\r\n		Правило: -ie заменяется на -y\r\n		Пример: lie — lying (лежать)\r\n\r\n	3.	Односложный глагол, оканчивающийся на гласную с согласной\r\n		Правило: последняя согласная удваивается\r\n		Пример: get — getting (получать)", 3, 3L },
                    { new Guid("9fc028bb-7c88-4729-914b-da448bf9a2a4"), "Следующий случай употребление времени «present continuous» - это когда говорим о запланированных и обязательно происходящих событий в ближайшем будущем", 4, 4L },
                    { new Guid("b87f1c47-5fa3-434b-bc05-e37665e08fcd"), "Как переводится to be и когда используется?\r\n\r\n    'Be' мы используем в 3 случаях, когда мы хотим сказать:\r\n        Кто/что кем/чем является (она медсестра);\r\n        Кто/что каким является (мой кот серый);\r\n        Кто/что где находится (папа на работе).\r\n\r\n    То есть если мы хотим описать местоположение чего-либо, состояние чего-либо или то, чем является этот предмет/человек, то мы используем глагол to be.", 1, 1L },
                    { new Guid("c0607a9b-4840-460d-9259-96f76de69d3f"), "Present continuous - настоящее длительное время, оно употребляется когда говорим о действиях которые происходит сейчас, на данный момент времени.", 1, 3L },
                    { new Guid("c160e770-7c36-46ac-a38f-44c3434d896d"), "Слова-маркеры: \r\n\r\n	This/next week (на этой/следующей неделе)\r\n	Tonight (вечером)\r\n	Today (сегодня)\r\n	Tomorrow (завтра)\r\n	This/next year (в этом/следующем году)\r\n	This/next weekend (в эти/следующие выходные).", 5, 4L },
                    { new Guid("c520930e-a413-4a2f-87d8-39339a3ffb45"), "Давайте рассмотрим примеры употребления. ", 3, 1L },
                    { new Guid("e661631f-71f3-4fbe-87b7-2cd824395c65"), "Важно знать, как глагол to be меняется в зависимости от того, кто производит действие. Это можете быть вы, ваш друг или группа людей. В настоящем времени этот глагол имеет три формы: am, is, are. ", 2, 1L },
                    { new Guid("eee4388d-57e5-4704-9aaa-a40a1cd47caa"), "Отрицательные предложения\r\n\r\n	1.	Формула: I am not + глагол-ing.\r\n		Пример: I am not singing - Я не пою.\r\n\r\n	2.	Формула: He/She/It is not + глагол-ing\r\n		Примеры:\r\n			He is not smiling - Он не улыбается. \r\n			She is not dancing - Она не танцует.\r\n			It is not shining - Оно не светит.\r\n\r\n	3.	Формула: We/You/They are not + глагол-ing.\r\n		Примеры: \r\n			We are not listening - Мы не слушаем.\r\n			You are not reading - Вы не читаете.\r\n			They are not swimming - Они не плавают.", 4, 3L },
                    { new Guid("f723b9c3-5eac-4aa8-8458-f2b6fe27a2b0"), "My Family - Learning English Speaking", 1, 6L }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "Type", "UnitId" },
                values: new object[] { new Guid("f915ddb7-e335-441d-ad60-f5ad649197cc"), "uVYP8U2I8NA", 2, 1, 7L });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "UnitId" },
                values: new object[] { new Guid("fcb87c5e-568e-45d8-bfc1-a7371eaf8730"), "В отрицательных предложениях\r\n\r\n    do + not - don’t\r\n    does + not - doesn’t\r\n\r\n    Subject + don’t/doesn’t + Verb\r\n\r\n    I don’t like ice cream \r\n    She doesn’t go to school", 4, 2L });

            migrationBuilder.InsertData(
                schema: "application",
                table: "UnitTaskSource",
                columns: new[] { "Id", "Content", "Key", "SortOrder", "Type", "UnitTaskId", "Value" },
                values: new object[,]
                {
                    { new Guid("08890b74-4a0e-417f-a606-3342cd04769a"), "We are from Egypt", null, 5, 1, 2L, "We are not from Egypt" },
                    { new Guid("0e0584d5-275c-4d2a-93ca-96e9f86a8126"), "They * at work.", "*", 4, 0, 1L, "are" },
                    { new Guid("10640ec1-33d6-4f8d-b451-bf6cb080062c"), "He is Kazakh", null, 10, 1, 2L, "He is not Kazakh" },
                    { new Guid("10c2bb0c-1fcd-469f-8e31-41de53118b88"), "They are Brazilian", null, 9, 1, 2L, "They are not Brazilian" },
                    { new Guid("38344196-e30f-430f-9516-4522542b342a"), "She * late for work.", "*", 6, 0, 1L, "is" },
                    { new Guid("39732ac8-44cf-4e9d-a77a-7e9c7f5ac48f"), "I * at school.", "*", 1, 0, 1L, "am" },
                    { new Guid("3a5b8cba-e95f-4b4f-a6d0-e5ab491d796b"), "We * in the office.", "*", 3, 0, 1L, "are" },
                    { new Guid("44328dd9-f81a-4318-a558-552ac63082c9"), "I am British", null, 1, 1, 2L, "I am not British" },
                    { new Guid("4b7ca567-febd-4916-b7c5-5fb2cbca3f3b"), "He * early.", "*", 5, 0, 1L, "is" },
                    { new Guid("68df48c7-537f-4283-8e42-cb85f40feb44"), "It is from China", null, 7, 1, 2L, "It is not from China" },
                    { new Guid("6b51537c-ebee-45c6-8369-a8b3b0e0e920"), "We * in Kazakhstan ", "*", 8, 0, 1L, "are" },
                    { new Guid("72799524-bd0c-46ec-badd-5a57fa633327"), "You * beautiful.", "*", 2, 0, 1L, "are" },
                    { new Guid("784b5e0d-b852-4a0f-8415-008ffb7a631e"), "She is in America", null, 6, 1, 2L, "She is not in America" },
                    { new Guid("7caddc31-49eb-4caa-83ce-bc3466d34ca7"), "He is from Turkey", null, 4, 1, 2L, "He is not from Turkey" },
                    { new Guid("7cec4f8c-47df-4d05-b9c2-863e24a426f9"), "You are Russian", null, 2, 1, 2L, "You are not Russian" },
                    { new Guid("8ec15ed8-c520-4bd8-a0bd-e7033d5b2bb0"), "You are French", null, 8, 1, 2L, "You are not French" },
                    { new Guid("942b66e9-893e-4efe-9629-5f4fd13c9481"), "You * Kazakh.", "*", 7, 0, 1L, "are" },
                    { new Guid("ab2a43e7-fa47-4956-90db-8b68fdc39933"), "My name * Yernur.", "*", 9, 0, 1L, "is" },
                    { new Guid("c7887c71-eb34-4340-96ad-adf9b532ca16"), "It * my school. ", "*", 10, 0, 1L, "is" },
                    { new Guid("e4944504-eb23-463d-9594-404ec64e3e83"), "They are in the office", null, 3, 1, 2L, "They are not in the office" }
                });
        }
    }
}
