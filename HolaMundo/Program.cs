using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
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
            Console.WriteLine("Humano ingresa el numero a buscar de la lista");
            int numeroBuscar=int.Parse(Console.ReadLine());
            int[] listaNumeros = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Humano ingresa el elemento "+(i+1)+" de la lista");
                int numero = int.Parse(Console.ReadLine());
                listaNumeros[i] = numero;
            }
            int pos = 0;
            bool bandera = false;
            while (pos < 7 && bandera == false) {
                if (numeroBuscar == listaNumeros[pos]) {
                    bandera = true;
                    break;
                }
                pos++;
            }
            if (bandera == true)
            {
                Console.WriteLine("Felicidades humano se encontro el numero " + numeroBuscar + " en la posicion " + (pos+1));
            }
            else {
                Console.WriteLine("Lo siento humano no se encontro el numero "+numeroBuscar);
            }
            Console.Read();
        }
    }
}
