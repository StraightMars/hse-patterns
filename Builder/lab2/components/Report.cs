using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.components
{
    class Report
    {
        public Text Text { get; set; }
        public Diagram Diagram { get; set; }
        public Graphic Graphic { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Text != null)
                sb.Append("Text: " + Text.ActualText + "\n");
            if (Diagram != null)
                sb.Append("Diagram: " + Diagram.Number + "\n");
            if (Graphic != null)
                sb.Append("Graphic: " + Graphic.Number + "\n");

            return sb.ToString();
        }
    }
}
