using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawTree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private double th1 = 30 * Math.PI / 180;
        private double th2 = 20 * Math.PI / 180;
        private double per1;
        private double per2;

        public Form1() {
            InitializeComponent();
        }

        private void draw_btn_Click(object sender, EventArgs e) {
            if (graphics != null) {
                graphics.Clear(SystemColors.Control);
                graphics.Dispose();
            }
            graphics = CreateGraphics();
            per1 = right_bar.Value / 100.0;
            per2 = left_bar.Value / 100.0;
            drawCayleyTree(10, 350, 460, 100, -Math.PI / 2);
        }

        private void drawCayleyTree(int n, 
            double x0, double y0, double leng, double th) {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            double x2 = (x1 - x0) * 3 / 4 + x0;
            double y2 = (y1 - y0) * 3 / 4 + y0;

            drawLine(x0, y0, x1, y1, n-1);


            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2);
        }

        private void drawLine(double x0, 
            double y0, double x1, double y1, int width) {
            graphics.DrawLine(
                new Pen(Color.Green, width),
                (int)x0, (int)y0, (int)x1, (int)y1);
        }
    }
}
