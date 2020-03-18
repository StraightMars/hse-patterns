using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Client
    {
        public void ClientCode(IAccess access)
        {
            access.Request();
        }
    }
}
