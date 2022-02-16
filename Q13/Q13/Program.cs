using System;

namespace Q13
{
    //13 - Faça um algoritmo que receba uma matriz[i,z] como parâmetro e imprima todos os valores dessa matriz.
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int i, z;
            float[,] nums;

            //Input
            Console.WriteLine("Insira a quantidade de Linhas");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de Colunas");
            z = int.Parse(Console.ReadLine());

            Console.Clear();

            try
            {
                //Iniciando a matriz
                nums = new float[i, z];

                //Inserindo valores na matriz
                for (int x = 0; x < i; x++)
                {
                    for (int y = 0; y < z; y++)
                    {
                        Console.WriteLine($"Insira o valor da posição {x},{y}:");
                        nums[x, y] = float.Parse(Console.ReadLine());
                    }
                }

                //Chamando função
                Print(nums,i,z);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Print(float[,] nums,int xMax,int yMax)
        {
            //Print matriz
            Console.Clear();
            Console.WriteLine("=======================================");
            for (int x = 0; x < xMax; x++)
            {
                for (int y = 0; y < yMax; y++)
                {
                    Console.WriteLine($"Posição {x},{y}: {nums[x, y]}");
                }
            }

            //Print matriz Tabela
            Console.WriteLine("=======================================");
            for (int x = 0; x < xMax; x++)
            {
                for (int y = 0; y < yMax; y++)
                {
                    Console.Write(" ");
                    Console.Write(nums[x, y]);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
