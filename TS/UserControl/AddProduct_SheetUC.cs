using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TS.Model;
using TS.Classes;
using TS.ViewModel;
using TS.Properties;


namespace TS
{
    public partial class AddProduct_SheetUC : UserControl
    {

        TSEntities _entities;
        PopupMessage ppMsg;
        int datagridId = 1;
        long dgRowId = 1;
        bool datagridEdit = false;
        long passedId = 0;

        decimal ttlRate = 0, ttlAmt = 0;
        public AddProduct_SheetUC(long pId = 0)
        {
            InitializeComponent();
            passedId = pId;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void clear()
        {
            txtSheetName.Text = string.Empty;
            txtTotalAmount.Text = "0";
            txtTaxRate.Text = "0";
            txtTotalRate.Text = "0";
            txtProfitMargin.Text = "0";
            cmbGst.SelectedIndex = 0;
            txtProfitMargin.Enabled = false;
            dgSheetDetails.Rows.Clear();
            txtRemark.Text = string.Empty;
            ttlRate = 0;
        }
        private void clearDetails()
        {
            txtpName.Text = string.Empty;
            txtQtyWeight.Text = string.Empty;
            txtRate.Text = string.Empty;
            txtAmt.Text = string.Empty;
            cmbQtyWeight.SelectedIndex = 0;
        }



        private void AddProduct_SheetUC_Load(object sender, EventArgs e)
        {
            clear();
            txtSheetName.Focus();
            //txtPname.Font = new Font("Arial", 50, FontStyle.Bold);
            cmbQtyWeight.SelectedIndex = 0;
            productNameNameAutoComplete();
            ProductgridBind();

            if (passedId != 0)
            {
                showAvailableData();
            }
        }


        private void showAvailableData()
        {
            try
            {
                clear();
                clearDetails();

                btnSubmit.Text = "Update";
                _entities = new TSEntities();

                var data = _entities.tbl_SheetMaster.Where(x => x.sheetId == passedId).FirstOrDefault();

                txtSheetName.Text = data.sheetName;
                txtTotalRate.Text = data.totalRate.ToString();
                txtTotalAmount.Text = data.totalAmt.ToString();
                txtProfitMargin.Text = data.profitMargin.ToString();
                txtTaxRate.Text = data.gstAmt.ToString();

                if (data.gstPer == 18)
                {
                    cmbGst.SelectedIndex = 1;
                }
                if (data.gstPer == 28)
                {
                    cmbGst.SelectedIndex = 2;

                }
                else 
                { 
                    cmbGst.SelectedIndex = 0;
                }

                ttlRate = Convert.ToDecimal(data.totalRate);


                //Sheet Details

                _entities = new TSEntities();
                var sheetDetailsData = _entities.tbl_SheetDetails.Where(x => x.sheetId ==passedId).ToList();

                datagridId = 1;

                foreach (var item in sheetDetailsData)
                {
                    var itemName = _entities.tbl_ProductMaster.Where(x => x.id == item.pId).FirstOrDefault().p_Name;

                    dgSheetDetails.Rows.Add(
                        datagridId.ToString(),
                        itemName,
                        item.qty,
                       item.weight, 
                        item.rate,
                        item.amt);

                    datagridId = datagridId + 1;
                }


            }
            catch (Exception x)
            {

            }
        }

        private void ProductgridBind()
        {
            ppMsg = new PopupMessage();
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
                ppMsg.infoMessage("Something went wrong. Contact your system administrator!");

            }

        }

        private void productNameNameAutoComplete()
        {
            _entities = new TSEntities();

            var productNameAutoComplete = _entities.tbl_ProductMaster;
            txtpName.AutoCompleteCustomSource.Clear();
            foreach (var item in productNameAutoComplete)
            {
                txtpName.AutoCompleteCustomSource.Add(item.p_Name.ToString());
            }
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


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ppMsg = new PopupMessage();
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
                else if (txtProfitMargin.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtProfitMargin, "Profit margin cannot be blank.");
                    txtProfitMargin.Focus();
                    panel9.Visible = true;
                    lblError.Text = "Profit margin cannot be blank.";
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

                        _entities = new TSEntities();

                        tbl_SheetMaster sm = new tbl_SheetMaster();
                        sm.sheetName = txtSheetName.Text.Trim().ToString();
                        sm.date = Convert.ToDateTime(dateTimePicker1.Text.ToString()).Date;
                        sm.totalRate = Convert.ToDecimal(txtTotalRate.Text.Trim());
                        sm.totalAmt = Convert.ToDecimal(txtTotalAmount.Text.Trim());
                        sm.profitMargin = Convert.ToDecimal(txtProfitMargin.Text.Trim());

                        if (cmbGst.SelectedIndex == 1)
                        {
                            sm.gstPer = 18;
                        }
                        else if (cmbGst.SelectedIndex == 2)
                        {
                            sm.gstPer = 28;
                        }
                        else
                        {
                            sm.gstPer = 0;
                        }
                        sm.gstAmt = Convert.ToDecimal(txtTaxRate.Text.Trim());
                        sm.remarks = txtRemark.Text.Trim().ToString();

                        sm.cDate = DateTime.Now;

                        _entities.tbl_SheetMaster.Add(sm);
                        _entities.SaveChanges();

                        ppMsg.successMessage();

                        addSheetDetailsData();

                    }
                    else
                    {
                        //Update Code
                    }

                    clear();
                    clearDetails();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void txtRate_Leave(object sender, EventArgs e)
        {
            ppMsg = new PopupMessage();
            try
            {

                if (txtQtyWeight.Text != string.Empty)
                {
                    if (txtRate.Text == string.Empty)
                    {
                        txtRate.Text = "0.00";
                    }

                    _entities = new TSEntities();

                    var rates = _entities.tbl_ProductMaster.Where(x => x.p_Name == txtpName.Text.Trim().ToString()).FirstOrDefault();

                    if (Convert.ToDecimal(txtRate.Text.Trim()) != rates.rate)
                    {
                        DialogResult myResult;
                        myResult = MessageBox.Show("Are you really wanna change rate of the item?", "Update Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (myResult == DialogResult.OK)
                        {
                            rates.rate = Convert.ToDecimal(txtRate.Text.Trim());
                            _entities.SaveChanges();
                            ppMsg.updateMessage();

                            ProductgridBind();
                        }
                        else
                        {

                        }
                        txtAmt.Text = Convert.ToDecimal((Convert.ToDecimal(txtQtyWeight.Text.Trim()) * Convert.ToDecimal(txtRate.Text.Trim()))).ToString();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            clear();
            clearDetails();
        }


        void addSheetDetailsData()
        {
            foreach (DataGridViewRow dr in dgSheetDetails.Rows)
            {
                if (Convert.ToString(dr.Cells[0].Value) != string.Empty)
                {
                    _entities = new TSEntities();

                    tbl_SheetDetails sheetDetails = new tbl_SheetDetails();

                    sheetDetails.sheetId = _entities.tbl_SheetMaster.Where(x => x.sheetName == txtSheetName.Text.Trim().ToString()).FirstOrDefault().sheetId;


                    var gridProductName = dr.Cells[1].Value.ToString();
                    sheetDetails.pId = _entities.tbl_ProductMaster.Where(x => x.p_Name == gridProductName).FirstOrDefault().id;
                    sheetDetails.qty = Convert.ToDecimal(dr.Cells[2].Value.ToString());
                    sheetDetails.weight = Convert.ToDecimal(dr.Cells[3].Value.ToString());
                    sheetDetails.rate = Convert.ToDecimal(dr.Cells[4].Value.ToString());
                    sheetDetails.amt = Convert.ToDecimal(dr.Cells[5].Value.ToString());
                    sheetDetails.cDate = DateTime.Now;

                    _entities.tbl_SheetDetails.Add(sheetDetails);
                    _entities.SaveChanges();

                    //Update Qty in stock

                    //var itemQty = _entities.tbl_StockItemDetails.Where(x => x.itemId == purchaseDetails.productID).FirstOrDefault();

                    //itemQty.qty = itemQty.qty + purchaseDetails.qty;
                    //itemQty.upadtedDate = DateTime.Now;

                    //_entities.SaveChanges();
                }
            }
        }


        private void txtAmt_Leave(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;

            //if (txtpName.Text == string.Empty)
            //{
            //    errorProvider1.Clear();
            //    errorProvider1.SetError(txtpName, "Enter Product Name.");
            //    txtpName.Focus();
            //    panel9.Visible = true;
            //    lblError.Text = "Enter Product Name.";
            //}
            //else if (txtQtyWeight.Text == string.Empty)
            //{
            //    errorProvider1.Clear();
            //    errorProvider1.SetError(txtQtyWeight, "Enter Qty or Weight.");
            //    txtQtyWeight.Focus();
            //    panel9.Visible = true;
            //    lblError.Text = "Enter Qty or Weight.";
            //}
            //else if (txtRate.Text == string.Empty)
            //{
            //    errorProvider1.Clear();
            //    errorProvider1.SetError(txtRate, "Enter Rate.");
            //    txtRate.Focus();
            //    panel9.Visible = true;
            //    lblError.Text = "Enter Rate.";
            //}
            //else
            //{
            errorProvider1.Clear();

            if (txtpName.Text != string.Empty && txtQtyWeight.Text != string.Empty && txtRate.Text != string.Empty && txtAmt.Text != string.Empty)
            {

                fillGridData();
                totalCalcs();
            }
            else
            {

                txtpName.Focus();
            }


        }

        private void fillGridData()
        {
            try
            {
                //ttlRate = 0;
                if (datagridEdit)
                {
                    dgSheetDetails.Rows[datagridId].Cells[1].Value = txtpName.Text.Trim();

                    if (cmbQtyWeight.SelectedIndex == 1) //qty
                    {
                        dgSheetDetails.Rows[datagridId].Cells[2].Value = txtQtyWeight.Text.Trim();
                    }
                    else
                    {
                        dgSheetDetails.Rows[datagridId].Cells[2].Value = "0";
                    }
                    if (cmbQtyWeight.SelectedIndex == 2) //weight
                    {
                        dgSheetDetails.Rows[datagridId].Cells[3].Value = txtQtyWeight.Text.Trim();
                    }
                    else
                    {
                        dgSheetDetails.Rows[datagridId].Cells[2].Value = txtQtyWeight.Text.Trim();
                    }

                    if (txtRate.Text == string.Empty)
                    {
                        txtRate.Text = "0";
                    }
                    if (txtAmt.Text == string.Empty)
                    {
                        txtAmt.Text = "0";
                    }

                    dgSheetDetails.Rows[datagridId].Cells[4].Value = txtRate.Text.Trim();
                    dgSheetDetails.Rows[datagridId].Cells[5].Value = txtAmt.Text.Trim();
                    this.datagridEdit = false;

                    //var dgrate = Convert.ToDecimal(dgSheetDetails.Rows[datagridId].Cells[5].Value);

                    //  var dgQtyWeight = Convert.ToDecimal(dgPurchaseItem.Rows[datagridId].Cells[2].Value);
                }
                else
                {
                    var qty = "";
                    var weight = "";

                    if (cmbQtyWeight.SelectedIndex == 1) //qty
                    {
                        qty = txtQtyWeight.Text.Trim();
                    }
                    else
                    {
                        qty = "0";
                    }
                    if (cmbQtyWeight.SelectedIndex == 2) //weight
                    {
                        weight = txtQtyWeight.Text.Trim();
                    }
                    else
                    {
                        weight = "0";
                    }
                    if (cmbQtyWeight.SelectedIndex == 0) //default
                    {
                        qty = txtQtyWeight.Text.Trim();
                    }

                    if (txtRate.Text == string.Empty)
                    {
                        txtRate.Text = "0";
                    }
                    if (txtAmt.Text == string.Empty)
                    {
                        txtAmt.Text = "0";
                    }

                    dgSheetDetails.Rows.Add(dgRowId.ToString(), txtpName.Text.Trim().ToString(), qty, weight, txtRate.Text.Trim().ToString(), txtAmt.Text.Trim().ToString());
                    dgRowId = dgRowId + 1;
                    if (Convert.ToDecimal(txtAmt.Text.Trim()) > 0)
                    {
                        txtProfitMargin.Enabled = true;
                    }
                }

                if (txtRate.Text == string.Empty)
                {
                    txtRate.Text = "0";
                }

                ttlRate += Convert.ToDecimal(txtAmt.Text.Trim());

                txtTotalRate.Text = ttlRate.ToString();
                txtTotalAmount.Text = ttlRate.ToString();
                clearDetails();
                txtpName.Focus();
                errorProvider1.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void txtQtyWeight_Leave(object sender, EventArgs e)
        {
            try
            {

                if (txtQtyWeight.Text != string.Empty)
                {
                    if (txtRate.Text == string.Empty)
                    {
                        txtRate.Text = "0";
                    }
                    txtAmt.Text = Convert.ToDecimal((Convert.ToDecimal(txtQtyWeight.Text.Trim()) * Convert.ToDecimal(txtRate.Text.Trim()))).ToString();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
        decimal pM = 0;
        private void txtProfitMargin_Leave(object sender, EventArgs e)
        {
            try
            {

                if (txtProfitMargin.Text != string.Empty)
                {
                    if (Convert.ToDecimal(txtProfitMargin.Text) != pM)
                    {
                        decimal ttlAmt = Convert.ToDecimal(txtTotalAmount.Text.Trim().ToString()) + Convert.ToDecimal(txtProfitMargin.Text.Trim());
                        txtTotalAmount.Text = ttlAmt.ToString();
                        pM = Convert.ToDecimal(txtProfitMargin.Text);
                    }
                    totalCalcs();

                }
            }
            catch (Exception x)
            {

            }
            //  totalCalc();
        }

        private void txtTaxRate_Leave(object sender, EventArgs e)
        {
            //totalCalc();

            //decimal ttlAmt = Convert.ToDecimal(txtTotalAmount.Text) + Convert.ToDecimal(txtTaxRate.Text);

            // txtTotalAmount.Text = ttlAmt.ToString();
        }

        private void totalCalc()
        {
            try
            {
                decimal ttlRate = 0, ttlProfit = 0, ttlgst = 0, ttlAmount = 0;

                ttlRate = Convert.ToDecimal(txtTotalRate.Text.ToString());
                ttlgst = Convert.ToDecimal(txtTaxRate.Text.ToString());

                //profit margin
                if (txtProfitMargin.Text != string.Empty)
                {
                    ttlProfit = Convert.ToDecimal(txtProfitMargin.Text.ToString()) + Convert.ToDecimal(txtTotalRate.Text.ToString());
                }
                else
                {
                    ttlProfit = 0;
                }

                //tax 
                if (cmbGst.SelectedIndex == 1)
                {
                    //18% 
                    if (txtTaxRate.Text == string.Empty)
                    {
                        ttlgst = (ttlProfit + ttlgst) * 18 / 100;
                        ttlAmount = ttlProfit + ttlgst;
                    }
                    else
                    {
                        ttlAmount = (ttlProfit + ttlgst);

                    }
                }
                else if (cmbGst.SelectedIndex == 2)
                {
                    //28%
                    if (txtTaxRate.Text == string.Empty)
                    {
                        ttlgst = (ttlProfit + ttlgst) * 28 / 100;
                        ttlAmount = ttlProfit + ttlgst;
                    }
                    else
                    {
                        ttlAmount = (ttlProfit + ttlgst);

                    }
                }

                txtTotalAmount.Text = ttlAmount.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void cmbGst_SelectedIndexChanged(object sender, EventArgs e)
        {
            //totalCalc();

            totalCalcs();
        }

        private void totalCalcs()
        {
            try
            {
                decimal gstRate = 0;

                if (cmbGst.SelectedIndex == 1)
                {
                    gstRate = Convert.ToDecimal(Convert.ToDecimal(txtTotalRate.Text) + Convert.ToDecimal(txtProfitMargin.Text)) * 18 / 100;
                }
                else if (cmbGst.SelectedIndex == 2)
                {
                    gstRate = Convert.ToDecimal(Convert.ToDecimal(txtTotalRate.Text) + Convert.ToDecimal(txtProfitMargin.Text)) * 28 / 100;

                }
                else
                {
                    gstRate = 0;
                }

                txtTaxRate.Text = gstRate.ToString();

                decimal ttlAmt = gstRate + Convert.ToDecimal(Convert.ToDecimal(txtTotalRate.Text) + Convert.ToDecimal(txtProfitMargin.Text));

                txtTotalAmount.Text = ttlAmt.ToString();
            }
            catch (Exception c)
            {

            }
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

        private void txtpName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ppMsg = new PopupMessage();
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
                ppMsg.infoMessage("Something went wrong. Contact your system administrator!");

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpName_Leave(object sender, EventArgs e)
        {
            try
            {
                _entities = new TSEntities();
                if (txtpName.Text != string.Empty)
                {
                    var rates = _entities.tbl_ProductMaster.Where(x => x.p_Name == txtpName.Text.Trim().ToString()).FirstOrDefault();

                    txtRate.Text = rates.rate.ToString();
                    ProductgridBind();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void dgProductMaster_DoubleClick(object sender, EventArgs e)
        {
            ppMsg = new PopupMessage();
            try
            {
                //ProductId = 0;
                if (dgProductMaster.CurrentRow.Index != -1 && dgProductMaster.CurrentRow.Cells[1].Value != null)
                {
                    var lID = Convert.ToInt32(dgProductMaster.CurrentRow.Cells[0].Value);

                    _entities = new TSEntities();
                    var data = _entities.tbl_ProductMaster.Where(x => x.id == lID).FirstOrDefault();

                    //clear();
                    txtpName.Text = data.p_Name;
                    txtRate.Text = data.rate.ToString();
                    //   ProductId = data.id;


                    //btnSubmit.Text = "Update";
                }
            }
            catch (Exception x)
            {
                ppMsg.infoMessage("Something went wrong. Contact your system administrator!");

            }
        }

        private void dgProductMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ppMsg = new PopupMessage();
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

                        var selectedData1 = _entities.tbl_ProductMaster.Where(x => x.id == cellId).OrderBy(x => x.p_Name).FirstOrDefault();

                        if (selectedData1 != null)
                        {
                            _entities.tbl_ProductMaster.Remove(selectedData1);
                        }
                        else
                        {
                            // MessageBox.Show("Something went wrong. Record cannot be deleted.");

                            ppMsg.infoMessage("Something went wrong. Record cannot be deleted.");
                        }

                        _entities.SaveChanges();

                        ppMsg.deleteMessage();
                        //MessageBox.Show("Record deleted ");
                        ProductgridBind();
                    }

                }
            }
            catch (Exception x)
            {
                ppMsg.infoMessage("Something went wrong. Contact your system administrator!");

            }
        }

        private void dgSheetDetails_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgSheetDetails.CurrentRow.Index != -1 && dgSheetDetails.CurrentRow.Cells[1].Value != null)
                {


                    //var Rowid = Convert.ToInt32(dgPurchaseItem.CurrentRow.Cells[0].Value);
                    txtpName.Text = dgSheetDetails.CurrentRow.Cells[1].Value.ToString();
                    txtRate.Text = dgSheetDetails.CurrentRow.Cells[4].Value.ToString();
                    txtAmt.Text = dgSheetDetails.CurrentRow.Cells[5].Value.ToString();

                    if (Convert.ToDecimal(dgSheetDetails.CurrentRow.Cells[2].Value) > 0)
                    {
                        cmbQtyWeight.SelectedIndex = 1;
                        txtQtyWeight.Text = dgSheetDetails.CurrentRow.Cells[2].Value.ToString();
                    }
                    else if (Convert.ToDecimal(dgSheetDetails.CurrentRow.Cells[3].Value) > 0)
                    {
                        cmbQtyWeight.SelectedIndex = 2;
                        txtQtyWeight.Text = dgSheetDetails.CurrentRow.Cells[3].Value.ToString();
                    }

                    else
                    {
                        cmbQtyWeight.SelectedIndex = 0;
                        txtQtyWeight.Text = "0";

                    }

                    ttlRate = ttlRate - Convert.ToDecimal(txtAmt.Text);

                    //MessageBox.Show(ttlWeight + "-" + ttlMelting + "-" + ttlRate);

                    int id = Convert.ToInt32(dgSheetDetails.CurrentRow.Index);

                    datagridId = id;
                    datagridEdit = true;
                    txtpName.Focus();
                    //foreach (DataGridViewCell oneCell in dgPurchaseItem.SelectedCells)
                    //{
                    //    if (oneCell.Selected)
                    //        dgPurchaseItem.Rows.RemoveAt(oneCell.RowIndex);
                    //}

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong. Contact your system administrator");
            }
        }

        private void dgSheetDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgSheetDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSubmit.Enabled = false;

                if (dgSheetDetails.Columns[e.ColumnIndex].Name == "DeleteThis")
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        // int id = Convert.ToInt32(dgPurchaseItem.CurrentRow.Index);

                        foreach (DataGridViewCell oneCell in dgSheetDetails.SelectedCells)
                        {

                            var dgRate = Convert.ToDecimal(dgSheetDetails.Rows[oneCell.RowIndex].Cells[4].Value);
                            var dgAmt = Convert.ToDecimal(dgSheetDetails.Rows[oneCell.RowIndex].Cells[5].Value);

                            ttlRate = ttlRate - dgAmt;
                            // ttlAmt = ttlAmt - dgAmt;

                            txtTotalRate.Text = ttlRate.ToString();
                            //  txtTotalAmount.Text = ttlAmt.ToString();

                            if (oneCell.Selected)
                                dgSheetDetails.Rows.RemoveAt(oneCell.RowIndex);

                            totalCalcs();

                        }
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong. Contact your system administrator");
            }
        }
    }
}
