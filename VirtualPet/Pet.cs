using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

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
            Name = "Shane";
            Species = "Dog";
            Hunger = 50;
            Boredom = 60;
            Health = 30;

        }
        //CLASS METHODS
        public string PetName()
        {
            return Name;
        }
        
        public string PetSpecies()
        {
            return Species;
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
        }

        public void SeeDoctor()
        {
            Health += 30;
        }

        public void Play()
        {
            Hunger += 10;
            Boredom -= 20;
            Health += 10;
        }
        public void DoNothing()
        {
            Hunger += 5;
            Boredom += 5;
            Health -= 5;
        }
        public void MinHunger()
        {
            Hunger = 0;
        }














    }




}
