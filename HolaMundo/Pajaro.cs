using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Pajaro : Animal
    {
        override public void comer()
        {
            Console.WriteLine("Los pajaros comemos alpiste");
        }
        public void volar()
        {
            Console.WriteLine("Los pajaros volamos");
        }

    }
}
