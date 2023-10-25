using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7MorganWestin
{
    public class Cirkel : Geometri
    {
        public double _radius { get; set; }

        public Cirkel(int radius)
        {
            this._radius = radius;
        }

        public override double Area()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
