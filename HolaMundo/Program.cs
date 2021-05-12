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
            int altura = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("humano ingresa la cantidad de escales que va a tener tu escalera"));
            for (int numEscalera=1; numEscalera<=altura; numEscalera++) {
                for (int i = 1; i <= numEscalera; i++) {
                    Console.Write("*");
                }
                Console.WriteLine("");

            }
            Console.Read();
        }
    }
}
