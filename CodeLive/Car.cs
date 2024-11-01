using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLive
{
    public class Car : IMovable
    {
        public string Brand { get; set; }

        public Car(string brand)
        {
            Brand = brand;
        }

        // Implementera Move-metoden från IMovable
        public void Move()
        {
            Console.WriteLine($"{Brand} Bilen kör framåt.");
        }
    }
}
