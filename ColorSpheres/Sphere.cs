using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private Color _color;
        private double _radius;
        private int _timesThrown;

        public Sphere(Color color, double radius)
        {
            _color = color;
            _radius = radius;
            _timesThrown = 0;
        }

        public void Pop()
        {
            _radius = 0;
        }

        public void Throw()
        {
            if (_radius > 0)
            {
                _timesThrown++;
            }
        }

        public int GetTimesThrown()
        {
            return _timesThrown;
        }

        /*public override string ToString()
        {
            string status = _radius > 0 ? $"radius={_radius}" : "POPPED";
            return $"Sphere({status}, thrown={_timesThrown}, {_color})";
        }*/
    }
}