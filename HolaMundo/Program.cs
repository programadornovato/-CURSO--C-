using System;
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
            double a = 6;
            double b = 5;
            Console.WriteLine("a="+a+" b="+b);
            /*
            //a = a + b;
            a += b;
            Console.WriteLine("a=" + a + " b=" + b);
            
            //a = a - b;
            a -= b;
            Console.WriteLine("a=" + a + " b=" + b);

            //a = a * b;
            a *= b;
            Console.WriteLine("a=" + a + " b=" + b);

            //a = a / b;
            a /= b;
            Console.WriteLine("a=" + a + " b=" + b);
            */
            //a = a % b;
            a %= b;
            Console.WriteLine("a=" + a + " b=" + b);


            Console.Read();
        }
    }
}
