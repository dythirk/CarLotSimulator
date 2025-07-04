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

    }
}
