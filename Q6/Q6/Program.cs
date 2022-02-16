using System;
using System.Globalization;

namespace Q6
{
    //6 - Uma partida de futebol iniciou na hora A e terminou na hora B.
    //Faça um algoritmo que calcule o tempo que durou a partida.
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            DateTime startHour,finishHour;
            TimeSpan totalHours;

            try
            {   
                //Input
                Console.WriteLine("Insira o inicio do jogo: HH:mm:ss");
                startHour = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
                Console.WriteLine("Insira o final do jogo: HH:mm:ss");
                finishHour = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);

                //Pegando a quantidade de horas / Get the time span
                totalHours = finishHour.Subtract(startHour);

                //Print
                Console.WriteLine("Total de horas do jogo: " + totalHours);

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
