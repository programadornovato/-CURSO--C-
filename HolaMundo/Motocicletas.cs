using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Motocicletas : Gasolina
    {
        public override void llantas()
        {
            Console.WriteLine("Yo soy una moto y tengo 2 llantas");
        }
    }
}
