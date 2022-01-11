using System;
using System.Collections.Generic;
 
namespace DZ_Collections_TranslateWord
{
    class Program
    {
        public static void Main(string[] args)
        {
            ConsoleKeyInfo consoleKey;
 
            Dictionary<string, string> englishDictionary = new Dictionary<string, string>();
            englishDictionary.Add("hello", "Привет");
            englishDictionary.Add("sorry", "Извините");
            englishDictionary.Add("beautiful", "Красивый");
            englishDictionary.Add("strong", "Сильный");
            englishDictionary.Add("power", "Cила");
 
            Console.WriteLine("Добро пожаловать!!!");
 
            do
            {
                OutputTranslationWord(englishDictionary);
                Console.WriteLine("\nНажмите любую клавишу для продолжения или клавишу Escape для выхода из программы");
                consoleKey = Console.ReadKey();
            } while (consoleKey.Key != ConsoleKey.Escape);
            
        }
 
        static void OutputTranslationWord(Dictionary<string, string> dictionary)
        {
            Console.Write("\nВведите слово на английском языке чтобы увидеть перевод.\nДоступные слова для ввода: Hello, Sorry, Beautiful, Strong, Power.\nВведите слово: ");
            string englishWord = Console.ReadLine();
            englishWord = englishWord.ToLower();
 
            if (dictionary.ContainsKey(englishWord))
                Console.WriteLine($"Перевод: {dictionary[englishWord]}");
 
 
            else
                Console.WriteLine("Перевод не найден!!! Повторите ввод.");
        }
    }
}
