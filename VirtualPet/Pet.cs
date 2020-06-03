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
            Hunger = 50;
            Thirst = 60;
            Boredom = 60;
            Health = 30;
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
            Boredom += 5;
            Hunger += 5;
            Thirst += 5;


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
      

        }
        public bool CheckIfDead()
        {
            if (Hunger >= 100 || Thirst >= 100 || Health <= 0)
            {
                return true;
            }
            
            return false;
        }

        public bool CheckIfAdoptable()
        {
            if (Health >= 80)
            {
                return true;
            }

            return false;
        }
     

        public void PrintPetsStatus()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (Hunger >= 80 || Thirst >= 80 || Boredom >= 80 || Health <= 20)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            Console.WriteLine($"Name: {Name}| Species: {Species}| Health: {Health}| Hunger: {Hunger}| Thirst: {Thirst}| Boredom: {Boredom}\n");
            Console.ResetColor();
        }




    }




}
