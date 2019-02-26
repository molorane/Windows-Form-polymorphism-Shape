using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormPorlymorphism
{
    class CRectangle:CShape
    {
        private int Length { get; set; }
        private int Width { get; set; }

        public CRectangle(int length, int width, Color colour)
        {
            this.Length = length;
            this.Width = width;
            this.colour = colour;
        }

        public override void Paint(Graphics g)
        {
            g.FillRectangle(new SolidBrush(colour), 0, 0, Length, Width);
        }

        public override double getArea()
        {
            return Length * Width;
        }

        public override string ToString()
        {
            return "Rectangle with Length " + Length.ToString() + " and Width " + Width.ToString();
        }
    }
}
