using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicEditor
{
    public class Point : Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point(string name, int x = 0, int y = 0, int radius = 3)
        {
            name = name ?? throw new ArgumentNullException(nameof(name));
            X = x;
            Y = y;
            this.name = name;
            this.radius = radius;
            identityZone = radius * 2;
            color = Color.Black;
            type = ShapeType.Point;
            visible = true;
            multiplicity = 1;
        }

        public Point(Point point, string name, int radius) : this(name, point.X, point.Y, radius)
        {
        }

        public override void SetMultiplicity(int k)
        {
            if (k > 0)
            {
                multiplicity++;
            }
            else
            {
                multiplicity--;
            }
        }

        public override void Draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(color), X - radius, Y - radius, radius * 2, radius * 2);
        }

        public override void Shift(int deltaX, int deltaY = 0)
        {
            X += deltaX;
            Y += deltaY;
        }

        public override bool HitTest(int x, int y)
        {
            double distance = Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
            return distance < identityZone;
        }

        public bool ShowMessage()
        {
            DialogResult result = MessageBox.Show($"Имя: {name}\nX: {X}\nY: {Y}\nРадиус: {radius}\nЦвет: {color}\nУдалить точку?", "Информация о точке", MessageBoxButtons.YesNo);
            return result == DialogResult.Yes;
        }
    }
}
