using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Abstractions.Interfaces
{
    public interface IStorage<T>
    {
        public void Add(T obj);
        public void Remove(T obj);
        public void Clear();
        public int Size();
    }
}
