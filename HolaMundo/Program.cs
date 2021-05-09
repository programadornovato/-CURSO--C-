using System;
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
            try
            {
                Console.WriteLine("Bienvenido a su tienda PN");
                Console.WriteLine("Ingresa el valor del producto 1:");
                double p1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el valor del producto 2:");
                double p2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el valor del producto 3:");
                double p3 = double.Parse(Console.ReadLine());
                double suma = p1 + p2 + p3;
                Console.WriteLine("Humano deseas redondear tus centavos S/N");
                string respuesta = Console.ReadLine();
                if ((respuesta == "S") || (respuesta == "s"))
                {
                    double sumaRedondeada = Math.Ceiling(suma);
                    double redendeo = sumaRedondeada - suma;
                    Console.WriteLine("Gracias humano por haber redondeado " + String.Format("{0:C}", redendeo));
                }
                else
                {
                    Console.WriteLine("Pinche humano miserable");
                }
            }
            catch (Exception e) {
                Console.WriteLine("Pinche cajero tonto escribiste algo mal "+ e);
            }
            Console.Read();
        }
    }
}
