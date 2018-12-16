using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabZoo;

namespace UnitTestProjectZoo
{
    [TestClass]
    public class UnitTest1
    {
        Zoo zoo = new Zoo();
        Zone f1 = new Zone();
        Zone f2 = new Zone();

        AviaryBear bearAviary = new AviaryBear(2);
        AviaryGiraffe giraffeAviary = new AviaryGiraffe(2);
        AviaryWolf wolfAviary = new AviaryWolf(2);

        [TestMethod()]
        public void AreasAggregateTest()
        {
            f1.Add(f2);
            zoo.AddField(f1);

            Assert.AreEqual(zoo.areas[0], f1);
            Assert.AreEqual(zoo.areas[1], f2);
        }

        [TestMethod()]
        public void ComponentHirerarchyTest()
        {
            f1.Add(f2);
            f1.Add(bearAviary);
            f2.Add(giraffeAviary);
            f2.Add(wolfAviary);
            zoo.AddField(f1);

            Assert.AreEqual(f1, f2);
            Assert.AreEqual(f1.Composites()[1], bearAviary);
            Assert.AreEqual(f2.Composites()[0], giraffeAviary);
            Assert.AreEqual(f2.Composites()[1], wolfAviary);
        }

        [TestMethod()]
        [ExpectedException(typeof(NoPlaceException))]
        public void NoPlaceTest()
        {
            Zoo zoo = new Zoo();
            zoo.AddAnimal("Some Animal", 100);
        }

        [TestMethod()]
        [ExpectedException(typeof(NoPlaceException))]
        public void ZeroPlaceTest()
        {
            f1.Add(f2);
            f1.Add(bearAviary);
            f2.Add(giraffeAviary);
            f2.Add(wolfAviary);
            zoo.AddField(f1);
            for (int i = 0; i < 10; i++)
                zoo.AddAnimal("Some Animal", 10);
        }

        [TestMethod()]
        public void SumWeightTest()
        {
            f1.Add(f2);
            f1.Add(bearAviary);
            f2.Add(giraffeAviary);
            f2.Add(wolfAviary);
            zoo.AddField(f1);

            zoo.AddAnimal("Some Animal 1", 1);
            zoo.AddAnimal("Some Animal 2", 2);

            Assert.AreEqual(zoo.SumWeight(), 3);
        }

        [TestMethod()]
        public void AverageWeightTest()
        {
            f1.Add(f2);
            f1.Add(bearAviary);
            f2.Add(giraffeAviary);
            f2.Add(wolfAviary);
            zoo.AddField(f1);

            zoo.AddAnimal("Some Animal 1", 1);
            zoo.AddAnimal("Some Animal 2", 3);

            Assert.AreEqual(zoo.AverageWeight(), 2);
        }

        [TestMethod()]
        public void VoiceTest()
        {
            f1.Add(f2);
            f1.Add(bearAviary);
            f2.Add(giraffeAviary);
            f2.Add(wolfAviary);
            zoo.AddField(f1);

            zoo.AddAnimal("Some Animal", 1);
            Animal a = zoo.animals[0];
            string v1 = a.Voice();

            zoo.Night();
            string v2 = a.Voice();
            Assert.AreEqual(v2, "Piss off, I'm " + a._name + " and I'm sleeping.");
            a.Wake();
            Assert.AreEqual(a.Voice(), v1);
        }
    }
}
