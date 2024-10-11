using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace minmax
{
    internal class Program
    {
        public static List<int> Lista = new List<int>();
        public static void feltomt()
        {
            Random rnd = new Random();
            for (int i = 0;i < 10; i++)
            {
                Lista.Add(rnd.Next(1-101));
            }

            for (int i = 0;i < Lista.Count;i++)
            {
                Console.WriteLine(Lista[i]+",");
            }

        }
        public static int minimum()
        {
            int min = lista[0];

            for (int i = 0;i <Lista.Count;i++)
            {
                if (Lista[1] > min)
                {
                    min = Lista[1];
                }

            return min;
        }
            public static int maximum()
            {
                int max = lista[0];

                for (int i = 0; i < Lista.Count; i++)
                {
                    if (Lista[1] > max)
                    {
                        min = Lista[1];
                    }

                    return max;
                }
                static void Main(string[] args)
        {
            feltomt();
            Console.WriteLine();
            Console.WriteLine(minimum());
            Console.WriteLine(maximum());
        }
    }
}
