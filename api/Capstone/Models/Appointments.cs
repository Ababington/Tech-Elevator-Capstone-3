using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Appointments
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        //in sql date is date and time is time/ only DATETIME is an option so I left it as string
        public string Date { get; set; }
        public string Time { get; set; }
        public string Message { get; set; }
        //have as a bit in sql for 0 or 1. Want int or bool?
        public bool Virtual { get; set; }
        public string Status { get; set; }

    }
}
