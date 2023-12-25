using AutoMapper;
using Entities;
using Shared.DataTransferObjects;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Game
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<Question, QuestionDto>();
            CreateMap<Answer, AnswerDto>();
        }
    }
}
