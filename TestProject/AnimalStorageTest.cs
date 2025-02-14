using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject;
using Project.Realisation.AnimalTypes;
using Project.Abstractions.Interfaces;
using Project.Realisation.Storages;
using System.Globalization;
using NuGet.Frameworks;

namespace TestProject
{
    [TestFixture]
    class AnimalStorageTest
    {
        private Rabbit rabbitEx1;
        private AnimalStorage storage;
        [SetUp]
        public void Setup() 
        {
            storage = new AnimalStorage();
            rabbitEx1 = new Rabbit(2, "Johny", 4, 10);
        }
        [Test]
        public void Add()
        { 
            storage.Add(rabbitEx1);
            Assert.AreEqual(storage.Last().Name, "Johny");
        }
        [Test]
        public void Clear() 
        {
            storage.Clear();
            Assert.IsTrue(storage.animals.Count == 0);
        }

        [Test]
        public void CountFood() 
        {
            storage.Add(rabbitEx1);
            Assert.AreEqual(storage.CountFood(), 2);
        }

        [Test]
        public void Size()
        {
            storage.Add(rabbitEx1);
            Assert.AreEqual(storage.Size(), 1);
        }
    }
}
