using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class StudentC : IStudent
    {
        public void Update(ITeacher teacher)
        {
            try
            {
                string[] str = (teacher as Teacher).State.Split(',');
                string[] mark = str[2].Split('=');
                if ((teacher as Teacher).State.Contains(("C=" + mark[1]).ToString()) && Int32.Parse(mark[1]) == 3)
                    Console.WriteLine("StudentC: Better luck next time");
            }
            catch (Exception)
            {
                Console.WriteLine("Сегодня без оценки");
            }
        }
    }
}
