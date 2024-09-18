namespace Exercise2
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtAdd = new TextBox();
            txtDate = new TextBox();
            lstEdu = new ListBox();
            cboDep = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 36);
            label1.Name = "label1";
            label1.Size = new Size(243, 38);
            label1.TabIndex = 0;
            label1.Text = "Employee Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 133);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 1;
            label2.Text = "Employee Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 202);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.TabIndex = 2;
            label3.Text = "Employee Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 306);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 3;
            label4.Text = "Date of Joining";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 377);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 4;
            label5.Text = "Education";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 453);
            label6.Name = "label6";
            label6.Size = new Size(107, 25);
            label6.TabIndex = 5;
            label6.Text = "Department";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(207, 133);
            txtName.Name = "txtName";
            txtName.Size = new Size(310, 31);
            txtName.TabIndex = 6;
            // 
            // txtAdd
            // 
            txtAdd.BorderStyle = BorderStyle.FixedSingle;
            txtAdd.Location = new Point(207, 202);
            txtAdd.Multiline = true;
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(310, 77);
            txtAdd.TabIndex = 7;
            // 
            // txtDate
            // 
            txtDate.BorderStyle = BorderStyle.FixedSingle;
            txtDate.Location = new Point(207, 306);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(186, 31);
            txtDate.TabIndex = 8;
            // 
            // lstEdu
            // 
            lstEdu.BorderStyle = BorderStyle.FixedSingle;
            lstEdu.FormattingEnabled = true;
            lstEdu.ItemHeight = 25;
            lstEdu.Items.AddRange(new object[] { "UnderGraduate", "PostGraduate" });
            lstEdu.Location = new Point(207, 377);
            lstEdu.Name = "lstEdu";
            lstEdu.Size = new Size(186, 27);
            lstEdu.TabIndex = 9;
            lstEdu.UseWaitCursor = true;
            // 
            // cboDep
            // 
            cboDep.FormattingEnabled = true;
            cboDep.Items.AddRange(new object[] { "Human Resource", "Marketing", "R&D" });
            cboDep.Location = new Point(207, 450);
            cboDep.Name = "cboDep";
            cboDep.Size = new Size(186, 33);
            cboDep.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(66, 520);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 11;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(229, 520);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 12;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(389, 520);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 13;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 580);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cboDep);
            Controls.Add(lstEdu);
            Controls.Add(txtDate);
            Controls.Add(txtAdd);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Employee Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtAdd;
        private TextBox txtDate;
        private ListBox lstEdu;
        private ComboBox cboDep;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}