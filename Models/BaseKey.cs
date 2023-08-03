using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Models
{
    public class BaseKey
    {
        [Key]
        public Guid Id { get; set; }
    }
}
