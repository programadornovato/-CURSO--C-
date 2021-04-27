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
            string nombre = "Juan", apellido = "Peres";
            string nombreCompleto = nombre +" "+ apellido;
            Console.WriteLine(nombreCompleto);
            apellido = "Perez";
            nombreCompleto = nombre + " " + apellido;
            Console.WriteLine(nombreCompleto);
            Console.Read();
        }
        static public void saluda() {
            Console.WriteLine("Hola");
        }
    }
}
