using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLive
{
    //subklass Dog som ärver från animal
     public class Dog : Animal
     {
        public Dog(string name) : base(name) { }

        public override void Speak()
        {
            Console.WriteLine($"{Name} Säger : Woof Woof!");
        }
    }
}
