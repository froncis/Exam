using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Application.Services.Calculator
{
    public static class InterestRateCalculator
    {
        public static List<double> GetYearlyValue(float presentValue, int maturityYear,
               float lowerBoundInterestRate, float upperBoundrateInterestRate, float incrementalRate)
        {
            List<double> futureValueList = new List<double>();

            float initialFutureValue = presentValue;
            lowerBoundInterestRate = lowerBoundInterestRate / 100;
            incrementalRate = incrementalRate / 100;
            upperBoundrateInterestRate = upperBoundrateInterestRate / 100;

            for (int i = 0; i < maturityYear; i++)
            {
                //1000(present value) *  10% or 0.10(lowerBoundRate) = 100(interestValue)
                var interestValue = presentValue * lowerBoundInterestRate;

                //1000 + 100 = 1100(futureValue)
                var futureValue = initialFutureValue + interestValue;

                //This is to save the value of increased presentValue to futureValue
                initialFutureValue = futureValue;

                futureValueList.Add(futureValue);

                //0.10/10%(lowerBoundRate) + 0.20/20%(incrementalRate) = 0.30/30%(new lowerBoundRate)
                lowerBoundInterestRate = lowerBoundInterestRate + incrementalRate;
                presentValue = futureValue;

                if (lowerBoundInterestRate > upperBoundrateInterestRate)
                    // fix the increasedRate to uppoBoundRate
                    lowerBoundInterestRate = upperBoundrateInterestRate;

            }
            return futureValueList;
        }

        public static List<CalculatorDto> GetYearlyValueByClass(CalculatorDto value)
        {
            List<CalculatorDto> listPerYearComputation = new List<CalculatorDto>();

            var lower = value.LowerBoundInterestRate /= 100;
            var upper = value.UpperBoundInterestRate /= 100;
            var incRate = value.IncrementalRate /= 100;

            var newPresentValue = value.PresentValue;

            for (int i = 0; i < value.MaturityYear; i++)
            {
                CalculatorDto perYearComputation = new CalculatorDto();
                perYearComputation.PresentValue = newPresentValue;
                perYearComputation.Year = i+1;
                perYearComputation.LowerBoundInterestRate = lower;
                perYearComputation.UpperBoundInterestRate = upper;
                perYearComputation.IncrementalRate = incRate;
                perYearComputation.MaturityYear = value.MaturityYear;

                var newLowerInterestRate = newPresentValue * Convert.ToDecimal(lower);

                perYearComputation.FutureValue = newPresentValue + newLowerInterestRate;

                listPerYearComputation.Add(perYearComputation);

                lower += incRate;

                if (lower > upper)
                    lower = upper;

                newPresentValue = perYearComputation.FutureValue;
            }

            return listPerYearComputation;
        }
    }
}
