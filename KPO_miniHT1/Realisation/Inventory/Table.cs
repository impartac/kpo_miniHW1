using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Abstractions.Interfaces;

namespace Project.Realisation.Inventory
{
    public class Table : Thing
    {
        public Table(int number, string descripion = "") : base(number, descripion)
        {
        }
    }
}
