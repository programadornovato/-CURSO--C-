using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class tipoDeportivo:Carro
    {
        private int cilindros;
        public tipoDeportivo(string _matricula, string _marca, string _modelo, int _cilindros)
        : base(_matricula, _marca, _modelo)
        {
            cilindros = _cilindros;
        }
        override public string retornarDatos()
        {
            return "matricula=" + getMatricula() + " marca=" + getMarca() + " modelo=" + getModelo() + " cilindros=" + cilindros;
        }

    }
}
