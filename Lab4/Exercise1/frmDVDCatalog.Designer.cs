namespace Lab4
{
    partial class frmDVDCatalog
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
            lblHeading = new Label();
            lblDVDCodeNo = new Label();
            txtNo = new TextBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblLang = new Label();
            lblPrice = new Label();
            cboLang = new ComboBox();
            grpSubTitles = new GroupBox();
            radNo = new RadioButton();
            radYes = new RadioButton();
            updPrice = new NumericUpDown();
            btnAdd = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            grpSubTitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updPrice).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(173, 33);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(236, 48);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "DVD Catalog";
            // 
            // lblDVDCodeNo
            // 
            lblDVDCodeNo.AutoSize = true;
            lblDVDCodeNo.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDVDCodeNo.Location = new Point(40, 129);
            lblDVDCodeNo.Name = "lblDVDCodeNo";
            lblDVDCodeNo.Size = new Size(136, 25);
            lblDVDCodeNo.TabIndex = 1;
            lblDVDCodeNo.Text = "DVD Number";
            // 
            // txtNo
            // 
            txtNo.BorderStyle = BorderStyle.FixedSingle;
            txtNo.Location = new Point(200, 130);
            txtNo.Name = "txtNo";
            txtNo.ReadOnly = true;
            txtNo.Size = new Size(209, 31);
            txtNo.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(40, 211);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(111, 27);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "DVD Title";
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Location = new Point(200, 208);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(390, 31);
            txtTitle.TabIndex = 4;
            // 
            // lblLang
            // 
            lblLang.AutoSize = true;
            lblLang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLang.Location = new Point(40, 306);
            lblLang.Name = "lblLang";
            lblLang.Size = new Size(106, 27);
            lblLang.TabIndex = 5;
            lblLang.Text = "Language";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(40, 405);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(62, 27);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price";
            // 
            // cboLang
            // 
            cboLang.FormattingEnabled = true;
            cboLang.Items.AddRange(new object[] { "English", "Spanish", "French", "Chinese", "Russian" });
            cboLang.Location = new Point(200, 306);
            cboLang.Name = "cboLang";
            cboLang.Size = new Size(209, 33);
            cboLang.TabIndex = 9;
            cboLang.SelectedIndexChanged += cboLang_SelectedIndexChanged;
            // 
            // grpSubTitles
            // 
            grpSubTitles.Controls.Add(radNo);
            grpSubTitles.Controls.Add(radYes);
            grpSubTitles.Location = new Point(173, 476);
            grpSubTitles.Name = "grpSubTitles";
            grpSubTitles.Size = new Size(236, 127);
            grpSubTitles.TabIndex = 10;
            grpSubTitles.TabStop = false;
            grpSubTitles.Text = "Subtitles";
            // 
            // radNo
            // 
            radNo.AutoSize = true;
            radNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radNo.Location = new Point(144, 59);
            radNo.Name = "radNo";
            radNo.Size = new Size(62, 29);
            radNo.TabIndex = 1;
            radNo.TabStop = true;
            radNo.Text = "No";
            radNo.UseVisualStyleBackColor = true;
            radNo.CheckedChanged += radNo_CheckedChanged;
            // 
            // radYes
            // 
            radYes.AutoSize = true;
            radYes.Checked = true;
            radYes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radYes.Location = new Point(27, 59);
            radYes.Name = "radYes";
            radYes.Size = new Size(64, 29);
            radYes.TabIndex = 0;
            radYes.TabStop = true;
            radYes.Text = "Yes";
            radYes.UseVisualStyleBackColor = true;
            radYes.CheckedChanged += radYes_CheckedChanged;
            // 
            // updPrice
            // 
            updPrice.Location = new Point(200, 405);
            updPrice.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            updPrice.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            updPrice.Name = "updPrice";
            updPrice.Size = new Size(209, 31);
            updPrice.TabIndex = 11;
            updPrice.Value = new decimal(new int[] { 5, 0, 0, 0 });
            updPrice.ValueChanged += updPrice_ValueChanged;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(99, 627);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 43);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(431, 627);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 43);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(267, 627);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 43);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmDVDCatalog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 717);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(updPrice);
            Controls.Add(grpSubTitles);
            Controls.Add(cboLang);
            Controls.Add(lblPrice);
            Controls.Add(lblLang);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(txtNo);
            Controls.Add(lblDVDCodeNo);
            Controls.Add(lblHeading);
            Name = "frmDVDCatalog";
            Text = "DVD Library";
            grpSubTitles.ResumeLayout(false);
            grpSubTitles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)updPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private Label lblDVDCodeNo;
        private TextBox txtNo;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblLang;
        private Label lblPrice;
        private ComboBox cboLang;
        private GroupBox grpSubTitles;
        private RadioButton radNo;
        private RadioButton radYes;
        private NumericUpDown updPrice;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnSave;
    }
}
