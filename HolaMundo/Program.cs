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
            double[] calificaciones = new double[4];
            int semestre = 0;
            double suma = 0;
            double promedio = 0;
            do {
                string calificacionString = Interaction.InputBox("humano ingresa la calificacion del semestre "+(semestre+1));
                if (calificacionString == "")
                {
                    break;
                }
                else {
                    double calificacion = double.Parse(calificacionString);
                    calificaciones[semestre] = calificacion;
                    semestre++;
                }
            } while (semestre<4);
            if (semestre > 0)
            {
                foreach (double cal in calificaciones)
                {
                    suma += cal;
                }
                promedio = suma / semestre;
                MessageBox.Show("La calificacion del alumno es:" + promedio);
            }
            else {
                MessageBox.Show("humano olgasan te pedi que ingresara calificaciones" );
            }

        }
    }
}
