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

        [Fact]
        public void FeedAllPets_Should_Feed_All_Pets()
        {
            Pet firstPet = new Pet();
            firstPet.Hunger = 10;
            sut.AddPet(firstPet);

            Pet secondPet = new Pet();
            secondPet.Hunger = 10;
            sut.AddPet(secondPet);

            sut.FeedAllPets();

            Assert.Equal(40, firstPet.Hunger);
            Assert.Equal(40, secondPet.Hunger);
        }

        [Fact]
        public void WaterAllPets_Should_Water_All_Pets()
        {
            Pet firstPet = new Pet();
            firstPet.Thirst = 10;
            sut.AddPet(firstPet);

            Pet secondPet = new Pet();
            secondPet.Thirst = 10;
            sut.AddPet(secondPet);

            sut.WaterAllPets();

            Assert.Equal(40, firstPet.Thirst);
            Assert.Equal(40, secondPet.Thirst);

        }



    }

       



}
