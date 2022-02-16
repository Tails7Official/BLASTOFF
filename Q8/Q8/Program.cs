using System;

namespace Q8
{
    //8 - Faça um algoritmo que receba um número e retorne se o número é primo ou não.
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            float num;

            //Input
            Console.Write("Insira o numero: ");
            num = float.Parse(Console.ReadLine());

            //Chamando a função
            Console.WriteLine(Primo(num));
        }

        static string Primo(float num)
        {
            float numUpd;
            int countDiv = 0;

            //Transformando o valor em positivo
            numUpd = Math.Abs(num);
            
            //Verificando a quantidade de divisores do numero
            for(float i = -numUpd; i <= numUpd; i++)
            {
                if (-numUpd % i == 0)
                    countDiv++;
            }

            //Verificando se é primo e fazendo o OutPut
            if(countDiv == 4)
            {
               return $"O valor {num} é primo";
            }
            
            return $"O valor {num} não é primo";
        }
    }
}
