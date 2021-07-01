using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    static class VehicleFactory
    {
        public static IVehicle CreateVehicle(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "car":
                    return new Car() { Color = "Blue", BodyType = "Sedan", IsDrivable = true };
                case "motorcycle":
                    return new Motorcycle() { Color = "Black" };
                case "big rig":
                    return new BigRig() { Color = "White", NumberOfWheels = 18 };
                default:
                    return new Car();
            }
        }
    }
}
