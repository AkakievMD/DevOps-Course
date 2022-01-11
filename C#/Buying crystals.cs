using System;
 
namespace DZ_Buying crystals
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroGold;
            int purchasedCrystals;
            int priceOneCrystal = 10; 
 
 
            Console.WriteLine("Сколько золота вам необходимо для похода в магазин?");
            heroGold = Convert.ToInt32(Console.ReadLine());
 
            Console.WriteLine("Вы пришли в магазин чтобы купить кристаллы, сколько кристаллов вы хотите купить?");
            purchasedCrystals = Convert.ToInt32(Console.ReadLine());
 
            heroGold = heroGold - (purchasedCrystals * priceOneCrystal);
 
            Console.WriteLine($"Куплено кристаллов: {purchasedCrystals} ");
            Console.WriteLine($"Золото осталось: {heroGold}");
 
            Console.ReadLine();
 
 
 
        }
    }
}
