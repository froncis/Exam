using Exam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Application.Common.Interfaces
{
    public interface IRateValueRepository : IAsyncRepository<RateValues>
    {
        Task<List<RateValues>> GetRateWithCalculatedValues();
        Task<List<RateValues>> GetAllRateValues();
    }
}
