using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tamagotchi.Models;

namespace Tamagotchi.Test
{
    [TestClass]
    public class TamagotchiAnimalTest
    {
        [TestMethod]
        public void ConstructorTest_True()
        {
            TamagotchiAnimal tama = new TamagotchiAnimal("Lady");
            Assert.AreEqual(typeof(TamagotchiAnimal), tama.GetType());
            Assert.AreEqual("Lady", tama.Name);
        }
    }
}