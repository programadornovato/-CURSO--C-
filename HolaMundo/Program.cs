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
            string[,] alumnos = new string[7,2];
            for (int i = 0; i < alumnos.GetLength(0); i++)
            {
                Console.WriteLine("Humano ingresa el nombre del alumno "+(i+1));
                alumnos[i,0]=Console.ReadLine();
                Console.WriteLine("Humano ingresa el salon del alumno "+(i+1));
                alumnos[i,1]=Console.ReadLine();
            }
            Console.WriteLine("Humano ingresa el salon de los alumnos que quieres ver ");
            string salon = Console.ReadLine();
            for (int i = 0; i < alumnos.GetLength(0); i++)
            {
                if (alumnos[i, 1] == salon) {
                    /*
                    Console.Write(alumnos[i,0]);
                    Console.Write(" | "+alumnos[i,1]);
                    */
                    for (int j = 0; j < alumnos.GetLength(1); j++)
                    {
                        Console.Write(alumnos[i,j]+" | ");
                    }

                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
