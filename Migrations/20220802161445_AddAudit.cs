using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SerpantWebApp.Migrations
{
    public partial class AddAudit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditRecords",
                columns: table => new
                {
                    AuditID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuditActionType = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    DateTimeStamp = table.Column<DateTime>(nullable: false),
                    KeyProductFieldID = table.Column<int>(nullable: false),
                    KeyRoleFieldID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditRecords", x => x.AuditID);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34dfwef33-y525f-h432-r32-evvvreze32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f3608f4-79b9-428b-9200-bf28401593c1", "AQAAAAEAACcQAAAAEPdGsLNGdwxw66JqwgThMbL9ScMWQ4S225wUC1BF+1ms89RgCRbrjfPoNvv6bB/Qqw==", "5bee5305-be6b-45f7-8954-636ed785416a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12884843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd4086b6-534d-4918-845e-b03855c86b2a", "AQAAAAEAACcQAAAAEEVgbHjIqTW31yevVT3/iZxxupR+GYAYhlKfszrO2m5Rxp5qz6mNT1dxYHs7XxdsEw==", "11a600b6-ac2c-4a09-a657-31a381e7f573" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c15eeds50-9053-4323-53de23-dw32435f33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d702e09-e2a3-492c-afe8-beb053ddc004", "AQAAAAEAACcQAAAAEArfLFv7FliNsxsBIsa3TNn93duabqQOkMaIFAqXo2a4UzrqV1huVo/oO78sPYI86g==", "56799f40-7c5e-425d-80d6-2eb6d1984a2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "effin2343-3fzz-tg3f-2fsa3-eccafwee32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff72b986-d183-4146-a5c5-1b672201df07", "AQAAAAEAACcQAAAAEDBCwWlR2TlDLSec2a2IT+/oPu8Wcard0me012AIQarxLm8PxfUqb4mXHs25ctsRkg==", "05881ae4-ab1b-4f8f-b194-795c49e5953e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dff3b2f0-dfd3-45ff-b046-e34f421cf05d", "AQAAAAEAACcQAAAAEJIdmU3r4k9wu9kfojDjKs7Ju6F/Nc8sPjwLfrcTQtgbKktW99IiCg4rjbVudH0+5g==", "42014bf9-8fb7-4f52-86bf-8a6df9d4d258" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rrtetrere-f32g-s42q-f3232f-ecdsvd32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5068e5a-babe-4851-88a1-7f1475c7ec55", "AQAAAAEAACcQAAAAEIAleF1sizDmsqCSMgNnv5SSjTYGtSHqNrDJeOcJSPkhkpWirk6PrednIpNBZ7+CoQ==", "c87ab2b7-0d59-4c14-a0f2-b22278c8117b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rtweetwe1-3gre-yop2-verbm-rwerreww433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "043ae6c6-1069-4e74-92c7-a1790ca6466c", "AQAAAAEAACcQAAAAEGqIoRbj/T3rOqa0jnrF06tzfF2uu9HvhcD63slUg7qycJyR2ecXcHF7j8stpXqVAw==", "c3b2cfb1-07a1-40cb-a9b7-de6cd2eb1277" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vre4yw-h563-g34y45h-fewf32-pqpfowef3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17d85e94-d082-4552-855e-40afd3a22a1c", "AQAAAAEAACcQAAAAED20tImCd79PWcKBeLjtJ1/tJwRvlZtj9yBu2irtH+k8YxcahEz7wtOq5da1UnxQJQ==", "f8af4af5-54e0-44dc-8e6b-5061f0266894" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "020bc6ed-f397-4630-9a84-ee524835b359", "AQAAAAEAACcQAAAAEGHDLwfrxgFfw2oYv8DWSNbq7RPbCrrN1Ukalz4mTxTnYBNygOJt/nP7TlcjcuHUJQ==", "de649dbf-a81c-49a2-89db-5621bd5796be" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditRecords");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34dfwef33-y525f-h432-r32-evvvreze32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0befe10c-99d6-4e91-8aa1-6aad78bb9f24", "AQAAAAEAACcQAAAAENLWquvNt3JvvcuTgT3gyjcM0m41cjrJqp+sPiFBin/OsW3ibPTUU0ra6ZbU6IcPlw==", "51bfeedd-a8b8-4848-b904-bf02e79784fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12884843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3169b220-4039-4b55-af9c-edbf0c9b7831", "AQAAAAEAACcQAAAAEIzR9i0P/3wPQNZDJbVq0GYh7gqOTDgIw84Oa7vf+V4SNpk6h4XVrEXzQEW48OcMzQ==", "54e8bcea-47c1-4ccf-930d-197bc4689ba0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c15eeds50-9053-4323-53de23-dw32435f33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d48ba05-f808-4b5c-bcce-12ae0872e27e", "AQAAAAEAACcQAAAAEBlC7RjBaGPpLc01ZK0ECCAiVhm4P1V9y/D6pJwnCbfqTNozgFhRcVy6E8q1CKcbPA==", "66f69982-da0d-4bd2-bfe7-ad1ef408004c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "effin2343-3fzz-tg3f-2fsa3-eccafwee32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99f9eb47-6ec8-4014-9c7a-b03ef1230417", "AQAAAAEAACcQAAAAEJ+ftXpzK9U1k3LLLMIVfixdH4tmsXvvt5lf7BNmH1luvNIJlNHN8u1SH5FcnZMCHA==", "1f28f33c-44a6-44ee-b8c4-31467397dd42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06ffe80d-7dc8-4ca9-8315-ceaaa2a6667e", "AQAAAAEAACcQAAAAEA9SrZiHilDHfoGTUECNogDXwYdE05bTUyOUOBjuMaXdg2vKhU0L4WYJqQLEekAuEA==", "e4e4200d-0db8-4d2e-b879-d6aa294e0637" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rrtetrere-f32g-s42q-f3232f-ecdsvd32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75be9772-04da-4eb5-aebd-e3e1ed579aa0", "AQAAAAEAACcQAAAAEFLK5Bh5roo/b/hbPIrtmUF6RgHk8T0lvOHJk1LZsa5bs9S8h1jiuiFDKrq0JrUEfA==", "07a5a3b7-2bcc-4283-a21f-bc817e4bffbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rtweetwe1-3gre-yop2-verbm-rwerreww433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90e136f0-a1c5-469d-b220-639b31753128", "AQAAAAEAACcQAAAAEDem3PI6EEanseTH6P6NmPGZauzaT7kCpfDcweehfS86FxxTs0tZT+uWG6XVSOoUVA==", "c33d97ad-0618-47a7-be76-4bfb7aad759f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vre4yw-h563-g34y45h-fewf32-pqpfowef3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3333b48b-a3b2-4920-af4a-619c2554a17b", "AQAAAAEAACcQAAAAEO3n3xpY4fNXaylGwznPjGH4hdpRyKYocpYmIV2O0HiHZqj3vwhXI5Wlz6CBvQ74bQ==", "3fdab30a-97bd-460d-bf11-9ee766f115be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cb47dca-4f1e-410a-9e9b-2b92e50b9527", "AQAAAAEAACcQAAAAEB7aDy7xeYOrV+aPOPFjRuPB5giYBEZl40wOwJx+uoiaPMWafjr5lfBWF1r++dJ9Mg==", "36a4b45b-3e52-4144-91c1-2727ec7bf5cc" });
        }
    }
}
