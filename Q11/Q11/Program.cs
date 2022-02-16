using System;
using System.Collections.Generic;

namespace Q11
{
    //11 - Dada duas lista de números A[1,2,3,4] e B[1,2,5,8], faça um algoritmo que retorne a intersecção das listas
    class Program
    {
        static void Main(string[] args)
        {
            //Com HashSet
            comSortedSet();
            //Sem HashSet
            semSortedSet();
        }

        static void comSortedSet()
        {
            //Variables
            SortedSet<int> A = new SortedSet<int> { 1, 2, 3, 4 };
            SortedSet<int> B = new SortedSet<int> { 1, 2, 5, 8 };

            //Print A
            Console.WriteLine("Lista A");
            Console.WriteLine("===================================");
            foreach (int n in A)
            {
                Console.WriteLine(n);
            }
            //Print B
            Console.WriteLine("Lista B");
            Console.WriteLine("===================================");
            foreach (int n in B)
            {
                Console.WriteLine(n);
            }

            //Função
            A.IntersectWith(B);

            //Print
            Console.WriteLine("Nova Lista com SortedSet");
            Console.WriteLine("===================================");
            foreach (int n in A)
            {
                Console.WriteLine(n);
            }
        }

        static void semSortedSet()
        {
            //Variables
            int[] A = new int[] { 1, 2, 3, 4 };
            int[] B = new int[] { 1, 2, 5, 8 };

            List<int> newList = new List<int>();

            //Verificando os num iguais
            for (int x = 0; x < A.Length; x++)
            {
                for (int y = 0; y < B.Length; y++)
                {
                    if (A[x] == B[y] && !newList.Contains(A[x]))
                        newList.Add(A[x]);
                }
            }
            //Print
            Console.WriteLine("Nova Lista Sem SortedSet");
            Console.WriteLine("===================================");
            foreach (int n in newList)
            { 
                Console.WriteLine(n);
            }
        }
    }
}
