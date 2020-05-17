using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet myPet = new Pet();

            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("Hello! Welcome to Virtual Pets\n");

                Console.WriteLine("What would you like to do?\n");
                Console.WriteLine("1. Set Name");
                Console.WriteLine("2. Set Species");
                Console.WriteLine("3. Check Hunger");
                Console.WriteLine("4. Check Boredom");
                Console.WriteLine("5. Check Health");
                Console.WriteLine("6. Check ticks");
                Console.WriteLine("7. Exit Game\n");


                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        SetPet();
                        break;
                    case "2":
                        SetSpecies();
                        break;
                    case "3":
                        CheckHunger();
                        break;
                    case "4":
                        CheckBoredom();
                        break;
                    case "5":
                        CheckHealth();
                        break;
                    case "6":
                        CheckTicks();
                        break;
                    case "7":
                        keepThinking = false;
                        Console.WriteLine("Good-bye!");
                        break;
                    default:
                        break;
                }

            }
            
        }
        static void SetPet()
        {
            Console.Clear();
            Pet myPet = new Pet();
            string setName = myPet.SetName();
            Console.WriteLine($"You'r pet's name is {setName}");
            
            Console.WriteLine("Press Enter To Return");
            Console.ReadLine();
        }
        static void SetSpecies()
        {
            Console.Clear();
            Pet myPet = new Pet();
            string setSpecies = myPet.SetSpecies();
            Console.WriteLine($"You'r pet's species is {setSpecies}");

            Console.WriteLine("Press Enter To Return");
            Console.ReadLine();
        }
        static void CheckHunger()
        {
            Console.Clear();
            Pet myPet = new Pet();
            int checkHunger = myPet.GetHunger();
            Console.WriteLine($"You'r pet's Hunger level is {checkHunger}");

            Console.WriteLine("Press Enter To Return");
            Console.ReadLine();
        }
        static void CheckBoredom()
        {
            Console.Clear();
            Pet myPet = new Pet();
            int checkBoredom = myPet.GetBoredom();
            Console.WriteLine($"You'r pet's Boredom level is {checkBoredom}");

            Console.WriteLine("Press Enter To Return");
            Console.ReadLine();
        }
        static void CheckHealth()
        {
            Console.Clear();
            Pet myPet = new Pet();
            int checkBoredom = myPet.GetBoredom();
            Console.WriteLine($"You'r pet's boredom level is {checkBoredom}");

            Console.WriteLine("Press Enter To Return");
            Console.ReadLine();
        }
        static void CheckTicks()
        {
            Console.Clear();


            Console.WriteLine("Press Enter To Return");
            Console.ReadLine();
        }



    }
}
