using RefugeeCamp.Domaine.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.Entity
{
    public class Appointment
    {   
        public int Id { get; set; }
        public DateTime DateRgistration { get; set; }
        public DateTime DateAppointment { get; set; }
        public String AppointmentType { get; set; }
    }
}
