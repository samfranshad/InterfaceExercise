using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

        public int BedLength { get; set; }
        public bool HasTrailerHitch { get; set; }

        public int NumberOfSeatbelts { get; set; }
        public bool IsDrivable { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }

        public string CompanyName { get; set; }
        public string Slogan { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Make: {CompanyName}\nModel: {Model}\nCompany slogan: {Slogan}\nIs it drivable? {IsDrivable}\nMileage: {Mileage} miles\nSeatbelt Count: {NumberOfSeatbelts}\nBed Length: {BedLength} feet\nIs there a trailer hitch? {HasTrailerHitch}\n");
        }
    }
}
