using System;

namespace _04_Xenlonguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                int esferas = int.Parse(Console.ReadLine());
                Console.WriteLine(esferas - Math.Floor(Math.Sqrt(esferas)));
            }
        }
    }
}
