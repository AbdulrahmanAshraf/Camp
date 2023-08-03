using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Dtos.Expenses
{
    public class GetAllExpensesDto
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Cost { get; set; }
        public string CreateDate { get; set; }
    }
}
