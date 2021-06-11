using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Camiones : Diesel
    {
        public override void llantas()
        {
            Console.WriteLine("Yo soy un camion y tengo 8 llanatas");
        }
    }
}
