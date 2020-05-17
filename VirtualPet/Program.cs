using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet myPet = new Pet();
            
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
                    string petName = myPet.SetName();
                    Console.WriteLine($"Your Pet name is {petName}");
                    break;
                case "2":
                    string petSpecies = myPet.SetSpecies();
                    Console.WriteLine($"Your Pet species is {petSpecies}");
                    break;
                case "3":
                    int petHunger = myPet.GetHunger();
                    Console.WriteLine($"Your Pet hunger level is {petHunger}");
                    break;
                case "4":
                    int petBoredom = myPet.GetBoredom();
                    Console.WriteLine($"Your Pet boredom level is {petBoredom}");
                    break;
                case "5":
                    int petHealth = myPet.GetHealth();
                    Console.WriteLine($"Your Pet health level is {petHealth}");
                    break;
                case "6":
                    Console.WriteLine("No Ticks Found");
                    break;
                case "7":
                    Console.WriteLine("Good-bye!");
                    break;
                default:
                    break;
            }


            
            

            
            

            
            
            
            
            
            
            
            
            
            

            

        
        
        
        
        
            Console.ReadLine();
        }


    }
}
