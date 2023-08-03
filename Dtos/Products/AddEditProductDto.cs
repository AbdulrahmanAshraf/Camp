using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Dtos.Products
{
    public class AddEditProductDto
    {
        public string Id { get; set; }
        [Required(ErrorMessage ="اسم المنتج مطلوب")]
        public string Name { get; set; }
        [Required(ErrorMessage = "نوع المنتج مطلوب")]
        public string Category { get; set; }
        public int? Quantity { get; set; }
        [Required(ErrorMessage = "سعر المنتج مطلوب")]
        public decimal Price { get; set; }
    }
}
