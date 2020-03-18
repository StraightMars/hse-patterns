using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class To2Notation : INotation
    {
        int numberToShift;
        INotation baseToShift;

        public To2Notation(int _number, INotation _base)
        {
            numberToShift = _number;
            baseToShift = _base;
        }

        public string Interpret(Context context)
        {
            return Convert.ToString(numberToShift, Int32.Parse(baseToShift.Interpret(context)));
        }
    }
}
