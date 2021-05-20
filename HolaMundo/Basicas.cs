using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Basicas
    {
        int n1;
        int n2;
        public Basicas(int _n1,int _n2) {
            n1 = _n1;
            n2 = _n2;
        }
        public int suma() {
            return n1 + n2;
        }
        public int resta() {
            return n1 - n2;
        }
        public int multiplicacion() {
            return n1 * n2;
        }
        public int divicion() {
            return n1 / n2;
        }
    }
}
