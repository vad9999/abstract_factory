using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    abstract class AbstractFigures
    {
        public abstract Color color { get; set; }
        public abstract Figures CreateCircle(int size, int x, int y);
        public abstract Figures CreateSquare(int size, int x, int y);
        public abstract Figures CreateTriangle(int size, int x, int y);
    }
}
