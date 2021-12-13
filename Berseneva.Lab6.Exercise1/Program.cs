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
        public static void Change(int maxValue, int[] MyarrayInt)
        {
            if (MyarrayInt.Length == 0)
                return;

            var m = MyarrayInt[0];
            var max = maxValue;

            if (m == max)
                return;

            for (int i = 0; i < MyarrayInt.Length; i++)
            {                
                if (MyarrayInt[i] == m)
                {
                    MyarrayInt[i] = max;
                }

                else if (MyarrayInt[i] == max)
                {
                    MyarrayInt[i] = m;
                }
                Console.WriteLine(MyarrayInt[i]);
            }
        }
    }
}
