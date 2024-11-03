using System;
using System.Data;
using Wisej.Web;

namespace Pharmacy.UC_Admin
{
    public partial class UC_UpdateUser : Wisej.Web.UserControl
    {
        function fn = new function();
        String query;
        public UC_UpdateUser()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String vaiTro = txtUserRole.Text;
            String tenNguoiDung = txtName.Text;
            String SoDienThoai = txtMobileNo.Text;
            String email = txtEmail.Text;
            String taikhoan=txtUserName.Text;
            String matkhau = txtPassword.Text;

            string query = "UPDATE users SET userRole = '" + vaiTro + "', name = '" + tenNguoiDung + "', mobile = '" + SoDienThoai + "',username='"+taikhoan+",password='" + matkhau + "' WHERE name = '" + tenNguoiDung + "'";
            fn.setData(query, "Cập Nhật Người Dùng Thành Công");
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                query = "select * from users where name= '" + txtName.Text + "'";
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMobileNo.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtUserName.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPassword.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("Không có người dùng có tên: " + txtName.Text + "tồn tại.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }
        }
        private void clearAll()
        {
            txtUserRole.ResetText();
            txtName.Clear();
            txtMobileNo.Clear();
            txtEmail.Clear();
            txtUserName.Clear();
            txtPassword.Clear();

        }
    }
}
