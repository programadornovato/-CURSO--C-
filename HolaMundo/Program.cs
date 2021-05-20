using System;
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
            Persona p1 = new Persona("juan", -1);
            Persona p2 = new Persona("pepe", -2);
            //p1.inicializar("juan",1);
            p1.mostrar();
            p2.mostrar();
            Console.Read();
        }
    }
}
