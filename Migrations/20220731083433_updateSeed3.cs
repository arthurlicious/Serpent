using Microsoft.EntityFrameworkCore.Migrations;

namespace SerpantWebApp.Migrations
{
    public partial class updateSeed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "c15eeds50-9053-4323-53de23-dw32435f33", "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { "b74ddd14-6340-4840-95c2-db12884843e5", "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { "rrtetrere-f32g-s42q-f3232f-ecdsvd32433", "rewefac1-c53d-434f-a5gz-pet32gg95711" },
                    { "effin2343-3fzz-tg3f-2fsa3-eccafwee32433", "rewefac1-c53d-434f-a5gz-pet32gg95711" },
                    { "34dfwef33-y525f-h432-r32-evvvreze32433", "rewefac1-c53d-434f-a5gz-pet32gg95711" },
                    { "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423", "rewefac1-c53d-434f-a5gz-pet32gg95711" },
                    { "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife", "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { "vre4yw-h563-g34y45h-fewf32-pqpfowef3", "c7b013f0-5201-4317-abd8-c211f91b7330" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34dfwef33-y525f-h432-r32-evvvreze32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33051d10-52aa-495f-a80b-19b868ffc854", "AQAAAAEAACcQAAAAECqpdNkPVIBKauqjMTBzwvHlssTOmzcXJLTGo/pnFosXbyNVlF0VBb8YuZnRhZ0WVg==", "9264e859-93a9-422b-b5ae-f6f770c9dc3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12884843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9472c12-514d-417e-8d45-170485e37e6c", "AQAAAAEAACcQAAAAEMZqIj9iWQannfU2kj/eZiTxUexf8Uj1A6MdJILZ9sPdAHae10keWRGMW2HOKw0HDA==", "aaab0f59-7d7c-47c7-bdc6-99d7a3feabc4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c15eeds50-9053-4323-53de23-dw32435f33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50bf100b-cdca-4b5c-9d4f-aeb77d8f6024", "AQAAAAEAACcQAAAAEEvXBmxMjyRDU6+32kXsR16cgzOJWgghkblgQ2gou/7Na/Tu96eCaHw0h4WhigSNww==", "8d895806-d67a-4e39-a3c5-1a5772834393" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "effin2343-3fzz-tg3f-2fsa3-eccafwee32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63b43bcf-bbcd-47e5-ae67-8c1613083046", "AQAAAAEAACcQAAAAEP10ZkuF7v8f43T5rJYUdNhFxqZFp8HLwE7aO1o6rQ7MstQlPgDomGeb+rckNhukHw==", "4752c4b4-530f-4002-9ef4-042a2913f3df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9c615d6-35c9-4295-bbc6-ef6a9bae8b19", "AQAAAAEAACcQAAAAEGz0UJKZqCkPTovOZUB4xz+KptdPptr951OUib8PFF7WIhEmLAgHsrvsX0RkpG2+tg==", "848f51f6-e296-4459-80f1-164481b27838" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rrtetrere-f32g-s42q-f3232f-ecdsvd32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebb34ced-2957-4769-ae0a-4cef5ead5ffa", "AQAAAAEAACcQAAAAEOviw2j8kIDL4/2wS33WWHMQeaL0/iV5Y9SD4dpdE+ymcgn+n0OTbdbA7PMbIzG6nQ==", "48ebdb15-aa11-4546-ba3f-cbc2003d72e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rtweetwe1-3gre-yop2-verbm-rwerreww433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e0e98c6-b47e-437c-895e-53ec549dd6d6", "AQAAAAEAACcQAAAAEA3RVynSbyxhv5dF+F2qxogIY27SOlJTRMT/3jHrMmYDy1P7O9DAx9nKJniPYu4vZg==", "302fc2f3-7979-416d-9d26-44cd7ea47158" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vre4yw-h563-g34y45h-fewf32-pqpfowef3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4e3d985-fa87-4afa-b012-67560b4334d4", "AQAAAAEAACcQAAAAEPrjl+1IcAU5tDLaJyw/GF630HOeGjWlkosFcXyKBDmELuwVXQM1TIynoZy2wYR86A==", "1f0684d9-7c79-40f2-96c4-dd3ef3c36bde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47938270-090a-415d-be51-a86ccd70870a", "AQAAAAEAACcQAAAAEHZpeYuM0gGIzDn81OK1i29bh8ObHESI7khisiCo34Oj73lwTwTrFDxlXRv7bbhb9A==", "00fb5ed7-9b7e-4ef8-a45b-cd0694feed90" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "34dfwef33-y525f-h432-r32-evvvreze32433", "rewefac1-c53d-434f-a5gz-pet32gg95711" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b74ddd14-6340-4840-95c2-db12884843e5", "fab4fac1-c546-41de-aebc-a14da6895711" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c15eeds50-9053-4323-53de23-dw32435f33", "fab4fac1-c546-41de-aebc-a14da6895711" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "effin2343-3fzz-tg3f-2fsa3-eccafwee32433", "rewefac1-c53d-434f-a5gz-pet32gg95711" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423", "rewefac1-c53d-434f-a5gz-pet32gg95711" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "rrtetrere-f32g-s42q-f3232f-ecdsvd32433", "rewefac1-c53d-434f-a5gz-pet32gg95711" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "vre4yw-h563-g34y45h-fewf32-pqpfowef3", "c7b013f0-5201-4317-abd8-c211f91b7330" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife", "c7b013f0-5201-4317-abd8-c211f91b7330" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34dfwef33-y525f-h432-r32-evvvreze32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "143a39dd-164a-49cd-9e30-d7130b9a3974", "AQAAAAEAACcQAAAAEKFxGIxZiWSaeJ5YekGnTb+yHH4uciIvJXLKvy7dCVoHFPL3Aa703aG8l75AmA5j6Q==", "92926d45-d6dc-47d1-bdf5-03f960c811a6" });

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "effin2343-3fzz-tg3f-2fsa3-eccafwee32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43eb2336-78ae-4b12-9be0-da07fc026cdb", "AQAAAAEAACcQAAAAEMr8LnPfNQWuib79glFVnPJPH8A6sNvtfk4kaLCxxWzWHmDXRS39cgKhp7GDXHj7ug==", "45a95667-7841-47bd-929e-b5dce6a65898" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "424294d2-4493-49dd-a916-50529cbc58a5", "AQAAAAEAACcQAAAAEBuxJ6PAwuXbdYDYgtKDE2eh/LqEl8NObzSSi5unOvDH8Mqt8w9lOvlVB1tfjAQ5vg==", "f781c034-59cc-4f25-b074-5dbe749dc940" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rrtetrere-f32g-s42q-f3232f-ecdsvd32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "109d6cd7-a041-43b7-b806-70724720bdda", "AQAAAAEAACcQAAAAEACHUwSJykglulm7YZ3KcJHVh7zPRHTx1lK3ysa+J4m5Nail7Ck8TmOIiWELpTN0mw==", "f5e61ff7-0165-4bb0-a1b8-89dbf9dc74a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rtweetwe1-3gre-yop2-verbm-rwerreww433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2b6d620-f1ab-446b-9901-db45facacc72", "AQAAAAEAACcQAAAAEER1NfIxUyV4eweR05c/lvx8jqB6WjiF6IGUD+CF+NvNFCtWZFGYI+QoxJfH1BYatQ==", "cba31498-7be0-4110-a4ff-528eb267ff6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vre4yw-h563-g34y45h-fewf32-pqpfowef3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1efac528-921b-43e5-9f9f-9eb9b1ad54ad", "AQAAAAEAACcQAAAAEBLdT6w4iK5K60fRNG9skjxc0g8/4OQ/wHlBVIWAJ5hGQSeJzRWo6hkqU73EQFOAxQ==", "a95d85d9-ada4-4158-a36e-ef5ef8fb1cb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8244161-5001-4e03-8a90-6a2ce3171558", "AQAAAAEAACcQAAAAEFBZAaYqp4f2zGtcjnJIzL9Y2kUMJClDR/5y+FEQ/v2upAxe81KGacgUvKuWZWi9TQ==", "89610378-c06e-4f7f-8b1d-07f97bf8238e" });
        }
    }
}
