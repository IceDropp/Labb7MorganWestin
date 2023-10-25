using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7MorganWestin
{
    public class Parallellogram : Geometri
    {
        public double _base { get; set; }
        public double _height { get; set; }

        public Parallellogram(int basen, int height)
        {
            this._base = basen;
            this._height = height;
        }

        public override double Area()
        {
            return _base * _height;
        }
    }
}
