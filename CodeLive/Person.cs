using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLive
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //konstruktor för att initiera egenskaperna
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void VisaInfo()
        {
            Console.WriteLine($"Namn: {Name}, Ålder: {Age}");
        }
    }
}
