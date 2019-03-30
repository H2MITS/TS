using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TS
{
    public partial class AddProduct_SheetUC : UserControl
    {
        public AddProduct_SheetUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(!Dashboard.Instance.PnlContainer.Controls.ContainsKey("UCNext"))
            //{
            //    UCNext un = new UCNext();
            //    un.Dock = DockStyle.Fill;
            //    Dashboard.Instance.PnlContainer.Controls.Add(un);
            //}
            //Dashboard.Instance.PnlContainer.Controls["UCNext"].BringToFront();
            //Dashboard.Instance.BackButton.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void clear()
        {
            txtpName.Text = string.Empty;
            txtQtyWeight.Text = string.Empty;
            txtRate.Text = string.Empty;

        }



        private void btnBack_Click(object sender, EventArgs e)
        {

        }


        private void AddProduct_SheetUC_Load(object sender, EventArgs e)
        {
            txtSheetName.Focus();
            //txtPname.Font = new Font("Arial", 50, FontStyle.Bold);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lollipopButton1_Click_1(object sender, EventArgs e)
        {
            if (!Dashboard.Instance.PnlContainer.Controls.ContainsKey("SheetListUC"))
            {
                SheetListUC un = new SheetListUC();
                un.Dock = DockStyle.Fill;
                Dashboard.Instance.PnlContainer.Controls.Add(un);
            }
            Dashboard.Instance.PnlContainer.Controls["SheetListUC"].BringToFront();
            Dashboard.Instance.BackButton.Visible = false;

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtSheetName.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtSheetName, "Enter Sheet Name.");
                    txtSheetName.Focus();
                    panel9.Visible = true;
                    lblError.Text = "Enter Sheet Name.";
                }
                else if (txtRate.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtRate, "Enter Rate.");
                    txtRate.Focus();
                    panel9.Visible = true;
                    lblError.Text = "Enter Rate.";
                }
                else if (txtProfitMargin.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtProfitMargin, "Enter Profit Margin.");
                    txtProfitMargin.Focus();
                    panel9.Visible = true;
                    lblError.Text = "Enter Profit Margin.";
                }
                //else if (txtTaxRate.Text == string.Empty)
                //{
                //    errorProvider1.Clear();
                //    errorProvider1.SetError(txtTaxRate, "Enter Tax Amt.");
                //    txtTaxRate.Focus();
                //    panel9.Visible = true;
                //    lblError.Text = "Enter Tax Amt.";
                //}
                //else if (txtTotalAmount.Text == string.Empty)
                //{
                //    errorProvider1.Clear();
                //    errorProvider1.SetError(txtTotalAmount, "Enter Total Amount.");
                //    txtTotalAmount.Focus();
                //    panel9.Visible = true;
                //    lblError.Text = "Enter Total Amount.";
                //}
                else
                {
                    if (btnSubmit.Text == "Submit")
                    {
                        // Save Code
                    }
                    else
                    {
                        //Update Code
                    }
                }
            }
            catch (Exception x)
            {

            }
        }

        private void txtRate_Leave(object sender, EventArgs e)
        {
            if (txtpName.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtpName, "Enter Product Name.");
                txtpName.Focus();
                panel9.Visible = true;
                lblError.Text = "Enter Product Name.";
            }
            else if (txtQtyWeight.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtQtyWeight, "Enter Qty or Weight.");
                txtQtyWeight.Focus();
                panel9.Visible = true;
                lblError.Text = "Enter Qty or Weight.";
            }
            else if (txtRate.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtRate, "Enter Rate.");
                txtRate.Focus();
                panel9.Visible = true;
                lblError.Text = "Enter Rate.";
            } 
            else
            {
                // save - update code
            }
        }
    }
}
