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
            /*
            Console.WriteLine("Hola humano selecciona una de estas tres opciones:");
            Console.WriteLine("1.- Acceso");
            Console.WriteLine("2.- Configuracion");
            Console.WriteLine("3.- Salir");
            int opcion = int.Parse(Console.ReadLine());
            while (opcion != 3) {
                switch (opcion) {
                    case 1:
                        Console.WriteLine("Seleccionaste acceso");
                        break;
                    case 2:
                        Console.WriteLine("Seleccionaste Configuracion");
                        break;
                    case 3:
                        Console.WriteLine("Seleccionaste Salir, adios humano");
                        break;
                    default:
                        Console.WriteLine("Humano estupido te pedi que escribieras o 1 o 2 o 3");
                        break;
                }
                Console.WriteLine("Hola humano selecciona una de estas tres opciones:");
                Console.WriteLine("1.- Acceso");
                Console.WriteLine("2.- Configuracion");
                Console.WriteLine("3.- Salir");
                opcion = int.Parse(Console.ReadLine());
            }
            */
            int opcion = 0;
            do {
                Console.WriteLine("Hola humano selecciona una de estas tres opciones:");
                Console.WriteLine("1.- Acceso");
                Console.WriteLine("2.- Configuracion");
                Console.WriteLine("3.- Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Seleccionaste acceso");
                        break;
                    case 2:
                        Console.WriteLine("Seleccionaste Configuracion");
                        break;
                    case 3:
                        Console.WriteLine("Seleccionaste Salir, adios humano");
                        break;
                    default:
                        Console.WriteLine("Humano estupido te pedi que escribieras o 1 o 2 o 3");
                        break;
                }
            } while (opcion!=3);
            Console.Read();
        }
    }
}
