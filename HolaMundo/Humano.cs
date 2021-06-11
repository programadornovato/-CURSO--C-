using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Humano:Animal
    {
        override public void comer() {
            Console.WriteLine("Soy el ser supremo y como en platos");
        }
        override public void correr() {
            Console.WriteLine("Soy el ser supremo y corro con tenis");
        }
    }
}
