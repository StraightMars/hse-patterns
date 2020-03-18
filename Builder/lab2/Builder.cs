using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.components;

namespace lab2
{
    abstract class Builder
    {
        public Report Report { get; private set; }
        public void CreateReport()
        {
            Report = new Report();
        }

        public abstract void SetText();
        public abstract void SetDiagram();
        public abstract void SetGraphic();
    }
}
