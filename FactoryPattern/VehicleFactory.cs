using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfWheels) {
            if (numberOfWheels == 2)
            {
                Console.WriteLine("Creating motorcycle");
                return new Motorcycle();
            }
            else
            {
                Console.WriteLine("Creating Car");
                return new Car();
            }
        }
    }
}
