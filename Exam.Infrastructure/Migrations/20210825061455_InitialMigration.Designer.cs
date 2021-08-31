﻿// <auto-generated />
using System;
using Exam.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Exam.Infrastructure.Migrations
{
    [DbContext(typeof(CalculatorDbContext))]
    [Migration("20210825061455_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Exam.Domain.Entities.CalculatorValues", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FutureValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<float>("IncrementalRate")
                        .HasColumnType("real");

                    b.Property<float>("LowerBoundInterestRate")
                        .HasColumnType("real");

                    b.Property<int>("MaturityYear")
                        .HasColumnType("int");

                    b.Property<decimal>("PresentValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<float>("UpperBoundInterestRate")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("CalculatorValues");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2021, 8, 25, 6, 14, 55, 103, DateTimeKind.Utc).AddTicks(9008),
                            DateUpdated = new DateTime(2021, 8, 25, 6, 14, 55, 103, DateTimeKind.Utc).AddTicks(9247),
                            FutureValue = 1100m,
                            IncrementalRate = 0.2f,
                            LowerBoundInterestRate = 0.1f,
                            MaturityYear = 4,
                            PresentValue = 1000m,
                            UpperBoundInterestRate = 0.5f
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2021, 8, 25, 6, 14, 55, 104, DateTimeKind.Utc).AddTicks(7922),
                            DateUpdated = new DateTime(2021, 8, 25, 6, 14, 55, 104, DateTimeKind.Utc).AddTicks(7931),
                            FutureValue = 1430m,
                            IncrementalRate = 0.2f,
                            LowerBoundInterestRate = 0.3f,
                            MaturityYear = 4,
                            PresentValue = 1100m,
                            UpperBoundInterestRate = 0.5f
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2021, 8, 25, 6, 14, 55, 104, DateTimeKind.Utc).AddTicks(8053),
                            DateUpdated = new DateTime(2021, 8, 25, 6, 14, 55, 104, DateTimeKind.Utc).AddTicks(8055),
                            FutureValue = 2145m,
                            IncrementalRate = 0.2f,
                            LowerBoundInterestRate = 0.5f,
                            MaturityYear = 4,
                            PresentValue = 1430m,
                            UpperBoundInterestRate = 0.5f
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateTime(2021, 8, 25, 6, 14, 55, 104, DateTimeKind.Utc).AddTicks(8095),
                            DateUpdated = new DateTime(2021, 8, 25, 6, 14, 55, 104, DateTimeKind.Utc).AddTicks(8096),
                            FutureValue = 3217.5m,
                            IncrementalRate = 0.2f,
                            LowerBoundInterestRate = 0.5f,
                            MaturityYear = 4,
                            PresentValue = 2145m,
                            UpperBoundInterestRate = 0.5f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}