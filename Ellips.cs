using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7MorganWestin
{
    public class Ellips : Geometri
    {
        public double _semiMajorAxis { get; set; }
        public double _semiMinorAxis { get; set; }

        public Ellips(int semiMajorAxis, int semiMinorAxis)
        {
            this._semiMajorAxis = semiMajorAxis;
            this._semiMinorAxis = semiMinorAxis;
        }

        public override double Area()
        {
            return Math.PI * _semiMajorAxis * _semiMinorAxis;
        }
    }
}
