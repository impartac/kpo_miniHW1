using Project.Abstractions.Interfaces;
using Project.Realisation.Storages;

namespace Project.Realisation.Buildings
{
    public class Zoo : IZoo
    {
        private AnimalStorage animalStorage;
        private IClinic clinic { get; set; }
        private InventoryStorage inventoryStorage;

        public Zoo(IClinic clinic) 
        {
            animalStorage = new AnimalStorage();
            inventoryStorage = new InventoryStorage();
            this.clinic = clinic;
        }

        public void Add(IAnimal animal)
        {
            if (clinic.CheckHealth(animal))
            {
                animalStorage.Add(animal);
            }
            else
            {
                throw new ArgumentException("Animal isn't healthy");
            }
        }
        public void Remove(IAnimal animal)
        {
            animalStorage.Remove(animal);
        }
        public void ClearAnimalStorage()
        {
            animalStorage.Clear();
        }
        public void ClearInventoryStorage()
        {
            inventoryStorage.Clear();
        }
        public void Add(IInventory inventory) {
            inventoryStorage.Add(inventory);
        }
        public void Remove(IInventory inventory)
        {
            inventoryStorage.Remove(inventory);
        }
        public string AnimalStorageToString() 
        {
            var v = animalStorage.ToString();
            return v!= String.Empty ? v : "Empty";
        }

        public string ContactAnimalStorage() {
            var v = animalStorage.ContactAnimalToString();
            return v != String.Empty ? v : "Empty";
        }
        public string InventoryStorageToString()
        {
            var v = inventoryStorage.ToString();
            return v != String.Empty ? v : "Empty";
        }
        public int AnimalStorageCountFood() 
        {
            return animalStorage.CountFood();
        }
        public int AnimalStorageCount() 
        {
            return animalStorage.Size();
        }
    }
}
