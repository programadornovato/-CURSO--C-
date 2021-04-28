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
            Console.WriteLine("Humano por favor ingresa un NUMERO entre 1 y 7:");
            int dia = Convert.ToInt32(Console.ReadLine());
            switch (dia) {
                case 1:
                    Console.WriteLine("Seleccionaste el dia lunes");
                    break;
                case 2:
                    Console.WriteLine("Seleccionaste el dia martes");
                    break;
                case 3:
                    Console.WriteLine("Seleccionaste el dia miercoles");
                    break;
                case 4:
                    Console.WriteLine("Seleccionaste el dia jueves");
                    break;
                case 5:
                    Console.WriteLine("Seleccionaste el dia viernes");
                    break;
                case 6:
                    Console.WriteLine("Seleccionaste el dia sabado");
                    break;
                case 7:
                    Console.WriteLine("Seleccionaste el dia domingo");
                    break;
                default:
                    Console.WriteLine("Humano estupido te pedi un NUMERO entre 1 y 7");
                    break;
            }
            Console.Read();
        }
    }
}
