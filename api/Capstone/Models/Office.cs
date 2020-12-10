using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Office
    {
        public int OfficeId { get; set; }
      //  public int AddressId { get; set; }
        public int Phone { get; set; }
        public int OfficeHours { get; set; }
        public string OfficeName { get; set; }
       // public int AddressId { get; set; }
        public int UserId { get; set; }
        public string StreetAddress { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

    }
}
