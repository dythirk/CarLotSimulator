using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Carlot
    {
        public static int _numberOfCars = 0;
        public List<Car> ParkingLot { get; set; } = new List<Car>();
        public void CheckCars()
        {
            foreach (var vehicle in ParkingLot)
            {
                Console.WriteLine($"Vehicle is a {vehicle.Year} {vehicle.Make} {vehicle.Model}.");
            }

        }
    }
}
