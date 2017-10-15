using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefugeeCamp.Domaine.Entity;

namespace RefugeeCamp.Data
{
<<<<<<< HEAD
   public class Context : DbContext
=======
    class Context : DbContext
>>>>>>> master
    {
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Refugee> Refugees { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public Context() : base("name = RefugeeCampConection")
        {
        }
    }
}
