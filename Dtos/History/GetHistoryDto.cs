using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Dtos.History
{
    public class GetHistoryDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string UserFullName { get; set; }
    }
}
