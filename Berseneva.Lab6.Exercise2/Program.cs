using System;

namespace Berseneva.Lab6.Exercise2
{
    class Program
    {
        static void Main()
        {
            int n = 3;
            int m = 4;

            int[,] A = new int[n, m];

            Random(A);
            WriteMatrice(A);
            Show(A);   
        }
        public static void Random(int[,] A)
        {
            Random rand = new Random();
            for (int i = 0; i < A.GetLength(0); i++) 
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = rand.Next(0, 100);
                }
            }

        }

        public static void WriteMatrice(int[,] A)
        {
            for (var i = 0; i < A.GetLength(0); i++) 
            {
                for (var j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = Convert.ToInt32(Console.ReadLine()); 
                }
            }
        }
        public static void Show(int[,] A)
        {
            for (var i = 0; i < A.GetLength(0); i++) 
            {
                for (var j = 0; j < A.GetLength(1); j++) 
                {
                    Console.Write("{0, -3}", A[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            var b = MinValue(A);
            Console.WriteLine("Минимальный элемент матрицы: " + b);
        }

        static int MinValue(int[,] A)
        {
            int maxValue = int.MaxValue;
            for (var i = 0; i < A.GetLength(0); i++)
            {
                for (var j = 0; j < A.GetLength(1); j++)
                {
                    if (maxValue < A[i, j])
                    {
                        maxValue = A[i, j];
                    }
                }
            }
            return maxValue;

        }
    }
}
