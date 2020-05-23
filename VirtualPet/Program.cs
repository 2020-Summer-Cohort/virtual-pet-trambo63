using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //myPet is Object of Type Pet
            Pet myPet;
            
                Console.WriteLine("Hello! Welcome to Virtual Pets\n");
               //***Create(Create Pet Method) for this! Add an Add Pet option to menu
                //Console.WriteLine("Enter Pet Name: ");
                //string name = Console.ReadLine();
                //Console.WriteLine("Enter Pet Species: ");
                //string species = Console.ReadLine();
                //Console.Clear();
            

            bool keepThinking = true;
            do
            {
                Console.WriteLine(name + " the " + species);
                int hungerLevel = myPet.GetHunger();
                Console.WriteLine($"You'r pet's Hunger level is {hungerLevel}");
                int boredomLevel = myPet.GetBoredom();
                Console.WriteLine($"You'r pet's Boredom level is {boredomLevel}");
                int healthLevel = myPet.GetHealth();
                Console.WriteLine($"You'r pet's health level is {healthLevel}\n");
                Console.WriteLine("Type Number and press Enter:");
                Console.WriteLine("What would you like to do?\n");
                Console.WriteLine("1. Neglect");
                Console.WriteLine("2. Give Food");
                Console.WriteLine("3. Take to Vet");
                Console.WriteLine("4. Play With");
                Console.WriteLine("5. Admit Pet to Shelter");
                Console.WriteLine("6. Adopt Pet");
                Console.WriteLine("7. Exit Game\n");

                //if (hungerLevel >= 100 || healthLevel <= 0)
                //{
                //    Console.Clear();
                //    Console.WriteLine(name + " is dead!!");
                //    Console.WriteLine("press enter to exit");
                //    keepThinking = false;
                //}
                //if (boredomLevel >= 100)
                //{
                //    Console.Clear();
                //    Console.WriteLine(name + " ran away");
                //    Console.WriteLine("press enter to exit");
                //    keepThinking = false;
                //}

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        myPet.Neglect();
                        Console.Clear();
                        Console.WriteLine("Bad Owner!!\n Hunger level +5\n boredom level +5\n health -5");
                        break;
                    case "2":
                        myPet.Feed();
                        Console.Clear();
                        Console.WriteLine("You feed your pet hunger level -40");
                        break;
                    case "3":
                        myPet.SeeDoctor();
                        Console.Clear();
                        Console.WriteLine("Took pet to doctor:\n health level + 30");
                        break;
                    case "4":
                        myPet.Play();
                        Console.Clear();
                        Console.WriteLine("Playing with pet:\n hunger level +10\n boredom level - 20\n health level +10 ");
                        break;
                    case "5":
                        //Admit Pet
                        myPet = new Pet();
                        Console.Write("Enter Pet's Name: ");
                        myPet.PetName(Console.ReadLine());
                        Console.Write("Enter Pet's Species: ");
                        myPet.PetSpecies(Console.ReadLine());
                        //petShelter.AddPet(myPet); 
                        break;
                    case "6":
                        //Adopt Pet
                        break;
                    case "7":
                        keepThinking = false;
                        Console.Clear();
                        Console.WriteLine("Good-bye!");
                        break;
                    default:
                        break;

                }


            } while (keepThinking);
            


        }
        



    }
}
