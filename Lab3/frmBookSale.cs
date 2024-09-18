namespace Lab3
{
    public partial class frmBookSale : Form
    {
        private clsBookSale mBookSale;
        public frmBookSale()
        {
            InitializeComponent();
        }

        private void mnuCal_Click(object sender, EventArgs e)
        {
            try
            {
                mBookSale = new clsStudentBookSale(txtTitle.Text, Convert.ToInt32(txtQuan.Text), Convert.ToDecimal(txtPrice.Text), chkDis.Checked, chkDisStudent.Checked);

                txtPrice.Text = mBookSale.Price.ToString("C");
                lblEPrice.Text = mBookSale.ExtendedPrice().ToString("C");
                lblDis.Text = mBookSale.DiscountAmount().ToString("C");
                lblNetDue.Text = mBookSale.NetDue().ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Quantity or Price." + ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtQuan.Text = "";
            txtPrice.Text = "";
            lblEPrice.Text = "";
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuSum_Click(object sender, EventArgs e)
        {
            string strMessage = "Sales Total: " + clsBookSale.SalesTotal.ToString("C")
                + "\nSales Count: " + clsBookSale.SalesCount.ToString();
            MessageBox.Show(strMessage, "Summary Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
