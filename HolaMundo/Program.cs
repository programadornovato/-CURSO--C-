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
            Random rdn = new Random();
            int aleatorio=rdn.Next(1,6);
            int numero=int.Parse(Interaction.InputBox("Humano por favor ingresa un numero entre 1 y 5"));
            while (aleatorio != numero) {
                numero = int.Parse(Interaction.InputBox("Humano estupido no le atinaste el numero que estaba pensando era "+ aleatorio+" intenta de nuevo o ingresa 0 para salir"));
                if (numero == 0) {
                    break;
                }
                aleatorio = rdn.Next(1, 6);
            }
            if (numero == 0)
            {
                MessageBox.Show("Ademas de ser estupido eres impasiente el numero que estaba pensando era " + aleatorio);
            }
            else {
                MessageBox.Show("Felicidades humano le atinaste al numero "+numero);
            }
            //Console.Read();
        }
    }
}
