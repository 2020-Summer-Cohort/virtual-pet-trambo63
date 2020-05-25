using System;
using System.Collections.Generic;
using System.Net;
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

        [Fact]
        public void FindPetNameInList_Should_Return_Correct_Pet_Object()
        {
            Pet petToRemove = new Pet();
            sut.AddPet(petToRemove);
            int myPetIndex = sut.PetShelterList.IndexOf(petToRemove);

            Pet returnedFromList = sut.FindPetNameByIndex(myPetIndex);

            Assert.True(petToRemove.Equals(returnedFromList));
        }

        [Fact]
        public void RemovePet_Should_Remove_Pet_From_List()
        {
            Pet pet = new Pet();
            sut.AddPet(pet);

            sut.RemovePetFromList(pet);

            Assert.DoesNotContain(pet, sut.PetShelterList);
        }

    }
}
