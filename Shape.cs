using System.Drawing;

namespace GraphicEditor
{
    public enum ShapeType { Point, Line, Rectangle, Arc };

    public abstract class Shape
    {
        protected string name;
        protected ShapeType type;
        protected Color color;
        protected int radius;
        protected bool visible;
        protected int identityZone;
        protected int multiplicity;

        public abstract void SetMultiplicity(int k);
        public abstract bool HitTest(int x, int y);
        public abstract void Draw(Graphics graphics);
        public abstract void Shift(int deltaX, int deltaY = 0);

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public ShapeType Type
        {
            get { return type; }
        }

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Radius
        {
            get { return radius; }
            set { SetRadius(value); }
        }

        public bool Visible
        {
            get { return visible; }
            set { visible = value; }
        }

        public int IdentityZone
        {
            get { return identityZone; }
        }

        public int Multiplicity
        {
            get { return multiplicity; }
        }

        public void SetRadius(int radius)
        {
            identityZone = radius * 2;
            this.radius = radius;
        }

    }

}