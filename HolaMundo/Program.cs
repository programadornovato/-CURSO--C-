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
            int fil = int.Parse(Interaction.InputBox("Humano ingresa la cantidad de filas de tu matriz"));
            int col = int.Parse(Interaction.InputBox("Humano ingresa la cantidad de columnas de tu matriz"));
            int[,] matriz = new int[fil, col];
            for (int i = 0; i < fil; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matriz[i, j] = int.Parse(Interaction.InputBox("Matriz["+(i+1)+","+(j+1)+"]"));
                }
            }
            int sumaFil = 0;
            int sumaCol = 0;
            string res = "";
            for (int i = 0; i < fil; i++)
            {
                sumaFil = 0;
                for (int j = 0; j < col; j++)
                {
                    sumaFil = sumaFil + matriz[i, j];
                }
                res = res + "Las suma de la fila " + (i + 1) + " " + sumaFil+"\n";
            }
            res = res + "\n";
            for (int j = 0; j < col; j++)
            {
                sumaCol = 0;
                for (int i = 0; i < fil; i++)
                {
                    sumaCol = sumaCol + matriz[i, j];
                }
                res = res + "La suma de la columa " + (j + 1) + " " + sumaCol+"\n";
            }
            MessageBox.Show(res);
        }
    }
}
