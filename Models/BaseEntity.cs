using System;
using System.ComponentModel.DataAnnotations;

namespace PlaystationProject.Models
{
    public class BaseEntity: BaseKey
    {
        public DateTime Create_Date { get; set; }
        public DateTime? Last_Modify_Date { get; set; }
        public Guid Created_By { get; set; }
        public Nullable<Guid> Last_Modified_By { get; set; }
    }
}
