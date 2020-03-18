using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public interface ITeacher
    {
        void Attach(IStudent student);

        void Detach(IStudent student);

        void Notify();
    }
}
