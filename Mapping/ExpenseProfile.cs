using PlaystationProject.Dtos.Expenses;
using PlaystationProject.Models;
using PlaystationProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Mapping
{
    public class ExpenseProfile : MappingProfileBase
    {
        public ExpenseProfile()
        {
            CreateMap<Expense, EditExpenseDto>().ReverseMap();
        }
    }
}
