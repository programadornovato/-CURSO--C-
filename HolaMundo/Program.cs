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
            Random rand = new Random();
            int d1 = rand.Next(1,7);
            int d2 = rand.Next(1,7);
            int d3 = rand.Next(1,7);
            Console.WriteLine("Dado 1="+d1);
            Console.WriteLine("Dado 2="+d2);
            Console.WriteLine("Dado 3="+d3);
            if (d1 == 6 && d2 == 6 & d3 == 6)
            {
                Console.WriteLine("Excelente");
            }
            else {
                if ((d1 == 6 && d2 == 6) || (d1 == 6 && d3 == 6) || (d2 == 6 && d3 == 6))
                {
                    Console.WriteLine("Muy bien");
                }
                else {
                    if (d1 == 6 || d2 == 6 || d3 == 6)
                    {
                        Console.WriteLine("Bien");
                    }
                    else 
                    {
                        Console.WriteLine("Pesimo");
                    }
                }
            }
            Console.Read();
        }
    }
}
