namespace TS
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPname = new LollipopTextBox();
            this.lollipopLabel1 = new LollipopLabel();
            this.txtQty = new LollipopTextBox();
            this.lollipopLabel2 = new LollipopLabel();
            this.txtWeight = new LollipopTextBox();
            this.lollipopLabel3 = new LollipopLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lollipopButton2 = new LollipopButton();
            this.lollipopButton1 = new LollipopButton();
            this.SuspendLayout();
            // 
            // txtPname
            // 
            this.txtPname.FocusedColor = "Black";
            this.txtPname.FontColor = "Black";
            this.txtPname.IsEnabled = true;
            this.txtPname.Location = new System.Drawing.Point(133, 56);
            this.txtPname.MaxLength = 32767;
            this.txtPname.Multiline = false;
            this.txtPname.Name = "txtPname";
            this.txtPname.ReadOnly = false;
            this.txtPname.Size = new System.Drawing.Size(300, 24);
            this.txtPname.TabIndex = 0;
            this.txtPname.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPname.UseSystemPasswordChar = false;
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.Black;
            this.lollipopLabel1.Location = new System.Drawing.Point(27, 61);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(106, 19);
            this.lollipopLabel1.TabIndex = 1;
            this.lollipopLabel1.Text = "Product Name: ";
            // 
            // txtQty
            // 
            this.txtQty.FocusedColor = "Black";
            this.txtQty.FontColor = "Black";
            this.txtQty.IsEnabled = true;
            this.txtQty.Location = new System.Drawing.Point(133, 100);
            this.txtQty.MaxLength = 32767;
            this.txtQty.Multiline = false;
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = false;
            this.txtQty.Size = new System.Drawing.Size(89, 24);
            this.txtQty.TabIndex = 1;
            this.txtQty.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQty.UseSystemPasswordChar = false;
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.Black;
            this.lollipopLabel2.Location = new System.Drawing.Point(85, 107);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(42, 17);
            this.lollipopLabel2.TabIndex = 1;
            this.lollipopLabel2.Text = "Qty : ";
            // 
            // txtWeight
            // 
            this.txtWeight.FocusedColor = "Black";
            this.txtWeight.FontColor = "Black";
            this.txtWeight.IsEnabled = true;
            this.txtWeight.Location = new System.Drawing.Point(312, 100);
            this.txtWeight.MaxLength = 32767;
            this.txtWeight.Multiline = false;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = false;
            this.txtWeight.Size = new System.Drawing.Size(125, 24);
            this.txtWeight.TabIndex = 2;
            this.txtWeight.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtWeight.UseSystemPasswordChar = false;
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.Black;
            this.lollipopLabel3.Location = new System.Drawing.Point(245, 107);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(64, 17);
            this.lollipopLabel3.TabIndex = 1;
            this.lollipopLabel3.Text = "Weight : ";
            this.lollipopLabel3.Click += new System.EventHandler(this.lollipopLabel3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(31, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 2);
            this.panel2.TabIndex = 6;
            // 
            // lollipopButton2
            // 
            this.lollipopButton2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopButton2.BGColor = "Red";
            this.lollipopButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lollipopButton2.FontColor = "#ffffff";
            this.lollipopButton2.Location = new System.Drawing.Point(347, 168);
            this.lollipopButton2.Name = "lollipopButton2";
            this.lollipopButton2.Size = new System.Drawing.Size(90, 41);
            this.lollipopButton2.TabIndex = 8;
            this.lollipopButton2.Text = "Cancel";
            // 
            // lollipopButton1
            // 
            this.lollipopButton1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopButton1.BGColor = "Lime";
            this.lollipopButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lollipopButton1.FontColor = "#ffffff";
            this.lollipopButton1.Location = new System.Drawing.Point(248, 168);
            this.lollipopButton1.Name = "lollipopButton1";
            this.lollipopButton1.Size = new System.Drawing.Size(90, 41);
            this.lollipopButton1.TabIndex = 9;
            this.lollipopButton1.Text = "Submit";
            this.lollipopButton1.Click += new System.EventHandler(this.lollipopButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.lollipopButton1);
            this.Controls.Add(this.lollipopButton2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lollipopLabel3);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtPname);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LollipopTextBox txtPname;
        private LollipopLabel lollipopLabel1;
        private LollipopTextBox txtQty;
        private LollipopLabel lollipopLabel2;
        private LollipopTextBox txtWeight;
        private LollipopLabel lollipopLabel3;
        private System.Windows.Forms.Panel panel2;
        private LollipopButton lollipopButton2;
        private LollipopButton lollipopButton1;
    }
}

