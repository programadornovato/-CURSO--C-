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
            string miPagina = "ProgramadorNovato.com";
            string presentacion = "Mi pagina web es: ";
            miPagina = miPagina.ToLower();
            Console.WriteLine(presentacion+ miPagina);
            Console.Read();
        }
    }
}
