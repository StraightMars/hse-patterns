using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Context context = new Context();

            int[] numberToSolve = new int[rnd.Next(0, 11)];
            for (int i = 0; i < numberToSolve.Length; i++)
            {
                numberToSolve[i] = rnd.Next(-1000, 1001);
            }

            int bin = 2;
            int oct = 8;
            int hex = 16;

            context.SetNotation("bin", bin);
            context.SetNotation("oct", oct);
            context.SetNotation("hex", hex);

            foreach (int elem in numberToSolve)
            {
                INotation toBin = new To2Notation(elem, new NotationBase("bin"));
                INotation toOct = new To2Notation(elem, new NotationBase("oct"));
                INotation toHex = new To2Notation(elem, new NotationBase("hex"));

                Console.WriteLine("Перевод числа {0} в:\nДвоичную СС - {1},\nВосьмеричную СС - {2},\nШестнадцатеричную СС - {3}\n",
                elem, toBin.Interpret(context), toOct.Interpret(context), toHex.Interpret(context));
            }
        }
    }
}
