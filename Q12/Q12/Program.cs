using System;
using System.Collections.Generic;

namespace Q11
{
    //12 - Dada duas lista de números A[1,2,3,4] e B[1,2,5,8], faça um algoritmo que retorne a concatenação das listas.
    class Program
    {
        static void Main(string[] args)
        {
            //Chamando a função
            NewList();
        }

        static void NewList()
        {
            //Variables
            List<int> A = new List<int> { 1, 2, 3, 4 };
            List<int> B = new List<int> { 1, 2, 5, 8 };

            //Adicionando os valores no final
            A.AddRange(B);

            //Print
            Console.WriteLine("Nova Lista");
            Console.WriteLine("===================================");
            foreach (int n in A)
            {
                Console.Write(n);
            }
        }
    }
}
