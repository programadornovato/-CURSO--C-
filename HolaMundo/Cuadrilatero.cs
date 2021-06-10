using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Cuadrilatero
    {
        private double lado1;
        private double lado2;
        public Cuadrilatero(double lado) {
            lado1 = lado;
            lado2 = lado;
        }
        public Cuadrilatero(double _lado1, double _lado2) {
            lado1 = _lado1;
            lado2 = _lado2;
        }
        public double perimetro() {
            return (lado1 + lado2) * 2;
        }
        public double area() {
            return lado1 * lado2;
        }

    }
}
