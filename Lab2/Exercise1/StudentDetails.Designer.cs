namespace Exercise1
{
    partial class StudentDetails
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
            txtName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtYear = new TextBox();
            lstClass = new ListBox();
            cboDiv = new ComboBox();
            lstHob = new CheckedListBox();
            btnConfirm = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 32);
            label1.Name = "label1";
            label1.Size = new Size(309, 38);
            label1.TabIndex = 0;
            label1.Text = "Student's Class Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 114);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 1;
            label2.Text = "Student Name";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(209, 111);
            txtName.Name = "txtName";
            txtName.Size = new Size(272, 31);
            txtName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 176);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 3;
            label3.Text = "Year of birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 233);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 4;
            label4.Text = "Standard/Class";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 339);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 5;
            label5.Text = "Division";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 405);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 6;
            label6.Text = "Hobbies";
            // 
            // txtYear
            // 
            txtYear.BorderStyle = BorderStyle.FixedSingle;
            txtYear.Location = new Point(209, 176);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(165, 31);
            txtYear.TabIndex = 7;
            // 
            // lstClass
            // 
            lstClass.BorderStyle = BorderStyle.FixedSingle;
            lstClass.FormattingEnabled = true;
            lstClass.ItemHeight = 25;
            lstClass.Items.AddRange(new object[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" });
            lstClass.Location = new Point(209, 233);
            lstClass.Name = "lstClass";
            lstClass.Size = new Size(165, 77);
            lstClass.TabIndex = 8;
            // 
            // cboDiv
            // 
            cboDiv.FormattingEnabled = true;
            cboDiv.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cboDiv.Location = new Point(209, 339);
            cboDiv.Name = "cboDiv";
            cboDiv.Size = new Size(165, 33);
            cboDiv.TabIndex = 9;
            // 
            // lstHob
            // 
            lstHob.BorderStyle = BorderStyle.FixedSingle;
            lstHob.FormattingEnabled = true;
            lstHob.Items.AddRange(new object[] { "Singing", "Dancing", "Swimming", "Reading", "Travelling" });
            lstHob.Location = new Point(209, 405);
            lstHob.Name = "lstHob";
            lstHob.Size = new Size(165, 86);
            lstHob.TabIndex = 10;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(62, 558);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(194, 34);
            btnConfirm.TabIndex = 11;
            btnConfirm.Text = "Confirm Student Details";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(303, 558);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(199, 34);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // StudentDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(548, 657);
            Controls.Add(btnClear);
            Controls.Add(btnConfirm);
            Controls.Add(lstHob);
            Controls.Add(cboDiv);
            Controls.Add(lstClass);
            Controls.Add(txtYear);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentDetails";
            Text = "Student Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtYear;
        private ListBox lstClass;
        private ComboBox cboDiv;
        private CheckedListBox lstHob;
        private Button btnConfirm;
        private Button btnClear;
    }
}
