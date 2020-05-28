﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace VirtualPet
{
    public class PetShelter 
    {
        public List<Pet> PetShelterList = new List<Pet>();
        public int DeadPetCount { get; set; }

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
        public void TakeToPark()
        {
            foreach(Pet pet in PetShelterList)
            {
                pet.Park();
                pet.Tick();
            }
        }

        public void RemoveDeadPet()
        {
            List<Pet> deadPetList = new List<Pet>();
            foreach(Pet pet in PetShelterList)
            {
                bool isDead = pet.CheckIfDead();
                if (isDead)
                {
                    deadPetList.Add(pet);
                    DeadPetCount++;
                }

            }
            foreach (Pet pet in deadPetList)
            {
                RemovePetFromList(pet);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{pet.GetName()} is Dead!!\n");
                Console.ResetColor();
                Console.WriteLine($"Press Enter to cart off {pet.GetName()}'s body.\n");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("You'r under investigation for animal cruelty!\n");
                Console.ResetColor();
            }

        }
        public bool MaxDeadPets()
        {
            if (DeadPetCount >= 2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("GAME OVER!\n");
                Console.WriteLine("Press Enter to Exit! NOW!\n");
                Console.ResetColor();
                return true;
            }
            return false;

        }

    }
}
