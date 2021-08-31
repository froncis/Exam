using Exam.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Domain.Entities
{
    public class RateValues : BaseEntity
    {
        public int MaturityYear { get; set; }
        public float UpperBoundInterestRate { get; set; }
        public float IncrementalRate { get; set; }
    }
}