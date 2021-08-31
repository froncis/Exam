using Exam.Application.Common.Interfaces;
using Exam.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Infrastructure.Repositories
{
    public class CalculatorValueRepository : BaseRepository<CalculatorValues>, ICalculatorValuesRepository
    {
        public CalculatorValueRepository(CalculatorDbContext context) : base(context)
        {
        }

        public async Task<List<CalculatorValues>> GetAllCalculatedValuesByRateId(int id)
        {
            var result = await _context.CalculatorValues.Where(i => i.RateValues.Id == id).ToListAsync();
            return result;
        }
    }
}
