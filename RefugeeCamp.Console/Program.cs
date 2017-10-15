using RefugeeCamp.Data;
using RefugeeCamp.Domaine.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Refugee refugee = new Refugee {FirstName="Jasser" };
            Context ctx = new Context();
            ctx.Refugees.Add(refugee);
        }
    }
}
