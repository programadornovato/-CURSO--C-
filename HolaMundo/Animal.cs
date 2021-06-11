using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Animal
    {
        virtual public void comer() {
            Console.WriteLine("Los animales comen");
        }
        virtual public void correr() {
            Console.WriteLine("Los animales corren");
        }
    }
}
