using Project.Abstractions.Interfaces;
using Project.Realisation.AnimalTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Project.Realisation.Factories
{
    public class WolfFactory : IAnimalFactory
    {
        public Animal Create(int food, string name, int number, int kidness=0, string description = "")
        {
            return new Wolf(food, name, number, kidness, description);
        }
    }
}
