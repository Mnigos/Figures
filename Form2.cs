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
    public partial class Form2 : Form
    {
        private int sideA;
        private int sideB;

        private bool isOpen = true;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            sideA = (int)numInputA.Value;
            sideB = (int)numInputB.Value;

            txtCircuit.Text = ((2 * sideA) + (2 * sideB)).ToString();
            txtField.Text = (sideA * sideB).ToString();
        }

        private void btnChangeWindow_Click(object sender, EventArgs e)
        {
            Form1 rectangle = new Form1();
            isOpen = false;

            rectangle.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isOpen) Application.Exit();
        }
    }
}
