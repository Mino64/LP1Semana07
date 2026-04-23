using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        private byte _red;
        private byte _green;
        private byte _blue;
        private byte _alpha;
 
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            _red = red;
            _green = green;
            _blue = blue;
            _alpha = alpha;
        }
 
        public Color(byte red, byte green, byte blue)
            : this(red, green, blue, 255)
        {
        }
 
        public int Red => _red;
        public int Green => _green;
        public int Blue => _blue;
        public int Alpha => _alpha;
 
        public int GetGrey()
        {
            return (_red + _green + _blue) / 3;
        }
 /*
        public override string ToString()
        {
            return $"Color(R={_red}, G={_green}, B={_blue}, A={_alpha}, Grey={GetGrey()})";
        }*/
    }
}