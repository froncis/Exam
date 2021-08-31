
namespace Exam.Application.Services.Calculator
{
    public class CalculatorDto
    {
        public decimal PresentValue { get; set; }
        public decimal FutureValue { get; set; }
        public float LowerBoundInterestRate { get; set; }
        public int Year { get; set; }

        //Fix values
        public int MaturityYear { get; set; }
        public float UpperBoundInterestRate { get; set; }
        public float IncrementalRate { get; set; }

    }
}
