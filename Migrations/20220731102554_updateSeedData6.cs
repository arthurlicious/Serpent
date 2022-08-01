using Microsoft.EntityFrameworkCore.Migrations;

namespace SerpantWebApp.Migrations
{
    public partial class updateSeedData6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseID", "Credits", "TeacherID", "Title" },
                values: new object[] { 1, 3, null, "Fundamental of Programming" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34dfwef33-y525f-h432-r32-evvvreze32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd2155b0-3a53-4216-87a7-fbedd8003665", "AQAAAAEAACcQAAAAECgIizTNCyUS85SmtMUaWEUyHYzcahimTpvQkn2DCtv1lvCVJj6jbDqI/rNoNht5UA==", "fabd99f2-3a02-4ff5-a8fd-036dbd05d674" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12884843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31dd572d-2312-4cb5-921e-4641a83df1fe", "AQAAAAEAACcQAAAAEB3/0d2XlVxbxsVSK75qCDWeONgAA7vJ4dMOxVzgaLmfN/Ens4IGRRaBKP66u+um/Q==", "a95400f5-d09a-4928-8ed4-5db2e2cb5e40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c15eeds50-9053-4323-53de23-dw32435f33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d3f9394-8f19-436a-b480-fc57d01ba46c", "AQAAAAEAACcQAAAAEEmej44+dCC7BNZefl7yNYbmXoXovfG1rfqbfBsMXGyZrJUmObVq0EpSKiidIeyVQA==", "6c85217e-443c-4971-ba99-321232d4a48c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "effin2343-3fzz-tg3f-2fsa3-eccafwee32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc8888c3-41ed-49ca-a213-0e1bf4bd2d31", "AQAAAAEAACcQAAAAEAahSDQTU3VD7tPgh2MwiMQv2YU54PYzqF+ac+lK/KuDiSB3krv9qmeDuZFh5heA0w==", "19972ee3-0419-425a-b3ed-29a086b691ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fet434t34-fwe3d-tu34f-fwe-owepopwefpf2423",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f053299-eb0f-4dfa-955e-faad4daf5310", "AQAAAAEAACcQAAAAEHMJf5jl//k1RJ72rHLZ9FBx44I7xKs9GNuSVcQEWiYC1N3XDVw73VmG3Czglr26pg==", "51431dec-d3d8-4758-8339-cbc22e729f3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rrtetrere-f32g-s42q-f3232f-ecdsvd32433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2102a3ab-a203-4f18-9535-77e15f376d4d", "AQAAAAEAACcQAAAAEEPHMezDTxXcib2Hhybk2XJUFaU5xtZF3C3vZaH2kiOLTwgca9USueK5yOvjkTc7jg==", "6401187b-0235-445f-92b1-fb502dc95dc0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rtweetwe1-3gre-yop2-verbm-rwerreww433",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1775ce30-40ee-4384-bb99-a0146fa02c01", "AQAAAAEAACcQAAAAEB8aq0ZAuDYk90d8Uh0lbvg0cKrq/w6yAWZ5q+D/DJuUxHRNsVumgOSRG/3lu6xw7A==", "9ed0968b-c5d2-41f2-be8a-4a8b93f25db8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vre4yw-h563-g34y45h-fewf32-pqpfowef3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da8dc165-0a1c-4fcf-bf17-3086529e3fdf", "AQAAAAEAACcQAAAAEF5wH+MaHfYtC13U4ag/vjXImX+6BAZBOCoNAdczMYqpv87qiHDYFL1LdHmbTZqZgw==", "ac2f4395-c75d-4cf6-bafb-45baa8307f25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zdmmdf34-fewf3-geg2353-ppoe-fwekkv32ife",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "469a0f1a-a584-4755-8d87-81000f4d220f", "AQAAAAEAACcQAAAAEAkywTeNBY95vKxXt0MmGxWG6TPejoJKxxUu8MHczeak4rxYZRWVzyvGgeS0Ro46sw==", "4e806da7-8722-407a-8707-ba8d961a8ad4" });
        }
    }
}
