using System;
 
namespace kvadrat
{
  class MainClass
  {
    public static void Main(string[] args)
    {
 
      int lenght = 0;
      int height = 0;
      int outside = 0;  //заливка
      int inside = 0;   //контур
 
 
      int[,] mass = new int[height, lenght];
 
      Console.WriteLine("введите высоту - ");
      height = Convert.ToInt32(Console.ReadLine());
 
      Console.WriteLine("введите длину - ");
      lenght = Convert.ToInt32(Console.ReadLine());
 
 
      for (int i = 0; i < height; i++)
      {
        for (int j = 0; j < lenght; j++)
        {
          if (i > 0 && j > 0 && i < height - 1 && j < lenght - 1)
            Console.Write("0");
          else
            Console.Write("X");
        }
        Console.Write("\n");
      }
      Console.ReadKey();
    }
  }
}
