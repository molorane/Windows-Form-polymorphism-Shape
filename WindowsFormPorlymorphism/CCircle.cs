using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormPorlymorphism
{
    class CCircle : CShape
    {
        private int Radius { get; set; }

        public CCircle(int Radius,Color colour)
        {
            this.colour = colour;
            this.Radius = Radius;
        }

        public override void Paint(Graphics g)
        {
            g.FillEllipse(new SolidBrush(colour), 0, 0, (int)(2 * Radius), (int)(2 * Radius));
        }

        public override double getArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return "Circle with radius "+ Radius.ToString();
        }
    }
}
