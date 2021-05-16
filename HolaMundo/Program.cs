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
            Console.WriteLine("Humano por favor ingresa dos pinches numeros");
            Console.WriteLine("Valor de a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de b");
            int b = int.Parse(Console.ReadLine());
            int tem = a;
            a = b;
            b = tem;
            Console.WriteLine("El valor de a es "+a);
            Console.WriteLine("El valor de b es "+b);
            Console.ReadLine();
        }
    }
}
