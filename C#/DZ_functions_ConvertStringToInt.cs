using System;
 
namespace DZ_functions_ConvertStringToInt
{
    class Program
    {
        public static void Main(string[] args)
        {
            int convertNumber = GetNumber();
            Console.WriteLine("\nСконвертированное число: " + convertNumber);
 
            Console.Write("\nНажмите любую клавишу для завершения...");
            Console.ReadKey();
            Console.WriteLine();
        }
 
        static int GetNumber()
        {
            string requestedNumber;
            int convertNumber = 0;
            bool result;
            bool programWork = true;
 
            while (programWork == true)
            {
                Console.Write("Введите число: ");
                requestedNumber = Console.ReadLine();
                result = int.TryParse(requestedNumber, out convertNumber);
 
                if (result)
                {
                    Console.WriteLine("\nПоздравляю!!! Вы удачно конвертировали string в int.");
                    programWork = false;
                }
 
                else
                {
                    Console.WriteLine("\nНеобходимо ввести число!!! Повторите ввод.\n");
                }
            }
 
            return convertNumber;
        }
    }
}
