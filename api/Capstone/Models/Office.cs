using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Office
    {
        public int OfficeId { get; set; }
        public int AddressId { get; set; }
        public int Phone { get; set; }
        public int OfficeHours { get; set; }

    }
}
