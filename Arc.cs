using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicEditor
{
    internal class Arc:Shape
    {
        private int radiusArc;
        private bool clockwise;
        private bool signCurvature;
        private Point left;
        private Point right;

        public Arc(Point left, Point right, int radiusArc = 10, bool clockwise = true, bool signCurvature = false, int radius = 5)
        {
            this.left = left;
            this.right = right;
            name = $"{left.Name} {right.Name}";
            this.radius = radius;
            this.radiusArc = radiusArc;
            this.clockwise = clockwise;
            this.signCurvature = signCurvature;
            identityZone = radius * 2;
            color = Color.Black;
            type = ShapeType.Arc;
            visible = true;
            multiplicity = 1;
            this.signCurvature = signCurvature;
        }

        public Arc(string name)
        {
            left = null;
            right = null;
            radiusArc = 10;
            this.name = name;
            radius = 3;
            identityZone = radius * 2;
            color = Color.Black;
            type = ShapeType.Arc;
            visible = true;
            multiplicity = 1;
            clockwise = true;
            signCurvature = false;
        }

        public override void Shift(int deltaX, int deltaY)
        {
            left.Shift(deltaX, deltaY);
            right.Shift(deltaX, deltaY);
        }

        public override void SetMultiplicity(int k)
        {
            if (k > 0)
            {
                multiplicity++;
                multiplicity %= 3;
            }
        }

        public override bool HitTest(int x, int y)
        {
            return false;
        }

        public override void Draw(Graphics graphics)
        {
            double centerX;
            double centerY;
            double d = Math.Sqrt(Math.Pow(left.X - right.X, 2)+Math.Pow(left.Y-right.Y,2));
            double h = Math.Sqrt(Math.Pow(radiusArc, 2) - Math.Pow(d / 2, 2));

            if (signCurvature)
            {
                centerX = left.X + (right.X - left.X) / 2 + h * (right.Y - left.Y) / d;
                centerY = left.Y + (right.Y - left.Y) / 2 - h * (right.X - left.X) / d;
            }
            else
            {
                centerX = left.X + (right.X - left.X) / 2 - h * (right.Y - left.Y) / d;
                centerY = left.Y + (right.Y - left.Y) / 2 + h * (right.X - left.X) / d;
            }

            int x = (int)centerX - radiusArc;
            int y = (int)centerY + radiusArc;

            int startAngle = (int)(Math.Atan2(left.Y - y, left.X - x) * 180 / Math.PI);
            int endAngle = (int)(Math.Atan2(right.Y - y, right.X - x) * 180 / Math.PI);
            int sweepAngle =endAngle - startAngle;
            if (!clockwise)
            {
                sweepAngle *= -1;
            }

            using (Pen pen = new Pen(color, radius))
            {
                graphics.DrawArc(pen,x,y,radiusArc*2,radiusArc*2,startAngle,sweepAngle);
            }
        }

        public bool ShowMessage()
        {
            DialogResult result = MessageBox.Show($"Имя: {name}\nX1: {left.X} Y1: {left.Y}\nX2: {right.X} Y2: {right.Y}\nРадиус: {radiusArc}\nЖирность: {radius}\nЦвет: {color}\n Удалить дугу?", "Информация о дуге", MessageBoxButtons.YesNo);
            return result == DialogResult.Yes;
        }
    }
}
