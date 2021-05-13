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
            string texto = Interaction.InputBox("Humano por favor ingresa un palindromo");
            string textoTemp = texto;
            //ana
            if (texto != null) {
                texto = texto.ToLower();
                texto = texto.Replace(" ", "");
                int longitud = texto.Length;
                bool igual = true;
                int cont = 0;
                for (int ind=longitud-1;ind>=0;ind--) {
                    if (texto[ind] != texto[cont]) {
                        igual = false;
                        break;
                    }
                    cont++;
                }
                if (igual == true)
                {
                    MessageBox.Show("Felicidades humano la frace " + textoTemp + " si es palindromo");
                }
                else {
                    MessageBox.Show("Humano estupido la frace " + textoTemp + " no si es palindromo");
                }
            }
            //Console.Read();
        }
    }
}
