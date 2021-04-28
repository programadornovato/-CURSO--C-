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
            Console.WriteLine("Humano ingresa un NUMERO entre 0 y 10:");
            double calificacion = double.Parse(Console.ReadLine());
            int calRedondeada = Convert.ToInt32(Math.Round(calificacion));
            if ((calRedondeada >= 0) && (calRedondeada < 6))
            {
                Console.WriteLine("El alumno se chingo");
            }
            else if ((calRedondeada >= 6) && (calRedondeada <= 9))
            {
                Console.WriteLine("El alumno ya chingo");
            }
            else if (calRedondeada == 10)
            {
                Console.WriteLine("El alumno es una v3rg4");
            }
            else {
                Console.WriteLine("Humano estupido te pedi un numero entre 0 y 10");
            }

            Console.Read();
        }
    }
}
