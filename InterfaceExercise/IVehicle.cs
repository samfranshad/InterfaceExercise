using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
        */

        public int NumberOfSeatbelts { get; set; }
        public bool IsDrivable { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }


        public void DisplayDetails();


    }
}
