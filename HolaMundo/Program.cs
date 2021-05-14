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
            Console.WriteLine("humano por favor ingresa un texto");
            string texto = Console.ReadLine();
            if (texto != "") {
                int longitud = texto.Length;
                char[] caracteres = new char[longitud];
                int contador = 0;
                for (int i = longitud - 1; i >= 0; i--) {
                    caracteres[contador] = texto[i];
                    contador++;
                }
                /*
                foreach (char caracter in caracteres) {
                    Console.Write(caracter);
                }
                */
                Console.WriteLine(caracteres);
            }
            Console.Read();
        }
    }
}
