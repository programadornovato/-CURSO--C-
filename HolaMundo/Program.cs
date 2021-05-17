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
            int[,] matrizO = new int[3,3];
            int[,] matrizT = new int[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizO[i, j] = int.Parse(Interaction.InputBox("Humano ingresa el elemento de la matrizO["+(i+1)+ "," + (j + 1) + "]"));
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizT[i, j] = matrizO[j, i];
                }
            }
            string resultado = "Matriz original\n";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultado = resultado + matrizO[i, j] + " | ";
                }
                resultado = resultado + "\n";
            }
            resultado = resultado+"\n\nMatriz original\n";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultado = resultado + matrizT[i, j] + " | ";
                }
                resultado = resultado + "\n";
            }
            MessageBox.Show(resultado);
        }
    }
}
