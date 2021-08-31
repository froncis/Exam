
namespace Exam.Application.Services.CalculatorValue
{
    public class CalculatorValueViewModel
    {
        public decimal PresentValue { get; set; }
        public decimal FutureValue { get; set; }
        public float LowerBoundInterestRate { get; set; }
        public int Year { get; set; }
        public int RateValueId { get; set; }
    }
}
