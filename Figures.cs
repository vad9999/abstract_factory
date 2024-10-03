using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    abstract class Figures
    {
        public abstract void Draw(Graphics g);
        public abstract int X { get; set; }
        public abstract int Y { get; set; }
    }
}
