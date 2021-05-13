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
            int[] arregloNumeros = new int[] {5,8,3,7,4,1 };
            Console.WriteLine("El elemento numero 4="+ arregloNumeros[3]);
            Console.WriteLine("Longitud del arreglos es "+arregloNumeros.Length);
            for (int i= 0; i < arregloNumeros.Length; i++) {
                Console.WriteLine("El valor del elemento "+(i+1)+" es "+arregloNumeros[i]);
            }
            Console.Read();
        }
    }
}
