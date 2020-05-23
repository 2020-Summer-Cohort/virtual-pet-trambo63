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
               
                Console.WriteLine("Type Number and press Enter:");
                Console.WriteLine("What would you like to do?\n");
                Console.WriteLine("1. Neglect Pets");
                Console.WriteLine("2. Feed Pets");
                Console.WriteLine("3. Take to Vet");
                Console.WriteLine("4. Play With Pets");
                Console.WriteLine("5. Admit Pet to Shelter");
                Console.WriteLine("6. Adopt Pet");
                Console.WriteLine("7. See Pets Status");
                Console.WriteLine("8. Exit Game\n");

                string menuChoice = Console.ReadLine();
                Console.Clear();

                switch (menuChoice)
                {
                    case "1":
                        //myPet.Neglect();
                        //Console.Clear();
                        //Console.WriteLine("Bad Owner!!\n Hunger level +5\n boredom level +5\n health -5");
                        break;
                    case "2":
                        //myPet.Feed();
                        //Console.Clear();
                        //Console.WriteLine("You feed your pet hunger level -40");
                        break;
                    case "3":
                        //myPet.SeeDoctor();
                        //Console.Clear();
                        //Console.WriteLine("Took pet to doctor:\n health level + 30");
                        break;
                    case "4":
                        //myPet.Play();
                        //Console.Clear();
                        //Console.WriteLine("Playing with pet:\n hunger level +10\n boredom level - 20\n health level +10 ");
                        break;
                    case "5":
                        //Admit Pet
                        myPet = new Pet();
                        Console.Clear();
                        Console.Write("Enter Pet's Name: ");
                        myPet.PetName(Console.ReadLine());
                        Console.Write("Enter Pet's Species: ");
                        myPet.PetSpecies(Console.ReadLine());
                        petList.AddPet(myPet);
                        Console.Clear();
                        break;
                    case "6":
                        //Adopt Pet
                        Console.Clear();
                        petList.PrintAllPetNames();
                        Console.Write("Which Pet would you like to Adopt: ");
                        int petNumber = Convert.ToInt32(Console.ReadLine());
                        Pet petToRemove = petList.FindPetNameByIndex(petNumber - 1);
                        petList.RemovePetFromList(petToRemove);
                        Console.WriteLine("Your Pet has been Adopted!");
                        break;
                    case "7":
                        petList.PrintAllPetDetails();
                        break;
                    case "8":
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
