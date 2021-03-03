using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    public partial class Form1 : Form
    {
        private int radius;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnChangeWindow_Click(object sender, EventArgs e)
        {
            Form2 rectangle = new Form2();

            rectangle.Show();
            this.Hide();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            radius = (int)numInput.Value;

            txtCircuit.Text = (2 * Math.PI * radius).ToString();
            txtField.Text = (Math.PI * Math.Sqrt(radius)).ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
