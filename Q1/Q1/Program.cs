using System;
using System.Globalization;


namespace Q1
{
    //1- Dada as idades I, J, K, X, Y. Faça um algoritmo para calcular a média das idades.
    class Program
    {
        static void Main(string[] args)
        {
            //Variables 
            int average = 0;
            int I, J, K, X, Y;
            try
            {
                //Input
                Console.WriteLine("Insira a I idade:");
                I = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira a J idade:");
                J = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira a K idade:");
                K = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira a X idade:");
                X = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira a Y idade:");
                Y = int.Parse(Console.ReadLine());

                //Verificando se tem um numero negativo
                if(I < 0 || J < 0 || K < 0 || X < 0 || Y < 0)
                {
                    throw (new ArgumentException("Um valor é negativo"));
                }

                //Tirando a media
                average = (I + J + K + X + Y) / 5;

                //Print
                Console.WriteLine("Media : " + average);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}
