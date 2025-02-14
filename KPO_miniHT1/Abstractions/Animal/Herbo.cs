using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Project.Abstractions.Interfaces
{
    public abstract class Herbo : Animal
    {
        int _kidness;
        protected Herbo(int food, string name, int number, int kidness = 0, string description = "") : base(food, name, number, kidness, description)
        {
            _kidness = kidness;
        }

        public int Kindness {
            get => _kidness; 
            set => _kidness = (0<= value && value<=10) ? value : throw new ArgumentOutOfRangeException();
        }
        public bool IsContact() 
        {
            return _kidness > 5;
        }
    }
}
