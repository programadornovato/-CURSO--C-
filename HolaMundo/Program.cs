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
            int contador = 0;
            double calificacion = 0;
            double suma = 0;
            double promedio = 0;
            string texto = "";
            do
            {
                texto=Interaction.InputBox("Humano ingresa la calificacion del semestre "+(contador+1)+" o preciona cancelar para terminar");
                if (texto != "") {
                    calificacion = double.Parse(texto);
                    suma = suma + calificacion;
                    contador++;
                }
            } while (texto != "");
            if (contador > 0)
            {
                promedio = suma / contador;
                MessageBox.Show("El promedio del alumno es " + promedio);
            }
            else {
                MessageBox.Show("A demas de ser estupido eres flojo no ingresaste ninguna calificacion");
            }
            //Console.Read();
        }
    }
}
