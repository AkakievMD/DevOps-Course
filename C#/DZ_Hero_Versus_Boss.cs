using System;
 
namespace DZ_Hero_Versus_Boss
{
    class Program
    {
        public static void Main()
        {
            Random random = new Random();
            
            double healthHero = 1000;
            double healthBoss = 1000;
 
            string spellHero;
 
            double damageFirebol = 50;
            double damageCoupPunch;
            double passiveHealing;
            double hitBoss;
            
            Console.WriteLine("Босс: -Вот мы и встретились Герой! Я здесь чтобы уничтожить тебя, а следом и весь Мир, останови меня если сможешь!");
            Console.WriteLine("Герой:  -У тебя ничего не выйдет Злодей! Я остановлю тебя даже ценой своей жизни!\n");
            Console.WriteLine("Добро пожаловать в игру битва с Боссом!");
            Console.WriteLine("Тебе необходимо для начала ознакомится с заклинаниями которые тебе доступны для победы над Боссом.");
            Console.WriteLine("1) Заклинание \"firebol\" наносит урон равный 50.\n");
            Console.WriteLine("2) Заклинание \"coup punch\" наносит случайный урон от 0 до 250, это мощное заклинание, но от использования такого заклинания есть последствия, Герой от использования данного заклинания получит урон равный половине от урона заклинания.\n");
            Console.WriteLine("3) Заклинание \"holy shield\" защищает Героя божественным щитом блокируя урон Босса в зависимости от текущего уровня здоровья Героя. Совместно с данным заклинание используется атакующее заклинание \"firebol\"\n");
            Console.WriteLine("30% процентов блокирования урона если здоровье героя от 700 до 1000 XP");
            Console.WriteLine("50% процентов блокирования урона если здоровье героя от 500 до 700 XP");
            Console.WriteLine("70% процентов блокирования урона если здоровье героя от 1 до 500 XP\n");
            Console.WriteLine("4) Заклинание \"time sphere\" окружает Босса временной сферой в которой время останавливается даже для микробов. У Героя есть пять атак, если атака была слишком слабой то Босс сможет нанести по герою ответный удар, если же атака героя была достаточно сильной-то Босс не сможет нанести по Герою ответный удар.");
            Console.WriteLine("Совместно с данным заклинание используется атакующее заклинание \"coup punch\" атака которого ограничена случайным уроном от 1 до 100.\n");
            Console.WriteLine("5) Заклинание \"passive healing\", данное заклинание носит пассивный характер, если атака Босса была слишком сильной (от 230) то Герой сможет восстановить случайное количество здоровья от 1 до 100 XP.");
            Console.WriteLine("Заклинание \"passive healing\" не работает во время использования заклинаний \"holy shield\" и \"time sphere\".\n");
 
            while (healthHero > 0 && healthBoss > 0)
            {
                Console.WriteLine($"Здоровье Героя = {healthHero}");
                Console.WriteLine($"Здоровье Злодея = {healthBoss}\n");
 
                Console.WriteLine("Произнесите заклинание!");
                spellHero = Console.ReadLine();
                Console.WriteLine();
 
                switch(spellHero)
                {
                    case "firebol":
                        {
                            hitBoss = random.Next(1, 251);
                            
                            if (hitBoss > 230)
                            {
                                healthHero -= hitBoss;
                                passiveHealing = random.Next(1, 101);
                                healthHero += passiveHealing;
                                healthBoss -= damageFirebol;
 
                                Console.WriteLine("Вы использовали заклинание \"firebol\"!!!");
                                Console.WriteLine($"Так же сработал пасcивный навык \"passive healing\" и вам удалось воcстановить {passiveHealing} единиц здоровья");
                                Console.WriteLine($"Урон от вашего заклинания: {damageFirebol}      |     Урон который нанес по вашему герою Босс: {hitBoss - passiveHealing}\n");
                            }
 
                            else
                            {
                                healthHero -= hitBoss;
                                healthBoss -= damageFirebol;
 
                                Console.WriteLine("Вы использовали заклинание \"firebol\"!!!");
                                Console.WriteLine($"Урон от вашего заклинания: {damageFirebol}      |     Урон который нанес по вашему герою Босс: {hitBoss}\n");
                            }
                        }
                        break;
                    case "coup punch":
                        {
                            hitBoss = random.Next(1, 251);
 
                            if (hitBoss > 230)
                            {
                                healthHero -= hitBoss;
                                passiveHealing = random.Next(1, 101);
                                healthHero += passiveHealing;
                                damageCoupPunch = random.Next(1, 251);
                                healthBoss -= damageCoupPunch;
                                healthHero -= damageCoupPunch / 2;
 
                                Console.WriteLine("Вы использовали заклинание \"coup punch\"!!!");
                                Console.WriteLine($"Так же сработал пасcивный навык \"passive healing\" и вам удалось воcстановить {passiveHealing} единиц здоровья");
                                Console.WriteLine($"Урон от вашего заклинания: {damageCoupPunch}      |     Вы потеряли здоровья от вашей атаки: {damageCoupPunch / 2}      |       Урон который нанес по вашему герою Босс: {hitBoss - passiveHealing}\n");
                            }
 
                            else
                            {
                                hitBoss = random.Next(1, 251);
                                damageCoupPunch = random.Next(1, 251);
                                healthHero -= hitBoss;
                                healthBoss -= damageCoupPunch;
                                healthHero -= damageCoupPunch / 2;
                             
                                Console.WriteLine("Вы использовали заклинание \"coup punch\"!!!");
                                Console.WriteLine($"Урон от вашего заклинания: {damageCoupPunch}      |      Вы потеряли здоровья от вашей атаки: {damageCoupPunch / 2}      |       Урон который нанес по вашему герою Босс: {hitBoss}\n");
                            }
                        }
                        break;
                    case "holy shield":
                        {
                            Console.WriteLine("Вы использовали заклинание \"holy shield\"!!!");
 
                            hitBoss = (double)random.Next(1, 251);
                            healthBoss -= damageFirebol;
 
                            if (healthHero > 700)
                            {
                                hitBoss -= (hitBoss * 30) / 100;
                                healthHero -= hitBoss;
                                Console.WriteLine($"Количество заблокированного урона {(hitBoss * 30) / 100}");
                            }
 
                            else if(healthHero > 500)
                            {
                                hitBoss -= (hitBoss * 50) / 100;
                                healthHero -= hitBoss;
                                Console.WriteLine($"Количество заблокированного урона {(hitBoss * 50) / 100}");
                            }
                            else if (healthHero > 300)
                            {
                                hitBoss -= (hitBoss * 70) / 100;
                                healthHero -= hitBoss;
                                Console.WriteLine($"Количество заблокированного урона {(hitBoss * 70) / 100}");
                            }
                            else if (healthHero < 300)
                            {
                                hitBoss -= (hitBoss * 70) / 100;
                                healthHero -= hitBoss;
                                Console.WriteLine($"Количество заблокированного урона {(hitBoss * 70) / 100}");
                            }
 
                            Console.WriteLine($"Урон от вашего заклинания\"firebol\": {damageFirebol}      |      Урон который нанес по вашему герою Босс: {hitBoss}\n");
                        }
                        break;
                    case "time sphere":
                        {
                            Console.WriteLine("Вы использовали заклинание \"time sphere\"!!!\n");
 
                            for (int numberOfAttacks = 1; numberOfAttacks <= 5; numberOfAttacks++)
                            {
                                damageCoupPunch = random.Next(1, 101);
                                
                                if (damageCoupPunch < 50)
                                {
                                    if (healthBoss < 0)
                                    {
                                        continue;
                                    }
 
                                    hitBoss = random.Next(1, 101);
                                    healthHero -= hitBoss;
                                    healthBoss -= damageCoupPunch;
 
                                    Console.WriteLine("Ваша атака оказалась не достаточно сильной и Босс смог нанести по вам урон");
                                    Console.WriteLine($"Атака №{numberOfAttacks} из 5 нанесла {damageCoupPunch} урона по Боссу     |      Урон который нанес по вашему герою Босс: {hitBoss}\n");
 
                                }
 
                                else
                                {
                                    if (healthBoss < 0)
                                    {
                                        continue;
                                    }
 
                                    healthBoss -= damageCoupPunch;
 
                                    Console.WriteLine("Ваша атака оказалась достаточно сильной и Босс не смог нанести по вам урон");
                                    Console.WriteLine($"Атака № {numberOfAttacks} из 5 нанесла {damageCoupPunch} урона по Боссу\n");
                                }
                            }    
                        }
                        break;
 
                    default:
                        {
                            hitBoss = random.Next(1, 251);
                            healthHero -= hitBoss;
                            Console.WriteLine("Я плохо произнес заклинание и не смог нанести урон по Боссу.\n");                         
                            Console.WriteLine($"Урон который нанес по вашему герою Босс: { hitBoss}\n");
                        }
                        break;
                }
 
                if (healthHero <= 0)
                {
                    Console.WriteLine("Босс: -Вот и все Герой!!! Ты проиграл!!!");
                    Console.WriteLine("Герой проиграл схватку с Боссом.");
                }
 
                else if (healthBoss <= 0)
                {
                    Console.WriteLine("Герой: -Вот и все Злодей!!! Ты проиграл!!!");
                    Console.WriteLine("Герой выйграл схватку с Боссом.");
                }
            }
        }
    }
}
