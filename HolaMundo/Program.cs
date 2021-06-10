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
            Console.WriteLine("Humano ingresa la cantidad de alumnos");
            int cantidadAlumnos = int.Parse(Console.ReadLine());
            Alumnos[] a = new Alumnos[cantidadAlumnos];
            for (int i = 0; i < cantidadAlumnos; i++)
            {
                Console.WriteLine("Humano ingresa el NOMBRE del alumno "+(i+1));
                string nombre = Console.ReadLine();
                Console.WriteLine("Humano ingresa la CALIFICACION del alumno "+(i+1));
                double calificacion =double.Parse(Console.ReadLine());
                Console.WriteLine("Humano ingresa el AULA del alumno "+(i+1));
                char aula = Console.ReadLine()[0];
                a[i] = new Alumnos(nombre,calificacion,aula);
            }
            double suma = 0;
            double promedio = 0;
            int cantidadAlumnosSalon = 0;
            Console.WriteLine("Humano de que AULA quieres promediar las calificaciones");
            char salon = Console.ReadLine()[0];
            for (int i = 0; i < cantidadAlumnos; i++)
            {
                if (salon == a[i].getAula()) {
                    suma = suma + a[i].getCalificacion();
                    cantidadAlumnosSalon++;
                }
            }
            promedio = suma / cantidadAlumnosSalon;
            Console.WriteLine("El promedio de los alumnos del salon "+ salon+" es "+promedio);
            Console.Read();
        }
    }
}
