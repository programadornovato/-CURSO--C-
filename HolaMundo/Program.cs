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
            MiClase c1 = new MiClase();
            MiClase c2 = new MiClase();
            c1.normal = "c1 Atributo normal modificado";
            c2.normal = "c2 Atributo normal modificado";
            Console.WriteLine("c1.normal="+ c1.normal);
            Console.WriteLine("c2.normal="+ c2.normal);
            MiClase.estatico = "Atributo estatico modificado";
            Console.WriteLine("MiClase.estatico="+ MiClase.estatico);
            Console.Read();
        }
    }
}
