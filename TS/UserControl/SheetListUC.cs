using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TS;

namespace TS
{
    public partial class SheetListUC : UserControl
    {
        public SheetListUC()
        {
            InitializeComponent();
        }

        private void UCNext_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (!Dashboard.Instance.PnlContainer.Controls.ContainsKey("AddProduct_SheetUC"))
            {
                Dashboard.Instance.PnlContainer.Controls.Clear();
                AddProduct_SheetUC un = new AddProduct_SheetUC();
                un.Dock = DockStyle.Fill;
                Dashboard.Instance.PnlContainer.Controls.Add(un);
                
            }
            Dashboard.Instance.PnlContainer.Controls["AddProduct_SheetUC"].BringToFront();
            Dashboard.Instance.BackButton.Visible = true;

        }

        private void SheetListUC_Load(object sender, EventArgs e)
        {

        }

        private void lollipopLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSheetName.Text = string.Empty;

        }
    }
}
