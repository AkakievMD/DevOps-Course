using System;
using System.Linq;
 
namespace DZ_functions_ShuffleFunction
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = Enumerable.Range(1, 10).ToArray();
            OutputArray(array);
            ShuffleArray(array);
 
            Console.Write("\nПеремешанный порядок чисел в массиве: ");
 
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
 
            Console.Write("\n\nНажмите любую клавишу для завершения программы...");
            Console.ReadKey();
 
            Console.WriteLine();
        }
   
        public static void ShuffleArray( int[] array)
        {
            Random random = new Random();
 
            for (int i = 0; i < array.Length; i++)
            {
                int randomIndex = random.Next(array.Length - 1);
 
                int temp = array[i];
                array[i] = array[randomIndex];
                array[randomIndex] = temp;
            }
        }
 
        static void OutputArray(int[] array)
        {
            Console.Write("Текущий порядок чисел в массиве: ");
 
            foreach (var item in array)
                Console.Write(item + " ");
        }
    }
}
