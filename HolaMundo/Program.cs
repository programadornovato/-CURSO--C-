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
            string texto = Interaction.InputBox("Humano por favor ingresa una lista de numeros separados por comas");
            string[] listaNumerosTexto = texto.Split(',');
            int cantidad = listaNumerosTexto.Length;
            int[] listaNumeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                listaNumeros[i] = int.Parse(listaNumerosTexto[i]);
            }
            int tem = 0;
            for (int i = 0; i < cantidad-1; i++)
            {
                for (int j = 0; j < cantidad - 1; j++)
                {
                    if (listaNumeros[j] > listaNumeros[j + 1]) {
                        tem = listaNumeros[j];
                        listaNumeros[j] = listaNumeros[j + 1];
                        listaNumeros[j + 1] = tem;
                    }
                }
            }
            Console.WriteLine("Humano aqui estan tus pinches numeros odenados de forma acendente");
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(listaNumeros[i]);
            }
            Console.WriteLine("Humano aqui estan tus pinches numeros odenados de forma decendente");
            for (int i = cantidad-1; i >= 0; i--)
            {
                Console.WriteLine(listaNumeros[i]);
            }
            Console.Read();
        }
    }
}
