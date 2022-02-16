using System;

namespace Q9
{
    //9 - Faça um algoritmo que receba um número e retorne a tabuada desse número.
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            float num;

            //Input
            Console.WriteLine("Insira o numero");
            num = int.Parse(Console.ReadLine());

            //Processo
            for (float i = 0; i <= 10; i++)
            {
                float mult = i * num;
                
                if (i == 0)
                    mult = 0;
                //Print
                Console.WriteLine($"|{num} * {i} = {mult}");
            }
        }
    }
}
