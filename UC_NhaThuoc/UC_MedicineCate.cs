using System;
using System.Data;
using System.Drawing;
using Wisej.Web;

namespace Pharmacy.UC_NhaThuoc
{
    public partial class UC_MedicineCate : Wisej.Web.UserControl
    {
        function fn = new function();
        String query;
        public UC_MedicineCate()
        {
            InitializeComponent();
            HideMedicineImageColumn2();
            HideMedicineIDColumn2();
        }

        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds;
            HideMedicineImageColumn2();
            HideMedicineIDColumn2();

            if (txtCheck.SelectedIndex == 0)
            {
                query = "select * from thuoc where medicine_category = 'Khang Sinh'";
                ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                SetLabel.Text = "Thuốc Kháng Sinh";
                SetLabel.ForeColor = Color.Black;
            }
            else if (txtCheck.SelectedIndex == 1)
            {
                query = "select * from thuoc where medicine_category = 'Giam Dau'";
                ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                SetLabel.Text = "Thuốc Giảm Đau";
                SetLabel.ForeColor = Color.Black;

            }
            else if (txtCheck.SelectedIndex == 2)
            {
                query = "select * from thuoc where medicine_category = 'Giam Ho'";
                ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                SetLabel.Text = "Thuốc Giảm Ho";
                SetLabel.ForeColor = Color.Black;

            }
            else if (txtCheck.SelectedIndex == 3)
            {
                query = "select * from thuoc where medicine_category = 'Chong Co Giat'";
                ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                SetLabel.Text = "Thuốc Chống Co Giật";
                SetLabel.ForeColor = Color.Black;

            }
            else if (txtCheck.SelectedIndex == 4)
            {
                query = "select * from thuoc where medicine_category = 'Dieu Tri Tang Huyet Ap";
                ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                SetLabel.Text = "Thuốc Điều Trị Tăng Huyết Áp";
                SetLabel.ForeColor = Color.Black;

            }
            else if (txtCheck.SelectedIndex == 5)
            {
                query = "select * from thuoc";
                ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                SetLabel.Text = "Tất Cả Thuốc";
                SetLabel.ForeColor = Color.Black;
            }

        }

        private void HideMedicineImageColumn2()
        {
            if (guna2DataGridView1.Columns.Contains("medicine_image"))
            {
                guna2DataGridView1.Columns["medicine_image"].Visible = false;
            }
        }
        private void HideMedicineIDColumn2()
        {
            if (guna2DataGridView1.Columns.Contains("id"))
            {
                guna2DataGridView1.Columns["id"].Visible = false;
            }
        }
    }
}

