using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using Wisej.Web;

namespace Pharmacy.UC_NhaThuoc
{
    public partial class UC_MedicineList : Wisej.Web.UserControl
    {
        function fn = new function();
        String query;
        public UC_MedicineList()
        {
            InitializeComponent();
            HideMedicineImageColumn();
            HideMedicineIDColumn();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from thuoc where medicine_name like '" + txtSearch.Text + "%'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            LoadImagesIntoGrid(ds);
        }

        private void LoadImagesIntoGrid(DataSet ds)
        {
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                try
                {
                    var cellValue = row.Cells["medicine_image"].Value;
                    if (cellValue != null)
                    {
                        string imgPath = cellValue.ToString();
                        if (System.IO.File.Exists(imgPath))
                        {
                            row.Cells["ImageColumn"].Value = Image.FromFile(imgPath);
                        }
                        else
                        {
                            row.Cells["ImageColumn"].Value = null; // Handle invalid image path
                        }
                    }
                    else
                    {
                        row.Cells["ImageColumn"].Value = null; // Handle null image path
                    }
                }
                catch
                {
                    row.Cells["ImageColumn"].Value = null; // Handle exceptions
                }
            }
        }

        private void UC_Pharmacist_ViewMedicine_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            guna2DataGridView1.RowTemplate.Height = 100; // Adjust to the image size

            query = "select * from thuoc";
            setDataGridView(query);
        }

        private void setDataGridView(String query)
        {
            DataSet ds = fn.GetData(query);

            // Add an image column to the DataGridView
            if (!guna2DataGridView1.Columns.Contains("ImageColumn"))
            {
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.Name = "ImageColumn";
                imgColumn.HeaderText = "Hình Ảnh Thuốc";
                imgColumn.CellImageLayout = DataGridViewImageCellLayout.Zoom;
                guna2DataGridView1.Columns.Add(imgColumn);
            }

            // Bind data from dataset to DataGridView
            guna2DataGridView1.DataSource = ds.Tables[0];

            // Load images from paths
            LoadImagesIntoGrid(ds);

            // Hide columns that shouldn't be visible
            HideMedicineImageColumn();
        }

        private void HideMedicineImageColumn()
        {
            if (guna2DataGridView1.Columns.Contains("medicine_image"))
            {
                guna2DataGridView1.Columns["medicine_image"].Visible = false;
            }
        }

        private void HideMedicineIDColumn()
        {
            if (guna2DataGridView1.Columns.Contains("id"))
            {
                guna2DataGridView1.Columns["id"].Visible = false;
            }
        }

        String medicineID;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineID = guna2DataGridView1.Rows[e.RowIndex].Cells["medicine_id"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(medicineID))
            {
                if (MessageBox.Show("Are You Sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from thuoc where medicine_id='" + medicineID + "'";
                    fn.setData(query, "Medicine Record Deleted.");
                    UC_Pharmacist_ViewMedicine_Load(this, null);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thuốc để xóa.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_Pharmacist_ViewMedicine_Load(this, null);
        }
    }
}
