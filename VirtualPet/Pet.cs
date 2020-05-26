using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;

namespace VirtualPet
{
    public class Pet
    {
        Random random = new Random();

        //CLASS PROPERTIES
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        //CLASS CONSTRUCTORS
        public Pet()
        {
            Hunger = random.Next(20, 80);
            Thirst = random.Next(20, 80);
            Boredom = random.Next(20, 80);
            Health = random.Next(20, 80);
        }
        //CLASS METHODS
        public void PetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        
        public void PetSpecies(string species)
        {
            Species = species;
        }
        
        public int GetHunger()
        {
            return Hunger;
        }
        
        public int GetThirst()
        {
            return Thirst;
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

        public void Water()
        {
            Thirst -= 30;
            if(Thirst <=0)
            {
                Thirst = 0;
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
            Thirst += 10;
            if (Boredom <= 0)
            {
                Boredom = 0;
            }
            if (Health >= 100)
            {
                Health = 100;
            }
            if (Hunger >= 100)
            {
                Hunger = 100;
            }
            if (Thirst >= 100)
            {
                Thirst = 100;
            }
            
         
        }
        public void Park()
        {
            Hunger += 5;
            Thirst += 5;
            Boredom -= 15;
            Health += 15;

            if (Hunger >= 100)
            {
                Hunger = 100;
            }
            if (Thirst >= 100)
            {
                Thirst = 100;
            }
            if (Boredom <=0)
            {
                Boredom = 0;
            }
            if (Health >= 100)
            {
                Health = 100;
            }

        }
        public void Tick()
        {
            Boredom += random.Next(0, 11);
            Hunger += random.Next(0, 11);
            Thirst += random.Next(0, 11);
            Health -= random.Next(0, 11);


            if (Boredom >= 100)
            {
                Boredom = 100;
            }
            if (Hunger >= 100)
            {
                Hunger = 100;
            }
            if (Thirst >= 100)
            {
                Thirst = 100;
            }
            if (Health <= 100)
            {
                Health = 100;
            }

        }
    
      
    
    

        public void PrintPetsStatus()
        {
            Console.WriteLine($"Name: {Name}| Species: {Species}| Health: {Health}| Hunger: {Hunger}| Thirst: {Thirst}| Boredom: {Boredom}\n");
        }




    }




}
