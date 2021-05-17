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
            Console.WriteLine("Humano ingresa el numero a buscar");
            int numeroBuscar = int.Parse(Console.ReadLine());
            int[] listaNumeros = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Huamano ingresa el valor del elemento "+(i+1));
                listaNumeros[i]=int.Parse(Console.ReadLine());
            }
            int n = listaNumeros.Length;
            int inf = 0;
            int centro = 0;
            int sup = n - 1;
            bool bandera = false;
            while (inf <= sup) {
                centro = (sup + inf) / 2;
                if (listaNumeros[centro] == numeroBuscar)
                {
                    bandera = true;
                    break;
                }
                else if (numeroBuscar < listaNumeros[centro])
                {
                    sup = centro - 1;
                }
                else {
                    inf = centro + 1;
                }
            }
            if (bandera == true)
            {
                Console.WriteLine("Felicidades humano el numero " + numeroBuscar + " estaba en la posicion " + (centro + 1));
            }
            else {
                Console.WriteLine("Humano estupido el numero "+numeroBuscar+" no se encuentra en el arreglo");
            }
            Console.Read();
        }
    }
}
