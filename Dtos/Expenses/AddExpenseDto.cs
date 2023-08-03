using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Dtos.Expenses
{
    public class AddExpenseDto
    {
        [Required(ErrorMessage = "نوع المصروف مطلوب")]
        public string Type { get; set; }

        [Required(ErrorMessage = "وصف المصروف مطلوب")]
        public string Description { get; set; }

        [Required(ErrorMessage = "تكلفة المصروف مطلوب")]
        public decimal Cost { get; set; }
    }
}
