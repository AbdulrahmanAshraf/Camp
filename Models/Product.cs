using System.Collections.Generic;

namespace PlaystationProject.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? Quantity { get; set; }
        public string Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual MasterData MasterDataCode { get; set; }
    }
}
