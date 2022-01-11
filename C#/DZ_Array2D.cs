using System;
 
namespace DZ_Array
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
 
            int[,] array = new int [4, 5];
            int numberColumn = 0;
            int numberLine = 1;
            int additionResult = 0;
            int multiplicationResult = 1;
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 9);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
 
            for (int i = 0; i < array.GetLength(0); i++)
            {
                multiplicationResult *= array[i, numberColumn];
            }
 
            for (int i = 0; i < array.GetLength(1); i++)
            {
                additionResult += array[numberLine, i];
            }
 
            Console.WriteLine($"Результат сложения 2 строки: {additionResult}");
            Console.WriteLine($"Результат умножения 1 столбца: {multiplicationResult}");
            Console.ReadLine();
        }
    }
}
