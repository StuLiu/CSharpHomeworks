using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topic5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(this.textBox1.Text);
            double num2 = Convert.ToDouble(this.textBox2.Text);
            this.textBox3.Text = Convert.ToString(num1 * num2);
        }
    }
}
