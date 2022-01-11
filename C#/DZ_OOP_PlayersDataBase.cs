using System;
using System.Collections.Generic;
 
namespace DZ_OOP_PlayersDataBase
{
    class Program
    {
        public static void Main(string[] args)
        {
            Database dataBase = new Database();
 
            dataBase.Work();
        }
 
        class Player
        {
            public int Level { get; private set; }
            public string Nickname { get; private set; }
            public bool IsBanned { get; private set; }
 
            public Player(int playerLevel, string nicknamePlayer)
            {
                Level = playerLevel;
                Nickname = nicknamePlayer;
            }
 
            public void Ban()
            {
                IsBanned = true;
            }
 
            public void UnBan()
            {
                IsBanned = false;
            }
 
            public void ShowInfo()
            {
                Console.WriteLine($"\nNickname: {Nickname}\nУровень: {Level}");
 
                if (IsBanned == true)
                {
                    Console.WriteLine("Игрок забанен: Да");
                }
                else
                {
                    Console.WriteLine("Игрок забанен: Нет");
                }
 
                Console.WriteLine();
            }
        }
 
        class Database
        {
            private List<Player> _players = new List<Player>();
 
            public void Work()
            {
                bool programWork = true;
 
                do
                {
                    Console.Write("1) Добавить игрока в базу данных\n2) Забанить игрока в базе данных\n3) Разбанить игрока в базе данных\n4) Удалить игрока из базы данных\n5) Показать список всех играков в базе данных\n6) Выход из программы\n\nВведите номер опции: ");
 
                    string indexOptions = Console.ReadLine();
 
                    switch (indexOptions)
                    {
                        case "1":
                            AddPlayer();
                            break;
                        case "2":
                            BanPlayer();
                            break;
                        case "3":
                            UnbanPlayer();
                            break;
                        case "4":
                            DeletePlayer();
                            break;
                        case "5":
                            OutputAllPlayers();
                            break;
                        case "6":
                            programWork = false;
                            break;
                        default:
                            Console.WriteLine("\nНеверный ввод! Повторите ввод.\n");
                            break;
                    }
 
                    Console.Write("Нажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                    Console.Clear();
                } 
                while (programWork == true);
            }
 
            public void AddPlayer()
            {
                int playerLevel = 1;
 
                Console.Write("\nВведите Nickname игрока: ");
                string nicknamePlayer = Console.ReadLine();
 
                _players.Add(new Player(playerLevel, nicknamePlayer));
 
                Console.WriteLine();
            }
 
            private void BanPlayer()
            {
                if (_players.Count != 0)
                {
                    int index = 0;
 
                    OutputAllPlayers();
 
                    Console.Write("Введите номер игрока которого хотите забанить: ");
 
                    bool result = TryGetIndex(out index);
 
                    if (result == true)
                        _players[--index].Ban();
                    else
                        Console.WriteLine("Порядковый номер игрока указан не корректно!\n");
                }
                else
                {
                    Console.Write("\nСписок игроков пуст!!!");
                    Console.WriteLine("\n");
                }
            }
 
            private void UnbanPlayer()
            {
                if (_players.Count != 0)
                {
                    int index = 0;
 
                    OutputAllPlayers();
 
                    Console.Write("Введите номер игрока которого хотите разбанить: ");
 
                    bool result = TryGetIndex(out index);
 
                    if (result == true)
                        _players[--index].UnBan();
                    else
                        Console.WriteLine("Порядковый номер игрока указан не корректно!\n");
                }
                else
                {
                    Console.Write("\nСписок игроков пуст!!!");
                    Console.WriteLine("\n");
                }
            }
 
            private void DeletePlayer()
            {
                if (_players.Count != 0)
                {
                    int index = 0;
 
                    OutputAllPlayers();
 
                    Console.Write("Введите номер игрока которого хотите удалить: ");
 
                    bool result = TryGetIndex(out index);
 
                    if (result == true)
                        _players.RemoveAt(--index);
                    else
                        Console.WriteLine("Порядковый номер игрока указан не корректно!\n");
                }
                else
                {
                    Console.Write("\nСписок игроков пуст!!!");
                    Console.WriteLine("\n");
                }
            }
 
            private void OutputAllPlayers()
            {
                if (_players.Count != 0)
                {
                    for (int i = 0; i < _players.Count; i++)
                    {
                        Console.Write($"\nПорядковый номер игрока: {++i}");
                        _players[--i].ShowInfo();
                    }
                }
                else
                {
                    Console.Write("\nСписок игроков пуст!!!");
                    Console.WriteLine("\n");
                }
            }
 
            private bool TryGetIndex(out int index)
            {
                string userInput = Console.ReadLine();
                bool result = int.TryParse(userInput, out index);
 
                if (result)
                {
                    if (index <= _players.Count & index > 0)
                    {
                        Console.WriteLine();
                        return true;
                    }
                }
 
                Console.WriteLine();
                return false;
            }
        }
    }
}
