using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Dtos
{
    public class GridSearchDto : Pagination
    {
        public string SearchName { get; set; }
        public string Type { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}
