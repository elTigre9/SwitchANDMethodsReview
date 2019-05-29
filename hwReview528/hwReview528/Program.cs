using System;

namespace hwReview528
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello adventurer");
            Console.WriteLine("Choose your weapon:");
            Console.WriteLine("1. Sword, 2. Deagle, 3. Laptop: ");
            string weapon = Console.ReadLine();

            switch(weapon)
            {
                case "1":
                    attackSword();
                    break;
                case "2":
                    attackDeagle(99);
                    break;
                case "3":
                    string enemyResult = attackLaptop(8);
                    Console.WriteLine(enemyResult);
                    break;
                default:
                    Console.WriteLine("You died for lack of weapon. Rot in hell!");
                    break;
            }
        }

        private static void attackSword()
        {
            Console.WriteLine("You chose sword");
            Console.WriteLine("You attacked with the sword");
        }

        private static void attackDeagle(int damage)
        {
            Console.WriteLine("You chose Deagle");
            Console.WriteLine("You attacked with Deagle for {0} dmg.", damage);
        }

        private static string attackLaptop(int looper)
        {
            Console.WriteLine("You chose laptop");
            for(int i = 0; i < looper; i++)
            {
                attackDeagle(i * 40);
            }

            return "Your enemy is definitely vanquished";
        }
    }
}
