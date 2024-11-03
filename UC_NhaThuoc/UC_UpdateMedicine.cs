using System;
using System.Data;
using Wisej.Web;

namespace Pharmacy.UC_NhaThuoc
{
    public partial class UC_UpdateMedicine : Wisej.Web.UserControl
    {
        function fn = new function();
        String query;
        public UC_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMedicineID.Text != "")
            {
                query = "select * from thuoc where medicine_id= '" + txtMedicineID.Text + "'";
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMedicineName.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtMedicineCategory.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtQuantity.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtPrice.Text = ds.Tables[0].Rows[0][8].ToString();
                    txtType.Text = ds.Tables[0].Rows[0][9].ToString();
                }
                else
                {
                    MessageBox.Show("Không có thuốc có mã: " + txtMedicineID.Text + "tồn tại.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }
        }
        private void clearAll()
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtMedicineCategory.ResetText();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtType.ResetBindings();
            if (txtAddQuantity.Text != "0")
            {
                txtAddQuantity.Text = "0";
            }
            else
            {
                txtAddQuantity.Text = "0";
            }
            if (txtDiscount.Text != "0")
            {
                txtDiscount.Text = "0";
            }
            else
            {
                txtDiscount.Text = "0";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        Int64 totalQuantity;
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String medicine_name = txtMedicineName.Text;
            String medicine_category = txtMedicineCategory.Text;
            Int64 medicine_quantity = Int64.Parse(txtQuantity.Text);
            Int64 addQuantity = Int64.Parse(txtAddQuantity.Text);
            Int64 unitPrice = Int64.Parse(txtPrice.Text);
            String medicine_Type = txtType.Text;
            Int64 discount= Int64.Parse(txtDiscount.Text);
            Int64 tax = Int64.Parse(txtTax.Text);
            totalQuantity = medicine_quantity + addQuantity; 
            string query = "UPDATE thuoc SET medicine_name = '" + medicine_name + "', medicine_category = '" + medicine_category + "',DonViTinh = '" + medicine_Type + "', quantity = '" + totalQuantity + "', price_per_unit = '" +unitPrice + "',discount='"+ discount + "',tax='"+ tax + "' WHERE medicine_id = '" + txtMedicineID + "'";
            fn.setData(query, "Cập Nhật Thuốc Thành Công");

        }
    }
}
