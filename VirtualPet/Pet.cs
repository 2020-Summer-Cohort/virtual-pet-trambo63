using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;

namespace VirtualPet
{
    public class Pet
    {   //CLASS PROPERTIES
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        //CLASS CONSTRUCTORS
        public Pet()
        {
            Hunger = 50;
            Boredom = 60;
            Health = 30;

        }
        //CLASS METHODS
        public void PetName(string name)
        {
            Name = name;
        }
        
        public void PetSpecies(string species)
        {
            Species = species;
        }
        
        public int GetHunger()
        {
            return Hunger;
        }
        
        public int GetBoredom()
        {
            return Boredom;
        }

        public int GetHealth()
        {
            return Health;
        }

        public void Feed()
        {
            Hunger -= 40;
            if (Hunger <= 0)
            {
                Hunger = 0;
            }
        }

        public void SeeDoctor()
        {
            Health += 30;
            if (Health >= 100)
            {
                Health = 100;
            }
        }

        public void Play()
        {
            Hunger += 10;
            Boredom -= 20;
            Health += 10;
            if (Boredom <= 0)
            {
                Boredom = 0;
            }
            if (Health >= 100)
            {
                Health = 100;
            }
            if (Hunger <= 0)
            {
                Hunger = 0;
            }
        }
        public void Neglect()
        {
            Hunger += 5;
            Boredom += 5;
            Health -= 5;
        }

        public void PrintAllPetsStatus()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Health Level: {Health}");
            Console.WriteLine($"Hunger Level: {Hunger}");
            Console.WriteLine($"Boredom Level: {Boredom}\n");
        }



      














    }




}
