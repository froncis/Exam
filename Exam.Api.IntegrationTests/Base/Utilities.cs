using Exam.Domain.Entities;
using Exam.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Api.IntegrationTests.Base
{
    public class Utilities
    {
        public static void InitializeDbForTests(CalculatorDbContext context)
        {
            context.RateValues.Add(new RateValues
            {
                IncrementalRate = 10F,
                MaturityYear = 4,
                UpperBoundInterestRate = 50F
            });
            context.RateValues.Add(new RateValues
            {
                IncrementalRate = 20F,
                MaturityYear = 2,
                UpperBoundInterestRate = 30F
            });
            context.RateValues.Add(new RateValues
            {
                IncrementalRate = 10F,
                MaturityYear = 5,
                UpperBoundInterestRate = 40F
            });
            context.RateValues.Add(new RateValues
            {
                IncrementalRate = 10F,
                MaturityYear = 7,
                UpperBoundInterestRate = 50F
            });

            context.SaveChanges();
        }
    }
}
