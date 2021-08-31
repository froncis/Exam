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
    public class RateValueRepository : BaseRepository<RateValues>, IRateValueRepository
    {
        public RateValueRepository(CalculatorDbContext context) : base(context)
        {
        }

        public Task<List<RateValues>> GetRateWithCalculatedValues()
        {
            throw new NotImplementedException();
        }

        public Task<List<RateValues>> GetAllRateValues()
        {
            var result = _context.RateValues.OrderBy(i => i.DateCreated).ToListAsync();
            return result;
        }
    }
}
