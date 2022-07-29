using Microsoft.EntityFrameworkCore.Migrations;

namespace SerpantWebApp.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Teacher",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Student",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Presence",
                table: "Attendance",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12884843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a2fa110-c050-4cc0-93ed-040c1024eb94", "AQAAAAEAACcQAAAAEBQJAZW4ccSbIbr/vbWc9NotOzE71GBpVhQj1tsiuC2A7PLk3is7dTIXGCRh84Dk3Q==", "b2ed099b-9acb-4104-8462-064c6a7f82d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c15eeds50-9053-4323-53de23-dw32435f33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53a1a84d-7ee8-401a-881f-5e0555c26264", "AQAAAAEAACcQAAAAEGKGY4Sl3XqT/djr4ewKA6e/LgZM/3t+HfcEKoMl1Kc9L1/ZHVgkpZanqf8g6cWm+g==", "a4e0f1a2-3525-47bb-9cdc-1dc32df138d2" });

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_UserID",
                table: "Teacher",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_UserID",
                table: "Student",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_AspNetUsers_UserID",
                table: "Student",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_AspNetUsers_UserID",
                table: "Teacher",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_AspNetUsers_UserID",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_AspNetUsers_UserID",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_UserID",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Student_UserID",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Student");

            migrationBuilder.AlterColumn<int>(
                name: "Presence",
                table: "Attendance",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12884843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35745e96-32a1-4cee-8194-745e6f1bb82b", "AQAAAAEAACcQAAAAEMnG50BaSiT/pygH19P4hu/+8wj5UWhP1bMm6F4Q711y6TXOkfU0FIAQUGybuDJanA==", "8ce06451-ea44-432a-bf45-673ba83fa731" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c15eeds50-9053-4323-53de23-dw32435f33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "721a9503-b267-488f-8b71-8dd74b2b563a", "AQAAAAEAACcQAAAAEMO0TRuween80yuDtK5ub/xoakVxp8rI8kgQ/R8YwPQPVLufGs/lXm+KxjYGekE/2w==", "4a235b41-6dc3-466e-b298-6fac59380ef5" });
        }
    }
}
