using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GraphicEditor
{
    internal class Rectangle:Shape
    {
        private int angle;
        private Point left;
        private Point right;
        public Rectangle(Point left, Point right, int radius = 3, int angle = 0)
        {
            this.left = left;
            this.right = right;
            this.angle = angle;
            name = $"{left.Name} {right.Name}";
            this.radius = radius;
            identityZone = radius * 2;
            color = Color.Black;
            type = ShapeType.Rectangle;
            visible = true;
            multiplicity = 1;
        }

        public Rectangle(string name)
        {
            left = null;
            right = null;
            angle = 0;
            this.name = name;
            radius = 3;
            identityZone = radius * 2;
            color = Color.Black;
            type = ShapeType.Rectangle;
            visible = true;
            multiplicity = 1;
        }

        public override void Shift(int deltaX,int deltaY)
        {
            left.Shift(deltaX,deltaY);
            right.Shift(deltaX,deltaY);
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
            Pen pen = new Pen(color, radius);

            float centerX = (left.X + right.X) / 2;
            float centerY = (left.Y + right.Y) / 2;

            float width = Math.Abs(right.X - left.X);
            float height = Math.Abs(right.Y - left.Y);

            double radians = angle * Math.PI / 180;

            Matrix rotationMatrix = new Matrix();
            rotationMatrix.RotateAt(angle, new PointF(centerX, centerY));
            graphics.Transform = rotationMatrix;

            graphics.DrawRectangle(pen, centerX - width / 2, centerY - height / 2, width, height);

            rotationMatrix.RotateAt(-angle, new PointF(centerX, centerY));
            graphics.Transform = rotationMatrix;
        }

        public bool ShowMessage()
        {
            DialogResult result = MessageBox.Show($"Имя: {name}\nX1: {left.X} Y1: {left.Y}\nX2: {right.X} Y2: {right.Y}\nУгол: {angle}\nЖирность: {radius}\nЦвет: {color}\n Удалить прямоугольник?", "Информация о прямоугольнике", MessageBoxButtons.YesNo);
            return result == DialogResult.Yes;
        }
    }
}
