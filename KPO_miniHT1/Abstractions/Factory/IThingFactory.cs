using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Abstractions.Interfaces;

namespace Project.Abstractions.Interfaces
{
    public interface IThingFactory
    {
        public IThing Create(int number, string description = "");
    }
}
