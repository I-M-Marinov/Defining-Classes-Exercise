using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Engine
    {
        public Engine(double speed, int power)
        {
            Power = power;
            Speed = speed;
        }

        public double Speed { get; set; }
        public int Power { get; set; }
    }
}
