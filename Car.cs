using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    class Car : IVehicle
    {
        public string Color { get; set; }
        public string BodyType { get; set; }
        public bool IsDrivable { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Building a {Color} {BodyType}");
        }
    }
}
