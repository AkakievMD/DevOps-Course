using System;
 
namespace DZ_User information
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            int age;
            string zodiacSign;
            string job;
            string position;
 
            Console.WriteLine("Ваше имя?");
            firstName = Console.ReadLine();
 
            Console.WriteLine("Ваш возраст?");
            age = Convert.ToInt32(Console.ReadLine());
 
            Console.WriteLine("Ваш знак зодиака?");
            zodiacSign = Console.ReadLine();
 
            Console.WriteLine("Место работы?");
            job = Console.ReadLine();
 
            Console.WriteLine("Ваша должность?");
            position = Console.ReadLine();
 
            Console.WriteLine($"Вас зовут {firstName}, ваш возраст {age} год(а)/лет, вы {zodiacSign}, вы работаете в компании {job}, ваша должность {position}");
 
        }   
 
    }
}
