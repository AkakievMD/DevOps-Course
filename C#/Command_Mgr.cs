using System;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;
 
 
namespace Command_Mgr
{
    class Program
    {
        public static void Main()
        {
            Process myProcess = new Process();
 
            string pathOpenFile;
            string pathCreateFile;
            string pathCreateFolder;
            string pathFolder;
            string pathSaveFolder;
            string pathDeleteFile;
            string pathDeleteFolder;
            string command;
            string stopProgram = "";
 
            while(stopProgram != "esc")
            {
                Console.WriteLine("Добро пожаловать в диспетчер команд!");
                Console.WriteLine("Вам доступны следующие команды:\n");
 
                Console.WriteLine("1) openFile: Открыть файл или приложение с обязательным указанием его расширения");
                Console.WriteLine("Пример ввода:                  C:\\Windows\\notepad.exe\n");
 
                Console.WriteLine("2) create (Ключи: -File \\ -Folder): Создать по указанному пользователем пути файл или папку (при удалении файла, обязательно указать расширение");
                Console.WriteLine("Пример ввода (удаления файла): C:\\Users\\Михаил\\Desktop\\Test.txt");
                Console.WriteLine("Пример ввода (удаления папки): C:\\Users\\Михаил\\Desktop\\Test\n");
 
                Console.WriteLine("3) createZipArchive: Создать ZIP-архив");
                Console.WriteLine("Пример ввода (указать путь к папке для создания архива): C:\\Users\\Михаил\\Desktop\\Test");
                Console.WriteLine("Пример ввода (указать путь для сохранения архива):       C:\\Users\\Михаил\\Desktop\\Test.zip\n");
 
                Console.WriteLine("4) del (Ключи: -File \\ -Folder ): Удалить файл или папку по указанному пути");
                Console.WriteLine("Пример ввода (указать путь для удаления файла):          C:\\Users\\Михаил\\Desktop\\Test.txt");
                Console.WriteLine("Пример ввода (указать путь для удаления папки):          C:\\Users\\Михаил\\Desktop\\Test\n");
 
                Console.WriteLine("5) systemInfo: Вывести в консоль информацию о данном ПК\n\n Имя ПК\n Имя текущего пользователя\n Количество процессоров данном ПК\n Версия ядра ОС\n Диски определенные системой в настоящий момент\n");
                
                Console.WriteLine("6) esc: Выход из программы\n");
 
                Console.WriteLine("Введите команду:");
                command = Console.ReadLine();
 
                if (command == "openFile")
                {
                    Console.WriteLine("Введите путь к файлу или приложению (Важно! Команда не будет выполнена если путь указан неверно!):");
                    pathOpenFile = Console.ReadLine();
                    myProcess.StartInfo.FileName = pathOpenFile;
                    myProcess.Start();
                }
 
                else if (command == "create -File")
                {
                    Console.WriteLine("Введите путь, где будет создан файл (Важно! Команда не будет выполнена если путь указан неверно!):");
                    pathCreateFile = Console.ReadLine();
                    File.Create(pathCreateFile);
                }
                else if (command == "create -Folder")
                {
                    Console.WriteLine("Введите путь, где будет создана папка (Важно! Команда не будет выполнена если путь указан неверно!):");
                    pathCreateFolder = Console.ReadLine();
                    Directory.CreateDirectory(pathCreateFolder);
                }
                else if (command == "createZipArchive")
                {
                    Console.WriteLine("Введите путь к папке которую хотите сжать в архив (Важно! Команда н будет выполнена если путь указан неверно!):");
                    pathFolder = Console.ReadLine();
 
                    Console.WriteLine("Введите путь, где будет сохранен архив (Важно! Команда не будет выполнена если путь указан неверно!):");
                    pathSaveFolder = Console.ReadLine();
 
                    ZipFile.CreateFromDirectory(pathFolder, pathSaveFolder);
                }
                else if (command == "del -File")
                {
                    Console.WriteLine("Введите путь к файлу который необходимо удалить (Важно! Команда не будет выполнена если путь указан неверно!):");
                    pathDeleteFile = Console.ReadLine();
                    File.Delete(pathDeleteFile);
                }
                else if (command == "del -Folder")
                {
                    Console.WriteLine("Введите путь к файлу который необходимо удалить (Важно! Команда не будет выполнена если путь указан неверно!):");
                    pathDeleteFolder = Console.ReadLine();
                    Directory.Delete(pathDeleteFolder);
                }
                else if (command == "systemInfo")
                {
                    Console.WriteLine("Имя ПК: {0}", Environment.MachineName);
 
                    Console.WriteLine("Имя текущего пользователя: {0}", Environment.UserName);
 
                    Console.WriteLine("Количество процессоров на данном ПК: {0}", Environment.ProcessorCount);
 
                    Console.WriteLine("Версия ядра ОС: {0}", Environment.OSVersion.ToString());
 
                    string[] drives = Environment.GetLogicalDrives();
                    Console.WriteLine("Диски определенные системой в настоящий момент: {0}", String.Join(", ", drives));
                    Console.WriteLine();
 
                }
                else if (command == "esc")
                {
                    stopProgram = command;
                }
                else if (command != "openFile" && command != "create -File" && command != "create -Folder" && command != "createZipArchive" && command != "del - File" && command != "del -Folder" && command != "systemInfo")
                {
                    Console.WriteLine("\nНеверный ввод команды, попробуйте снова!");
                }
                   
                Console.Clear();
            }
        }
    }
}
