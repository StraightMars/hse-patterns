using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class RealAccess : IAccess
    {
        public void Request()
        {
            Console.WriteLine("Реальный объект: обработка запроса");
        }
    }
}
