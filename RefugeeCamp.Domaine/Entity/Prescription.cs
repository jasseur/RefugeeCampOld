using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.Entity
{
    public class Prescription
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public List<Drug> Drugs { get; set; }
    }
}
