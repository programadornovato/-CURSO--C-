using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class tipoFurgoneta:Carro
    {
        private int carga;
        public tipoFurgoneta(string _matricula, string _marca, string _modelo, int _carga)
        : base(_matricula, _marca, _modelo)
        {
            carga = _carga;
        }
        override public string retornarDatos()
        {
            return "matricula=" + getMatricula() + " marca=" + getMarca() + " modelo=" + getModelo() + " carga=" + carga;
        }

    }
}
