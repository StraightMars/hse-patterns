using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            var teacher = new Teacher();
            var studentA = new StudentA();
            teacher.Attach(studentA);

            var studentB = new StudentB();
            teacher.Attach(studentB);

            var studentC = new StudentC();
            teacher.Attach(studentC);

            Console.WriteLine("\n");

            teacher.Action("A=2,B=4,C=3");
            Console.WriteLine("\n\n");

            teacher.Action("A=3,B=5,C=4");
            Console.WriteLine("\n\n");

            teacher.Detach(studentC);

            teacher.Action("A=5,B=2,C=3");
        }
    }
}
