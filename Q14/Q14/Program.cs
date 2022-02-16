using System;

namespace Q14
{
    //14 - Faça um algoritmo que recebe uma palavra e retorne se a palavra é palíndromo.
    //(Palavra que se pode ler, indiferentemente, da esquerda para direita ou vice-versa.Ex: osso,Ana e etc).
    class Program
    {
        static void Main(string[] args)
        {
            //Variable 
            string word;
            string reverseWord = "";
            
            try
            {
                //Input
                Console.WriteLine("Insira a palavra");
                word = Console.ReadLine();

                //Removendo os espaços e colocando na msm formatação
                word = word.Replace(" ", String.Empty);
                word = word.ToLower();

                //Colocando ao contrario
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverseWord += word[i];
                }

                //Verificando se é palíndromo
                if (word.Equals(reverseWord))
                {
                    Console.WriteLine($"A palavra {word} é palíndromo");
                    Console.WriteLine($"Palavra ao contrario é {reverseWord}");
                }
                else Console.WriteLine($"A palavra {word} não é palíndromo");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
