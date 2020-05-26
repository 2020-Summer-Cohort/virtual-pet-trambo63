using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class PetShelter
    {
        public List<Pet> PetShelterList = new List<Pet>();

        public void AddPet(Pet pet)
        {
            PetShelterList.Add(pet);
        }

        public void PrintAllPetDetails()
        {
            Console.WriteLine("Your Pets:\n");
            foreach(Pet pet in PetShelterList)
            {
                pet.PrintPetsStatus();
            }
        }

        public void PrintAllPetNames()
        {
            int listNumber = 1;

            Console.WriteLine("Current Pets in Shelther");
            foreach(Pet pet in PetShelterList)
            {
                string name = pet.GetName();
                Console.WriteLine($"{listNumber}. {name}");
                listNumber++;
            }
        }

        public Pet FindPetNameByIndex(int index)
        {
            Pet selectedPet = PetShelterList[index];
            return selectedPet; 
        }

        public void RemovePetFromList(Pet pet)
        {
            PetShelterList.Remove(pet);
        }

        public void FeedAllPets()
        {
            foreach(Pet pet in PetShelterList)
            {
                pet.Feed();
            }
        }
        public void WaterAllPets()
        {
            foreach(Pet pet in PetShelterList)
            {
                pet.Water();
            }
        }
        public void Park()
        {
            foreach(Pet pet in PetShelterList)
            {
                pet.Park();
                pet.Tick();
            }
        }

   

    }
}
