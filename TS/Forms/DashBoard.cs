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
    public partial class Dashboard : Form
    {
        static Dashboard _obj;

        public static Dashboard Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Dashboard();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public Button BackButton
        {
            get { return btnBack; }
            set { btnBack = value; }
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            _obj = this;
 
            SheetListUC uc = new SheetListUC();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //panelContainer.Controls["ProductMaster"].BringToFront();
            //btnBack.Visible = false;
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            panel3.Height = button4.Height;
            panel3.Top = button4.Top ;

            panel4.Height = button4.Height;
            panel4.Top = button4.Top;

            ProductMasterUC uc = new ProductMasterUC();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
            Dashboard.Instance.PnlContainer.Controls["ProductMasterUC"].BringToFront();
            uc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;

            SheetListUC uc = new SheetListUC();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
            Dashboard.Instance.PnlContainer.Controls["SheetListUC"].BringToFront();
            uc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //panel3.Height = button6.Height;
            //panel3.Top = button6.Top;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
