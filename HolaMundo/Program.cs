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
            /*
            int[,] matriz = new int[2, 3];
            Console.WriteLine("Filas "+matriz.GetLength(0));
            Console.WriteLine("Columnas "+matriz.GetLength(1));
            */
            Console.WriteLine("Humano ingresa la cantidad de filas de tu matriz");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Humano ingresa la cantidad de columnas de tu matriz");
            int columnas = int.Parse(Console.ReadLine());
            int[,] matriz = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine("Matriz["+(i+1)+","+(j+1)+"]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Humano aqui esta tu piche matriz");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i,j]+",");
                }
                Console.WriteLine();
            }
            int[,,] matriz3d = new int[1, 2, 3];
            Console.WriteLine("x "+matriz3d.GetLength(0));
            Console.WriteLine("y "+matriz3d.GetLength(1));
            Console.WriteLine("z "+matriz3d.GetLength(2));
            Console.Read();
        }
    }
}
