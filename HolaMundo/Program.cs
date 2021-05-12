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
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("i="+(i+1));
            }
            */
            /*
            for (int i = 0; i < 10; i=i+2) {
                Console.WriteLine("i="+i);
            }
            
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine("i=" + (i + 1));
            }
            */
            int repeticiones;
            try {
                repeticiones = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("humano ingresa un numero"));
            }
            catch (Exception e) {
                Console.WriteLine("Humano estupido te pedi un inche numero");
                repeticiones = 0;
            }
            for (int i = 0; i < repeticiones; i++) {
                Console.WriteLine("i=" + (i + 1));
            }
            Console.Read();
        }
    }
}
