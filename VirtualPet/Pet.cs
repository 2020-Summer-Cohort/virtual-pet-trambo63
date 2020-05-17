using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        public string name { get; set; }
        
        public PetName()
        {
            name = "Shane";
            
            
        }
        public string GetName()
        {
            return name;
            
        }

        

    }




}
