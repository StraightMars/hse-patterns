using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Panel : Component
    {
        private List<Component> components = new List<Component>();

        public Panel (string name) : base(name)
        { }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine("Панель: " + name);
            Console.WriteLine("Элементы панели: ");
            foreach (Component elem in components)
                elem.Print();
            Console.WriteLine("\n");
        }

    }
}
