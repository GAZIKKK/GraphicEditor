using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicEditor
{
    public class Line : Shape
    {
        protected Point left;
        protected Point right;

        public Line(Point left, Point right, int radius = 3)
        {
            this.left = left;
            this.right = right;
            name = $"{left.Name} {right.Name}";
            this.radius = radius;
            identityZone = radius * 2;
            color = Color.Black;
            type = ShapeType.Line;
            visible = true;
            multiplicity = 1;
        }

        public Line(string name)
        {
            left = null;
            right = null;
            this.name = name;
            radius = 3;
            identityZone = radius * 2;
            color = Color.Black;
            type = ShapeType.Line;
            visible = true;
            multiplicity = 1;
        }

        public override void SetMultiplicity(int k)
        {
            if (k > 0)
            {
                multiplicity++;
                multiplicity %= 3;
            }
        }

        public override void Shift(int deltaX, int deltaY = 0)
        {
            left.Shift(deltaX, deltaY);
            right.Shift(deltaX, deltaY);
        }

        public override bool HitTest(int x, int y)
        {
            double distance;
            if (left.X == right.X)
            {
                distance = Math.Abs(x - left.X);
                if (distance <= identityZone)
                {
                    return true;
                }
                return false;
            }

            double k = (right.Y - left.Y) / (right.X - left.X);
            double b = left.Y - k * left.X;
            distance = Math.Abs(k * x - y + b) / Math.Sqrt(k * k + 1);
            if (distance <= identityZone)
            {
                return true;
            }
            return false;
        }


        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(color, radius);
            g.DrawLine(pen, left.X, left.Y, right.X, right.Y);
        }

        public bool ShowMessage()
        {
            DialogResult result = MessageBox.Show($"Имя: {name}\nX1: {left.X} Y1: {left.Y}\nX2: {right.X} Y2: {right.Y}\nЖирность: {radius}\nЦвет: {color}\n Удалить линию?", "Информация о линии", MessageBoxButtons.YesNo);
            return result == DialogResult.Yes;
        }
    }
}
