using Project.Abstractions.Interfaces;
using Project.Realisation.AnimalTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Realisation.Factories
{
    public class RabbitFactory : IAnimalFactory
    {
        public Animal Create(int food, string name, int number, int kidness, string description = "")
        {
            return new Rabbit(food, name, number, kidness, description);
        }
    }
}
