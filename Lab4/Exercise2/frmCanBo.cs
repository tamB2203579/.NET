using Lab4;
using MySql.Data.MySqlClient;
using System.Data;

namespace Exercise2
{
    public partial class frmCanBo : Form
    {
        int CodeNo;
        public frmCanBo()
        {
            InitializeComponent();
            LoadChucVuCombobox();
        }

        private void LoadChucVuCombobox()
        {
            try
            {
                ClassConnection.Open();
                string query = "select * from ChucVu";
                MySqlCommand command = new MySqlCommand(query, ClassConnection.mySqlConnection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                cboChucVu.DataSource = dataTable;
                cboChucVu.DisplayMember = "TenCV";
                cboChucVu.ValueMember = "MaCV";
                cboChucVu.SelectedIndex = -1;
                ClassConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        public void ResetFields(bool status)
        {
            txtMaSo.Clear();
            txtHoTen.Clear();
            cboChucVu.SelectedIndex = -1;
            txtSoGio.Clear();
            txtDonGia.Clear();
            btnSave.Enabled = status;
            btnAdd.Enabled = !status;
            txtHoTen.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ClassConnection.Open();
                MySqlCommand mysqlcommand = new MySqlCommand("Select Max(MaCB) from CanBo", ClassConnection.mySqlConnection);
                CodeNo = Convert.ToInt32(mysqlcommand.ExecuteScalar());
                ClassConnection.Close();
            }
            catch (Exception)
            {
                CodeNo = 0;
            }
            CodeNo++;
            ResetFields(true);
            txtMaSo.Text = CodeNo.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "insert into CanBo values(@MaCB, @HoTen, @MaCV, @Hours, @Price)";
                ClassConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(strInsert, ClassConnection.mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@MaCB", CodeNo);
                mySqlCommand.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                mySqlCommand.Parameters.AddWithValue("@MaCV", cboChucVu.SelectedValue);
                mySqlCommand.Parameters.AddWithValue("@Hours", txtSoGio.Text);
                mySqlCommand.Parameters.AddWithValue("@Price", txtDonGia.Text);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
