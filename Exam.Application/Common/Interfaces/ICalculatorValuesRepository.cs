using Exam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Application.Common.Interfaces
{
    public interface ICalculatorValuesRepository : IAsyncRepository<CalculatorValues>
    {
        Task<List<CalculatorValues>> GetAllCalculatedValuesByRateId(int id);
    }
}
