using System;
 
namespace DZ_albomPhotos
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoInAlbum = 52;
            int photoInRow = 3;
 
            int numberOfRows = photoInAlbum / photoInRow;
            int remainingPhotos = photoInAlbum % photoInRow;
 
            Console.WriteLine($"Рядов будет выведено: {numberOfRows}");
            Console.WriteLine($"Лишних фотографий останется: {remainingPhotos}");
 
            Console.ReadLine();
 
 
 
        }
    }
}
