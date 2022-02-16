using System;
using System.Collections.Generic;
using System.Text;

namespace Q5
{
    //5 - Faça um algoritmo para apresentar se dois números são múltiplos.
    class Program
    {
        static void Main(string[] args)
        {
            int exit = 0;
            while (exit != 1)
            {
                //Variables
                float num1, num2;

                try
                {
                    //Input
                    Console.Write("Insira o 1º valor: ");
                    num1 = float.Parse(Console.ReadLine());
                    Console.Write("Insira o 2º valor: ");
                    num2 = float.Parse(Console.ReadLine());

                    //Verficando se multiplos entre si
                    Console.WriteLine(MultiploEntreSi(num1, num2));

                    //Verficando de quem são multiplos
                    MultiploN(num1);
                    MultiploN(num2);
                }
                //Verificando Exceptions
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                //Loop
                Console.WriteLine("");
                Console.WriteLine("Deseja Refazer? 0-S 1-N");
                exit = int.Parse(Console.ReadLine());
                Console.Clear();
            }
        }

        static string MultiploEntreSi(float n1, float n2)
        {
            StringBuilder result = new StringBuilder(100);
            Console.WriteLine("==============================");

            //Verificando se são multiplos entre si
            if (n1 % n2 == 0)
                result.AppendLine($"O 1º Numero {n1} é multiplo de {n2}");

            if (n2 % n1 == 0)
                result.AppendLine($"O 2º Numero {n2} é multiplo de {n1}");

            //Verificando se o resultado está vazio
            if (result.Length == 0)
                result.AppendLine("Os numeros não são multiplos entre si");

            //Retornando o resultado
            return result.ToString();
        }

        static void MultiploN(float n)
        {
            //Transformando o valor em positivo
            float nUpd = Math.Abs(n);
            //Lista de todos os multiplos
            List<float> multiplos = new List<float>();

            for (float i = -nUpd; i <= nUpd; i++)
            {
                if (n % i == 0)
                    multiplos.Add(i);
            }

            //Print
            Console.WriteLine("==============================");
            foreach (int num in multiplos)
            {
                Console.WriteLine($"O valor {n} é multiplo de {num}");
            }
        }
    }
}
