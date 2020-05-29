using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class RoboPet 
    {
        Random random = new Random();
        //CLASS PROPERTIES
        public string Name { get; set; }
        public string Species { get; set; }
        public int Fuel { get; set; }
        public int Oil { get; set; }
        public int Grease { get; set; }
        public int HydraulicFluid { get; set; }
        public int Efficiency { get; set; }

        //CLASS CONSTRUCTORS
        public RoboPet()
        {
            Fuel = 50;
            Oil = 60;
            Grease = 60;
            HydraulicFluid = 60;
            Efficiency = 50;
        }

        //CLASS METHODS
        public void RoboPetName(string name)
        {
            Name = name;
        }
        public string GetRoboPetName()
        {
            return Name;
        }

        public void RoboPetSpecies(string species)
        {
            Species = species;
        }

        public int GetFuel()
        {
            return Fuel;
        }

        public int GetOil()
        {
            return Oil;
        }

        public int GetGrease()
        {
            return Grease;
        }

        public int GetHydraulicFluid()
        {
            return HydraulicFluid;
        }

        public int GetEfficiency()
        {
            return Efficiency;
        }

        public void FuelUp()
        {
            Fuel += 40;
            if (Fuel >= 100)
            {
                Fuel = 100;
            }
        }

        public void TopOffOil()
        {
            Oil += 40;
            if (Oil >= 100)
            {
                Oil = 100;
            }

        }

        public void GreaseJoints()
        {
            Grease += 40;
            if (Grease >= 100)
            {
                Grease = 100;
            }
        }

        public void TopOffHydraulicFluid()
        {
            HydraulicFluid += 40;
            if (HydraulicFluid >= 100)
            {
                HydraulicFluid = 100;
            }
        }

        public void TakeToMechanic()
        {
            Efficiency += 40;
            if (Efficiency >= 100)
            {
                Efficiency = 100;
            }
        }

        public void RunRoboPet()
        {
            Fuel -= 10;
            Oil -= 10;
            Grease -= 10;
            HydraulicFluid -= 10;
            Efficiency += 10;
            if (Fuel <= 0)
            {
                Fuel = 0;
            }
            if (Oil <= 0)
            {
                Oil = 0;
            }
            if (Grease <= 0)
            {
                Grease = 0;
            }
            if (HydraulicFluid <= 0)
            {
                HydraulicFluid = 0;
            }
        }
        public void RoboTick()
        {
            Oil -= random.Next(0, 11);
            Grease -= random.Next(0, 11);
            HydraulicFluid -= random.Next(0, 11);


            if (Oil <= 0)
            {
                Oil = 0;
            }
            if (Grease <= 0)
            {
                Grease = 0;
            }
            if (HydraulicFluid <= 0)
            {
                HydraulicFluid = 0;
            }


        }

    }
}
