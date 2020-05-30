using System;

namespace VirtualPet
{
    class Program 
    {
        static void Main(string[] args)
        {
            //myPet is Object of Type Pet
            Pet myPet;
            RoboPet myRoboPet;
            PetShelter roboPetList = new PetShelter();
            PetShelter petList = new PetShelter();
            double myMoney = 40.00;
            
            Console.WriteLine("Hello! Welcome to Virtual Pet Shelter");
            Console.WriteLine("Earn $200.00 to reach Retierment\n");

            bool keepThinking = true;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (myMoney < 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                if (myMoney < -50)
                {
                    Console.Clear();
                    Console.WriteLine("Bankrupted!");
                    Console.WriteLine("Game Over: Press Enter to Exit");
                    keepThinking = false;
                }
                if (myMoney >= 200)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Retirement Achieved");
                    Console.WriteLine("Enjoy you'r Remaining years! Press Enter to Exit");
                    Console.ResetColor();
                    keepThinking = false;
                }
                Console.WriteLine($"Current Funds: ${myMoney}\n");
                Console.ResetColor();

                petList.PrintAllPetDetails();
                roboPetList.PrintAllRoboPetDetails();

                petList.RemoveDeadPet();
                if (petList.MaxDeadPets())
                {
                    keepThinking = false;
                }

                roboPetList.RemoveTotaledRoboPet();
             
                Console.WriteLine("Type Number and press Enter:");
                Console.WriteLine("What would you like to do?\n");
                Console.WriteLine("PETS____________________");
                Console.WriteLine("1. Take Animals to Park");
                Console.WriteLine("2. Feed Pets");
                Console.WriteLine("3. Water Pets");
                Console.WriteLine("4. Take a Pet to Vet");
                Console.WriteLine("5. Play With a Pet");
                Console.WriteLine("6. Admit Pet to Shelter");
                Console.WriteLine("7. Adopt Pet");
                Console.WriteLine("ROBOPETS____________________");
                Console.WriteLine("8. Fuel a RoboPet");
                Console.WriteLine("9. Top Off Fluids for a RoboPet");
                Console.WriteLine("10. Run a RoboPet");
                Console.WriteLine("11. Take a RoboPet to the Mechanic");
                Console.WriteLine("12. Build a RoboPet");
                Console.WriteLine("13. Sell a RoboPet");
                Console.WriteLine("14. Exit Game\n");

                string menuChoice = Console.ReadLine();
                Console.Clear();

                switch (menuChoice)
                {
                    case "1":
                        petList.TakeToPark();
                        myMoney -= 10;
                        break;
                    case "2":
                        petList.FeedAllPets();
                        myMoney -= 5;
                        break;
                    case "3":
                        petList.WaterAllPets();
                        myMoney -= 5;
                        break;
                    case "4":
                        Console.Clear();
                        petList.PrintAllPetNames();
                        Console.Write("Which Pet would you like to take to the Vet: ");
                        int petNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Pet petToTakeToVet = petList.FindPetNameByIndex(petNumber - 1);
                        petToTakeToVet.SeeDoctor();
                        myMoney -= 5;
                        break;
                    case "5":
                        Console.Clear();
                        petList.PrintAllPetNames();
                        Console.Write("Which Pet would you like to paly with: ");
                        petNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Pet petToPlayWith = petList.FindPetNameByIndex(petNumber - 1);
                        petToPlayWith.Play();
                        break;
                    case "6":
                        myPet = new Pet();
                        Console.Clear();
                        Console.Write("Enter Pet's Name: ");
                        myPet.PetName(Console.ReadLine());
                        Console.Write("Enter Pet's Species: ");
                        myPet.PetSpecies(Console.ReadLine());
                        petList.AddPet(myPet);
                        myMoney -= 10;
                        Console.Clear();
                        break;
                    case "7":
                        Console.Clear();
                        petList.PrintAllPetNames();
                        Console.Write("Which Pet would you like to Adopt: ");
                        petNumber = Convert.ToInt32(Console.ReadLine());
                        Pet petToRemove = petList.FindPetNameByIndex(petNumber - 1);
                        bool isAdoptable = petToRemove.CheckIfAdoptable();
                        if (isAdoptable)
                        {
                            petList.RemovePetFromList(petToRemove);
                            myMoney += 40.00;
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("This Pet does NOT meet Adoption Criteria. Health too low!");
                            Console.ResetColor();
                        }
                        break;
                    case "8":
                        Console.Clear();
                        roboPetList.PrintAllRoboPetNames();
                        Console.Write("Which RoboPet would you like to Fuel: ");
                        int roboPetNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        RoboPet roboPetToFuel = roboPetList.FindRoboPetNameByIndex(roboPetNumber - 1);
                        roboPetToFuel.FuelUp();
                        myMoney -= 10;
                        break;
                    case "9":
                        Console.Clear();
                        roboPetList.PrintAllRoboPetNames();
                        Console.Write("Which RoboPet would you like to Top Off Fluids for: ");
                        roboPetNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        RoboPet roboPetToTopOffFluids = roboPetList.FindRoboPetNameByIndex(roboPetNumber - 1);
                        roboPetToTopOffFluids.TopOffFluids();
                        myMoney -= 5;
                        break;
                    case "10":
                        Console.Clear();
                        roboPetList.PrintAllRoboPetNames();
                        Console.Write("Which RoboPet would you like to run: ");
                        roboPetNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        RoboPet roboPetToRun = roboPetList.FindRoboPetNameByIndex(roboPetNumber - 1);
                        roboPetToRun.RunRoboPet();
                        roboPetToRun.RoboTick();
                        break;
                    case "11":
                        Console.Clear();
                        roboPetList.PrintAllRoboPetNames();
                        Console.Write("Which RoboPet would you like to take to the Mechanic: ");
                        roboPetNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        RoboPet roboPetToTakeToMechanic = roboPetList.FindRoboPetNameByIndex(roboPetNumber - 1);
                        roboPetToTakeToMechanic.TakeToMechanic();
                        myMoney -= 20;
                        break;
                    case "12":
                        myRoboPet = new RoboPet();
                        Console.Clear();
                        Console.Write("Enter RoboPet's Name: ");
                        myRoboPet.RoboPetName(Console.ReadLine());
                        Console.Write("Enter RoboPet's Species: ");
                        myRoboPet.RoboPetSpecies(Console.ReadLine());
                        roboPetList.AddRoboPet(myRoboPet);
                        myMoney -= 20;
                        Console.Clear();
                        break;
                    case "13":
                        Console.Clear();
                        roboPetList.PrintAllRoboPetNames();
                        Console.Write("Which RoboPet would you like to Sell: ");
                        roboPetNumber = Convert.ToInt32(Console.ReadLine());
                        RoboPet roboPetToRemove = roboPetList.FindRoboPetNameByIndex(roboPetNumber - 1);
                        bool isSellable = roboPetToRemove.CheckIfSellable();
                        if (isSellable)
                        {
                            roboPetList.RemoveRoboPetFromList(roboPetToRemove);
                            myMoney += 60.00;
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("This RoboPet is not running at a high enough efficacy to sell!");
                            Console.ResetColor();
                        }
                        break;
                    case "14":
                        keepThinking = false;
                        break;
                    default:
                        break;
                }


            } while (keepThinking);
            


        }
        



    }
}
