using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.components;
using lab2.reports;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            //вид отчета 1: текст, диаграмма, график
            Builder builder = new ReportTextDiagramGraphic();
            Report first = director.Make(builder);
            Console.WriteLine(first.ToString() + "\n\n");

            //вид отчета 2: текст, график, диаграмма
            builder = new ReportTextGraphicDiagram();
            Report second = director.Make(builder);
            Console.WriteLine(second.ToString() + "\n\n");

            //вид отчета 3: диаграмма, текст, график
            builder = new ReportDiagramTextGraphic();
            Report third = director.Make(builder);
            Console.WriteLine(third.ToString() + "\n\n");

            //вид отчета 4: диаграмма, график, текст
            builder = new ReportDiagramGraphicText();
            Report fourth = director.Make(builder);
            Console.WriteLine(fourth.ToString() + "\n\n");

            //вид отчета 5: график, текст, диаграмма
            builder = new ReportGraphicTextDiagram();
            Report fifth = director.Make(builder);
            Console.WriteLine(fifth.ToString() + "\n\n");

            //вид отчета 6: график, диаграмма, текст
            builder = new ReportGraphicDiagramText();
            Report sixth = director.Make(builder);
            Console.WriteLine(sixth.ToString() + "\n\n");
        }
    }
}
