using System;
 
namespace DZ_OOP_WorkingWithProperties
{
    class Program
    {
        public static void Main(string[] args)
        {
            Player player = new Player(10, 10, '@');
            Draw draw = new Draw();
 
            draw.DrawPlayer(player.X, player.Y, player.Hero);
 
            Console.SetCursorPosition(0, 20);
 
        }
 
        class Player
        {
            public char Hero { get; private set; }
            public int X { get; private set; }
            public int Y { get; private set; }
 
            public Player (int x, int y, char hero)
            {
                X = x;
                Y = y;
                Hero = hero;           
            }
        }
 
        class Draw
        {
            public void DrawPlayer(int x, int y, char hero)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(hero);
            }
        }
    }
}
