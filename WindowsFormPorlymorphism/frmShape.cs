using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormPorlymorphism
{
    public partial class frmShape : Form
    {
        private CShape shape;
        Graphics g;
        Color colour;
        public frmShape()
        {
            InitializeComponent();
            g = pnlDraw.CreateGraphics();
            colour = Color.Red;

            shape = new CRectangle(50, 50, Color.Red);
            shape.Paint(g);
        }

        private void changed(object sender, EventArgs e)
        {
            pnlDraw.BackColor = Color.White;
            g.Clear(Color.Wheat);

            if(sender == this.btnColor)
            {
                if(colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colour = colorDialog.Color;
                }
            }

            if (rdCircle.Checked)
            {
                nud2.Visible = lblDim2.Visible = false;
                lblDim1.Text = "Radius";
                shape = new CCircle((int)nud1.Value, colour);
            }
            if (rdRectangle.Checked)
            {
                nud2.Visible = lblDim2.Visible = true;
                lblDim1.Text = "Length";
                lblDim2.Text = "Width";
                shape = new CRectangle((int)nud1.Value, (int)nud2.Value, colour);
            }
            if (rdTriangle.Checked)
            {
                nud2.Visible = lblDim2.Visible = true;
                lblDim1.Text = "Base";
                lblDim2.Text = "Height";
                shape = new CTriangle((int)nud1.Value, (int)nud2.Value, colour);
            }

            shape.Paint(g);
            lblInfo.Text = shape.ToString();
            lblArea.Text = "Area: "+ shape.getArea().ToString("F2");
        }
    }
}
