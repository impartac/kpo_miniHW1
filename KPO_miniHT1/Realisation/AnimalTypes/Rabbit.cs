using Project.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Realisation.AnimalTypes
{
    public class Rabbit : Herbo

    {
        public Rabbit(int food, string name, int number, int kidness, string description = "") : base(food, name, number, kidness, description)
        {
        }
    }
}
