using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.LogicManager
{
    public class Reader
    {
        public Reader() { }

        public int ReadKey(int min, int max)
        {
            ConsoleKeyInfo keyInfo;
            int keyValue;
            keyInfo = Console.ReadKey(true);

            if (!int.TryParse(keyInfo.KeyChar.ToString(), out keyValue))
            {
                throw new ArgumentException();
            }
            if (keyValue < min || keyValue > max)
            {
                throw new ArgumentOutOfRangeException();
            }

            return keyValue;
        }

        public int ReadInt(Func<int, bool> f) 
        {
            int x = 0;
            while (true)
            {
                bool v = int.TryParse(Console.ReadLine(), out x);
                if (v && f(x)) 
                {
                    return x;
                }
            }
        }

        public string ReadString(Func<string, bool> f)
        {
            string x;
            while (true)
            {
                x = Console.ReadLine();
                if (f(x))
                {
                    return x;
                }
            }
        }
    }
}
