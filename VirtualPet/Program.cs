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

                Console.WriteLine("Hello! Welcome to Virtual Pets\n");
                  

            bool keepThinking = true;
            do
            {
                petList.PrintAllPetDetails();

                Console.WriteLine("Type Number and press Enter:");
                Console.WriteLine("What would you like to do?\n");
                Console.WriteLine("1. Vacation");
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
                        petList.Vacation();
                        break;
                    case "2":
                        petList.FeedAllPets();  
                        break;
                    case "3":
                        petList.WaterAllPets();
                        break;
                    case "4":
                        Console.Clear();
                        petList.PrintAllPetNames();
                        Console.Write("Which Pet would you like to take to the Vet: ");
                        int petNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Pet petToTakeToVet = petList.FindPetNameByIndex(petNumber - 1);
                        petToTakeToVet.SeeDoctor();
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
                        Console.Clear();
                        break;
                    case "7":
                        Console.Clear();
                        petList.PrintAllPetNames();
                        Console.Write("Which Pet would you like to Adopt: ");
                        petNumber = Convert.ToInt32(Console.ReadLine());
                        Pet petToRemove = petList.FindPetNameByIndex(petNumber - 1);
                        petList.RemovePetFromList(petToRemove);
                        Console.Clear();
                        break;
                    case "8":
                        keepThinking = false;
                        Console.Clear();
                        break;
                    default:
                        break;

                }


            } while (keepThinking);
            


        }
        



    }
}
