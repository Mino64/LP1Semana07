using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PowerCell
{
    public class Cell
    {
        private float charge;
        public string Name { get; }

        public float Charge
        {
            get
            {
                if(charge < 0 )
                return 0;
                else if(charge > 200)
                return 200;
                else return charge;
            }

        }

        public int Level
        {
            get
            {
                return 1 + (int)Charge / 40;
            }
        }

        public Cell(string name)
        {
            Name = name;
            charge = 200;
        }

        public void Consume(float amount)
        {
            charge -= amount;
        }
        public void Restore()
        {
            charge = 200;
        }

        public override string ToString()
        {
            return $"[{Name}] Level {Level}: {Charge:F0}/200";
        }
    }
}