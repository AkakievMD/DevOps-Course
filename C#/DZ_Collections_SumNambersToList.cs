using System;
using System.Linq;
using System.Collections.Generic;
 
namespace DZ_Collections_SumNambersToList
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool result;
            string userInput;
 
            List<int> сollectionNumbers = new List<int>();
 
            do
            {
                Console.WriteLine("Добро пожаловать!!!");
                Console.WriteLine("\nУ данной программы есть две команды:\n1) sum - выводит сумму всех введенных ранее чисел.\n2) exit - завершает работу программы.\n");
                Console.Write("Введите число или команду: ");
                userInput = Console.ReadLine().ToLower();
                result = int.TryParse(userInput, out int number);
 
                if (result)
                {
                    сollectionNumbers.Add(number);
                }
 
                else if (userInput == "sum")
                {
                    SumNumbers(сollectionNumbers);
                }
 
                Console.Write("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();
            } while (userInput != "exit");
        }
 
        static void SumNumbers(List<int> сollectionNumbers)
        {
            int sum = сollectionNumbers.Sum();
            Console.WriteLine("Сумма введенных чисел равна: " + sum);
        }
    }
}
