using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormPorlymorphism
{
    class CTriangle:CShape
    {
        private int Base { get; set; }
        private int Height { get; set; }


        public CTriangle(int Base, int Height, Color colour)
        {
            this.Base = Base;
            this.Height = Height;
            this.colour = colour;
        }

        public override void Paint(Graphics g)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, 0);
            points[1] = new Point(0, Height);
            points[2] = new Point(Base, Height);

            g.FillPolygon(new SolidBrush(colour), points);
        }

        public override double getArea()
        {
            return (Base * Height) / 2;
        }

        public override string ToString()
        {
            return "Triangle with Base " + Base.ToString() + " and Height "+Height.ToString();
        }
    }
}
