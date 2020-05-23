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
            Console.WriteLine("Your Pets:");
            foreach(Pet pet in PetShelterList)
            {
                pet.PrintAllPetsStatus();
            }

        }

    }
}
