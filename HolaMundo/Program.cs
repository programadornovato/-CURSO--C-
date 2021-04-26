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
            string numString1 = "15.55";
            string numString2 = "25.22";
            /*
            //string resultadoS = numString1+ numString2;
            int num1 = Int32.Parse(numString1);
            int num2 = Int32.Parse(numString2);
            int resultadoI = num1 + num2;
            Console.WriteLine(resultadoI);
            */
            /*
            float numFloat1 = float.Parse(numString1);
            float numFloat2 = float.Parse(numString2);
            float resultadoF = numFloat1 + numFloat2;
            Console.WriteLine(resultadoF);
            */
            double numDoble1 = double.Parse(numString1);
            double numDoble2 = double.Parse(numString2);
            double resultadoD = numDoble1 + numDoble2;
            Console.WriteLine(resultadoD);
            
            Console.Read();
        }
    }
}
