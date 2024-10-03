using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    class BlueFactory : AbstractFigures
    {
        public override Color color { get; set; } = Color.Blue;
        public override Figures CreateCircle(int size, int x, int y) => new Circle(Brushes.Blue, size, x, y);
        public override Figures CreateSquare(int size, int x, int y) => new Square(Brushes.Blue, size, x, y);
        public override Figures CreateTriangle(int size, int x, int y) => new Triangle(Brushes.Blue, size, x, y);
    }
}
