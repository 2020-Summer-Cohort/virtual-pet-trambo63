using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class PetShelterTests
    {
        PetShelter sut;

        public PetShelterTests()
        {
            sut = new PetShelter();
        } 
        //AddPet
        [Fact]
        public void AddPet()
        {
            


            Assert.Single(sut.PetShelterList);
        }
    }
}
