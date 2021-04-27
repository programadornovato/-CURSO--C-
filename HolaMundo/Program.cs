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
            edad(1980);
            Console.Read();
        }
        public static void edad(int añoNacimiento) {
            int añosActual = DateTime.Now.Year;
            int edad = añosActual - añoNacimiento;
            Console.WriteLine("Edad es " + edad);
        }
    }
}
