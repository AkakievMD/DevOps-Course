using System;
 
namespace DZ_albomPhotos
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollar = 100000;
            double ruble = 100000;
            double euro = 100000;
            double dollarToRubleConversion = 76.4007;
            double dollarToEuroConversion = 0.84996;
            double rubleToDollarConversion = 0.01308;
            double rubleToEuroConversion = 0.01111;
            double euroToRubleConversion = 89.8106;
            double euroToDollarConversion = 1.17552;
            double conversionAmount;
            int tipeСurrency1;
            int tipeСurrency2;
            string exitProgram = "";
 
            Console.WriteLine("Добро пожаловать в конвертер валют\n");
 
            while (exitProgram != "exit")
            {
                Console.WriteLine($"Баланс USD счета = {dollar} USD");
                Console.WriteLine($"Баланс RUB счета = {ruble} RUB");
                Console.WriteLine($"Баланс EURO счета = {euro} EURO\n");
 
                Console.WriteLine("Выберите валюту которую будете конвертировать:");
                Console.WriteLine("1) Доллар\n2) Рубль\n3) Евро");
                
                Console.WriteLine("Ваш вариант:");
                tipeСurrency1 = Convert.ToInt32(Console.ReadLine());
 
                Console.WriteLine("\nВыберите валюту в которую будете конвертировать:");
                Console.WriteLine("1) Доллар\n2) Рубль\n3) Евро ");
 
                Console.WriteLine("Ваш вариант:");
                tipeСurrency2 = Convert.ToInt32(Console.ReadLine());
 
                if (tipeСurrency1 == 1 && tipeСurrency2 == 2)
                {
                    Console.WriteLine("\nСколько USD вы хотите сконвертировать в RUB?: ");
                    conversionAmount = Convert.ToInt32(Console.ReadLine());
 
                    if(conversionAmount > dollar)
                    {
                        Console.WriteLine("\nОшибка! Сумма конвертации не может быть больше остатка по счету с которого производится конвертация!");
                        Console.WriteLine($"Сумма которую вы пытались конвертировать: {conversionAmount} USD        Остаток по счету: {dollar} USD");
                        Console.WriteLine("Попробуйте повторить операцию.\n");
                        continue;
                    }
 
                    dollar -= conversionAmount;
                    ruble += dollarToRubleConversion * conversionAmount;
 
                    Console.WriteLine("\nКонвертация выполнена успешно!");
                    Console.WriteLine($"Результат конвертации: USD счет = {dollar} USD      RUB счет = {ruble} RUB\n");
                }
 
                if (tipeСurrency1 == 1 && tipeСurrency2 == 3)
                {
                    Console.WriteLine("\nСколько USD вы хотите сконвертировать в EURO?: ");
                    conversionAmount = Convert.ToInt32(Console.ReadLine());
 
                    if (conversionAmount > dollar)
                    {
                        Console.WriteLine("\nОшибка! Сумма конвертации не может быть больше остатка по счету с которого производится конвертация!");
                        Console.WriteLine($"Сумма которую вы пытались конвертировать: {conversionAmount} USD        Остаток по счету: {dollar} USD");
                        Console.WriteLine("Попробуйте повторить операцию.\n");
                        continue;
                    }
 
                    dollar -= conversionAmount;
                    euro += dollarToEuroConversion * conversionAmount;
 
                    Console.WriteLine("\nКонвертация выполнена успешно!");
                    Console.WriteLine($"Результат конвертации: USD счет = {dollar} USD      EURO счет = {euro} EURO\n");
                }
 
                if (tipeСurrency1 == 3 && tipeСurrency2 == 2)
                {
                    Console.WriteLine("\nСколько EURO вы хотите сконвертировать в RUB?: ");
                    conversionAmount = Convert.ToInt32(Console.ReadLine());
 
                    if (conversionAmount > euro)
                    {
                        Console.WriteLine("\nОшибка! Сумма конвертации не может быть больше остатка по счету с которого производится конвертация!");
                        Console.WriteLine($"Сумма которую вы пытались конвертировать: {conversionAmount} EURO       Остаток по счету: {euro} EURO");
                        Console.WriteLine("Попробуйте повторить операцию.\n");
                        continue;
                    }
 
                    euro -= conversionAmount;
                    ruble += euroToRubleConversion * conversionAmount;
 
                    Console.WriteLine("\nКонвертация выполнена успешно!");
                    Console.WriteLine($"Результат конвертации: EURO счет = {euro} EURO      RUB счет = {ruble} RUB\n");
                }
 
                if (tipeСurrency1 == 3 && tipeСurrency2 == 1)
                {
                    Console.WriteLine("\nСколько EURO вы хотите сконвертировать в USD?: ");
                    conversionAmount = Convert.ToInt32(Console.ReadLine());
 
                    if (conversionAmount > euro)
                    {
                        Console.WriteLine("\nОшибка! Сумма конвертации не может быть больше остатка по счету с которого производится конвертация!");
                        Console.WriteLine($"Сумма которую вы пытались конвертировать: {conversionAmount} EURO       Остаток по счету: {euro} EURO");
                        Console.WriteLine("Попробуйте повторить операцию.\n");
                        continue;
                    }
 
                    euro -= conversionAmount;
                    dollar += euroToDollarConversion * conversionAmount;
 
                    Console.WriteLine("\nКонвертация выполнена успешно!");
                    Console.WriteLine($"Результат конвертации: EURO счет = {euro} EURO      USD счет = {dollar} USD\n");
                }
 
                if (tipeСurrency1 == 2 && tipeСurrency2 == 1)
                {
                    Console.WriteLine("\nСколько RUB вы хотите сконвертировать в USD?: ");
                    conversionAmount = Convert.ToInt32(Console.ReadLine());
 
                    if (conversionAmount > ruble)
                    {
                        Console.WriteLine("\nОшибка! Сумма конвертации не может быть больше остатка по счету с которого производится конвертация!");
                        Console.WriteLine($"Сумма которую вы пытались конвертировать: {conversionAmount} RUB        Остаток по счету: {ruble} RUB");
                        Console.WriteLine("Попробуйте повторить операцию.\n");
                        continue;
                    }
 
                    ruble -= conversionAmount;
                    dollar += rubleToDollarConversion * conversionAmount;
 
                    Console.WriteLine("\nКонвертация выполнена успешно!");
                    Console.WriteLine($"Результат конвертации: RUB счет = {ruble} RUB       USD счет = {dollar} USD\n");
                }
 
                if (tipeСurrency1 == 2 && tipeСurrency2 == 3)
                {
                    Console.WriteLine("\nСколько RUB вы хотите сконвертировать в EURO?: ");
                    conversionAmount = Convert.ToInt32(Console.ReadLine());
 
                    if (conversionAmount > ruble)
                    {
                        Console.WriteLine("\nОшибка! Сумма конвертации не может быть больше остатка по счету с которого производится конвертация!");
                        Console.WriteLine($"Сумма которую вы пытались конвертировать: {conversionAmount} RUB        Остаток по счету: {ruble} RUB");
                        Console.WriteLine("Попробуйте повторить операцию.\n");
                        continue;
                    }
 
                    ruble -= conversionAmount;
                    euro += rubleToEuroConversion * conversionAmount;
 
                    Console.WriteLine("\nКонвертация выполнена успешно!");
                    Console.WriteLine($"Результат конвертации: RUB счет = {ruble} RUB       EURO счет = {euro} EURO\n");
                }
                Console.WriteLine("Для завершения работы программы введите слово \"exit\", для продолжения нажмите Enter:");
                exitProgram = Console.ReadLine();
                Console.Clear();
            }
        }   
    }
}
