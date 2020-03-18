using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.components;

namespace lab2
{
    class Director
    {
        public Report Make(Builder builder)
        {
            builder.CreateReport();
            builder.SetText();
            builder.SetDiagram();
            builder.SetGraphic();

            return builder.Report;
        }

    }
}
