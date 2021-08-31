using AutoMapper;
using Exam.Application.Services.CalculatorValue;
using Exam.Application.Services.CalculatorValue.Commands.CreateListCalculatorValue;
using Exam.Application.Services.RateValue.Command.CreateRateValue;
using Exam.Application.Services.RateValue.Command.UpdateRateValue;
using Exam.Application.Services.RateValue.Queries.GetRateValueDetails;
using Exam.Application.Services.RateValue.Queries.GetRateValueList;
using Exam.Domain.Entities;

namespace Exam.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CalculatorValues, CalculatorValueViewModel>().ReverseMap();

            //This is map for Create
            CreateMap<RateValues, CreateRateValueCommand>().ReverseMap();
            CreateMap<RateValues, UpdateRateValueCommand>().ReverseMap();

            CreateMap<CalculatorValues, CalculatedInterestValueCommand>().ReverseMap();

            //This is map for Queries
            CreateMap<RateValues, RateValueListViewModel>().ReverseMap();
            CreateMap<RateValues, RateValueDetailsViewModel>().ReverseMap();
            CreateMap<CalculatorValues, CalculatedValuesDto>().ReverseMap();
        }
    }
}
