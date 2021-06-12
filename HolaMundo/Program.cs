using System;
using System.Collections;
using System.Windows.Forms;
using Microsoft.VisualBasic;
/*
Autor: Programador novato
Fecha: 01/01/2021
Este programa hace que los novatos aprenden a hacer
un codigo bonito y ya
*/
namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro[] c = new Carro[4];
            c[0] = new Carro("CARRO01","Nissan","2010");
            c[1] = new tipoDeportivo("DEPORT01","Nissan","2012",8);
            c[2] = new TipoTurismo("TUR01","Nissan","2015",4);
            c[3] = new tipoFurgoneta("FUR01","Nissan","2018",500);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(c[i].retornarDatos());
            }
            Console.Read();
        }
    }
}
