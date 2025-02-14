using Project.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Realisation.Storages
{
    public class InventoryStorage : IInventoryStorage
    {
        private List<IInventory> inventory;

        public InventoryStorage()
        {
            inventory = new List<IInventory>();
        }
        public void Add(IInventory obj)
        {
            inventory.Add(obj);
        }

        public void Remove(IInventory obj)
        {
            inventory.Remove(obj);
        }

        public void Clear()
        {
            inventory.Clear();
        }

        public int Size()
        {
            return inventory.Count;
        }

        public override string ToString()
        {
            return string.Join(", ", inventory.Select(x => x.ToString()));
        }

        public IInventory Last() 
        {
            return inventory.Last();
        }
    }
}
