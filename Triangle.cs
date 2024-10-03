using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    class Triangle : Figures
    {
        public Size Size { get; set; }
        public override int X { get; set; }
        public override int Y { get; set; }
        private Brush _brush;

        public Triangle(Brush brush, int size, int x, int y)
        {
            _brush = brush;
            Size = new Size(size, size); // Для простоты равносторонний треугольник
            X = x;
            Y = y;
        }

        public override void Draw(Graphics g)
        {
            Point[] points = {
            new Point(X + Size.Width / 2, Y),
            new Point(X + Size.Width, Y + Size.Height),
            new Point(X, Y + Size.Height)
            };

            g.FillPolygon(_brush, points);
        }
    }
}
