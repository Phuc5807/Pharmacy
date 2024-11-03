using System;
using System.Data;
using Wisej.Web;

namespace Pharmacy.UC_Admin
{
    public partial class UC_ViewUser : Wisej.Web.UserControl
    {
        function fn = new function();
        String query;
        String currentuser = "";
        public UC_ViewUser()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { currentuser = value; }
        }

        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username like'" + txtUsername.Text + "%'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        String username;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                username = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa người dùng này không ?", "Xác nhận đã xóa !", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (currentuser != username)
                {
                    query = "delete from users where username='" + username + "'";
                    fn.setData(query, "User Record Deleted");
                    UC_ViewUser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Bạn đang cố xóa \n Tài khoản của bạn.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }
    }
}
