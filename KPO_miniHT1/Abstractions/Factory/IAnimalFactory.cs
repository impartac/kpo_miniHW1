﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Abstractions.Interfaces
{
    public interface IAnimalFactory
    {
        public Animal Create(int food, string name, int number, int kidness = 0, string description = "");
    }
}
