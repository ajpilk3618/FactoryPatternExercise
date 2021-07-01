using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of vehicle do you want to make? car, motorcycle, or big rig");
            string userInput = Console.ReadLine();

            IVehicle myVehicle = VehicleFactory.CreateVehicle(userInput);

            myVehicle.Drive();
            Console.ReadLine();

        }
    }
}
