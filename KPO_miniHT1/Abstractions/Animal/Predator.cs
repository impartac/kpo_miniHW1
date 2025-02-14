using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Project.Abstractions.Interfaces
{
    public class Predator : Animal
    {
        public Predator(int food, string name, int number, int kidness = 0,string description = "") : base(food, name, number, kidness, description)
        {
        }
    }
}
