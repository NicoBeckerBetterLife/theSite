using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models;

namespace Domain.AutoMapper
{
    public class ExpencesMappingProfile : Profile
    {
        public ExpencesMappingProfile()
        {
            CreateMap<ExpenditureModel, Expens>().ReverseMap();
            CreateMap<ParishUserModel, ParishUser>().ReverseMap(); 
            CreateMap<ExpenseTypeModel, ExpenseType>().ReverseMap();
            CreateMap<UserModel, User>().ReverseMap();
        }
    }
}
