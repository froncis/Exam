using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Exam.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalculatorValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PresentValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FutureValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaturityYear = table.Column<int>(type: "int", nullable: false),
                    LowerBoundInterestRate = table.Column<float>(type: "real", nullable: false),
                    UpperBoundInterestRate = table.Column<float>(type: "real", nullable: false),
                    IncrementalRate = table.Column<float>(type: "real", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculatorValues", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CalculatorValues",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "FutureValue", "IncrementalRate", "LowerBoundInterestRate", "MaturityYear", "PresentValue", "UpperBoundInterestRate" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 25, 6, 14, 55, 103, DateTimeKind.Utc).AddTicks(9008), new DateTime(2021, 8, 25, 6, 14, 55, 103, DateTimeKind.Utc).AddTicks(9247), 1100m, 0.2f, 0.1f, 4, 1000m, 0.5f },
                    { 2, new DateTime(2021, 8, 25, 6, 14, 55, 104, DateTimeKind.Utc).AddTicks(7922), new DateTime(2021, 8, 25, 6, 14, 55, 104, DateTimeKind.Utc).AddTicks(7931), 1430m, 0.2f, 0.3f, 4, 1100m, 0.5f },
                    { 3, new DateTime(2021, 8, 25, 6, 14, 55, 104, DateTimeKind.Utc).AddTicks(8053), new DateTime(2021, 8, 25, 6, 14, 55, 104, DateTimeKind.Utc).AddTicks(8055), 2145m, 0.2f, 0.5f, 4, 1430m, 0.5f },
                    { 4, new DateTime(2021, 8, 25, 6, 14, 55, 104, DateTimeKind.Utc).AddTicks(8095), new DateTime(2021, 8, 25, 6, 14, 55, 104, DateTimeKind.Utc).AddTicks(8096), 3217.5m, 0.2f, 0.5f, 4, 2145m, 0.5f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalculatorValues");
        }
    }
}
