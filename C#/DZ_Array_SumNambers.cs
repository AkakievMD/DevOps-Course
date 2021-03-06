using System;
namespace DZ_Array_SumNambers
{
    class Program
    {
        public static void Main(string[] args)
        {           
            int[] array = new int[0];
 
            int sum = 0;          
            bool result;
            string userInput;
            
            do
            {
                Console.WriteLine("\nУ данной программы есть две команды:\n1) sum - выводит сумму всех введенных ранее чисел.\n2) exit - завершает работу программы.\n");
                Console.Write("Введите число или команду: ");
                userInput = (Console.ReadLine());
                result = int.TryParse(userInput, out int number);
                userInput = userInput.ToLower();
 
                if (result)
                {
                    int[] tempArray = new int[array.Length + 1];
 
                    for (int i = 0; i < array.Length; i++)
                    {
                        tempArray[i] = array[i];
                    }
                    tempArray[tempArray.Length - 1] = number;
 
                    array = tempArray;
                }
                if (userInput == "sum")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += array[i];
                    }
 
                    Console.WriteLine("Сумма введенных чисел равна: " + sum);
                    sum = 0;
                }    
            } while (userInput != "exit") ;         
        }
    }
}
