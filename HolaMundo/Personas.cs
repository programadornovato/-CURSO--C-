using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Personas
    {
        private string nombre;
        private string apellido;
        private int edad;
        public Personas(string _nombre, string _apellido, int _edad) {
            nombre = _nombre;
            apellido = _apellido;
            edad = _edad;
        }
        public string getNombre() {
            return nombre;
        }
        public string getApellido() {
            return apellido;
        }
        public int getEdad() {
            return edad;
        }
    }
}
