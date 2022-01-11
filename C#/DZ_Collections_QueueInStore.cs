using System;
using System.Collections.Generic;
 
namespace DZ_Collections_QueueInStore
{
    class Program
    {
        public static void Main(string[] args)
        {
            ConsoleKeyInfo consoleKey;
 
            int sumAllPurchases = 0;
            int term = 0;
 
            int[] purchaseAmount = { 25, 55, 50, 296, 357 };
 
            Queue<string> buyers = new Queue<string>();
            buyers.Enqueue("Василий");
            buyers.Enqueue("Алексей");
            buyers.Enqueue("Роман");
            buyers.Enqueue("Владимир");
            buyers.Enqueue("Михаил");
 
            Console.WriteLine("Добро пожаловать!!!");
 
            do
            {
                ServesQueueBuyers(buyers, purchaseAmount, ref sumAllPurchases, ref term);
                Console.WriteLine("\nНажмите любую клавишу для продолжения или клавишу Escape для выхода из программы");
                consoleKey = Console.ReadKey();
                Console.Clear();
            } while (consoleKey.Key != ConsoleKey.Escape);
        }
 
        static void ServesQueueBuyers(Queue<string> buyers, int[] purchaseAmount, ref int sumAllPurchases, ref int term)
        {
            if (buyers.Count != 0)
            {
                Console.WriteLine("Текущий остаток по счету с покупок: " + sumAllPurchases);
                Console.WriteLine("Пришел покупатель! Сейчас в очереди: " + buyers.Dequeue() + "\nСумма покупки: " + purchaseAmount[term]);
            }
 
            else
            {
                Console.WriteLine("Покупателей больше нет!");
                Console.WriteLine("Текущий остаток по счету с покупок: " + sumAllPurchases);
            }
 
            if (term == 0)
            {
                sumAllPurchases = purchaseAmount[term++] + sumAllPurchases;
            }
 
            else if(purchaseAmount.Length > term)
            {
                sumAllPurchases = purchaseAmount[term++] + sumAllPurchases;
            }
        }
    }
}
