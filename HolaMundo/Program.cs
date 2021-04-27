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
            //int años=edad(1980);
            Console.WriteLine("Edad es "+ edad(1980));
            Console.WriteLine("El año de nacimiento es "+ añoNacimiento(20));
            Console.Read();
        }
        public static int edad(int añoNacimiento) {
            int añosActual = DateTime.Now.Year;
            //int edad = añosActual - añoNacimiento;
            return añosActual - añoNacimiento;
        }
        public static int añoNacimiento(int edad) {
            int añoActual = DateTime.Now.Year;
            //int añoNacimiento = añoActual - edad;
            return añoActual - edad;
        }
    }
}
