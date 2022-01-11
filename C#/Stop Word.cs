using System;
 
namespace Stop Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string stopWord = "exit";
            string userInput = "";
 
            while(stopWord != userInput)
            {
                Console.WriteLine("Чтобы остановить работу цикла введите слово \"exit\"");
                userInput = Console.ReadLine();
            }
 
            Console.WriteLine("\nНажмите Enter для завершения программы.");
            Console.ReadLine();
        }   
    }
}
