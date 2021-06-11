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
            //Automotores a = new Automotores();
            //Gasolina g = new Gasolina();
            Autos a = new Autos();
            a.llantas();
            Camiones c = new Camiones();
            c.llantas();


            Console.Read();
        }
    }
}
