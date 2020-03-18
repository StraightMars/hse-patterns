using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab3.Vidgets;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Component window = new Panel("Главная страница (панель)");

            Component header = new Panel("Хэдер (панель)");

            Component headerText = new Text_Field("Поле ввода в хэдере");
            Component headerBtn = new Button("Кнопка в хэдере");

            header.Add(headerText);
            header.Add(headerBtn);

            window.Add(header);

            Component footer = new Panel("Футер (панель)");

            Component footerText = new Text_Field("Текст в футере");
            Component footerBtn = new Button("Кнопка в футере");

            footer.Add(footerText);
            footer.Add(footerBtn);
            footer.Remove(footerText);

            window.Add(footer);

            window.Print();
        }
    }
}
