using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Abstractions.Interfaces
{
    public class Omnivore : Animal
    {
        public Omnivore(int food, string name, int number, int kidness = 0, string description = "") : base(food, name, number, kidness, description)
        {
        }
    }
}
