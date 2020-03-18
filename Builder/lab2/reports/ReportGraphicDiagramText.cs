using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.components;

namespace lab2.reports
{
    class ReportGraphicDiagramText : Builder
    {
        public override void SetText()
        {
            this.Report.Text = new Text { ActualText = "The structure is 'graphic, diagram, text'" };
        }
        public override void SetDiagram()
        {
            this.Report.Diagram = new Diagram { Number = 6 };
        }
        public override void SetGraphic()
        {
            this.Report.Graphic = new Graphic { Number = 6 };
        }
    }
}
