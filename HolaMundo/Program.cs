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
            int a = 1;
            int b = 2;
            //a =a + 1;
            //a +=1;
            /*
            a++;
            Console.WriteLine("a="+a+" b="+b);
            b--;
            Console.WriteLine("a="+a+" b="+b);
            */
            b = ++a;
            Console.WriteLine("a=" + a + " b=" + b);
            Console.Read();
        }
    }
}
