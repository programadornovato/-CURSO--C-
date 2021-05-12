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
            /*
            int i = 1;
            while (i <= 10) {
                Console.WriteLine("i="+i);
                i=i+2;
            }
            */
            /*
            int i = 10;
            while (i >= 1) {
                Console.WriteLine("i=" + i);
                i=i-3;
            }
            */
            int repeticiones = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Humano ingresa el numero de repeticiones"));
            int i = 1;
            while (i <= repeticiones) {
                Console.WriteLine("i=" + i);
                i++;
            }
            Console.Read();
        }
    }
}
