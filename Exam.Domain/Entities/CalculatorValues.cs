using Exam.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Domain.Entities
{
    public class CalculatorValues : BaseEntity
    {
        public decimal PresentValue { get; set; }
        public decimal FutureValue { get; set; }
        public int Year { get; set; }
        public float LowerBoundInterestRate { get; set; }
        public RateValues RateValues { get; set; }
    }
}