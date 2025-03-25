using Existence.Beyond.Infrastructure;
using Existence.Beyond.Timeless;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Existence.Tests
{
    [TestClass]
    public class TimelessTests
    {
        [TestMethod]
        public void TestPetHouse()
        {
            HashSet<Pet> pets = new HashSet<Pet>();
            int iKittensCount = 0;
            foreach (var p in Timeless.PetHouse.FictionalPetMapping)
            {
                Pet pet = p.Value;
                if (pet.BirthYear.HasValue) iKittensCount++;
                if (!pets.Contains(pet)) pets.Add(pet);
                Assert.AreEqual(pet.TruthClass, TruthClassification.Fictional);
            }
            Assert.AreEqual(pets.Count, 8);
            Assert.AreEqual(iKittensCount, 4);
            pets.Clear();
            iKittensCount = 0;
            foreach (var p in Timeless.PetHouse.NonFictionalPetMapping)
            {
                Pet pet = p.Value;
                if (pet.BirthYear.HasValue) iKittensCount++;
                if (!pets.Contains(pet)) pets.Add(pet);
                Assert.AreEqual(pet.TruthClass, TruthClassification.Nonfictional);
            }
            Assert.AreEqual(pets.Count, 8);
            Assert.AreEqual(iKittensCount, 4);
        }
    }
}
