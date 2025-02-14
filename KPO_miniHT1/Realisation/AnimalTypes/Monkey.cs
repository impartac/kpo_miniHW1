using Project.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Realisation.AnimalTypes
{
    internal class Monkey : Omnivore
    {
        public Monkey(int food, string name, int number, int kidness = 0, string description = "") : base(food, name, number, kidness, description)
        {
        }
    }
}
