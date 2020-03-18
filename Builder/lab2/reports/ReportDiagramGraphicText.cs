﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.components;

namespace lab2.reports
{
    class ReportDiagramGraphicText : Builder
    {
        public override void SetText()
        {
            this.Report.Text = new Text { ActualText = "The structure is 'diagram, graphic, text'" };
        }
        public override void SetDiagram()
        {
            this.Report.Diagram = new Diagram { Number = 4 };
        }
        public override void SetGraphic()
        {
            this.Report.Graphic = new Graphic { Number = 4 };
        }
    }
}
