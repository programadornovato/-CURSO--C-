using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Carro
    {
        private string matricula;
        private string marca;
        private string modelo;
        public Carro(string _matricula, string _marca, string _modelo) {
            matricula = _matricula;
            marca = _marca;
            modelo = _modelo;
        }
        public string getMatricula() {
            return matricula;
        }
        public string getMarca() {
            return marca;
        }
        public string getModelo() {
            return modelo;
        }
        virtual public string retornarDatos() {
            return "matricula=" + matricula + " marca=" + marca + " modelo=" + modelo;
        }
    }
}
