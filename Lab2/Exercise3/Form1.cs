namespace Exercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (lstSrc.SelectedItem != null && lstDes.SelectedItem != null) {
                if (lstSrc.SelectedItem.ToString() == lstDes.SelectedItem.ToString()) {
                    MessageBox.Show("Error Occurred! The starting and destination must be different.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Please select items in both the source and destination lists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            txtTicketNum.Text = "";
            txtName.Text = "";
            txtPassNum.Text = "";
            lstSrc.ClearSelected();
            lstDes.ClearSelected();
            txtDate.Text = "";
            cboClass.Text = "";
            for (int i = 0; i < lstService.Items.Count; i++) {
                if (lstService.GetItemChecked(i))
                    lstService.SetItemChecked(i, false);
            }
        }
    }
}
