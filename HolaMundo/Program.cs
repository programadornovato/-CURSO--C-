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
            try
            {
                Console.WriteLine("Humano por favor ingresa un piche NUMERO:");
                string numString = Console.ReadLine();
                int num = int.Parse(numString);
                int cuadrado = num * num;
                Console.WriteLine("Tu numero " + num + " al cuadrado es:" + cuadrado);
            }
            catch (Exception e)
            {
                Console.WriteLine("Humano estupido te pedi un  N U M E R O");
            }
            finally {
                Console.WriteLine("Este codigo se ejecuta si o si");
            }
            Console.Read();
        }
    }
}
