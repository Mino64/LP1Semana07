using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerCell
{
    public class Cell
    {
        private float charge;

        private Random rnd;

        public string Name{get;}

        public float Charge
        {
            get
            {
                return rnd.Next(0,201);
            }

        }

        public int Level
        {
            get
            {
                return 1 + (int)Charge/40;
            }
        }

        public Cell (string name)
        {
            Name = name;
            charge = 200;
        }

        public void Consume (float amount)
        {
            charge -= amount;
        }
        public void Restore()
        {
            charge = 200;
        }
    }
}