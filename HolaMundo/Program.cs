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
            bool entro = false;
            int numero= int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Humano ingresa un numero entre 1 y 999:"));
            if (numero >= 0 && numero <= 9)
            {
                MessageBox.Show("El numero " + numero + " es de tipo unidad");
                entro = true;
            }
            else {
                if (numero >= 10 && numero <= 99)
                {
                    MessageBox.Show("El numero " + numero + " es de tipo decena");
                    entro = true;
                }
                else {
                    if (numero >= 100 && numero <= 999) {
                        MessageBox.Show("El numero " + numero + " es de tipo centena");
                        entro = true;
                    }
                }
            }
            if (entro == false) {
                MessageBox.Show("Humano estupido te pedi un numero entre 0 y 999");
            }
            //Console.Read();
        }
    }
}
