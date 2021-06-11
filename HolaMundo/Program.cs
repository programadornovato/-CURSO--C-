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
            Personas p = new Personas("Juan","Perez",30);
            Console.WriteLine("Nombre="+p.getNombre()+" Apellido="+p.getApellido()+" Edad="+p.getEdad());
            Estudiantes e = new Estudiantes("Pepe", "Morales", 20, "cod_PPM", 10,'c');
            Console.WriteLine("Nombre=" + e.getNombre() + " Apellido=" + e.getApellido() + " Edad=" + e.getEdad()+" Codigo Estudiante="+e.getCodigoEstudiante()+" calificacion="+e.getCalificacion()+" Salon="+e.getSalon());
            Console.Read();
        }
    }
}
