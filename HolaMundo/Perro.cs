using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Perro : Animal
    {
        override public void comer()
        {
            Console.WriteLine("Nosotros los perros comemos en el un plato en el piso");
        }
        override public void correr()
        {
            Console.WriteLine("Los perros correteamos a los humanos");
        }

    }
}
