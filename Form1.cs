using System.Drawing;

namespace abstract_factory
{
    public partial class Form1 : Form
    {
        AbstractFigures factory = null;
        Figures figures = null;

        int x = 375;
        int y = 230;
        int size = 100;

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(new string[] { "Blue", "Red" });
            comboBox2.Items.AddRange(new string[] { "Circle", "Triangle", "Square" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Red":
                    factory = new RedFactory();
                    break;
                case "Blue":
                    factory = new BlueFactory();
                    break;
                default:
                    break;
            }

            switch (comboBox2.SelectedItem.ToString())
            {
                case "Circle":
                    figures = factory.CreateCircle(size, x, y);
                    break;
                case "Square":
                    figures = factory.CreateSquare(size, x, y);
                    break;
                case "Triangle":
                    figures = factory.CreateTriangle(size, x, y);
                    break;
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (figures != null)
            {
                base.OnPaint(e);
                figures.Draw(e.Graphics);
            }
        }
    }
}
