using System;

namespace Q10
{
    //10 - Faça um algoritmo que receba um número e retorne o Fatorial desse número.
    class Program
    {
        static void Main(string[] args)
        {
            //Variable
            int n;
            try
            {
                //Input
                Console.WriteLine("Insira o valor: ");
                n = int.Parse(Console.ReadLine());

                //Verificando se o n é menor que 0
                if (n < 0)
                    throw (new ArgumentException("O valor é negativo"));

                if (n != 0)
                {
                    float fact = 1;
                    for (int i = n; i >= 1; i--)
                    {
                        fact = fact * i;
                    }
                    Console.Write($"Fatorial de {n}! = {fact}");
                }
                else Console.WriteLine($"Fatorial de 0! é 1");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
