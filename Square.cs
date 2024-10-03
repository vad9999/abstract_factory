using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    class Square : Figures
    {
        public Size Size { get; set; }
        public override int X { get; set; }
        public override int Y { get; set; }
        private Brush _brush;

        public Square(Brush brush, int size, int x, int y)
        {
            _brush = brush;
            Size = new Size(size, size); // Квадрат тоже имеет одинаковую ширину и высоту
            X = x;
            Y = y;
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(_brush, X, Y, Size.Width, Size.Height);
        }
    }
}
