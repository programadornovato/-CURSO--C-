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
            int[] a = new int[5];
            int[] b = new int[5];
            int[] c = new int[10];
            int j = 0;
            for (int i = 0; i < 5; i++) {
                a[i]=int.Parse(Interaction.InputBox("Humano ingresa el elemento del arreglo a["+(i+1)+"] "));
            }
            for (int i = 0; i < 5; i++) {
                b[i]=int.Parse(Interaction.InputBox("Humano ingresa el elemento del arreglo b["+(i+1)+"] "));
            }
            for (int i = 0; i < 5; i++) {
                c[j] = a[i];
                j++;
                c[j] = b[i];
                j++;
            }
            string arreglo = "";
            foreach (int elemento in c) {
                arreglo = arreglo +"\n"+ elemento;
            }
            MessageBox.Show(arreglo);
        }
    }
}
