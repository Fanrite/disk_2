using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disk_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //A
            int[] a = { 21, 24, 27, 30, 33, 36, 39, 41, 44, 47 };
            Console.Write("A: ");
            foreach (int AWrite in a)
                Console.Write($"{AWrite},");

            //B

            int[] b = { 1, 2, 3, 6, 11, 22, 43, 86, 171, 342 };

            Console.Write("\nB: ");
            foreach (int BWrite in b)
                Console.Write($"{BWrite},");

            //AxB
            string[,] c = new string[10, 10];
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < b.Length; j++)
                    c[i, j] = $"({a[i]} {b[j]})";

            Console.Write("\nC:\n");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write($"{c[i, j]} ");
                Console.Write("\n");
            }

            Console.Write("\nB/A: (1 36),(2 36),(3 36),(6 36)");
            Console.ReadKey();
        }
    }
}
