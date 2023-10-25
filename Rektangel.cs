using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7MorganWestin
{
    public class Rektangel : Geometri
    {
        public double _length { get; set; }              // etablerar en dubble som heter length
        public double _width { get; set; }

        public Rektangel(int lenght, int width)
        {
            this._length = lenght;                                 // sätter värde på längden
            this._width = width;
        }

        public override double Area()
        {
            return _length * _width;          // längd * bredd returneras
        }
    }
}
