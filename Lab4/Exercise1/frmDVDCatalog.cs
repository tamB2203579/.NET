using MySql.Data.MySqlClient;

namespace Lab4
{
    public partial class frmDVDCatalog : Form
    {
        int CodeNo;
        decimal price;
        string language;
        int subTitle;
        public frmDVDCatalog()
        {
            InitializeComponent();
        }

        public void ResetFields(bool status)
        {
            txtNo.Clear();
            txtTitle.Clear();
            cboLang.SelectedIndex = -1;
            updPrice.Value = updPrice.Minimum;
            radYes.Checked = true;
            radNo.Checked = false;
            btnSave.Enabled = status;
            btnCancel.Enabled = status;
            btnAdd.Enabled = !status;
            txtTitle.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ClassConnection.Open();
                MySqlCommand mysqlcommand = new MySqlCommand("Select Max(DVDCodeNo) from DVDs", ClassConnection.mySqlConnection);
                CodeNo = Convert.ToInt32(mysqlcommand.ExecuteScalar());
                ClassConnection.Close();
            }
            catch (Exception)
            {
                CodeNo = 0;
            }
            CodeNo++;
            ResetFields(true);
            txtNo.Text = CodeNo.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFields(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "insert into DVDs values(@DVDNo, @DVDTitle, @DVDLang, @SubTitle, @Price)";
                ClassConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(strInsert, ClassConnection.mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@DVDNo", CodeNo);
                mySqlCommand.Parameters.AddWithValue("@DVDTitle", txtTitle.Text);
                mySqlCommand.Parameters.AddWithValue("@DVDLang", language);
                mySqlCommand.Parameters.AddWithValue("@SubTitle", subTitle);
                mySqlCommand.Parameters.AddWithValue("@Price", price);
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Insert successfully!!!");
                ClassConnection.Close();
                ResetFields(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLang.SelectedIndex == -1) return;
            language = cboLang.Text;
        }

        private void updPrice_ValueChanged(object sender, EventArgs e)
        {
            price = updPrice.Value;
        }

        private void radYes_CheckedChanged(object sender, EventArgs e)
        {
            subTitle = 1;
        }

        private void radNo_CheckedChanged(object sender, EventArgs e)
        {
            subTitle = 0;
        }
    }
}
