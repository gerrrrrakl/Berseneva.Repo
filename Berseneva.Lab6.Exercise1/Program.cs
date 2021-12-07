using System;

namespace Berseneva.Lab6.Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;


            Console.WriteLine("Введите количество элементов в массиве n:");
            n = int.Parse(Console.ReadLine());

            int[] MyarrayInt = new int[n];
            
            Random random = new Random();
            for (int i = 0; i < MyarrayInt.GetLength(0); i++)
            {
                MyarrayInt[i] = random.Next(10);
                Console.Write("{0, 1} ", MyarrayInt[i]);
                Console.WriteLine();
            }
            var b = MaxValue(MyarrayInt);
            Console.WriteLine("Максимальный элемент массива: " + b);
            Change(b, MyarrayInt);
            Console.WriteLine();            
        }
        static int MaxValue(int[] MyarrayInt)
        {
            int minValue = int.MinValue;
            for (int i = 0; i < MyarrayInt.GetLength(0); i++)
            {
                if (minValue < MyarrayInt[i])
                {
                    minValue = MyarrayInt[i];
                }
            }
            return minValue;
        }
        public static void Change(int MaxValue, int[] MyarrayInt)
        {
            for (int i = 0; i < MyarrayInt.GetLength(0); i++)
            {
                int a = MyarrayInt[0];
                MyarrayInt[0] = MaxValue;
                a = MaxValue;
                Console.WriteLine(MyarrayInt[i]);
            }
        }
    }
}
