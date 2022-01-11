using System;
 
namespace Secret Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretMessage = "Вы читаете секретное сообщение";
            string password = "password";
            string userInput;
            int numberAttempts;
            int attemptNumber = 1;
 
            for (numberAttempts = 3; numberAttempts >= attemptNumber; attemptNumber++)
            {
                Console.WriteLine("Введите пароль чтобы прочитать секретное сообщение");
                Console.WriteLine($"Попытка №: {attemptNumber}");
                userInput = Console.ReadLine();
 
                if (userInput == password)
                {
                    Console.WriteLine($"\n{secretMessage}");
                    break;
                }
            }
 
            Console.WriteLine("\nНажмите Enter для завершения программы.");
            Console.ReadLine();
        }   
    }
}
