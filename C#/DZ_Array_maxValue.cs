using System;
 
namespace DZ_Array_maxValue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
 
            int[,] array = new int[10, 10];
            int maxValue = 0;
            int value;
 
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10, 100);
                    Console.Write(array[i, j] + " ");
                }
 
                Console.WriteLine();
            }
 
            for (int i = 0; i < array.GetLength(0); i++)    
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    value = array[i, j] + 0;
 
                    if (maxValue < value)
                    {
                        maxValue = value;
                    }
                }
            }
 
            Console.WriteLine($"\nМаксимальное значение верхней матрицы: {maxValue}");
 
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == maxValue)
                    {
                        array[i, j] = 0;
                    }
                }
            }
 
            Console.WriteLine();
 
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
 
                    if (array[i, j] == 0)
                    {
                        Console.Write(" ");
                    }
                }
 
                Console.WriteLine();
            }
 
            Console.ReadLine();
        }
    }
}
