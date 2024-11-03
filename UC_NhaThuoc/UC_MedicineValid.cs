using System;
using System.Data;
using System.Drawing;
using Wisej.Web;

namespace Pharmacy.UC_NhaThuoc
{
    public partial class UC_MedicineValid : Wisej.Web.UserControl
    {
        function fn = new function();
        String query;
        public UC_MedicineValid()
        {
            InitializeComponent();
            HideMedicineImageColumn1();
            HideMedicineIDColumn1();
        }

        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideMedicineImageColumn1();
            HideMedicineIDColumn1();

            if (txtCheck.SelectedIndex == 0)
            {
                query = "select * from thuoc where expire_date >= GETDATE()";
                DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                SetLabel.Text = "Thuốc Còn Hạn";
                SetLabel.ForeColor = Color.Black;
            }
            else if (txtCheck.SelectedIndex == 1)
            {
                query = "select * from thuoc where expire_date <= GETDATE()";
                DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                SetLabel.Text = "Thuốc Hết Hạn";
                SetLabel.ForeColor = Color.Red;

            }
            else if (txtCheck.SelectedIndex == 2)
            {
                query = "select * from thuoc";
                DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                SetLabel.Text = "Tất Cả Thuốc";
                SetLabel.ForeColor = Color.Black;
            }
        }
        private void HideMedicineImageColumn1()
        {
            if (guna2DataGridView1.Columns.Contains("medicine_image"))
            {
                guna2DataGridView1.Columns["medicine_image"].Visible = false;
            }
        }
        private void HideMedicineIDColumn1()
        {
            if (guna2DataGridView1.Columns.Contains("id"))
            {
                guna2DataGridView1.Columns["id"].Visible = false;
            }
        }
    }
}
