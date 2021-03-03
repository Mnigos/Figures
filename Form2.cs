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
    }
}
