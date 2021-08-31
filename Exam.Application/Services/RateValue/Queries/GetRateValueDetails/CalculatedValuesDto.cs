using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Application.Services.RateValue.Queries.GetRateValueDetails
{
    public class CalculatedValuesDto
    {
        public decimal PresentValue { get; set; }
        public decimal FutureValue { get; set; }
        public float LowerBoundInterestRate { get; set; }
        public int Year { get; set; }
    }
}
