using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Exam.Infrastructure.Migrations
{
    public partial class UpdatedMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RateValueId",
                table: "CalculatorValues");

            migrationBuilder.UpdateData(
                table: "CalculatorValues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 10, 54, 6, 705, DateTimeKind.Utc).AddTicks(4493), new DateTime(2021, 8, 25, 10, 54, 6, 705, DateTimeKind.Utc).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "CalculatorValues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 10, 54, 6, 706, DateTimeKind.Utc).AddTicks(3105), new DateTime(2021, 8, 25, 10, 54, 6, 706, DateTimeKind.Utc).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "CalculatorValues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 10, 54, 6, 706, DateTimeKind.Utc).AddTicks(3229), new DateTime(2021, 8, 25, 10, 54, 6, 706, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "CalculatorValues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 10, 54, 6, 706, DateTimeKind.Utc).AddTicks(3273), new DateTime(2021, 8, 25, 10, 54, 6, 706, DateTimeKind.Utc).AddTicks(3274) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RateValueId",
                table: "CalculatorValues",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CalculatorValues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "RateValueId" },
                values: new object[] { new DateTime(2021, 8, 25, 10, 50, 49, 91, DateTimeKind.Utc).AddTicks(7334), new DateTime(2021, 8, 25, 10, 50, 49, 91, DateTimeKind.Utc).AddTicks(7580), 1 });

            migrationBuilder.UpdateData(
                table: "CalculatorValues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "RateValueId" },
                values: new object[] { new DateTime(2021, 8, 25, 10, 50, 49, 92, DateTimeKind.Utc).AddTicks(5626), new DateTime(2021, 8, 25, 10, 50, 49, 92, DateTimeKind.Utc).AddTicks(5635), 1 });

            migrationBuilder.UpdateData(
                table: "CalculatorValues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "RateValueId" },
                values: new object[] { new DateTime(2021, 8, 25, 10, 50, 49, 92, DateTimeKind.Utc).AddTicks(5752), new DateTime(2021, 8, 25, 10, 50, 49, 92, DateTimeKind.Utc).AddTicks(5753), 1 });

            migrationBuilder.UpdateData(
                table: "CalculatorValues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "RateValueId" },
                values: new object[] { new DateTime(2021, 8, 25, 10, 50, 49, 92, DateTimeKind.Utc).AddTicks(5790), new DateTime(2021, 8, 25, 10, 50, 49, 92, DateTimeKind.Utc).AddTicks(5791), 1 });
        }
    }
}
