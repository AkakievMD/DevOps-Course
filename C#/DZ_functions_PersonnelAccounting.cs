using System;
 
namespace DZ_functions_PersonnelAccounting
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool programWorks = true;
 
            string[] fullNames = new string[0];
            string[] positions = new string[0];
 
            do
            {
                string indexOptions;
 
                Console.WriteLine("Выберите опцию меню.\n1) Добавить досье\n2) Вывести все досье\n3) Удалить досье\n4) Поиск досье\n5) Выход");
                Console.Write("Введите ваш вариант: ");
                indexOptions = Console.ReadLine();
 
                switch (indexOptions)
                {
                    case "1":
                            CreateDossier(ref fullNames, ref positions);
                        break;
 
                    case "2":
                            OutputAllDossiers(fullNames, positions);
                        break;
 
                    case "3":
                            DeleteDossier(ref fullNames, ref positions);
                        break;
 
                    case "4":
                            SearhcDossier(fullNames, positions);
                        break;
 
                    case "5":
                        programWorks = false;
                        break;
                    default:
                            Console.WriteLine("\nОшибка ввода! Повторите ввод.\n");
                        break;
                }
            } while (programWorks == true);
        }
 
        static void CreateDossier(ref string[] fullNames, ref string[] positions)
        {
            string userInputFullName = "";
            string userInputPosition = "";
 
            Console.Write("\nВведите ФИО сотрудника: ");
            userInputFullName = Console.ReadLine();
 
            Console.Write("Введите должность сотрудника: ");
            userInputPosition = Console.ReadLine();
            Console.WriteLine();
 
            fullNames = PopulatesArray(fullNames, userInputFullName);
            positions = PopulatesArray(positions, userInputPosition);
        }
 
        static string[] PopulatesArray(string[] array, string userInput)
        {
            string tempUserInput = userInput;
 
            string[] tempArray = new string[array.Length + 1];
 
            for (int i = 0; i < array.Length; i++)
                tempArray[i] = array[i];
 
            tempArray[tempArray.Length - 1] = tempUserInput;
 
            array = tempArray;
 
            return array;
        }
 
        static void OutputAllDossiers(string[] fullNames, string[] positions)
        {
            if (fullNames.Length > 0)
            {
                int indexNumber = 1;
 
                Console.WriteLine();
 
                for (int i = 0; i < fullNames.Length; i++)
                {
                    Console.Write($"{indexNumber++}){fullNames[i]} - {positions[i]} ");
                }
 
                Console.WriteLine("\n");
            }
 
            else
            {
                Console.WriteLine("\nСписок досье пуст!\n");
            }
        }
        static void DeleteDossier(ref string[] fullNames, ref string[] positions)
        {
            if (fullNames.Length > 0)
            {
                Console.WriteLine("\nКакое резюме вы хотите удалить?");
                OutputAllDossiers(fullNames, positions);
 
                Console.Write("Введите порядковый номер резюме: ");
                int indexNumber = Convert.ToInt32(Console.ReadLine());
 
                fullNames = ShrinksArray(fullNames, indexNumber);
                positions = ShrinksArray(positions, indexNumber);
            }
 
            else
            {
                Console.WriteLine("\nСписок досье пуст!");
            }
 
            Console.WriteLine();
        }
        static string[] ShrinksArray(string[] array, int indexNumber)
        {
            if (indexNumber > 0 && indexNumber <= array.Length)
            {
                string[] tempArray = new string[array.Length - 1];
 
                --indexNumber;
 
                for (int i = 0; i < indexNumber; i++)
                    tempArray[i] = array[i];
 
                for (int i = indexNumber + 1; i < array.Length; i++)
                    tempArray[i - 1] = array[i];
 
                array = tempArray;
            }
 
            return array;
        }
 
        static void SearhcDossier(string[] fullNames, string[] positions)
        {
            if (fullNames.Length > 0)
            {
                Console.Write("\nВведите ФИО: ");
                string fullNameLine = Console.ReadLine();
 
                Console.WriteLine("\nРезультаты поиска:");
 
                for (int i = 0; i < fullNames.Length; i++)
                {
                    if (fullNames[i] == fullNameLine)
                    {
                        Console.WriteLine($"ФИО: {fullNames[i]}\nДолжность: {positions[i]}\n");
                    }
                }
            }
 
            else
            {
                Console.WriteLine("\nСписок досье пуст!\n");
            }
        }
    }
}
