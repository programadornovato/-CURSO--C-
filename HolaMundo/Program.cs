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
            int a = 1;
            int b = 2;
            int res = 0;
            Calculadora c = new Calculadora();
            res=c.suma(a,b);
            Console.WriteLine("Suma="+ res);
            res=c.resta(a,b);
            Console.WriteLine("Resta=" + res);
            res=c.multiplicacion(a,b);
            Console.WriteLine("Multiplicacion=" + res);
            double ad = 1;
            double bd = 2;
            double resD=c.divicion(ad,bd);
            Console.WriteLine("Divicion=" + resD);

            Console.Read();
        }
    }
}
