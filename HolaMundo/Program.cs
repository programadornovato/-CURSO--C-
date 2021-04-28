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
            Console.WriteLine("¿Humano como te llamas?");
            string nombre = Console.ReadLine();
            Console.WriteLine("¿"+ nombre +" en que año naciste?");
            int añoNacimiento = int.Parse(Console.ReadLine());
            int edad = DateTime.Now.Year - añoNacimiento;
            Console.WriteLine("¿" + nombre + " de pura casualidad cunto ganas al mes?");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Pobre "+nombre+" a tus "+edad+" años y solo ganas "+salario+ " pesitos ");
            Console.Read();
        }
    }
}
