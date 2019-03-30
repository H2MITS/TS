namespace TS
{
    partial class ProductMasterUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lollipopLabel2 = new LollipopLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSubmit = new LollipopButton();
            this.dgProductMaster = new System.Windows.Forms.DataGridView();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtpName = new System.Windows.Forms.TextBox();
            this.lollipopLabel3 = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lollipopButton2 = new LollipopButton();
            this.btnCancel = new LollipopButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblTotalRows = new LollipopLabel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalRows);
            this.panel1.Controls.Add(this.lollipopLabel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.dgProductMaster);
            this.panel1.Controls.Add(this.txtRate);
            this.panel1.Controls.Add(this.txtpName);
            this.panel1.Controls.Add(this.lollipopLabel3);
            this.panel1.Controls.Add(this.lollipopLabel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.lollipopButton2);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 558);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel2.ForeColor = System.Drawing.Color.Black;
            this.lollipopLabel2.Location = new System.Drawing.Point(18, 111);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(55, 20);
            this.lollipopLabel2.TabIndex = 146;
            this.lollipopLabel2.Text = "Rate:  ";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Pink;
            this.panel4.Controls.Add(this.lblError);
            this.panel4.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(20, 504);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(699, 28);
            this.panel4.TabIndex = 143;
            this.panel4.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblError.Location = new System.Drawing.Point(4, 3);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(77, 20);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "Error Text ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BGColor = "Lime";
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FontColor = "#ffffff";
            this.btnSubmit.Location = new System.Drawing.Point(829, 106);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 38);
            this.btnSubmit.TabIndex = 142;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgProductMaster
            // 
            this.dgProductMaster.AllowUserToAddRows = false;
            this.dgProductMaster.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dgProductMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgProductMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProductMaster.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgProductMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgProductMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn10,
            this.Delete});
            this.dgProductMaster.EnableHeadersVisualStyles = false;
            this.dgProductMaster.Location = new System.Drawing.Point(17, 159);
            this.dgProductMaster.Name = "dgProductMaster";
            this.dgProductMaster.ReadOnly = true;
            this.dgProductMaster.Size = new System.Drawing.Size(916, 303);
            this.dgProductMaster.TabIndex = 136;
            this.dgProductMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductMaster_CellContentClick);
            this.dgProductMaster.DoubleClick += new System.EventHandler(this.dgProductMaster_DoubleClick);
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtRate.Location = new System.Drawing.Point(146, 108);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(185, 25);
            this.txtRate.TabIndex = 133;
            // 
            // txtpName
            // 
            this.txtpName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtpName.Location = new System.Drawing.Point(146, 77);
            this.txtpName.Name = "txtpName";
            this.txtpName.Size = new System.Drawing.Size(781, 25);
            this.txtpName.TabIndex = 132;
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel3.ForeColor = System.Drawing.Color.Black;
            this.lollipopLabel3.Location = new System.Drawing.Point(337, 108);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(21, 24);
            this.lollipopLabel3.TabIndex = 135;
            this.lollipopLabel3.Text = "/-";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel1.ForeColor = System.Drawing.Color.Black;
            this.lollipopLabel1.Location = new System.Drawing.Point(17, 80);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(123, 20);
            this.lollipopLabel1.TabIndex = 134;
            this.lollipopLabel1.Text = "Product Name: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(21, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 2);
            this.panel3.TabIndex = 131;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 23);
            this.label2.TabIndex = 130;
            this.label2.Text = "Add New Product";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(17, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 2);
            this.panel2.TabIndex = 141;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Maroon;
            this.panel7.Location = new System.Drawing.Point(17, 150);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(915, 2);
            this.panel7.TabIndex = 140;
            // 
            // lollipopButton2
            // 
            this.lollipopButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lollipopButton2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopButton2.BGColor = "#508ef5";
            this.lollipopButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lollipopButton2.FontColor = "#ffffff";
            this.lollipopButton2.Location = new System.Drawing.Point(738, 481);
            this.lollipopButton2.Name = "lollipopButton2";
            this.lollipopButton2.Size = new System.Drawing.Size(98, 41);
            this.lollipopButton2.TabIndex = 138;
            this.lollipopButton2.Text = "Print";
            this.lollipopButton2.Click += new System.EventHandler(this.lollipopButton2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BGColor = "Red";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FontColor = "#ffffff";
            this.btnCancel.Location = new System.Drawing.Point(842, 481);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 41);
            this.btnCancel.TabIndex = 137;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "hiddenId";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "rowNo";
            this.dataGridViewTextBoxColumn5.HeaderText = "SrNo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 40;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "p_Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "rate";
            this.dataGridViewTextBoxColumn10.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 120;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Delete.HeaderText = "Action";
            this.Delete.Image = global::TS.Properties.Resources.deleteButton;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 56;
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.AutoSize = true;
            this.lblTotalRows.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRows.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRows.ForeColor = System.Drawing.Color.Black;
            this.lblTotalRows.Location = new System.Drawing.Point(18, 481);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(17, 20);
            this.lblTotalRows.TabIndex = 146;
            this.lblTotalRows.Text = "0";
            // 
            // ProductMasterUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "ProductMasterUC";
            this.Size = new System.Drawing.Size(961, 575);
            this.Load += new System.EventHandler(this.ProductMasterUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgProductMaster;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtpName;
        private LollipopLabel lollipopLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private LollipopButton lollipopButton2;
        private LollipopButton btnCancel;
        private LollipopButton btnSubmit;
        private LollipopLabel lollipopLabel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private LollipopLabel lollipopLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private LollipopLabel lblTotalRows;
    }
}
