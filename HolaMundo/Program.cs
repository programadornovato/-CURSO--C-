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
            /*
            Console.WriteLine();
            Console.WriteLine("Hola");
            Console.WriteLine(5);
            Console.WriteLine(5.5);
            Console.WriteLine(true);
            */
            Vehiculo v1 = new Vehiculo("Nissan", "2020");
            v1.acelera();
            Vehiculo v2 = new Vehiculo("65464");
            v2.acelera(30);
            Console.Read();
        }
    }
}
