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
            int num1 = 5;
            int num2 = 3;
            int suma = num1 + num2;
            Console.WriteLine("Suma="+suma);

            int resta = num1 - num2;
            Console.WriteLine("Resta=" + resta);

            double divicion = Convert.ToDouble(num1) / Convert.ToDouble(num2);
            Console.WriteLine("Divicion=" + divicion);

            int multiplicacion = num1 * num2;
            Console.WriteLine("Multiplicacion=" + multiplicacion);

            double residuo = num1 % num2;
            Console.WriteLine("Residuo=" + residuo);

            Console.Read();
        }
    }
}
