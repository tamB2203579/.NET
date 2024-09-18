namespace Lab3
{
    partial class frmBookSale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTitle = new TextBox();
            txtQuan = new TextBox();
            txtPrice = new TextBox();
            lblEPrice = new TextBox();
            label6 = new Label();
            label7 = new Label();
            lblNetDue = new TextBox();
            lblDis = new TextBox();
            chkDis = new CheckBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            mnuNew = new ToolStripMenuItem();
            mnuCal = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            mnuSum = new ToolStripMenuItem();
            chkDisStudent = new CheckBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(57, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 2;
            label1.Text = "Book Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 3;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 170);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 4;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 238);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 5;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 320);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 6;
            label5.Text = "ExtendedPrice";
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Location = new Point(186, 108);
            txtTitle.Margin = new Padding(4, 5, 4, 5);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(484, 31);
            txtTitle.TabIndex = 7;
            // 
            // txtQuan
            // 
            txtQuan.BorderStyle = BorderStyle.FixedSingle;
            txtQuan.Location = new Point(186, 170);
            txtQuan.Margin = new Padding(4, 5, 4, 5);
            txtQuan.Name = "txtQuan";
            txtQuan.Size = new Size(200, 31);
            txtQuan.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Location = new Point(186, 238);
            txtPrice.Margin = new Padding(4, 5, 4, 5);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 31);
            txtPrice.TabIndex = 9;
            // 
            // lblEPrice
            // 
            lblEPrice.BackColor = SystemColors.Control;
            lblEPrice.BorderStyle = BorderStyle.FixedSingle;
            lblEPrice.Enabled = false;
            lblEPrice.ForeColor = Color.Black;
            lblEPrice.Location = new Point(186, 315);
            lblEPrice.Margin = new Padding(4, 5, 4, 5);
            lblEPrice.Name = "lblEPrice";
            lblEPrice.ReadOnly = true;
            lblEPrice.Size = new Size(200, 31);
            lblEPrice.TabIndex = 10;
            lblEPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 405);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 11;
            label6.Text = "Discount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 477);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 12;
            label7.Text = "Net Due";
            // 
            // lblNetDue
            // 
            lblNetDue.BackColor = SystemColors.Control;
            lblNetDue.BorderStyle = BorderStyle.FixedSingle;
            lblNetDue.Enabled = false;
            lblNetDue.ForeColor = Color.Black;
            lblNetDue.Location = new Point(186, 472);
            lblNetDue.Margin = new Padding(4, 5, 4, 5);
            lblNetDue.Name = "lblNetDue";
            lblNetDue.ReadOnly = true;
            lblNetDue.Size = new Size(200, 31);
            lblNetDue.TabIndex = 13;
            lblNetDue.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDis
            // 
            lblDis.BackColor = SystemColors.Control;
            lblDis.BorderStyle = BorderStyle.FixedSingle;
            lblDis.Enabled = false;
            lblDis.ForeColor = Color.Black;
            lblDis.Location = new Point(186, 400);
            lblDis.Margin = new Padding(4, 5, 4, 5);
            lblDis.Name = "lblDis";
            lblDis.ReadOnly = true;
            lblDis.Size = new Size(200, 31);
            lblDis.TabIndex = 14;
            lblDis.TextAlign = HorizontalAlignment.Right;
            // 
            // chkDis
            // 
            chkDis.AutoSize = true;
            chkDis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkDis.Location = new Point(501, 322);
            chkDis.Margin = new Padding(4, 5, 4, 5);
            chkDis.Name = "chkDis";
            chkDis.Size = new Size(181, 29);
            chkDis.TabIndex = 15;
            chkDis.Text = "Normal Discount";
            chkDis.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(727, 35);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuNew, mnuCal, mnuExit, mnuSum });
            fileToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // mnuNew
            // 
            mnuNew.Name = "mnuNew";
            mnuNew.Size = new Size(190, 34);
            mnuNew.Text = "New";
            mnuNew.Click += mnuNew_Click;
            // 
            // mnuCal
            // 
            mnuCal.Name = "mnuCal";
            mnuCal.Size = new Size(190, 34);
            mnuCal.Text = "Calculate";
            mnuCal.Click += mnuCal_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(190, 34);
            mnuExit.Text = "Exit";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuSum
            // 
            mnuSum.Name = "mnuSum";
            mnuSum.Size = new Size(190, 34);
            mnuSum.Text = "Summary";
            mnuSum.Click += mnuSum_Click;
            // 
            // chkDisStudent
            // 
            chkDisStudent.AutoSize = true;
            chkDisStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkDisStudent.Location = new Point(501, 383);
            chkDisStudent.Margin = new Padding(4, 5, 4, 5);
            chkDisStudent.Name = "chkDisStudent";
            chkDisStudent.Size = new Size(175, 29);
            chkDisStudent.TabIndex = 17;
            chkDisStudent.Text = "Distinct Student";
            chkDisStudent.UseVisualStyleBackColor = true;
            // 
            // frmBookSale
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 547);
            Controls.Add(chkDisStudent);
            Controls.Add(chkDis);
            Controls.Add(lblDis);
            Controls.Add(lblNetDue);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblEPrice);
            Controls.Add(txtPrice);
            Controls.Add(txtQuan);
            Controls.Add(txtTitle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmBookSale";
            Text = "Book Sales";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTitle;
        private TextBox txtQuan;
        private TextBox txtPrice;
        private TextBox lblEPrice;
        private Label label6;
        private Label label7;
        private TextBox lblNetDue;
        private TextBox lblDis;
        private CheckBox chkDis;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuCal;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuSum;
        private CheckBox chkDisStudent;
    }
}
