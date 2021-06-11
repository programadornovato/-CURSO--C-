using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Estudiantes:Personas
    {
        private string codigoEstudiante;
        private float calificacion;
        private char salon;
        public Estudiantes(string _nombre, string _apellido, int _edad, string _codigoEstudiante, float _calificacion,char _salon)
            :base(_nombre,_apellido,_edad) {
            codigoEstudiante = _codigoEstudiante;
            calificacion = _calificacion;
            salon = _salon;
        }
        public string getCodigoEstudiante() {
            return codigoEstudiante;
        }
        public float getCalificacion() {
            return calificacion;
        }
        public char getSalon() {
            return salon;
        }
    }
}
