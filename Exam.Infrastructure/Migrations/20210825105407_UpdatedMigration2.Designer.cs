// <auto-generated />
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
    [Migration("20210825105407_UpdatedMigration2")]
    partial class UpdatedMigration2
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

                    b.Property<float>("LowerBoundInterestRate")
                        .HasColumnType("real");

                    b.Property<decimal>("PresentValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RateValuesId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RateValuesId");

                    b.ToTable("CalculatorValues");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2021, 8, 25, 10, 54, 6, 705, DateTimeKind.Utc).AddTicks(4493),
                            DateUpdated = new DateTime(2021, 8, 25, 10, 54, 6, 705, DateTimeKind.Utc).AddTicks(4753),
                            FutureValue = 1100m,
                            LowerBoundInterestRate = 0.1f,
                            PresentValue = 1000m,
                            Year = 0
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2021, 8, 25, 10, 54, 6, 706, DateTimeKind.Utc).AddTicks(3105),
                            DateUpdated = new DateTime(2021, 8, 25, 10, 54, 6, 706, DateTimeKind.Utc).AddTicks(3116),
                            FutureValue = 1430m,
                            LowerBoundInterestRate = 0.3f,
                            PresentValue = 1100m,
                            Year = 0
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2021, 8, 25, 10, 54, 6, 706, DateTimeKind.Utc).AddTicks(3229),
                            DateUpdated = new DateTime(2021, 8, 25, 10, 54, 6, 706, DateTimeKind.Utc).AddTicks(3231),
                            FutureValue = 2145m,
                            LowerBoundInterestRate = 0.5f,
                            PresentValue = 1430m,
                            Year = 0
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateTime(2021, 8, 25, 10, 54, 6, 706, DateTimeKind.Utc).AddTicks(3273),
                            DateUpdated = new DateTime(2021, 8, 25, 10, 54, 6, 706, DateTimeKind.Utc).AddTicks(3274),
                            FutureValue = 3217.5m,
                            LowerBoundInterestRate = 0.5f,
                            PresentValue = 2145m,
                            Year = 0
                        });
                });

            modelBuilder.Entity("Exam.Domain.Entities.RateValues", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<float>("IncrementalRate")
                        .HasColumnType("real");

                    b.Property<int>("MaturityYear")
                        .HasColumnType("int");

                    b.Property<float>("UpperBoundInterestRate")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("RateValues");
                });

            modelBuilder.Entity("Exam.Domain.Entities.CalculatorValues", b =>
                {
                    b.HasOne("Exam.Domain.Entities.RateValues", null)
                        .WithMany("CalculatorValues")
                        .HasForeignKey("RateValuesId");
                });

            modelBuilder.Entity("Exam.Domain.Entities.RateValues", b =>
                {
                    b.Navigation("CalculatorValues");
                });
#pragma warning restore 612, 618
        }
    }
}
