using Exam.Application.Common.Interfaces;
using Exam.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CalculatorDbContext>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("CalculatorExamConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<ICalculatorValuesRepository, CalculatorValueRepository>();
            services.AddScoped<IRateValueRepository, RateValueRepository>();
            return services;
        }
    }
}
