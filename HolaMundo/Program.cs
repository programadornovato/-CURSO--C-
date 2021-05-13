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
            string[] perros=new string[] { "Monte","Chupacabras","Solovino","Chimuelo","El chiquito" };
            Console.WriteLine("CICLO CON FOR");
            for (int i = 0; i < perros.Length; i++) Console.WriteLine("El perro "+i+" es "+perros[i]);

            Console.WriteLine("CICLO CON FOREACH");
            int j = 0;
            foreach (string perro in perros) {
                Console.WriteLine("El perro "+j+" es "+perro);
                j++;
            }
            
            Console.Read();
        }
    }
}
