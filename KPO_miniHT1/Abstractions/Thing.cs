using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Abstractions.Interfaces;



namespace Project.Abstractions.Interfaces
{
    public abstract class Thing : IThing
    {
        private int _number;
        public int Number
        {
            get => _number;
            set => _number = value >= 0 ? value : throw new ArgumentOutOfRangeException();
        }

        public string Description { get; set; }
        public string Type { get => GetType().Name; }

        public override string ToString()
        {
            return $"Thing: <Type : {Type}, Number: {Number}, Description: {Description}>";
        }
        public Thing(int number, string descripion = "")
        {
            _number = number;
            Description = descripion;
        }
    }
}
