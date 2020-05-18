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
                Console.WriteLine("Hello! Welcome to Virtual Pets\n");
               
                Console.WriteLine("Type Number and press Enter:");
                Console.WriteLine("What would you like to do?\n");
                Console.WriteLine("1. See Name");
                Console.WriteLine("2. See Species");
                Console.WriteLine("3. Check Hunger");
                Console.WriteLine("4. Check Boredom");
                Console.WriteLine("5. Check Health");
                Console.WriteLine("6. Do Nothing");
                Console.WriteLine("7. Give Food");
                Console.WriteLine("8. Take to Vet");
                Console.WriteLine("9. Play With");
                Console.WriteLine("10. Exit Game\n");


                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        string petName = myPet.PetName();
                        Console.WriteLine($"You'r pet's name is {petName}");
                        break;
                    case "2":
                        string petSpecies = myPet.PetSpecies();
                        Console.WriteLine($"You'r pet's species is {petSpecies}");
                        break;
                    case "3":
                        int checkHunger = myPet.GetHunger();
                        Console.WriteLine($"You'r pet's Hunger level is {checkHunger}");
                        break;
                    case "4":
                        int checkBoredom = myPet.GetBoredom();
                        Console.WriteLine($"You'r pet's Boredom level is {checkBoredom}");
                        break;
                    case "5":
                        int checkHealth = myPet.GetHealth();
                        Console.WriteLine($"You'r pet's health level is {checkHealth}");
                        break;
                    case "6":
                        myPet.DoNothing();
                        Console.WriteLine("Bad Owner!!\n Hunger level +5\n boredom level +5\n health -5");
                        break;
                    case "7":
                        myPet.Feed();
                        Console.WriteLine("You feed your pet hunger level -40");
                        break;
                    case "8":
                        myPet.SeeDoctor();
                        Console.WriteLine("Took pet to doctor:\n health level + 30");
                        break;
                    case "9":
                        myPet.Play();
                        Console.WriteLine("Playing with pet:\n hunger level +10\n boredom level - 20\n health level +10 ");
                        break;
                    case "10":
                        keepThinking = false;
                        Console.WriteLine("Good-bye!");
                        break;
                    default:
                        break;

                   

                    
                }

            }
            
        }
        



    }
}
