using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.components;

namespace lab2.reports
{
    class ReportTextGraphicDiagram : Builder
    {
        public override void SetText()
        {
            this.Report.Text = new Text { ActualText = "The structure is 'text, graphic, diagram'" };
        }
        public override void SetDiagram()
        {
            this.Report.Diagram = new Diagram { Number = 2 };
        }
        public override void SetGraphic()
        {
            this.Report.Graphic = new Graphic { Number = 2 };
        }
    }
}
