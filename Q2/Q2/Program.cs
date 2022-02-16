using System;
using System.Globalization;

namespace Q2
{
    //2- Dada a distância A e o combustível gasto B, faça um algoritmo para calcular o consumo médio.
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            float distance;
            float gasConsume;

            try
            {
                //Input
                Console.Write("Insira a distancia percorrida: ");
                distance = float.Parse(Console.ReadLine());
                Console.Write("Insira a quantidade de combustivel gasto: ");
                gasConsume = float.Parse(Console.ReadLine());

                //Verificando se existe um valor negativo
                if (distance < 0 || gasConsume < 0)
                    throw (new ArgumentException("Um valor é negativo"));

                //Tirando o resultado
                float result = Average(distance, gasConsume);

                //Print
                Console.WriteLine($"Resultado : {result.ToString("F1", CultureInfo.InvariantCulture)} L");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static float Average(float dist, float gas)
        {
            return gas / dist;
        }
    }
}
