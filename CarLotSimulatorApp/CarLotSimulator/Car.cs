using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() { }

        public string Make;
        public string Model;
        public int Year;
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        public void MakeEngineNoise (string engineNoise)
        {
            EngineNoise = engineNoise;
            Console.WriteLine($"{Make} {Model} has an engine noise that sounds like {EngineNoise}.");
        }
        public void MakeHonkNoise(string honkNoise)
        {
            HonkNoise = honkNoise;
            Console.WriteLine($"{Make} {Model} has a honk noise that sounds like {HonkNoise}.");
        }



        public Car(string make, string model, int year, bool isDriveable)
        {
            Make = make;
            Model = model;
            Year = year;
            IsDriveable = isDriveable;

        }

    }
}
