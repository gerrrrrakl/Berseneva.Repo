using System;

namespace Berseneva.Lab6.Exercise2._1
{
    internal class Program
    {      
        static void Main(string[] args)
        {
            int n = 3, m = 4;

            int[,] A = new int[3, 4];           //вводим матрицу размерами 3 х 4
            Random random = new Random();
            Console.WriteLine();

            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = random.Next(1, 15);          //придаем каждому элементу матрицы случайное значение
                    Console.Write("{0, -3} ", A[i, j]);    //выводим матрицу
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                //присваеваем новой перменой первый элемент 
                int minValue = A[i, 0];
                for (int j = 0; j < m; j++)
                {
                    if (A[i, j] < minValue) //находим min-элемент
                    {
                        minValue = A[i, j];
                    }
 
                }
                Console.WriteLine("Строка {0}, минимальное значение: {1}", i, minValue);
                Console.WriteLine();
            }           
            Console.ReadKey();
        }
    }
}

