using Project.Abstractions.Interfaces;
using Project.Realisation.AnimalTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Realisation.Storages
{
    public class AnimalStorage : IAnimalStorage
    {
        public List<IAnimal> animals;
        public AnimalStorage()
        {
            animals = new List<IAnimal>();
        }
        #region IStorage<Animal>
        public void Add(IAnimal animal)
        {
            animals.Add(animal);
        }
        public void Remove(IAnimal animal)
        {
            animals.Remove(animal);
        }

        public void Clear()
        {
            animals.Clear();
        }

        public int Size()
        {
            return animals.Count;
        }
        #endregion
        #region IAnimalStorage
        public int CountFood()
        {
            return animals.Sum(animal => animal.Food);
        }
        #endregion

        public override string ToString()
        {
            return string.Join(", ", animals.Select(x => x.ToString()));
        }
        public string ContactAnimalToString() 
        {
            var filtredAnimals = animals.Where(x => x is Rabbit);
            return string.Join(", ", filtredAnimals.Select(x => x.ToString()));
        }
        public IAnimal Last() 
        {
            return animals.Last();
        }
    }
}
