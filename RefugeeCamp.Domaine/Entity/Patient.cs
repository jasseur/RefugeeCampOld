using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.Entity
{
    public class Patient : Refugee
    {
        public DateTime RegistrationDate { get; set; }

      //  public List<Allergie> Allergies { get; set; }
    }
}
