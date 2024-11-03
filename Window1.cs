
using System;
using System.Data;
using Wisej.Web;

namespace Pharmacy
{
    public partial class Window1 : Form
    {
        function fn = new function();
        DataSet ds;
        String query;
        public Window1()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txtUserName.Text == "root" && txtPassword.Text == "root")
                {
                    Admin ad = new Admin();
                    ad.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where username='" + txtUserName.Text + "' and password='" + txtPassword.Text + "'";
                ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Administrator")
                    {
                        Admin ad = new Admin();
                        ad.Show();
                        this.Hide();
                    }
                    else if (role == "Nhan Vien")
                    {
                        NhanVien nv = new NhanVien();
                        nv.Show();
                        this.Hide();
                    }
                    else if (role == "Quan Ly")
                    {
                        QuanLy ql = new QuanLy();
                        ql.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }
    }
}
