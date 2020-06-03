using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class RoboPet : Pet
    {
        Random random1 = new Random();
        //CLASS PROPERTIES
        public int Fuel { get; set; }
        public int Oil { get; set; }
        public int Grease { get; set; }
        public int HydraulicFluid { get; set; }
        public int RoboHealth { get; set; }

        //CLASS CONSTRUCTORS
        public RoboPet()
        {
            Fuel = 50;
            Oil = 60;
            Grease = 60;
            HydraulicFluid = 60;
            RoboHealth = 50;
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

        public int GetRoboHealth()
        {
            return RoboHealth;
        }

        public void FuelUp()
        {
            Fuel += 40;
            if (Fuel >= 100)
            {
                Fuel = 100;
            }
        }

        public void TopOffFluids()
        {
            Oil += 40;
            Grease += 40;
            HydraulicFluid += 40;
            if (Oil >= 100)
            {
                Oil = 100;
            }
            if (Grease >= 100)
            {
                Grease = 100;
            }
            HydraulicFluid += 40;
            if (HydraulicFluid >= 100)
            {
                HydraulicFluid = 100;
            }
        }

        public void TakeToMechanic()
        {
            RoboHealth += 40;
            if (RoboHealth >= 100)
            {
                RoboHealth = 100;
            }
        }

        public void RunRoboPet()
        {
            Fuel -= 20;
            Oil -= 10;
            Grease -= 10;
            HydraulicFluid -= 10;
            RoboHealth += 10;
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
            Oil -= 5;
            Grease -= 5;
            HydraulicFluid -= 5;


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
        public bool CheckIfTotaled()
        {
            if (Fuel <= 0 || Oil <= 20 || Grease <= 20 || HydraulicFluid <= 20)
            {
                return true;
            }

            return false;
        }

        public bool CheckIfSellable()
        {
            if (RoboHealth >= 80)
            {
                return true;
            }

            return false;
        }

        public void PrintRoboPetsStatus()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (Fuel <= 10 || Oil <= 30 || Grease <= 30 || HydraulicFluid <= 30)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            Console.WriteLine($"Name: {Name}| Species: {Species}| Fuel: {Fuel}| Oil: {Oil}| Grease: {Grease}| HydraulicFluid: {HydraulicFluid}| RoboHealth: {RoboHealth} \n");
            Console.ResetColor();
        }
    }
}
