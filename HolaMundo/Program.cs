using System;
using System.Windows.Forms;
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
            int i = 1;
            do
            {
                Console.WriteLine("i="+i);
                i++;
            } while (i <= 10);
            */
            /*
            int i = -10;
            do {
                Console.WriteLine("i=" + i);
                i--;
            } while (i>=1);
            */
            Random rdn = new Random();
            int aleatorio = rdn.Next(1,7);
            int i = 1;
            do {
                Console.WriteLine("i=" + i+" aleatorio="+aleatorio);
                i++;
            } while (i<=aleatorio);
            Console.Read();
        }
    }
}
