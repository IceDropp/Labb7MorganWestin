using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7MorganWestin
{
    public class Fyrkant : Geometri
    {
        public double _sideLength { get; set; }

        public Fyrkant(int _sideLength)
        {
            this._sideLength = _sideLength;
        }

        public override double Area()
        {
            return _sideLength * _sideLength;
        }
    }
}
