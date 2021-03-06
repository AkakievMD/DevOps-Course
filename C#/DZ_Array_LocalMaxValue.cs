using System;
namespace DZ_Array_LocalMaxValue
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[30];
 
            Random random = new Random();
 
            Console.Write("Массив натуральных чисел: ");
 
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 100);
                Console.Write(array[i] + " ");
            }
 
            Console.WriteLine("\n");
            Console.Write("Локальные максимумы массива натуральных чисел: ");
 
            if (array[0] > array[1])
            {
                Console.Write(array[0] + " ");
            }
 
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    Console.Write(array[i] + " ");
                }
            }
 
            if (array[^1] > array[^2])
            {
                Console.Write(array[^1]);
            }
            Console.WriteLine();
        }
    }
}
