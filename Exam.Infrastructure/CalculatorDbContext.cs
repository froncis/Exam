using Exam.Application.Common;
using Exam.Domain.Common;
using Exam.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Infrastructure
{
    public class CalculatorDbContext : DbContext
    {
        public CalculatorDbContext(DbContextOptions<CalculatorDbContext> options) : base(options)
        {
        }

        public DbSet<CalculatorValues> CalculatorValues { get; set; }
        public DbSet<RateValues> RateValues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CalculatorDbContext).Assembly);

            modelBuilder.Entity<CalculatorValues>().HasData(new CalculatorValues
            {
                Id = 1,
                PresentValue = 1000,
                FutureValue = 1100,
                LowerBoundInterestRate = 0.1F,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow
            });
            modelBuilder.Entity<CalculatorValues>().HasData(new CalculatorValues
            {
                Id = 2,
                PresentValue = 1100,
                LowerBoundInterestRate = 0.3F,
                FutureValue = 1430,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow
            });
            modelBuilder.Entity<CalculatorValues>().HasData(new CalculatorValues
            {
                Id = 3,
                PresentValue = 1430,
                LowerBoundInterestRate = 0.5F,
                FutureValue = 2145,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow
            });
            modelBuilder.Entity<CalculatorValues>().HasData(new CalculatorValues
            {
                Id = 4,
                PresentValue = 2145,
                LowerBoundInterestRate = 0.5F,
                FutureValue = 3217.5M,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow
            });
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.DateCreated = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.DateUpdated = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
