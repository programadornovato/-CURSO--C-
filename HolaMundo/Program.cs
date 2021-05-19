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
            int[,] matriz = new int[5, 5];
            int dato = 1;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = dato;
                    dato++;
                }
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j]+"\t");
                }
                Console.WriteLine();
            }
            
            int[] diagonalPrincipal = new int[matriz.GetLength(0)];
            int[] diagonalSecundaria = new int[matriz.GetLength(0)];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j) {
                        diagonalPrincipal[i] = matriz[i, j];
                    }
                    if ((i + j) == (matriz.GetLength(0) - 1)) {
                        diagonalSecundaria[i] = matriz[i, j];
                    }
                }
            }
            Console.WriteLine();
            int suma = 0;
            foreach (int numero in diagonalPrincipal) {
                Console.Write(numero+"\t");
                suma = suma + numero;
            }
            Console.WriteLine("suma diagonal princiapal="+suma+"\n");
            suma = 0;
            foreach (int numero in diagonalSecundaria)
            {
                Console.Write(numero + "\t");
                suma = suma + numero;
            }
            Console.WriteLine("suma diagonal secundaria=" + suma + "\n");
            Console.Read();
        }
    }
}
