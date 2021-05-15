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
            int mayor = 0;
            string texto = Interaction.InputBox("humano ingresa una lista de numeros separados por comas");
            string[] listaNumerosString = texto.Split(',');
            int cantidad = listaNumerosString.Length;
            int[] numeros = new int[cantidad];
            /*
            foreach (string numero in listaNumerosString) {
                Console.WriteLine(numero);
            }
            */
            for (int i = 0; i < cantidad; i++) {
                numeros[i] = int.Parse(listaNumerosString[i]);
            }
            foreach (int num in numeros) {
                if (num > mayor) {
                    mayor = num;
                }
            }
            MessageBox.Show("El numero mayor es "+mayor);
            
        }
    }
}
