using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Dtos.Account
{
    public class LoginDto
    {
        [Required(ErrorMessage ="اسم المستخدم مطلوب")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="كلمة السر مطلوبة")]
     
        public string Password { get; set; }
    }

   
}
