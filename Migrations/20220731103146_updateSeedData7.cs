using Microsoft.EntityFrameworkCore.Migrations;

namespace SerpantWebApp.Migrations
{
    public partial class updateSeedData7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Teacher_TeacherID",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_TeacherID",
                table: "Course");

            migrationBuilder.AlterColumn<string>(
                name: "TeacherID",
                table: "Course",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherID1",
                table: "Course",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                column: "TeacherID",
                value: "1");

            migrationBuilder.CreateIndex(
                name: "IX_Course_TeacherID1",
                table: "Course",
                column: "TeacherID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Teacher_TeacherID1",
                table: "Course",
                column: "TeacherID1",
                principalTable: "Teacher",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Teacher_TeacherID1",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_TeacherID1",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "TeacherID1",
                table: "Course");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherID",
                table: "Course",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34dfwef33-y525f-h432-r32-evvvreze32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ef92258-ed69-4d4a-914b-584218b767fa", "AQAAAAEAACcQAAAAEPkjXJlbvls+wMNdlURwUJJYqJpHwYyPUNJRHynY0G4qU2l+VhTeD1DP7Uh2nKvAdw==", "f4cf22b3-92fe-4d03-b073-8201057f2e65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12884843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d86400e-e0d4-4adc-b9cf-3802cf5ad4b3", "AQAAAAEAACcQAAAAEN8suBxItMOJxjpCMoTgEhVXrEb4PuJka1AWIrBl3SKoTEeDWtKth/wGwoyn+gOBLw==", "9a5fadd9-32cc-4f9f-a5c4-0797ed8623b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c15eeds50-9053-4323-53de23-dw32435f33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a1f4d00-2853-4ad9-89c7-419b28d3c7a5", "AQAAAAEAACcQAAAAEOdqT8jUn1+44Tca/9QXJOi3Jnagc9rZ/fpcz8z1NAmaYRxXiPevqeTGAf8btGwzFg==", "8281937f-4068-4b38-959c-ab46f07442ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "effin2343-3fzz-tg3f-2fsa3-eccafwee32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a1de3c3-80be-4761-b493-3273aa7f6f84", "AQAAAAEAACcQAAAAEKFY0zA3vM210Zjf5ECZqYjbSaA9S+WDw5plr5xlPLJbQNhSy9K/BZjhSAUb04v/Qg==", "e4c7775f-9f74-4ae6-96bf-58d492e45469" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1990e589-ac35-4915-95e5-68ba8ae4606c", "AQAAAAEAACcQAAAAEMAx8+NTyVbk1pWf0GTCkcUEr5vZLJOsguVBZ31qsKXao+sN4iVAqbgD9LLMsmFP8g==", "1b48f6ee-c448-4e85-a33a-32f65d3920a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rrtetrere-f32g-s42q-f3232f-ecdsvd32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0913bb78-d2dc-49ca-9875-ae269e393db4", "AQAAAAEAACcQAAAAEGlJFkcK9SyNPL2BJg0fki7eLwatyeHchrKZ4PQlNwsKxuOqKmvvWL/nUuR6DUb2Ow==", "374a38bf-e72d-43ee-9766-e1c512051bfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rtweetwe1-3gre-yop2-verbm-rwerreww433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19184503-34b4-44ac-a5bc-898c544566a0", "AQAAAAEAACcQAAAAEIm5Ap1zMykmbqlgsE1IM0z0+YR8QCdjCCkPqM76BSrwMmxZVIPGzEz7TReVkWG5/w==", "bdb08c0d-fc84-41f0-a7d6-65479839d33e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vre4yw-h563-g34y45h-fewf32-pqpfowef3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85db91ae-1e61-4506-87be-f31cdb595b80", "AQAAAAEAACcQAAAAED1KYPS/D8nfrunhXDrWyydDQiCm3gYToUUZ0L30f9mg4GXFN/JccLjJl5q298nEEA==", "6951fb53-93aa-4fab-843f-cbe748b70228" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c6c6a47-f40b-430c-96fb-f9d11c0d677e", "AQAAAAEAACcQAAAAEIPl+LtYGzPvkmtnVnnIo+rl9UfT0U6OXm1o1KFPdayVihT3rgkPYdJXb2oyuQy2iQ==", "694f6b0d-9775-4396-bdf8-cecf6cab89ce" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                column: "TeacherID",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Course_TeacherID",
                table: "Course",
                column: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Teacher_TeacherID",
                table: "Course",
                column: "TeacherID",
                principalTable: "Teacher",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
