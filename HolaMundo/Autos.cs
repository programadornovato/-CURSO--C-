using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Autos : Gasolina
    {
        public override void llantas()
        {
            Console.WriteLine("Yo sou un auto y tengo 4 llantas");
        }
    }
}
