using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Application.Services.RateValue.Queries.GetRateValueList
{
    public class RateValueListViewModel
    {
        public int Id { get; set; }
        public int MaturityYear { get; set; }
        public float UpperBoundInterestRate { get; set; }
        public float IncrementalRate { get; set; }
    }
}
