using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Abstractions.Interfaces
{
    public interface IAnimal : INamed, IAlive, IThing
    { 
        public string Type { get;}

        public int Food { get; set; }
    }
}
