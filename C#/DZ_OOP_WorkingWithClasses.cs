using System;
using System.Collections.Generic;
 
namespace DZ_OOP_WorkingWithClasses
{
    class Program
    {
        public static void Main(string[] args)
        {
            Player player = new Player(true, 25, 200, "JD", 3000, "TITAN");
 
            player.ShowInfoPlayer();
 
            Console.Write("\nНажмите любую клавишу для завершения программы");
            Console.ReadKey();
            Console.WriteLine();
        }
 
        class Player
        {
            private bool _playerStatusOnline;
            private int _playerAge;
            private int _playingTimeInHours;
            private int _playerRating;
            private string _nicknamePlayer;
            private string _playerRank;
            
            public Player(bool playerStatusOnline, int playerAge, int playingTimeInHours, string nicknamePlayer, int playerRating, string playerRank)
            {
                _playerStatusOnline = playerStatusOnline;
                _playerAge = playerAge;
                _playingTimeInHours = playingTimeInHours;
                _nicknamePlayer = nicknamePlayer;
                _playerRating = playerRating;
                _playerRank = playerRank;
            }
 
            public void ShowInfoPlayer()
            {
                if (_playerStatusOnline != false)
                    Console.WriteLine($"Cтатус игрока: Online");
                else
                    Console.WriteLine($"Cтатус игрока: Offline");
 
                Console.WriteLine($"Имя пользователя: {_nicknamePlayer}");
                Console.WriteLine($"Время проведенное в игре: {_playingTimeInHours} часов(часа)");
                Console.WriteLine($"Возраст игрока: {_playerAge} лет(года)");
                Console.WriteLine($"Ранг игрока: {_playerRank}");
                Console.WriteLine($"Рейтинг игрока: {_playerRating} MMP");
            }
        }
    }
}
