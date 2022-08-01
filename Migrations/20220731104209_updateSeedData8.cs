using Microsoft.EntityFrameworkCore.Migrations;

namespace SerpantWebApp.Migrations
{
    public partial class updateSeedData8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "StudentID",
                table: "Attendance",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CourseID",
                table: "Attendance",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CourseID1",
                table: "Attendance",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentID1",
                table: "Attendance",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherID1",
                table: "Attendance",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34dfwef33-y525f-h432-r32-evvvreze32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b2b2b31-edb7-408f-ac6a-7396054433ad", "AQAAAAEAACcQAAAAEASrvBacVK5Dd5eXAi+sA8BSehbewzN0XUQaTGEAZHM7/NY45xWvpw2TVNhw22GS7Q==", "e84ddcb8-f24d-4e2b-80fd-35f2535526d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12884843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7919f53-4b13-470b-bc4c-d491d1911b19", "AQAAAAEAACcQAAAAEFj0OO5IX/73XhozqUD5yann8eHbhEkB3UTKPh6gqm68GvfdSPDpuOoemPwWKvyJLQ==", "c5dbe5d8-9829-4c05-96d9-39a0a0e30919" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c15eeds50-9053-4323-53de23-dw32435f33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f889d948-e661-41fa-b75d-6dfc768584e3", "AQAAAAEAACcQAAAAENG1xsoysJr3d52zOipHxgyghONf5d+kaVAYq70ktdfC/BVSmk+HGwfA82WfqFZw8Q==", "5a743ccf-e38b-4b27-8bfa-e0a90c429bed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "effin2343-3fzz-tg3f-2fsa3-eccafwee32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acb2c13b-99a2-4171-a46f-02a2c7e37fa2", "AQAAAAEAACcQAAAAEOftYG3gLqJAbz+7nXxHuP3wgtFcOV0okTzathFD0xcWqKIuZEc21JKOHCepEa/LsA==", "ed2cda7b-4a7f-492b-8226-85832d341867" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "858f74f7-887e-467f-9517-7b202a4ab66e", "AQAAAAEAACcQAAAAEEJWA7+p1asNLYOOvxDxh2C0zJaTPMSZItkqixgwUkyzVVx1tw0ACAcDLN2UMzQt8w==", "525d1d4a-05c1-4fb7-814f-7d612ca34985" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rrtetrere-f32g-s42q-f3232f-ecdsvd32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7efb4b5e-ef3b-4cac-bdea-d6fa7620aab5", "AQAAAAEAACcQAAAAEPoduWFbpLljp9J301J2r6l6EdsMW3tRFQPfqzT8kTOJM4im1spVEB3f5l+HoD8msg==", "df8e8db8-86d0-457b-94c4-0bed0785cd77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rtweetwe1-3gre-yop2-verbm-rwerreww433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb52b6a9-66a4-49f5-9051-fc14f43087d7", "AQAAAAEAACcQAAAAEObzSmF0fv/3I8l7qp5RD30ceOxGXB+kGoEry0r1N1anUQIboFJtlPsuufwt3rvgQA==", "cf13f90d-3fba-4d58-8669-77a514500685" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vre4yw-h563-g34y45h-fewf32-pqpfowef3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee7f2dd1-1c1e-41b8-a8d4-edc42142b133", "AQAAAAEAACcQAAAAEKPhJFYd2W115yXEwCwvGaMyD7Os4fOr9p0gGZyItxsLKgVlmz4tCfNq9y0WEOeniA==", "c095d9b7-ed4b-4f78-a6f2-57aa4856abde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "211c7b06-5e8e-4006-b74d-71280abfb6da", "AQAAAAEAACcQAAAAELYGzMVdWtCM+LRXstaaJqoFIM2rANzOGMvyYS/yRBZJHo27/Ek0AqU1SLSUDkssPg==", "149d3739-882c-42a4-81d9-0ab8ad228ab7" });

            migrationBuilder.InsertData(
                table: "Attendance",
                columns: new[] { "LessonSessionID", "CourseID", "CourseID1", "Presence", "StudentID", "StudentID1", "TeacherID", "TeacherID1" },
                values: new object[] { 1, "1", null, true, "1", null, "1", null });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "LessonSessionID",
                keyValue: 1);

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
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Attendance",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Attendance",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34dfwef33-y525f-h432-r32-evvvreze32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a996657-3bfd-49aa-b050-31f7ffbc9643", "AQAAAAEAACcQAAAAEEemx8iVEViVS4FS3kSDTGALPycxcNRuXcqnrC3nEIR0waX3+qwtVmJKe8HTQ/7oXg==", "95e9854b-e9aa-4af7-90ec-b6954367df94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12884843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a27b177-c940-4b48-a46d-a135c47c6a2b", "AQAAAAEAACcQAAAAEEdX5F4vtkaRrpZPmb+Udu56tsbUfIiGJ+X8azsyCu9cmmzopzofp9BLNmrCzJMNBQ==", "b4e716d0-6329-486e-857c-018c1004264f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c15eeds50-9053-4323-53de23-dw32435f33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd2018fe-eaa0-424e-9053-5e9f642fc0e0", "AQAAAAEAACcQAAAAEI0okev1/VApvPI49lEK2WngV08U+6xVlj1Q2j0vncFm/gxR/QEjJ2VdMSQkZIQ+Ag==", "42d807be-bfb5-4018-82ab-d49d151fc98f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "effin2343-3fzz-tg3f-2fsa3-eccafwee32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "972861eb-5036-47fa-a5cd-ca995b4ad8bb", "AQAAAAEAACcQAAAAENxXfjHZfhuWtsFsYkG99v8W5wy3x9PeEzLHdL14YnqCkR61tL2ZuzdUtRPMr31cSg==", "176cf3a6-971f-42c3-835b-5336977a5c0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa684466-0895-432b-9b8a-4b579c9f4660", "AQAAAAEAACcQAAAAENHFG8/DiclO3hovJKybY6Ea4G9AlNYiJor4L/lc9t8Px0TIvk8RR0BrypFjCpCFwg==", "132831a1-f394-40b2-8541-2d4fa8fd9b58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rrtetrere-f32g-s42q-f3232f-ecdsvd32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14d4abe7-e952-495e-add4-1625a59d3342", "AQAAAAEAACcQAAAAELscBrHBx7aWN432sMAd5zBTni/NjbAkomKu0LRFwITNm+Ocy2So6j+rlB/kOfURvA==", "8ec54c76-7f88-42a6-99a5-d45204ab4358" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rtweetwe1-3gre-yop2-verbm-rwerreww433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b90fffc0-501a-4558-95f3-a6716deb2b92", "AQAAAAEAACcQAAAAEDD+jbUAXJmxoIVl4mzpQ/vlyMuUe915SJlKhBFwM9IjvmejuQrVS/mrFR7jN5v65Q==", "8aa8ef25-ad7b-4014-85bb-389453d23dae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vre4yw-h563-g34y45h-fewf32-pqpfowef3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f867fd45-513b-4278-9244-391e9365d8c0", "AQAAAAEAACcQAAAAEFet+znBXZpPInoHNPnfNMb7dnNtJyLhwafINumaa7DdEdlUVp/mgu6EsXqRI3utqQ==", "6a5e83eb-4026-441e-91b2-f9c19684e1bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b6491a5-95f3-4e50-90ed-40f896309580", "AQAAAAEAACcQAAAAEJ2OBXtHFZ7sf8k1OjIVj2mvqI83JTCQh1xjdz7O8T7jNp8AgeKDV+/U44GIHeUF8w==", "621bf957-a371-4a3c-949e-00e33eb96f11" });

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
    }
}
