using Exam.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Infrastructure.Configurations
{
    public class CalculatorValueConfiguration : IEntityTypeConfiguration<CalculatorValues>
    {
        public void Configure(EntityTypeBuilder<CalculatorValues> builder)
        {
            builder.Property(i => i.PresentValue)
                .IsRequired();

            builder.Property(i => i.LowerBoundInterestRate)
                .IsRequired();

            //builder.Property(i => i.RateValueId)
            //    .IsRequired();
        }
    }
}
