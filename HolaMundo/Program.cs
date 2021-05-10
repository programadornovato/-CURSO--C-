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
            string texto= Microsoft.VisualBasic.Interaction.InputBox("Ingresa un texto", "Titulo", "Respuesta por default");
            MessageBox.Show("Humano aqui esta tu pinche texto=" + texto);

            int entero= int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingresa un numero", "Titulo"));
            MessageBox.Show("Humano aqui esta tu pinche entero=" + entero);

            float flotante = float.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingresa un numero flotante", "Titulo"));
            flotante++;
            MessageBox.Show("Humano aqui esta tu pinche flotante=" + flotante);
            */
            char caracter = Microsoft.VisualBasic.Interaction.InputBox("Ingresa un texto", "Titulo")[3];
            MessageBox.Show("Humano aqui esta tu cuarto caracter=" + caracter);
            //Console.Read();
        }
    }
}
