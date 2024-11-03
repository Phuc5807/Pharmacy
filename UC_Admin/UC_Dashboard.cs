using System;
using System.Data;
using Wisej.Web;

namespace Pharmacy.UC_Admin
{
    public partial class UC_Dashboard : Wisej.Web.UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_Dashboard_Load(object sender, System.EventArgs e)
        {
            query = "select count(userRole) from users where userRole ='Administrator'";
            ds = fn.GetData(query);
            setLabel(ds, AdminLabel);

            query = "select count(userRole) from users where userRole ='Quan Ly'";
            ds = fn.GetData(query);
            setLabel(ds, QuanLyLabel);

            query = "select count(userRole) from users where userRole ='Nhan Vien'";
            ds = fn.GetData(query);
            setLabel(ds, NhanVienLabel);
        }
        private void setLabel(DataSet ds, Wisej.Web.Label label)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                label.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                label.Text = "0";
            }
        }

        private void btnSync_Click(object sender, System.EventArgs e)
        {
            UC_Dashboard_Load(this, null);
        }

        
    }
}
