using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class StudentA : IStudent
    {
        public void Update(ITeacher teacher)
        {
            try
            {
                string[] str = (teacher as Teacher).State.Split(',');
                string[] mark = str[0].Split('=');
                if ((teacher as Teacher).State.Contains(("A=" + mark[1]).ToString()) && Int32.Parse(mark[1]) < 3)
                    Console.WriteLine("StudentA: Okay(, bad mark...");
            }
            catch (Exception)
            {
                Console.WriteLine("Сегодня без оценки");
            }
        }
    }
}
