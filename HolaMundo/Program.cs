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
            saluda();
            despide("Adios desde el parametro que recibe el metodo");
            Console.Read();
        }
        static public void saluda() 
        {
            Console.WriteLine("Hola desde el metodo");
        }
        static public void despide(string texto) 
        {
            Console.WriteLine(texto);
        }
    }
}
