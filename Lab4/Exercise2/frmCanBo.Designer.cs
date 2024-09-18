namespace Exercise2
{
    partial class frmCanBo
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
            lblThongTin = new Label();
            lblMaSo = new Label();
            txtMaSo = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblChucVu = new Label();
            cboChucVu = new ComboBox();
            lblSoGio = new Label();
            lblDonGia = new Label();
            txtSoGio = new TextBox();
            txtDonGia = new TextBox();
            btnAdd = new Button();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblThongTin
            // 
            lblThongTin.AutoSize = true;
            lblThongTin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongTin.Location = new Point(154, 33);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(286, 38);
            lblThongTin.TabIndex = 0;
            lblThongTin.Text = "THÔNG TIN CÁN BỘ";
            // 
            // lblMaSo
            // 
            lblMaSo.AutoSize = true;
            lblMaSo.Location = new Point(59, 114);
            lblMaSo.Name = "lblMaSo";
            lblMaSo.Size = new Size(59, 25);
            lblMaSo.TabIndex = 1;
            lblMaSo.Text = "MSCB";
            // 
            // txtMaSo
            // 
            txtMaSo.BorderStyle = BorderStyle.FixedSingle;
            txtMaSo.Enabled = false;
            txtMaSo.Location = new Point(189, 114);
            txtMaSo.Name = "txtMaSo";
            txtMaSo.ReadOnly = true;
            txtMaSo.Size = new Size(150, 31);
            txtMaSo.TabIndex = 2;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(59, 192);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(93, 25);
            lblHoTen.TabIndex = 3;
            lblHoTen.Text = "Họ Tên CB";
            // 
            // txtHoTen
            // 
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Location = new Point(189, 190);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(356, 31);
            txtHoTen.TabIndex = 4;
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Location = new Point(59, 268);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(76, 25);
            lblChucVu.TabIndex = 5;
            lblChucVu.Text = "Chức vụ";
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Items.AddRange(new object[] { "Giảng viên", "Viên chức", "Trợ giảng" });
            cboChucVu.Location = new Point(189, 268);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(226, 33);
            cboChucVu.TabIndex = 6;
            // 
            // lblSoGio
            // 
            lblSoGio.AutoSize = true;
            lblSoGio.Location = new Point(59, 348);
            lblSoGio.Name = "lblSoGio";
            lblSoGio.Size = new Size(114, 25);
            lblSoGio.TabIndex = 7;
            lblSoGio.Text = "Số giờ giảng";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(59, 423);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(75, 25);
            lblDonGia.TabIndex = 8;
            lblDonGia.Text = "Đơn giá";
            // 
            // txtSoGio
            // 
            txtSoGio.BorderStyle = BorderStyle.FixedSingle;
            txtSoGio.Location = new Point(189, 348);
            txtSoGio.Name = "txtSoGio";
            txtSoGio.Size = new Size(226, 31);
            txtSoGio.TabIndex = 9;
            // 
            // txtDonGia
            // 
            txtDonGia.BorderStyle = BorderStyle.FixedSingle;
            txtDonGia.Location = new Point(189, 420);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(226, 31);
            txtDonGia.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(65, 496);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 43);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(231, 496);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 43);
            btnSave.TabIndex = 12;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(408, 496);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(124, 43);
            btnClose.TabIndex = 13;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCanBo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 568);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(txtDonGia);
            Controls.Add(txtSoGio);
            Controls.Add(lblDonGia);
            Controls.Add(lblSoGio);
            Controls.Add(cboChucVu);
            Controls.Add(lblChucVu);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Controls.Add(txtMaSo);
            Controls.Add(lblMaSo);
            Controls.Add(lblThongTin);
            Name = "frmCanBo";
            Text = "Can Bo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblThongTin;
        private Label lblMaSo;
        private TextBox txtMaSo;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblChucVu;
        private ComboBox cboChucVu;
        private Label lblSoGio;
        private Label lblDonGia;
        private TextBox txtSoGio;
        private TextBox txtDonGia;
        private Button btnAdd;
        private Button btnSave;
        private Button btnClose;
    }
}
