using System;
using System.Data;
using Wisej.Web;

namespace Pharmacy.UC_Admin
{
    public partial class UC_AddUser : Wisej.Web.UserControl
    {
        function fn = new function();
        String query;
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, System.EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String Dob = txtDOB.Text;
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            String email = txtEmail.Text;
            String username = txtUserName.Text;
            String password = txtPassword.Text;

            try
            {
                query = "insert into users(userRole,name,dob,mobile,email,username,password) values ('" + role + "','" + name + "','" + Dob + "','" + mobile + "','" + email + "','" + username + "','" + password + "')";
                fn.setData(query, "Đăng Nhập Thành Công");

            }
            catch (Exception)
            {
                MessageBox.Show("Tài khoản đã tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
        public void clearAll()
        {
            txtName.Clear();
            txtDOB.ResetText();
            txtMobileNo.Clear();
            txtEmail.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserRole.SelectedIndex = -1;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username='" + txtUserName.Text + "'";
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageSource = @"C:\\Users\\Admin\\Desktop\\PharmacyManagement\\Image\\yes.png";

            }
            else
            {
                pictureBox1.ImageSource = @"C:\\Users\\Admin\\Desktop\\PharmacyManagement\\Image\\no.png";
            }
        }
    }
}

