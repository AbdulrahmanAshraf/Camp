using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Dtos.Devices
{
    public class AddPeriodDto
    {
        [Required]
        public Guid WorkingDeviceId { get; set; }

        [Required(ErrorMessage = "نوع الفترة مطلوب")]
        public string PeriodType { get; set; }
    }
}
