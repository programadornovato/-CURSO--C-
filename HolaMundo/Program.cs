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
            try { 
                Console.WriteLine("Humano con cuantos litro de cerveza te emborrachas:");
                double litrosBorracho= double.Parse(Console.ReadLine());
                double mililitrosBorracho = litrosBorracho * 1000;
                Console.WriteLine("Humano cual es el diametro de tu vaso:");
                double diametro = double.Parse(Console.ReadLine());
                Console.WriteLine("Humano cual es la altura de tu vaso:");
                double altura = double.Parse(Console.ReadLine());

                double radio = diametro / 2;

                double volumen = Math.PI * radio * 2 * altura;
                double limiteVasos = mililitrosBorracho / volumen;
                //Console.WriteLine("limiteVasos="+ limiteVasos);
                Console.WriteLine("¿Humano cuantos vasos de cerveza has tomado?:");
                double vasosTomados = double.Parse(Console.ReadLine());
                if (vasosTomados >= limiteVasos)
                {
                    Console.WriteLine("Humano ya excediste la cantidad de vazos para estar borracho (osea ya esta pedo)");
                }
                else {
                    Console.WriteLine("Humano te hacen falta "+(limiteVasos-vasosTomados)+" vasos para estar borracho");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Humano ya estas hasta las manitas ya ni puedes escribir un numero, y yo con borrachos no hablo adios");
            }
            Console.Read();
        }
    }
}
