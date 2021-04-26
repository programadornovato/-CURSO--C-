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
            int num1 = 6;
            int num2 = 7;
            int suma = num1 + num2;
            int num3 = 3, num4 = 4, num5 = 15;
            double numd1 = 5.5;
            double numd2 = 6.6;
            double sumad = numd1 + numd2;
            float numFloat = 5.5f;
            //float sumaf = numFloat + numd1;
            Console.WriteLine("El valor de num1=" + num1 + " el tipo es=" + num1.GetType());
            Console.WriteLine("El valor de suma=" + suma + " el tipo es=" + suma.GetType());
            Console.WriteLine("El valor de sumad=" + sumad + " el tipo es=" + sumad.GetType());
            Console.WriteLine("El valor de numFloat=" + numFloat + " el tipo es=" + numFloat.GetType());

            Console.Read();
        }
    }
}
