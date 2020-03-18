using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class NotationBase : INotation
    {
        private string name;

        public NotationBase(string _name)
        {
            name = _name;
        }

        public string Interpret(Context context)
        {
            return context.GetNotation(name).ToString();
        }
    }
}
