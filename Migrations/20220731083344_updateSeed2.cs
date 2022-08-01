using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SerpantWebApp.Migrations
{
    public partial class updateSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "Description", "IPAddress", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Admin", "Admin" },
                    { "c7b013f0-5201-4317-abd8-c211f91b7330", "2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Teacher", "Teacher" },
                    { "rewefac1-c53d-434f-a5gz-pet32gg95711", "3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Student", "Student" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12884843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5215bd11-52ba-4d40-a4f0-4cf1f7d54f9d", "AQAAAAEAACcQAAAAEM+gW8p1caDuEUreuATJJA5K5FEiFRQomNoZOiSG6efcWOxxQS0a5YsEr3QZIao+Hg==", "e5a2bce7-2f83-489d-8ba5-d02cb38d8b19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c15eeds50-9053-4323-53de23-dw32435f33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd0d459e-6fe7-4734-86aa-0b44654766d3", "AQAAAAEAACcQAAAAEPc/lRowBSTLB17DABySne79lUPjr0r05sYOYL1u316pmHTYdyK+61yWhx/h2eh4Xg==", "d96948f6-184f-4622-8756-2205e45042ac" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "rtweetwe1-3gre-yop2-verbm-rwerreww433", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d2b6d620-f1ab-446b-9901-db45facacc72", "alexander@gmail.com", true, null, false, null, "alexander@gmail.com", "alexander@gmail.com", "AQAAAAEAACcQAAAAEER1NfIxUyV4eweR05c/lvx8jqB6WjiF6IGUD+CF+NvNFCtWZFGYI+QoxJfH1BYatQ==", null, false, "cba31498-7be0-4110-a4ff-528eb267ff6f", false, "alexander@gmail.com" },
                    { "rrtetrere-f32g-s42q-f3232f-ecdsvd32433", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "109d6cd7-a041-43b7-b806-70724720bdda", "mike@gmail.com", true, null, false, null, "mike@gmail.com", "mike@gmail.com", "AQAAAAEAACcQAAAAEACHUwSJykglulm7YZ3KcJHVh7zPRHTx1lK3ysa+J4m5Nail7Ck8TmOIiWELpTN0mw==", null, false, "f5e61ff7-0165-4bb0-a1b8-89dbf9dc74a0", false, "mike@gmail.com" },
                    { "effin2343-3fzz-tg3f-2fsa3-eccafwee32433", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "43eb2336-78ae-4b12-9be0-da07fc026cdb", "bob@gmail.com", true, null, false, null, "bob@gmail.com", "bob@gmail.com", "AQAAAAEAACcQAAAAEMr8LnPfNQWuib79glFVnPJPH8A6sNvtfk4kaLCxxWzWHmDXRS39cgKhp7GDXHj7ug==", null, false, "45a95667-7841-47bd-929e-b5dce6a65898", false, "bob@gmail.com" },
                    { "34dfwef33-y525f-h432-r32-evvvreze32433", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "143a39dd-164a-49cd-9e30-d7130b9a3974", "hansel@gmail.com", true, null, false, null, "hansel@gmail.com", "hansel@gmail.com", "AQAAAAEAACcQAAAAEKFxGIxZiWSaeJ5YekGnTb+yHH4uciIvJXLKvy7dCVoHFPL3Aa703aG8l75AmA5j6Q==", null, false, "92926d45-d6dc-47d1-bdf5-03f960c811a6", false, "hansel@gmail.com" },
                    { "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "424294d2-4493-49dd-a916-50529cbc58a5", "grethel@gmail.com", true, null, false, null, "grethel@gmail.com", "grethel@gmail.com", "AQAAAAEAACcQAAAAEBuxJ6PAwuXbdYDYgtKDE2eh/LqEl8NObzSSi5unOvDH8Mqt8w9lOvlVB1tfjAQ5vg==", null, false, "f781c034-59cc-4f25-b074-5dbe749dc940", false, "grethel@gmail.com" },
                    { "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e8244161-5001-4e03-8a90-6a2ce3171558", "saiful@gmail.com", true, null, false, null, "saiful@gmail.com", "saiful@gmail.com", "AQAAAAEAACcQAAAAEFBZAaYqp4f2zGtcjnJIzL9Y2kUMJClDR/5y+FEQ/v2upAxe81KGacgUvKuWZWi9TQ==", null, false, "89610378-c06e-4f7f-8b1d-07f97bf8238e", false, "saiful@gmail.com" },
                    { "vre4yw-h563-g34y45h-fewf32-pqpfowef3", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1efac528-921b-43e5-9f9f-9eb9b1ad54ad", "charis@gmail.com", true, null, false, null, "charis@gmail.com", "charis@gmail.com", "AQAAAAEAACcQAAAAEBLdT6w4iK5K60fRNG9skjxc0g8/4OQ/wHlBVIWAJ5hGQSeJzRWo6hkqU73EQFOAxQ==", null, false, "a95d85d9-ada4-4158-a36e-ef5ef8fb1cb5", false, "charis@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "rewefac1-c53d-434f-a5gz-pet32gg95711");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34dfwef33-y525f-h432-r32-evvvreze32433");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "effin2343-3fzz-tg3f-2fsa3-eccafwee32433");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rrtetrere-f32g-s42q-f3232f-ecdsvd32433");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rtweetwe1-3gre-yop2-verbm-rwerreww433");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vre4yw-h563-g34y45h-fewf32-pqpfowef3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12884843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5ebe830-9007-4411-b514-f1d9420592b3", "AQAAAAEAACcQAAAAENJbzoUslBdrAeio04kxJXhVgkY/FsmJUgegKzuGgW07K3/4xPIMxSwkkPg7lGB5pQ==", "65854c53-6ae4-4aa3-9204-3573c955826b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c15eeds50-9053-4323-53de23-dw32435f33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bac95aa2-8684-452a-a8df-ff7587cf8c4c", "AQAAAAEAACcQAAAAENUOxFpfkWc1s2kIJHGyKfRYOhwGh7grW2HxTc7auHExwuA1Wp7FB8hytilZYYd2Yg==", "34e1e13d-5f83-4a50-bdef-e31fe06c247c" });
        }
    }
}
