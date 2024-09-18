namespace Exercise3
{
    partial class Form1
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
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtTicketNum = new TextBox();
            txtName = new TextBox();
            txtPassNum = new TextBox();
            lstSrc = new ListBox();
            lstDes = new ListBox();
            txtDate = new TextBox();
            cboClass = new ComboBox();
            lstService = new CheckedListBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 30);
            label1.Name = "label1";
            label1.Size = new Size(353, 38);
            label1.TabIndex = 0;
            label1.Text = "Flight Reservation Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 114);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 1;
            label2.Text = "Ticket number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 172);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 2;
            label3.Text = "Passenger Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 240);
            label4.Name = "label4";
            label4.Size = new Size(147, 25);
            label4.TabIndex = 3;
            label4.Text = "Passport number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 306);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 4;
            label5.Text = "Source";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 397);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 5;
            label6.Text = "Destination";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 497);
            label7.Name = "label7";
            label7.Size = new Size(98, 25);
            label7.TabIndex = 6;
            label7.Text = "Flight Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 563);
            label8.Name = "label8";
            label8.Size = new Size(52, 25);
            label8.TabIndex = 7;
            label8.Text = "Class";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 626);
            label9.Name = "label9";
            label9.Size = new Size(75, 25);
            label9.TabIndex = 8;
            label9.Text = "Services";
            // 
            // txtTicketNum
            // 
            txtTicketNum.BorderStyle = BorderStyle.FixedSingle;
            txtTicketNum.Location = new Point(183, 114);
            txtTicketNum.Name = "txtTicketNum";
            txtTicketNum.Size = new Size(182, 31);
            txtTicketNum.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(183, 172);
            txtName.Name = "txtName";
            txtName.Size = new Size(279, 31);
            txtName.TabIndex = 10;
            // 
            // txtPassNum
            // 
            txtPassNum.BorderStyle = BorderStyle.FixedSingle;
            txtPassNum.Location = new Point(183, 240);
            txtPassNum.Name = "txtPassNum";
            txtPassNum.Size = new Size(182, 31);
            txtPassNum.TabIndex = 11;
            // 
            // lstSrc
            // 
            lstSrc.BorderStyle = BorderStyle.FixedSingle;
            lstSrc.FormattingEnabled = true;
            lstSrc.ItemHeight = 25;
            lstSrc.Items.AddRange(new object[] { "Amsterdam", "Ha Noi", "Singapore", "Beijing", "Tokyo", "Seoul" });
            lstSrc.Location = new Point(183, 306);
            lstSrc.Name = "lstSrc";
            lstSrc.Size = new Size(182, 77);
            lstSrc.TabIndex = 12;
            // 
            // lstDes
            // 
            lstDes.BorderStyle = BorderStyle.FixedSingle;
            lstDes.FormattingEnabled = true;
            lstDes.ItemHeight = 25;
            lstDes.Items.AddRange(new object[] { "Amsterdam", "Ha Noi", "Singapore", "Beijing", "Tokyo", "Seoul" });
            lstDes.Location = new Point(183, 397);
            lstDes.Name = "lstDes";
            lstDes.Size = new Size(182, 77);
            lstDes.TabIndex = 13;
            // 
            // txtDate
            // 
            txtDate.BorderStyle = BorderStyle.FixedSingle;
            txtDate.Location = new Point(183, 497);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(182, 31);
            txtDate.TabIndex = 14;
            // 
            // cboClass
            // 
            cboClass.FormattingEnabled = true;
            cboClass.Items.AddRange(new object[] { "Economy", "Premium Economy", "Bussiness Class", "First Class" });
            cboClass.Location = new Point(183, 560);
            cboClass.Name = "cboClass";
            cboClass.Size = new Size(182, 33);
            cboClass.TabIndex = 15;
            // 
            // lstService
            // 
            lstService.BorderStyle = BorderStyle.FixedSingle;
            lstService.FormattingEnabled = true;
            lstService.Items.AddRange(new object[] { "Child Care", "Nurse" });
            lstService.Location = new Point(183, 626);
            lstService.Name = "lstService";
            lstService.Size = new Size(182, 58);
            lstService.TabIndex = 16;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(109, 714);
            button1.Name = "button1";
            button1.Size = new Size(108, 44);
            button1.TabIndex = 17;
            button1.Text = "Verify";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(257, 714);
            button2.Name = "button2";
            button2.Size = new Size(108, 44);
            button2.TabIndex = 18;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 782);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lstService);
            Controls.Add(cboClass);
            Controls.Add(txtDate);
            Controls.Add(lstDes);
            Controls.Add(lstSrc);
            Controls.Add(txtPassNum);
            Controls.Add(txtName);
            Controls.Add(txtTicketNum);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Flight Reservation Details";
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
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtTicketNum;
        private TextBox txtName;
        private TextBox txtPassNum;
        private ListBox lstSrc;
        private ListBox lstDes;
        private TextBox txtDate;
        private ComboBox cboClass;
        private CheckedListBox lstService;
        private Button button1;
        private Button button2;
    }
}
