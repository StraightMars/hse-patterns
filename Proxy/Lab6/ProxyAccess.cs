using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class ProxyAccess : IAccess
    {
        private RealAccess _realAccess;

        public ProxyAccess(RealAccess realAccess)
        {
            _realAccess = realAccess;
        }

        public void Request()
        {
            if (this.CheckAccess())
            {
                this._realAccess = new RealAccess();
                this._realAccess.Request();

                this.LogAccess();
            }
        }

        public bool CheckAccess()
        {
            Console.WriteLine("Прокси: проверка доступа перед отправкой реального запроса");

            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Прокси: регистрация запроса");
        }
    }
}
