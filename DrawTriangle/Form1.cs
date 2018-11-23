using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawTriangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Pen trianglePen = new Pen(Color. Red);

            DrawTriangle(trianglePen, 50, 50, 200, 150, 100, 250);
        }

        public void DrawTriangle(Pen triangle, int x1, int y1, int x2, int y2, int x3, int y3 )
        {
            Graphics g = this.CreateGraphics();

            g.DrawLine(triangle, x1, y1, x2, y2);
            g.DrawLine(triangle, x2, y2, x3, y3);
            g.DrawLine(triangle, x3, y3, x1, y1);
        }
    }
}