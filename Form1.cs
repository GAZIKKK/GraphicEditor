﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicEditor
{
    public partial class Form1 : Form
    {
        private Point clickedPoint1;
        private Point clickedPoint2;
        private Line newLine;
        private Rectangle newRectangle;
        private int countPoint = 0;
        private int countLine = 0;
        private int countRectangle = 0;
        private const int COLUMNS_COUNT = 2;
        private int radius=5;
        private Color color = Color.Black;
        private LinkedList<Point> points = new LinkedList<Point>();
        private LinkedList<Line> lines = new LinkedList<Line>();
        private LinkedList<Rectangle> rectangle = new LinkedList<Rectangle>();
        private int countRowsPoint = 0;
        private ShapeType type = ShapeType.Point;
        int alpha = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void GraphiсPanel_MouseDown(object sender, MouseEventArgs e)
        {
            switch (type)
            {
                case ShapeType.Point:
                    DrawPoint(e);
                    break;
                case ShapeType.Line:
                    DrawLine(e); 
                    break;
                case ShapeType.Rectangle:
                    DrawRectangle(e);
                    break;
            }
        }
        
        private void DrawRectangle(MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                clickedPoint1 = new Point($"A{countLine}", e.Location.X, e.Location.Y, radius);
            }
            else if(e.Button == MouseButtons.Right)
            {
                if(rectangle.InIdentityZone((p, x, y) => p.HitTest(x, y), e.Location.X, e.Location.Y))
                {
                    var pointHitter = rectangle.GetItem((item, x, y) => item.HitTest(x, y), e.Location.X, e.Location.Y);
                    if (pointHitter.ShowMessage())
                    {
                        rectangle.Remove(pointHitter);
                        update(GraphicPanel.CreateGraphics());
                    }
                }
            }
        }

        private void DrawLine(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                clickedPoint1 = new Point($"A{countLine}", e.Location.X, e.Location.Y, radius);
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (lines.InIdentityZone((p, x, y) => p.HitTest(x, y), e.Location.X, e.Location.Y))
                {
                    var pointHitter = lines.GetItem((item, x, y) => item.HitTest(x, y), e.Location.X, e.Location.Y);
                    if (pointHitter.ShowMessage())
                    {
                        lines.Remove(pointHitter);
                        update(GraphicPanel.CreateGraphics());
                    }
                }
            }
        }

        private void DrawPoint(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (points.InIdentityZone((p, x, y) => p.HitTest(x, y), e.Location.X, e.Location.Y))
                {
                    DialogResult result = MessageBox.Show("Построить новую точку?", "Попадание в зону идентичности", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        AddPoint(e);
                    }
                }
                else
                {
                    AddPoint(e);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (points.InIdentityZone((p, x, y) => p.HitTest(x, y), e.Location.X, e.Location.Y))
                {
                    var pointHitter = points.GetItem((item, x, y) => item.HitTest(x, y), e.Location.X, e.Location.Y);
                    if (pointHitter.ShowMessage())
                    {
                        points.Remove(pointHitter);
                        update(GraphicPanel.CreateGraphics());
                    }
                }
            }
        }

        private void GraphicPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if(type == ShapeType.Line)
            {
                if (e.Button == MouseButtons.Left)
                {
                    clickedPoint2 = new Point($"B{countLine}", e.Location.X, e.Location.Y, radius);
                    newLine = new Line(clickedPoint1, clickedPoint2,$"AB{countLine}",radius);
                    newLine.Color = color;
                    Graphics g = GraphicPanel.CreateGraphics();
                    newLine.Draw(g);
                    lines.Add(newLine);
                    countLine++;
                    clickedPoint1 = new Point("A");
                    clickedPoint2 = new Point("B");
                }
            }
            else if(type == ShapeType.Rectangle)
            {
                if (e.Button == MouseButtons.Left)
                {
                    clickedPoint2 = new Point($"B{countLine}", e.Location.X, e.Location.Y, radius);
                    newRectangle = new Rectangle(clickedPoint1, clickedPoint2, $"AB{countRectangle}", radius, alpha);
                    newRectangle.Color = color;
                    Graphics g = GraphicPanel.CreateGraphics();
                    newRectangle.Draw(g);
                    rectangle.Add(newRectangle);
                    countRectangle++;
                    clickedPoint1 = new Point("A");
                    clickedPoint2 = new Point("B");
                }
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            TablePoints.RowHeadersWidth = TablePoints.Size.Width / COLUMNS_COUNT;
        }

        private void ChooseСolor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
        }

        private void textRadius_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(textRadius.Text.ToString(),out radius))
            {
                radius = int.Parse(textRadius.Text.ToString());
            }
        }

        private void textAlpha_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textAlpha.Text.ToString(), out alpha))
            {
                alpha = int.Parse(textAlpha.Text.ToString());
            }
        }

        private void update(Graphics g)
        {
            g.Clear(Color.White);
            lines.DrawItems(g, TablePoints);
            rectangle.DrawItems(g, TablePoints);
            countRowsPoint = points.DrawItems(g, TablePoints);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            points = new LinkedList<Point>();
            lines = new LinkedList<Line>();
            rectangle = new LinkedList<Rectangle>();
            using (Graphics g = GraphicPanel.CreateGraphics())
            {
                g.Clear(Color.White);
                TablePoints.Rows.Clear();
                countRowsPoint = 0;
                countPoint = 0;
                countLine = 0;
                countRectangle = 0;
            }   
        }

        private void LineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = ShapeType.Line;
            typeLabel.Text ="Тип: Линия";
        }

        private void PointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = ShapeType.Point;
            typeLabel.Text = "Тип: Точка";
        }

        private void RectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = ShapeType.Rectangle;
            typeLabel.Text = "Тип: Прямоугольник";
        }

        private void AddPoint(MouseEventArgs e)
        {
            clickedPoint1 = new Point($"A{countPoint}", e.Location.X, e.Location.Y, radius);
            clickedPoint1.Color = color;
            TablePoints.Rows.Add();
            TablePoints.Rows[countRowsPoint].Cells[0].Value = clickedPoint1.X;
            TablePoints.Rows[countRowsPoint].Cells[1].Value = clickedPoint1.Y;
            TablePoints.Rows[countRowsPoint].HeaderCell.Value = $"A{countPoint++}";
            countRowsPoint++;
            Graphics g = GraphicPanel.CreateGraphics();
            clickedPoint1.Draw(g);
            points.Add(clickedPoint1);
        }
    }
}