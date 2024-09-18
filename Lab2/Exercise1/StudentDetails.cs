namespace Exercise1
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int cnt = lstHob.CheckedItems.Count;
            string hobby = "";
            for (int i = 0; i < cnt; i++)
            {
                hobby += lstHob.CheckedItems[i];
                if (i < cnt - 1)
                {
                    hobby += ", ";
                }
            }
            MessageBox.Show(txtName.Text + " born in " + txtYear.Text + " from class " + lstClass.Text + " , Division " + cboDiv.Text + " has following hobbies " + hobby);
        }

        private void btnClear_Click(object sender, EventArgs e) {
            txtName.Text = "";
            txtYear.Text = "";
            lstClass.ClearSelected();
            cboDiv.Text = "";
            lstHob.ClearSelected();
            for (int i = 0; i < lstHob.Items.Count; i++) {
                if (lstHob.GetItemChecked(i))
                    lstHob.SetItemChecked(i, false);
            }
        }
    }
}
