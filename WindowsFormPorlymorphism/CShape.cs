using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormPorlymorphism
{
    abstract class CShape
    {
        protected Color colour { get; set; }

        abstract public double getArea();

        abstract public void Paint(Graphics g);

        public override string ToString()
        {
            return "Shape";
        }
    }
}
