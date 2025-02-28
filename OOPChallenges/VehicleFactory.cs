using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{ 
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string type)
        {
            if (type.ToLower() == "car") 
                return new Car1();
            else if (type.ToLower() == "bike") 
                return new Bike1();
            else 
                throw new ArgumentException("Invalid vehicle type");
        }
    }

}
