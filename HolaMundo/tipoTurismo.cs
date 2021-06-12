using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class TipoTurismo:Carro
    {
        private int numeroPuertas;
        public TipoTurismo(string _matricula, string _marca, string _modelo,int _numeroPuertas)
        :base(_matricula, _marca, _modelo)
        {
            numeroPuertas = _numeroPuertas;
        }
        override public string retornarDatos()
        {
            return "matricula=" + getMatricula() + " marca=" + getMarca() + " modelo=" + getModelo()+ " numeroPuertas="+ numeroPuertas;
        }

    }
}
