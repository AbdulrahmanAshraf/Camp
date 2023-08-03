using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Dtos.Devices
{
    public class EditDeviceDto
    {
        [Required]
        public string Id { get; set; }

        [Required(ErrorMessage = "اسم الجهاز مطلوب")]
        public string Name { get; set; }

        [Required(ErrorMessage = "نوع الجهاز مطلوب")]
        public string Type { get; set; }

        [Required(ErrorMessage = "سعر الساعة الفردي  مطلوب")]
        public int SingleHourCost { get; set; }

        [Required(ErrorMessage = "سعر الساعة الزوجي  مطلوب")]
        public int MultiHourCost { get; set; }
    }
}
