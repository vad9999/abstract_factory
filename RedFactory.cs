using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    class RedFactory : AbstractFigures
    {
        public override Color color { get; set; } = Color.Red;
        public override Figures CreateCircle(int size, int x, int y) => new Circle(Brushes.Red, size, x, y);
        public override Figures CreateSquare(int size, int x, int y) => new Square(Brushes.Red, size, x, y);
        public override Figures CreateTriangle(int size, int x, int y) => new Triangle(Brushes.Red, size, x, y);
    }
}
