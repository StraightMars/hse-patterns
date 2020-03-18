using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab9
{
    class Teacher : ITeacher
    {
        public string State { get; set; } = "";

        private List<IStudent> students = new List<IStudent>();

        public void Attach(IStudent student)
        {
            Console.WriteLine("Teacher (Subject): attached a student (observer)");
            this.students.Add(student);
        }

        public void Detach(IStudent student)
        {
            if (this.students.Contains(student))
            {
                this.students.Remove(student);
                Console.WriteLine("Teacher (Subject): detached a student (observer)");
            }  
        }

        public void Notify()
        {
            Console.WriteLine("Teacher (Subject): notifying students (observers)");

            foreach (var student in students)
                student.Update(this);
        }

        public void Action(string text)
        {
            Console.WriteLine("Teacher (Subject): Checking your hometasks... Wait 2 seconds.");
            this.State = text;

            Thread.Sleep(2000);

            Console.WriteLine("Teacher (Subject): " + this.State);
            this.Notify();
        }
    }
}
