using Microsoft.EntityFrameworkCore.Migrations;

namespace SerpantWebApp.Migrations
{
    public partial class updateSeedData10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Course_CourseID1",
                table: "Attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Student_StudentID1",
                table: "Attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Teacher_TeacherID1",
                table: "Attendance");

            migrationBuilder.DropIndex(
                name: "IX_Attendance_CourseID1",
                table: "Attendance");

            migrationBuilder.DropIndex(
                name: "IX_Attendance_StudentID1",
                table: "Attendance");

            migrationBuilder.DropIndex(
                name: "IX_Attendance_TeacherID1",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "CourseID1",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "StudentID1",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "TeacherID1",
                table: "Attendance");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherID",
                table: "Attendance",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Attendance",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Attendance",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "LessonSessionID",
                keyValue: 1,
                columns: new[] { "CourseID", "StudentID", "TeacherID" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_CourseID",
                table: "Attendance",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_StudentID",
                table: "Attendance",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_TeacherID",
                table: "Attendance",
                column: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Course_CourseID",
                table: "Attendance",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Student_StudentID",
                table: "Attendance",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Teacher_TeacherID",
                table: "Attendance",
                column: "TeacherID",
                principalTable: "Teacher",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Course_CourseID",
                table: "Attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Student_StudentID",
                table: "Attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Teacher_TeacherID",
                table: "Attendance");

            migrationBuilder.DropIndex(
                name: "IX_Attendance_CourseID",
                table: "Attendance");

            migrationBuilder.DropIndex(
                name: "IX_Attendance_StudentID",
                table: "Attendance");

            migrationBuilder.DropIndex(
                name: "IX_Attendance_TeacherID",
                table: "Attendance");

            migrationBuilder.AlterColumn<string>(
                name: "TeacherID",
                table: "Attendance",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "StudentID",
                table: "Attendance",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "CourseID",
                table: "Attendance",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CourseID1",
                table: "Attendance",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentID1",
                table: "Attendance",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherID1",
                table: "Attendance",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34dfwef33-y525f-h432-r32-evvvreze32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a89b045-f78d-4fa3-b2d7-302bd4ec949a", "AQAAAAEAACcQAAAAELHKRFff7YbAzWQ1w1h4mLVuBrAjgUipJN4SlicV7Oyj8TJKSOXMQ4/B+U2Eryq/wQ==", "84bd36eb-e903-408f-93a0-5d8ae18a8c18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12884843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "425ce959-377e-4f7c-8270-08d6ca22d71c", "AQAAAAEAACcQAAAAEJHW5xOXI2gRYWEYLpfWjyyfpz9aBqaI5AaRcRrtIT5P8YmkKVozqloF41yWp4ZN9A==", "594e678f-6fc8-496f-b4fc-c8f7cba618d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c15eeds50-9053-4323-53de23-dw32435f33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a72e26e-6415-41a8-b847-0230a4c2a682", "AQAAAAEAACcQAAAAENMGepPIMhLCtb9dQVR60VafBSWQvVnykhstxELrH9brEJXqDhTXM/erYyWnvEm3Zw==", "dc12e504-5707-4c8f-8ca2-bf9a1120e586" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "effin2343-3fzz-tg3f-2fsa3-eccafwee32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6aa38a7e-b9b6-499a-a745-6dff66b19fa8", "AQAAAAEAACcQAAAAECeN1PvdUjql/ec3VEzDivVgWDCaXG+ld48z+fIsxtsATrZ/eC5+s914hZsZC8iRiA==", "3e1cb588-3ad8-440b-8c75-44f0526d11d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "470dafdb-488d-4c6e-bd11-8337d389e94f", "AQAAAAEAACcQAAAAEMruuUjKK6w2ILOgOP9Rh9SQXOhdxBs9LfCWPWX8T1vY1/hNyPX2GjBTJHeOade+Hw==", "d5922751-6956-48d7-9922-247778e60d2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rrtetrere-f32g-s42q-f3232f-ecdsvd32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65cf9209-4141-4139-93de-49f601a35604", "AQAAAAEAACcQAAAAEHEshYtEwUQ/OtJIGWqzIGD+6mqO4PduN3SEIZL3ZJ/gOU4H9DOdMZBXJ9giLGosRg==", "66f04abd-95dd-4c67-ae21-5c34cca19bb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rtweetwe1-3gre-yop2-verbm-rwerreww433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e87bc92-1f6e-4a5d-adee-d4d729858cec", "AQAAAAEAACcQAAAAEM7HswYj4qFghnxUilyL6711BLU2OzUJ9FTlYp8XFvbI/gjfrgs49Ofg+DckkovhjQ==", "fb6443ce-933d-4b5c-9095-d3df066cab08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vre4yw-h563-g34y45h-fewf32-pqpfowef3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69473c35-1d2f-49be-b92e-00393b623924", "AQAAAAEAACcQAAAAEMpKd/iotk2ZtWLG3CoAsjIEY+ZNWFj4rVYt87T7fTPB9pQTwe/mTMv3FRKmduqwCA==", "0a631788-1d1d-4493-8d1c-5983503ec837" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b85c2f5-c14a-4bd2-ab47-7f9201a5eab2", "AQAAAAEAACcQAAAAEIhNRf74t6uDz8wRKnuwPTkg2Y0Ylnl7kFK0yo2eK71uB6SmVsCYH4jR/R70uyhJJA==", "eb5fa533-b0af-4568-b16f-b0ac5b59a0e6" });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "LessonSessionID",
                keyValue: 1,
                columns: new[] { "CourseID", "StudentID", "TeacherID" },
                values: new object[] { "1", "1", "1" });

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_CourseID1",
                table: "Attendance",
                column: "CourseID1");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_StudentID1",
                table: "Attendance",
                column: "StudentID1");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_TeacherID1",
                table: "Attendance",
                column: "TeacherID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Course_CourseID1",
                table: "Attendance",
                column: "CourseID1",
                principalTable: "Course",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Student_StudentID1",
                table: "Attendance",
                column: "StudentID1",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Teacher_TeacherID1",
                table: "Attendance",
                column: "TeacherID1",
                principalTable: "Teacher",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
