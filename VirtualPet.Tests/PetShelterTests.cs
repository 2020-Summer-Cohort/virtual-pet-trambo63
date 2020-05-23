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
        public void AddPet_Should_Increase_List_Count_To_1()
        {
            Pet newPet = new Pet();

            sut.AddPet(newPet);

            Assert.Single(sut.PetShelterList);
        }
    }
}
