using Project.Abstractions.Interfaces;
using Project.Realisation.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Realisation.Factories
{
    public class ComputerFactory: IThingFactory
    {
        public IThing Create(int number, string description = "")
        {
            return new Computer(number, description);
        }
    }
}
