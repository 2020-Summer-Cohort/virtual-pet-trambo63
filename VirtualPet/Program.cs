using System;

namespace VirtualPet
{
    class Program 
    {
        static void Main(string[] args)
        {
            //myPet is Object of Type Pet
            Pet myPet;
            PetShelter petList = new PetShelter();
            double myMoney = 60.00;

                Console.WriteLine("Hello! Welcome to Virtual Pet Shelter\n");

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
                if (myMoney > 100)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Retirement Achieved");
                    Console.WriteLine("Enjoy you'r Remaining years! Press Enter to Exit");
                    Console.ResetColor();
                    keepThinking = false;
                }
                Console.WriteLine($"Current Funds: ${myMoney}");
                Console.ResetColor();
                petList.PrintAllPetDetails();
                petList.RemoveDeadPet();
                if (petList.MaxDeadPets())
                {
                    keepThinking = false;
                }
             
                Console.WriteLine("Type Number and press Enter:");
                Console.WriteLine("What would you like to do?\n");
                Console.WriteLine("1. Take Animals to Park");
                Console.WriteLine("2. Feed Pets");
                Console.WriteLine("3. Water Pets");
                Console.WriteLine("4. Take a Pet to Vet");
                Console.WriteLine("5. Play With a Pet");
                Console.WriteLine("6. Admit Pet to Shelter");
                Console.WriteLine("7. Adopt Pet");
                Console.WriteLine("8. Exit Game\n");

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
                        keepThinking = false;
                        break;
                    default:
                        break;
                }


            } while (keepThinking);
            


        }
        



    }
}
