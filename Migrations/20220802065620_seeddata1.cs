using Microsoft.EntityFrameworkCore.Migrations;

namespace SerpantWebApp.Migrations
{
    public partial class seeddata1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34dfwef33-y525f-h432-r32-evvvreze32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6660634-3b23-40ca-8291-fae2954fcc7f", "AQAAAAEAACcQAAAAEHAjRZ5DGTbf6DI4+fI4pVNF8M1dqx2hrm5mhz9AVwaQ4a+GOAZcYjmL3COeTWeXFQ==", "b292791c-5e21-4af2-918e-99d779308bd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12884843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df41e224-fac7-4fc3-bbd4-dc96f85c01db", "AQAAAAEAACcQAAAAEM9oqxmD5DndKw66J5AFcHU6XCrcejgMn1Pi0phLwYSeRF5A3nGMidfn1N5OW/M+7A==", "7821d3d7-97c3-47f1-a7f6-2703b32e7a00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c15eeds50-9053-4323-53de23-dw32435f33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a9c38eb-e21e-4fe8-8362-8f1b8f0c1f9b", "AQAAAAEAACcQAAAAEBmiobhCug/fvV4qT7dRuFbPmsxScEUCt13OfVmuhIiJQGqAvAJOX3qP5sndBvsQZg==", "37e4a092-6b82-4792-b3c3-fed7159213e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "effin2343-3fzz-tg3f-2fsa3-eccafwee32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0638e68-cc90-40ad-8439-4081c6c014af", "AQAAAAEAACcQAAAAEL1hBI17G3lmBqhT+VSQQl5gEMpMqMz6I9h+LPje2Q9AEbv7/n2iX1pUSDPHJKSN6w==", "423960d1-1e7b-49fe-af20-a8cba3bbab26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d8c2796-b43f-481b-81f2-2821f5384366", "AQAAAAEAACcQAAAAEF+rUxBJdASrrO1fEIOvgY19ioJNhG7ByAsW0U/N9fRs3Ckq5cWzQgK91LuLxRvaWg==", "61b5e74f-66c0-40d9-b4b9-929392a0bb9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rrtetrere-f32g-s42q-f3232f-ecdsvd32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ec0340e-f05c-467d-85d7-4bda5acbf6d4", "AQAAAAEAACcQAAAAEP8fawEMFa7GqwE6Jr5Ab3l/MWcSvl1uzauAwKhp6vqt17zZwfKCyYH8j+LpZjm9yw==", "16962d89-43f7-47c0-b843-d2bb5c7846f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rtweetwe1-3gre-yop2-verbm-rwerreww433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59bd66cd-2c24-4650-83ef-209792070a34", "AQAAAAEAACcQAAAAEJ+TWrYANjlHR5PcxoG/ocxaBvCM9IWMyF9U/+H3kl13JV1+Nq+CM2xeIXmJM/pkNA==", "d8285404-f0c8-458a-9c94-f000dcf54367" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vre4yw-h563-g34y45h-fewf32-pqpfowef3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "857e0adb-2161-43e0-a981-08be87e0fbe3", "AQAAAAEAACcQAAAAEL2DXygd1o2qGbG0FRTT0qxH8w9iPEmGF5VfN8q6flUyV2Kci9NJWizr7fnYup9Uuw==", "908128bf-e71b-4681-a6d7-8ae203840174" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0df49866-24eb-4566-a506-c32bc6effc43", "AQAAAAEAACcQAAAAEIqSNuYTr7slQh5t1NRdP6wEmb9Jv53KrHRw3Nysy3B2cRcdsfWtnNAkUUv/DLnMEA==", "f6f5de24-8de9-4b2a-b98a-901779d6c282" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseID", "Credits", "Title" },
                values: new object[] { 2, 4, "Software Secure Development" });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "LessonSessionID",
                keyValue: 2,
                column: "CourseID",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "LessonSessionID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34dfwef33-y525f-h432-r32-evvvreze32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c2936d3-5eec-426d-ac15-2930f8050618", "AQAAAAEAACcQAAAAEPJblVKM/hZ/2UDzVebNzn1q8mAMC/5/igdk/bRZe7KwrQVTkuSNUAJjLVZDJauqLQ==", "27406111-bc4a-4c2a-9070-b0282d990c5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12884843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24930bb6-301c-4e10-b6a6-6c6d953df33d", "AQAAAAEAACcQAAAAENwZSFVbX8wffvaX3wthyPMY7bCSL5lxl2Y6APpeVFdjCSsVmwokgGxZSzEO05G5ig==", "2115fab3-cbbf-4e49-af7f-fa86c2385e6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c15eeds50-9053-4323-53de23-dw32435f33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b0c8804-d6da-45ff-907d-d8279cd31e60", "AQAAAAEAACcQAAAAEOu2AExfe9qK+BR9Jb/SDr37EW9+8FNxX118yRzE6TxSsC9QV4thHaPhVdMOOEvmTw==", "d2e61f7c-885a-43fe-91f8-572cdafd76af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "effin2343-3fzz-tg3f-2fsa3-eccafwee32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0048715b-2eac-4ab7-ab9d-8e2adc93716c", "AQAAAAEAACcQAAAAEFJK8tKphTq6r4S78x6nBl5jCf5sRwd80bW+YbjScwaDgAAViygy7qdVnbEeIMW0zg==", "d82b586b-6c13-4810-8afc-1d54b027be7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a32c9a26-3965-4c30-aa04-1ce391755ef3", "AQAAAAEAACcQAAAAEM6WkCpMrZH3vuX4YclyuLWu/HN9mTq46fH8Cc5opV8Rpx3gxcPiVGoOBBMxfjMEMw==", "f6dfc088-2429-4bcb-8a7b-c70a4960ef79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rrtetrere-f32g-s42q-f3232f-ecdsvd32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9581698b-521c-4323-b517-0185745dfce3", "AQAAAAEAACcQAAAAEM5lW4fwBAgN+Rn5oeEqbWjnx1RvjCTaDkSf1sl6i16+Bu6k5t+hZiBhP73e+Wxecg==", "2afe6426-c457-4971-bd44-f5ec2ea3ede0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rtweetwe1-3gre-yop2-verbm-rwerreww433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dd6adff-891f-4229-acdf-b46c87de9119", "AQAAAAEAACcQAAAAEIfA5g9y7b5xw4DhqsCw02CijJnAd3Pd0285UuN7JDbF7etA25wCrehEmP8GZRSKaw==", "026ef365-f164-4c88-bafc-859be005f84e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vre4yw-h563-g34y45h-fewf32-pqpfowef3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5dfbf16c-6bea-4007-a229-ffd44b0f72bb", "AQAAAAEAACcQAAAAELes6Mu86BOvO1YWo3q5qNAeOLgVV/NGPuUsvsDgBBBLjYe6Ujd6Jr8ZaVJsblRRaw==", "3e4db385-7252-4c03-b3b0-5e7ab9b17876" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73db3d6f-e0d6-4be4-8a8a-7723aac89b9b", "AQAAAAEAACcQAAAAEPfaSlMERWArv02vVYEQU72lXEEOfGhJdHF3kwA8zktiluufDQn5vvYgTnou5aJV9A==", "c7881e24-8327-4a9f-9b12-87af72305bd5" });

            migrationBuilder.InsertData(
                table: "Attendance",
                columns: new[] { "LessonSessionID", "CourseID", "Presence", "StudentID", "TeacherID" },
                values: new object[] { 2, 1, false, 5, 1 });
        }
    }
}
