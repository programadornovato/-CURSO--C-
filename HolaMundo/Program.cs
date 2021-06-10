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
            Cuadrilatero c;
            Console.WriteLine("Humano que tipo de figura deseas calcular: \n1 Cuadrado \n2 Rectangulo");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("Humano ingresa el valor del lado de tu cuadrado");
                double lado = double.Parse(Console.ReadLine());
                c = new Cuadrilatero(lado);
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Humano ingresa el valor del lado 1 del rectangulo");
                double lado1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Humano ingresa el valor del lado 2 del rectangulo");
                double lado2 = double.Parse(Console.ReadLine());
                c = new Cuadrilatero(lado1, lado2);
            }
            else {
                Console.WriteLine("Humano estupido las opciones solo son 1 y 2");
                c = new Cuadrilatero(0);
            }
            Console.WriteLine("Humano el perimetro es "+c.perimetro()+" el area es "+c.area());
            Console.Read();
        }
    }
}
