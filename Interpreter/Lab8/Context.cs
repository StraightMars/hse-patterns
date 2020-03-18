using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Context
    {
        Dictionary<string, int> notation;
        public Context()
        {
            notation = new Dictionary<string, int>();
        }

        public int GetNotation(string name)
        {
            return notation[name];
        }
        public void SetNotation(string name, int value)
        {
            if (notation.ContainsKey(name))
                notation[name] = value;
            else
                notation.Add(name, value);
        }
    }
}
