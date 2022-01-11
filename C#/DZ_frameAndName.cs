using System;
 
namespace DZ_frameAndName
{
    class Program
    {
        public static void Main(string[] args)
        {
            string word;
            string symbol;
 
            Console.WriteLine("Введите слово или предложение:");
            word = Console.ReadLine();
 
            Console.WriteLine("\nВведите символ из которого будет состоять рамка:");
            symbol = Console.ReadLine();
 
            for (int topFrame = 0; topFrame < word.Length + 2; topFrame++)
            {
                Console.Write(symbol);
            }
 
            Console.WriteLine();
            Console.WriteLine(symbol + word + symbol);
 
            for (int bottomFrame = 0; bottomFrame < word.Length + 2; bottomFrame++)
            {
                Console.Write(symbol);
            }
        }
    }
}
