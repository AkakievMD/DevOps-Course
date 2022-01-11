using System;
 
namespace DZ_functions_DrawBar
{
    class Program
    {
        public static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            ConsoleColor red = ConsoleColor.Red;
            ConsoleColor blue = ConsoleColor.Blue;
 
            int maxValue = 10;
            int dividerInterestBar = 10;
            int positionY = 54;
            int positionX = 8;
            int cursorOffset = 2;
            string healthBar = "Health Bar";
            string manaBar = "Mana Bar";
            string barArray = "";
 
            do
            {
                Console.WriteLine("Добро пожаловать!!!");
                Console.Write("\nДанная программа рисует Health Bar и Mana Bar.\nдля выхода из программы нажмите клавишу ESC, для продолжения нажмите клавишу Enter.");
                Console.WriteLine("\nДля ввода принамаются слудующие значения в процентах: 10, 20, 30, 40, 50, 60, 70, 80, 90, 100.");
                Console.WriteLine("\nНажмите клавишу Enter для продолжения или Escape для выхода из программы: ");
 
                key = Console.ReadKey();
 
                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        DrawBar(barArray, maxValue, dividerInterestBar, positionY, positionX, cursorOffset, healthBar, red);
                        DrawBar(barArray, maxValue, dividerInterestBar, positionY - cursorOffset, positionX + cursorOffset, cursorOffset, manaBar, blue);
                        break;
 
                    default:
                        if (key.Key != ConsoleKey.Escape)
                        {
                            Console.Clear();
                            Console.WriteLine("Неверный ввод!!! Повторите ввод.");
                        }
                        break;
                }
 
                Console.Write("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
 
                Console.Clear();
 
            } while (key.Key != ConsoleKey.Escape);
        }
 
        static void DrawBar(string barArray, int maxValue, int dividerInterestBar, int positionY, int positionX, int cursorOffset, string bar, ConsoleColor color)
        {
            int interestBar;
            string tempBar = bar;
 
            Console.Write($"\nНа сколько процентов {tempBar} вы хотите заполнить?: ");
            interestBar = Convert.ToInt32(Console.ReadLine());
 
            if (interestBar >= 0 & interestBar < 101 & interestBar == 10 | interestBar == 20 | interestBar == 30 | interestBar == 40 | interestBar == 50 | interestBar == 60 | interestBar == 70 | interestBar == 80 | interestBar == 90 | interestBar == 100)
            {
                OutputBar(barArray, interestBar, color, maxValue, dividerInterestBar, positionY, positionX);
            }
 
            else
            {
                Console.SetCursorPosition(positionY, positionX);
                Console.Write("Неверный ввод!!! Повторите ввод позже.\n");
            }
        }
 
        static void OutputBar(string bar, int interestBar, ConsoleColor color, int maxValue, int dividerInterestBar, int positionY, int positionX)
        {
            int numberIterations = interestBar / dividerInterestBar;
 
            for (int i = 0; i < numberIterations; i++)
                bar += '_';
 
            Console.SetCursorPosition(positionY, positionX);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            ConsoleColor defaultColor = ConsoleColor.Black;
            Console.BackgroundColor = defaultColor;
 
            bar = "";
 
            for (int i = numberIterations; i < maxValue; i++)
                bar += '_';
 
            Console.WriteLine(bar + ']');
        }
    }
}
