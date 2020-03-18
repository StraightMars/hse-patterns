using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Console.WriteLine("Пользователь: сотрудник№1 запрашивает данные сотрудника№2 (реальный объект)");
            RealAccess ra = new RealAccess();
            client.ClientCode(ra);

            Console.WriteLine("\nПользователь: сотрудник№1 запрашивает данные сотрудника№2 (прокси)");
            ProxyAccess pa = new ProxyAccess(ra);
            client.ClientCode(pa);
        }
    }
}
