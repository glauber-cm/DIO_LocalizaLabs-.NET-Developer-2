using System;

namespace _03_Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi, raio, volume;
            pi = 3.14159;
            raio = double.Parse(Console.ReadLine());

            volume = (4.0 * pi * (Math.Pow(raio, 3.0))/3.0);

            Console.WriteLine("VOLUME = " + Math.Round(volume, 3).ToString("F3"));

        }
    }
}
