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
using TS.Model;
using Tulpep.NotificationWindow;
using TS.Classes;
using TS.ViewModel;

namespace TS
{
    public partial class ProductMasterUC : UserControl
    {
        TSEntities _entities;
        private long ProductId;
        PopupMessage ppMessage;
        public ProductMasterUC()
        {
            InitializeComponent();

        }
        private void ProductMasterUC_Load(object sender, EventArgs e)
        {
            txtpName.Focus();
            //txtPname.Font = new Font("Arial", 50, FontStyle.Bold);
            gridBind();
            productNameAutoComplete();

            
             
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ppMessage = new PopupMessage();

            try
            {
                if (txtpName.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtpName, "Enter Product Name.");
                    txtpName.Focus();
                    panel4.Visible = true;
                    lblError.Text = "Enter Product Name.";
                }
                else if (txtRate.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtRate, "Enter Rate.");
                    txtRate.Focus();
                    panel4.Visible = true;
                    lblError.Text = "Enter Rate.";
                }
                else
                {
                    if (btnSubmit.Text == "Submit")
                    {
                        //Save No Code 
                        _entities = new TSEntities();
                        tbl_ProductMaster pm = new tbl_ProductMaster();
                        pm.p_Name = txtpName.Text.Trim().ToString();
                        pm.rate = Convert.ToDecimal(txtRate.Text.Trim());

                        _entities.tbl_ProductMaster.Add(pm);
                        _entities.SaveChanges();


                        //Notification

                        ppMessage.successMessage();

                    }
                    else
                    {
                        // Update No Code
                        _entities = new TSEntities();

                        var data = _entities.tbl_ProductMaster.Where(x => x.id == ProductId).FirstOrDefault();

                        data.p_Name = txtpName.Text.Trim().ToString();
                        data.rate = Convert.ToDecimal(txtRate.Text.Trim());
                        _entities.SaveChanges();

                        ppMessage.updateMessage();

                    }

                    // Clear Function Call
                    clear();

                }
            }
            catch (Exception x)
            {
                ppMessage.infoMessage("Something went wrong. Contact your system administrator!");
            }
        }

        private void clear()
        {
            txtpName.Text = string.Empty;
            txtRate.Text = string.Empty;
            btnSubmit.Text = "Submit";
            gridBind();
        }

        private void gridBind()
        {
            try
            {
                int rowNo = 1;
                dgProductMaster.AutoGenerateColumns = false;
                _entities = new TSEntities();

                List<ProductMasterVM> modelList = new List<ProductMasterVM>();

                var data = _entities.tbl_ProductMaster.OrderBy(x => x.p_Name);

                foreach (var item in data)
                {
                    ProductMasterVM model = new ProductMasterVM();
                    model.rowNo = rowNo;
                    model.id = item.id;
                    model.p_Name = item.p_Name;
                    model.rate = item.rate + " /-";

                    modelList.Add(model);

                    rowNo++;
                }
                dgProductMaster.DataSource = modelList;

                lblTotalRows.Text = modelList.Count.ToString() + " Rows";

            }
            catch (Exception x)
            {
                ppMessage.infoMessage("Something went wrong. Contact your system administrator!");

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void lollipopButton2_Click(object sender, EventArgs e)
        {
            //Print Call
        }

        private void dgProductMaster_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ProductId = 0;
                if (dgProductMaster.CurrentRow.Index != -1 && dgProductMaster.CurrentRow.Cells[1].Value != null)
                {
                    var lID = Convert.ToInt32(dgProductMaster.CurrentRow.Cells[0].Value);

                    _entities = new TSEntities();
                    var data = _entities.tbl_ProductMaster.Where(x => x.id == lID).FirstOrDefault();

                    //clear();
                    txtpName.Text = data.p_Name;
                    txtRate.Text = data.rate.ToString();
                    ProductId = data.id;


                    btnSubmit.Text = "Update";
                }
            }
            catch (Exception x)
            {
                ppMessage.infoMessage("Something went wrong. Contact your system administrator!");

            }
        }

        private void dgProductMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ppMessage = new PopupMessage();
            try
            {
                if (dgProductMaster.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult myResult;

                    myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        _entities = new TSEntities();

                        var cellId = Convert.ToInt32(dgProductMaster.CurrentRow.Cells[0].Value);

                        var selectedData1 = _entities.tbl_ProductMaster.Where(x => x.id == cellId).FirstOrDefault();

                        if (selectedData1 != null)
                        {
                            _entities.tbl_ProductMaster.Remove(selectedData1);
                        }
                        else
                        {
                            // MessageBox.Show("Something went wrong. Record cannot be deleted.");

                            ppMessage.infoMessage("Something went wrong. Record cannot be deleted.");
                        }

                        _entities.SaveChanges();

                        ppMessage.deleteMessage();
                        //MessageBox.Show("Record deleted ");
                        gridBind();
                    }

                }
            }
            catch (Exception x)
            {
                ppMessage.infoMessage("Something went wrong. Contact your system administrator!");

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int rowNo = 1;

                dgProductMaster.AutoGenerateColumns = false;
                _entities = new TSEntities();

                List<ProductMasterVM> productMasterListVM = new List<ProductMasterVM>();

                List<tbl_ProductMaster> data;

                if (txtpName.Text == "")
                {
                    data = _entities.tbl_ProductMaster.ToList();
                }
                else
                {
                    data = _entities.tbl_ProductMaster.Where(x => x.p_Name.Contains(txtpName.Text.Trim().ToString())).ToList();

                }

                foreach (var item in data)
                {
                    ProductMasterVM list = new ProductMasterVM();
                    list.rowNo = rowNo;
                    list.id = item.id;
                    list.p_Name = item.p_Name;

                    list.rate = item.rate.ToString() + " /-";

                    productMasterListVM.Add(list);
                    rowNo++;
                }

                dgProductMaster.DataSource = productMasterListVM;

                lblTotalRows.Text = productMasterListVM.Count.ToString() + " Rows";
            }
            catch (Exception x)
            {
                ppMessage.infoMessage("Something went wrong. Contact your system administrator!");

            }
        }

        private void productNameAutoComplete()
        {
            _entities = new TSEntities();


            var productNameAutoComplete = _entities.tbl_ProductMaster;
            txtpName.AutoCompleteCustomSource.Clear();
            foreach (var item in productNameAutoComplete)
            {
                
                txtpName.AutoCompleteCustomSource.Add(item.p_Name.ToString());
            }
        }

        private void txtpName_Leave(object sender, EventArgs e)
        {
            ppMessage = new PopupMessage();
            try
            {
                if (txtpName.Text != string.Empty)
                {
                    _entities = new TSEntities();
                    var p_nameExists = _entities.tbl_ProductMaster.Where(x => x.p_Name == txtpName.Text.Trim()).FirstOrDefault();

                    if (p_nameExists.id > 0)
                    {
                        ppMessage.infoMessage("Product Name already exists!");
                        txtpName.Focus();
                    }
                }
            }
            catch (Exception x)
            {
              //  ppMessage.infoMessage("Something went wrong. Contact your system administrator!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}
