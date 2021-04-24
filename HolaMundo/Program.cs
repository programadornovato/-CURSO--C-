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
            //Cambiamos el color del texto a amarillo y del fondo a azul
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            //escribimos texto y esperamos a que se precione una tecla
            Console.WriteLine("Hola mundo :)");
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hola Novato :)");
            Console.Read();
        }
    }
}
