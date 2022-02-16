using System;
using System.Globalization;

namespace Q4
{
    //4 - Faça um algoritmo que converta a temperatura de C para F. Utilize a fórmula C = 5/9(F-32)
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            float c;

            //Input
            Console.WriteLine("Insira o valor em C°");
            c = float.Parse(Console.ReadLine());

            //Chamando a função
            ToFahrenheit(c);
        }

        static void ToFahrenheit(float c)
        {
            float f;

            f = ((c * 9) + 160) / 5;
            
            //Print
            Console.WriteLine($"Fahrenheit : {f.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
