using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lollipopLabel3_Click(object sender, EventArgs e)
        {

        }

        private void lollipopFlatButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product Name : " + txtPname.Text + " - Qty: " + txtQty.Text + "- Weight: " + txtWeight.Text);
        }

        private void lollipopFlatButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fuck Off");
        }

        private void lollipopButton1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Product Name : " + txtPname.Text + " - Qty: " + txtQty.Text + "- Weight: " + txtWeight.Text);
        }
    }
}
