using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Exam.Infrastructure.Migrations
{
    public partial class UpdatedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IncrementalRate",
                table: "CalculatorValues");

            migrationBuilder.DropColumn(
                name: "UpperBoundInterestRate",
                table: "CalculatorValues");

            migrationBuilder.RenameColumn(
                name: "MaturityYear",
                table: "CalculatorValues",
                newName: "Year");

            migrationBuilder.AddColumn<int>(
                name: "RateValueId",
                table: "CalculatorValues",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RateValuesId",
                table: "CalculatorValues",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RateValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaturityYear = table.Column<int>(type: "int", nullable: false),
                    UpperBoundInterestRate = table.Column<float>(type: "real", nullable: false),
                    IncrementalRate = table.Column<float>(type: "real", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RateValues", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "CalculatorValues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "RateValueId", "Year" },
                values: new object[] { new DateTime(2021, 8, 25, 10, 50, 49, 91, DateTimeKind.Utc).AddTicks(7334), new DateTime(2021, 8, 25, 10, 50, 49, 91, DateTimeKind.Utc).AddTicks(7580), 1, 0 });

            migrationBuilder.UpdateData(
                table: "CalculatorValues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "RateValueId", "Year" },
                values: new object[] { new DateTime(2021, 8, 25, 10, 50, 49, 92, DateTimeKind.Utc).AddTicks(5626), new DateTime(2021, 8, 25, 10, 50, 49, 92, DateTimeKind.Utc).AddTicks(5635), 1, 0 });

            migrationBuilder.UpdateData(
                table: "CalculatorValues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "RateValueId", "Year" },
                values: new object[] { new DateTime(2021, 8, 25, 10, 50, 49, 92, DateTimeKind.Utc).AddTicks(5752), new DateTime(2021, 8, 25, 10, 50, 49, 92, DateTimeKind.Utc).AddTicks(5753), 1, 0 });

            migrationBuilder.UpdateData(
                table: "CalculatorValues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "RateValueId", "Year" },
                values: new object[] { new DateTime(2021, 8, 25, 10, 50, 49, 92, DateTimeKind.Utc).AddTicks(5790), new DateTime(2021, 8, 25, 10, 50, 49, 92, DateTimeKind.Utc).AddTicks(5791), 1, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_CalculatorValues_RateValuesId",
                table: "CalculatorValues",
                column: "RateValuesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CalculatorValues_RateValues_RateValuesId",
                table: "CalculatorValues",
                column: "RateValuesId",
                principalTable: "RateValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CalculatorValues_RateValues_RateValuesId",
                table: "CalculatorValues");

            migrationBuilder.DropTable(
                name: "RateValues");

            migrationBuilder.DropIndex(
                name: "IX_CalculatorValues_RateValuesId",
                table: "CalculatorValues");

            migrationBuilder.DropColumn(
                name: "RateValueId",
                table: "CalculatorValues");

            migrationBuilder.DropColumn(
                name: "RateValuesId",
                table: "CalculatorValues");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "CalculatorValues",
                newName: "MaturityYear");

            migrationBuilder.AddColumn<float>(
                name: "IncrementalRate",
                table: "CalculatorValues",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UpperBoundInterestRate",
                table: "CalculatorValues",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "CalculatorValues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "IncrementalRate", "MaturityYear", "UpperBoundInterestRate" },
                values: new object[] { new DateTime(2021, 8, 25, 6, 14, 55, 103, DateTimeKind.Utc).AddTicks(9008), new DateTime(2021, 8, 25, 6, 14, 55, 103, DateTimeKind.Utc).AddTicks(9247), 0.2f, 4, 0.5f });

            migrationBuilder.UpdateData(
                table: "CalculatorValues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "IncrementalRate", "MaturityYear", "UpperBoundInterestRate" },
                values: new object[] { new DateTime(2021, 8, 25, 6, 14, 55, 104, DateTimeKind.Utc).AddTicks(7922), new DateTime(2021, 8, 25, 6, 14, 55, 104, DateTimeKind.Utc).AddTicks(7931), 0.2f, 4, 0.5f });

            migrationBuilder.UpdateData(
                table: "CalculatorValues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "IncrementalRate", "MaturityYear", "UpperBoundInterestRate" },
                values: new object[] { new DateTime(2021, 8, 25, 6, 14, 55, 104, DateTimeKind.Utc).AddTicks(8053), new DateTime(2021, 8, 25, 6, 14, 55, 104, DateTimeKind.Utc).AddTicks(8055), 0.2f, 4, 0.5f });

            migrationBuilder.UpdateData(
                table: "CalculatorValues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "IncrementalRate", "MaturityYear", "UpperBoundInterestRate" },
                values: new object[] { new DateTime(2021, 8, 25, 6, 14, 55, 104, DateTimeKind.Utc).AddTicks(8095), new DateTime(2021, 8, 25, 6, 14, 55, 104, DateTimeKind.Utc).AddTicks(8096), 0.2f, 4, 0.5f });
        }
    }
}
