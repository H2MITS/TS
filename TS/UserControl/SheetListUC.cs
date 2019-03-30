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
using TS.Classes;
using TS.Model;
using TS.Properties;
using TS.ViewModel;

namespace TS
{
    public partial class SheetListUC : UserControl
    {
        TSEntities _entities;
        PopupMessage ppMsg;
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
            try
            {
                SheetgridBind();
            }
            catch (Exception x)
            {

            }
        }

        private void SheetgridBind()
        {
            ppMsg = new PopupMessage();
            try
            {
                int rowNo = 1;
                dgSheetMaster.AutoGenerateColumns = false;
                _entities = new TSEntities();

                List<SheetMasterVM> modelList = new List<SheetMasterVM>();

                var data = _entities.tbl_SheetMaster.OrderBy(x => x.sheetName);

                foreach (var item in data)
                {
                    SheetMasterVM model = new SheetMasterVM();
                    model.rowNo = rowNo;
                    model.sheetId = item.sheetId;
                    model.sheetName = item.sheetName;
                    
                    modelList.Add(model);

                    rowNo++;
                }
                dgSheetMaster.DataSource = modelList;

                lblTotalRows.Text = modelList.Count.ToString() + " Rows";

            }
            catch (Exception x)
            {
                ppMsg.infoMessage("Something went wrong. Contact your system administrator!");

            }

        }

        private void lollipopLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSheetName.Text = string.Empty;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dgSheetMaster_DoubleClick(object sender, EventArgs e)
        {
            ppMsg = new PopupMessage();
            try
            {
                if (dgSheetMaster.CurrentRow.Index != -1 && dgSheetMaster.CurrentRow.Cells[1].Value != null)
                {
                    var SID = Convert.ToInt32(dgSheetMaster.CurrentRow.Cells[0].Value);

                    if (!Dashboard.Instance.PnlContainer.Controls.ContainsKey("AddProduct_SheetUC"))
                    {
                        Dashboard.Instance.PnlContainer.Controls.Clear();
                        AddProduct_SheetUC un = new AddProduct_SheetUC(SID);
                        un.Dock = DockStyle.Fill;
                        Dashboard.Instance.PnlContainer.Controls.Add(un);

                    }
                    Dashboard.Instance.PnlContainer.Controls["AddProduct_SheetUC"].BringToFront();
                    Dashboard.Instance.BackButton.Visible = true;

                  
                }
            }
            catch (Exception x)
            {
                ppMsg.infoMessage("Something went wrong. Contact your system administrator!");
            }
        }
    }
}
