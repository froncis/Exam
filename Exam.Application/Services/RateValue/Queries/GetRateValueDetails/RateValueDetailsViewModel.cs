using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Application.Services.RateValue.Queries.GetRateValueDetails
{
    public class RateValueDetailsViewModel
    {
        public int MaturityYear { get; set; }
        public float UpperBoundInterestRate { get; set; }
        public float IncrementalRate { get; set; }
        public List<CalculatedValuesDto> CalculatedValuesDtos { get; set; }
    }
}
