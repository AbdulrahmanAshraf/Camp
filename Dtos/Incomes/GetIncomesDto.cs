using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Dtos.Incomes
{
    public class GetIncomesDto
    {
        public string DayDate { get; set; }
        public decimal Incomes { get; set; }
        public decimal Expenses { get; set; }
        public decimal TotalIncomes { get; set; }
   
    }
}
