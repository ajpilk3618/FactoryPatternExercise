using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    class BigRig : IVehicle
    {

        public string Color { get; set; }
        public int NumberOfWheels { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Building a {Color} Big Rig with {NumberOfWheels} wheels");
        }
    }
}
