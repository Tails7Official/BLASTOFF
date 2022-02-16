using System;
using System.Globalization;

namespace Q3
{
    //3 - Dados três números (a, b, c), faça um algoritmo para mostrar o menor número.
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            float a, b, c;

            //Input
            Console.Write("Insira o valor A : ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Insira o valor B : ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Insira o valor C : ");
            c = float.Parse(Console.ReadLine());

            //Chamando a função
            Min(a, b, c);

        }

        static void Min(float a, float b, float c)
        {
            float min = a;

            //Verificando o menor
            if (b < min)
                min = b;
            if (c < min)
                min = c;

            //Print
            Console.WriteLine($"O menor valor é: {min.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}
