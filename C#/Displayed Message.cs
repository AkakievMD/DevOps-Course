using System;
 
namespace DZ_albomPhotos
{
    class Program
    {
        static void Main(string[] args)
        {
            int messageNumber;
            int numberOfMessages;
            string displayedMessage;
 
            Console.WriteLine("Напишите сообщение которое вы хотели бы вывести в консоли: ");
            displayedMessage = Console.ReadLine();
 
            Console.WriteLine($"\nКакое количество раз вы хотите вывести сообщение \"{displayedMessage}\": ");
            numberOfMessages = Convert.ToInt32(Console.ReadLine());
 
            Console.WriteLine();
 
            for (messageNumber = 1; messageNumber <= numberOfMessages; messageNumber++)
            {
                Console.WriteLine($"{messageNumber}) {displayedMessage}");
            }
 
            Console.WriteLine("\nНажмите Enter для завершения программы.");
            Console.ReadLine();
        }   
    }
}
