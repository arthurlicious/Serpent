using Microsoft.EntityFrameworkCore.Migrations;

namespace SerpantWebApp.Migrations
{
    public partial class updateseedata11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Student",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34dfwef33-y525f-h432-r32-evvvreze32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32ec27f9-4378-45b4-a840-201c6ea4dde6", "AQAAAAEAACcQAAAAEKs5Eh5AlIe+YOKyhytWsPmVQyXx9QMry1K6+/tsi8IWFkGi7CpKm1MSsv+hwHrITQ==", "997627e7-aeff-4d83-adf8-a319cbdd2302" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12884843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acd397bb-8949-4f9f-b191-60eb2e7b6b2c", "AQAAAAEAACcQAAAAEOsS178AB3BIUpLdXEohIZ+0rdB1O564o9lW0OzYApI+3OqZtvY6HR0gN4Tlwc7hDw==", "4d072aa2-48d6-49ca-a923-096ee993cdc6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c15eeds50-9053-4323-53de23-dw32435f33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d16deb3-573a-444c-8612-9354c5f347b5", "AQAAAAEAACcQAAAAEFGbwgxIQ2zLuMkXhFdMnkVxgUhWgX66HOqV5nWU8D1rY1GrKuilBHrl8C6I0dcpOA==", "3d7e5776-98cf-4cba-b042-f6c10ff7cbb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "effin2343-3fzz-tg3f-2fsa3-eccafwee32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df8f4abd-cea6-4d4f-af1b-c9678119fab9", "AQAAAAEAACcQAAAAELeSNDknDzJmrLS0NrhSJWRTJ7iKux50ohwGp19tyFWfz/TZfgJcUN97S/exawGyEw==", "522b3ba8-1644-4ec2-8883-ddebdb8b6d34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3af6ceb-7564-465d-b70e-7eaea8ebea2c", "AQAAAAEAACcQAAAAEIiCwQja7olbT62TZfo8HB+GzjBNX2osmasSJhoxNoMqjKJN6L8TjYHpz/DRU11gmA==", "8199d408-e9fc-4ff7-8a77-6dff4cf03f0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rrtetrere-f32g-s42q-f3232f-ecdsvd32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a6e8e98-9451-47e0-a84d-8113b1f3a018", "AQAAAAEAACcQAAAAEMQrdn8kUnuGEMPIirZTeB/04FmWDqNXEbVg7RCdHSgb6bTw9ea+6dNZzOcIab/bnw==", "088dd45b-c89f-472c-af6e-d038bd7485a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rtweetwe1-3gre-yop2-verbm-rwerreww433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e71dcd6e-9665-44b5-b643-79d71a83b44b", "AQAAAAEAACcQAAAAELbXndfyZWRpY5ZVLQ2yrPcfe2UK3lR6UYOQkaARD2wWu4PnO+e58KtC6+MGlJhfBQ==", "84ce69eb-ea87-49e9-a9ea-1ef3ff773cce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vre4yw-h563-g34y45h-fewf32-pqpfowef3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbab3488-294f-4ba6-a75f-1b4e08bf06a7", "AQAAAAEAACcQAAAAEBKDMh3/h5QBT8LcMjwaVlI/m6dUib1kdlZ+mUaNdgEKDgWPSG7XRzUmJ3Sn0l96kQ==", "ac9a2ca5-ceb0-49b6-8332-44e98a4b9291" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15fe74db-3820-4336-b60f-75ba068479cd", "AQAAAAEAACcQAAAAEMeB1VHkyEdT4zd0isF66Rbh8ulvc+UbNw/sGUkN+ZS/xKWQh7J76INj11mcQ9jbNQ==", "0a746fa7-1a9e-4657-8235-573c9291ee10" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Student");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34dfwef33-y525f-h432-r32-evvvreze32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e09f648-b2c9-404e-99ec-f6c2f65e855e", "AQAAAAEAACcQAAAAEHkzWgCVwIS44RIftEBtk84nUpar003YFlq28WHp1iFGJi4pmFCdy/o7FhjjBriN3g==", "48962883-220b-406e-8522-8f0c375a3ca3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12884843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "553bb330-373f-46df-a68c-d2c2c13973b4", "AQAAAAEAACcQAAAAEK8r78Sn4VLJGrneiZvDSUIzxjCnq5oawvLCY5jtJaHf4JXhxmPZzbwloN8ThYGl0g==", "c06396a8-4149-4d37-8e4e-6ac9c45da3a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c15eeds50-9053-4323-53de23-dw32435f33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac097b3a-59ce-4076-a19c-4ce553f2389d", "AQAAAAEAACcQAAAAEIcVduliqKbzJ80W+vkuTFHrMxg2h6TMFctjFkJE9Bo/ZwQyW4FCudUWXk9kF8mSSw==", "219f7924-03df-4902-b9bc-2851ed86c2d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "effin2343-3fzz-tg3f-2fsa3-eccafwee32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d42fa3a8-aece-44c6-9a40-afe64f43022a", "AQAAAAEAACcQAAAAEMS7/yqrIYhRwKFGciLrkfH6T0dV2Dra26QGHqeJzaYdVQxjBtuVoDrBdfgY0nr8/w==", "3b0e990e-2cfb-41a6-9a6c-9f5976907fc1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbad0129-eead-4d84-9c81-7e1532f521ac", "AQAAAAEAACcQAAAAEC0PUfVkIcs6uLWy85aA9YmghZgEYz6JlvtgaeTUyfKtZ9QasRuDIYGXvWF5QggxvA==", "3c4e51f8-9083-4ced-ab08-f4023b10adb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rrtetrere-f32g-s42q-f3232f-ecdsvd32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4043954d-a772-41c8-b521-005587b9a686", "AQAAAAEAACcQAAAAEGne+HSGuZaCuP0OV/itWmZL2okeh11BlZ5bPg/fMwXa36FVALT0oU4BY108tfafzQ==", "467845c6-fbf1-4833-8ca1-6474c63b538e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rtweetwe1-3gre-yop2-verbm-rwerreww433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1100f2c-2a41-46e6-97de-2426ce2c18cb", "AQAAAAEAACcQAAAAENVROEE2Y+7xMlUOWqhJaeBpZ35sLAPjJ+zQJ9e1FpsX1KzClezgLZFNh2NAPFQW1g==", "ae5e31d9-1d85-409e-8bbd-ea99720a9d78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vre4yw-h563-g34y45h-fewf32-pqpfowef3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a945297b-e9ed-48ab-b62c-aed4b6e28341", "AQAAAAEAACcQAAAAEKLf4q0IQ2kW9kK5JDJJDGDXAuK4+qdFN0R5nxNnHV7MfE5H9Jtl/SHDTizwzcK6Eg==", "73b0314b-872a-40bb-9caf-c7cb4d5072c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "140db091-814f-4b65-bcf5-17fa6ccff07b", "AQAAAAEAACcQAAAAEFFFsFNgWqMBHzCY1C41p5Yk8JAp7k7Oi3Hj1DuvUzU1lGsCCElh/Vz7dbgh13iTcA==", "9c8f1826-2c7a-4b7f-9f24-2a3abb5df410" });
        }
    }
}
