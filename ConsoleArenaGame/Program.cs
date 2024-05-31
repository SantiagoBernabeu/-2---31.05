using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace ConsoleArenaGame
{
    class Program
    {
        static void ConsoleNotification(GameEngine.NotificationArgs args)
        {
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack,2)} and caused {Math.Round(args.Damage,2)} damage.");
            Console.WriteLine($"Attacker: {args.Attacker}");
            Console.WriteLine($"Defender: {args.Defender}");
        }
      /*  static void Menu()
        {
            Console.WriteLine($"------ Heroes ------");
            Console.WriteLine($"1 - Assassin");
            Console.WriteLine($"2 - Knight");
            Console.WriteLine($"3 - Samurai");
            Console.WriteLine($"4 - Viking\n");
            Console.WriteLine($"------ Weapons ------");
            Console.WriteLine($"1 - Axe");
            Console.WriteLine($"2 - Dagger");
            Console.WriteLine($"3 - Fist");
            Console.WriteLine($"4 - Katana");
            Console.WriteLine($"5 - Sword\n");
        }
       static void CreateHero()
        {
          
            Console.Write($"Hero: ");
            string[] input = Console.ReadLine().Split(' ');
            if (input[0] == "1" && input[4] == "1")
            {
                Hero hero = new Assassin(input[1], Convert.ToDouble(input[2]), Convert.ToDouble(input[3]), new Dagger(input[5]));
            }
        }*/
        static void Main(string[] args)
        {
            //Menu();
           List<Hero> heroes = new List<Hero>();

            Random rand = new Random();
            Hero hero1 = new Knight("Knight", 10, 20, new Sword("Sword")); heroes.Add(hero1);
            Hero hero2 = new Assassin("Assassin", 10, 5, new Dagger("Dagger")); heroes.Add(hero2);
            Hero hero3 = new Samurai("Samurai-1", 15, 15, new Katana("Katana")); heroes.Add(hero3);
            Hero hero4 = new Viking("Viking", 5, 25, new Axe("Axe")); heroes.Add(hero4);
            Hero hero5 = new Viking("Barehanded Viking", 10, 25, new Fist("Fist")); heroes.Add(hero5);
            Hero hero6 = new Samurai("Samurai-2", 10, 15, new Katana("Katana")); heroes.Add(hero6);


            GameEngine gameEngine = new GameEngine()
            {
                HeroA = heroes[rand.Next(1,3)],
                HeroB = heroes[rand.Next(4,6)],
                NotificationsCallBack = ConsoleNotification
                //NotificationsCallBack = args => Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {args.Attack} and caused {args.Damage} damage.")
            };

            gameEngine.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine.Winner}");
        }
    }
}