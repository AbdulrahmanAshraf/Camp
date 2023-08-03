using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Dtos.Products
{
    public class AddNewQuentityToProductDto
    {
        [Required]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "كمية المنتج مطلوبة")]
        public int Quantity { get; set; }

    }
}
