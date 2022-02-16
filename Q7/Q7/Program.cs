using System;
using System.Collections.Generic;

namespace Q7
{
    //7 - Dada uma lista de números A[1,2,3,...], faça um algoritmo que retorne uma lista somente com os números pares.
    class Program
    {
        static void Main(string[] args)
        {
            //Variable 
            List<float> nums = new List<float>();
            float count;

            //Pegando a quantidade do loop
            Console.WriteLine("Insira a quantidade de numeros:");
            count = float.Parse(Console.ReadLine());

            //Input
            for (float i = 0; i < count; i++)
            {
                Console.Clear();
                Console.WriteLine($"Insira o {i + 1}º valor");
                nums.Add(float.Parse(Console.ReadLine()));
            }

            Console.Clear();
            //Mostrando a lista antiga
            foreach (float num in nums)
            {
                Console.WriteLine($"|{num}");
            }

            //Chamando a função
            Par(nums);
        }


        static void Par(List<float> nums)
        {
            List<float> pares = new List<float>();

            try
            {
                //Verificando se as listas estão vazias
                if (nums.Count == 0)
                    throw (new ArgumentException("A lista está vazia"));

                //Verificando os numeros pares
                foreach (float num in nums)
                {
                    if (num % 2 == 0)
                        pares.Add(num);
                }

                //Print Lista Pares
                Console.WriteLine("======================");
                Console.WriteLine("Lista de Numeros Pares");
                Console.WriteLine("======================");
                
                //Verificando se a lista de pares está vazia
                if (pares.Count == 0 )
                    throw (new ArgumentException("Não exites numeros pares"));

                foreach (float num in pares)
                {
                    Console.WriteLine($"|{num}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
