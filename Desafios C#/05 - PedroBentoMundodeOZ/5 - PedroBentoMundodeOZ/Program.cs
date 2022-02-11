using System;
using System.Collections.Generic;
using System.Linq;

namespace _5___PedroBentoMundodeOZ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> joiasDistinct = new List<string>();   
            string strJoias = " ";

            strJoias = Console.ReadLine().Trim();

            while (strJoias != "")
            {
                if (strJoias.Contains("(") || strJoias.Contains(")"))
                {
                    joiasDistinct.Add(strJoias);
                }

                strJoias = Console.ReadLine();

                if (strJoias == null)
                {
                    strJoias = "";
                }
            }
            Console.WriteLine(joiasDistinct.Distinct().Count());


        }

    }


}

