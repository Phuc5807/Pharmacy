using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using Wisej.Web;

namespace Pharmacy.UC_NhaThuoc
{
    public partial class UC_SellMedicine : Wisej.Web.UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;

        public UC_SellMedicine()
        {
            InitializeComponent();
            txtExpireDate.Format = DateTimePickerFormat.Custom;
            txtExpireDate.CustomFormat = "yyyy/MM/dd"; // Định dạng ngày tháng năm

            
        }

        private void UC_Pharmacist_SellMedicine_Load(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "SELECT medicine_name FROM thuoc WHERE expire_date >= GETDATE() AND quantity > 0";
            ds = fn.GetData(query);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                listBoxMedicines.Items.Add(row["medicine_name"].ToString());
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_Pharmacist_SellMedicine_Load(this, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "SELECT medicine_name FROM thuoc WHERE medicine_name LIKE @searchText AND expire_date >= GETDATE() AND quantity > 0";
            ds = fn.GetData(query);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                listBoxMedicines.Items.Add(row["medicine_name"].ToString());
            }
        }

        private void listBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            string name = listBoxMedicines.GetItemText(listBoxMedicines.SelectedItem);
            txtMedicineName.Text = name;
            query = "SELECT medicine_id, expire_date, price_per_unit FROM thuoc WHERE medicine_name = '" + name + "'";
            ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                txtMedicineID.Text = row["medicine_id"].ToString();

                // Parse the date to ensure it's in a valid format
                if (DateTime.TryParse(row["expire_date"].ToString(), out DateTime expireDate))
                {
                    txtExpireDate.Text = expireDate.ToString("yyyy/MM/dd"); // Format as needed
                }
                else
                {
                    txtExpireDate.Text = string.Empty; // Clear the text if parsing fails
                }

                txtPricePerUnit.Text = row["price_per_unit"].ToString();
            }
        }

        private void txtNoofUnits_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNoofUnits.Text, out int noOfUnits) && decimal.TryParse(txtPricePerUnit.Text, out decimal unitPrice))
            {
                decimal totalAmount = unitPrice * noOfUnits;
                txtTotalPrice.Text = totalAmount.ToString();
            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        protected int n;
        protected int totalAmount = 0;
        protected Int64 quantity, newQuantity;

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMedicineID.Text) && int.TryParse(txtNoofUnits.Text, out int noOfUnits))
            {
                query = "SELECT quantity FROM thuoc WHERE medicine_id = '" + txtMedicineID.Text + "'";
                ds = fn.GetData(query);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    quantity = Int64.Parse(ds.Tables[0].Rows[0]["quantity"].ToString());
                    newQuantity = quantity - noOfUnits;

                    if (newQuantity >= 0)
                    {
                        n = guna2DataGridView1.Rows.Add();
                        guna2DataGridView1.Rows[n].Cells[0].Value = txtMedicineID.Text;
                        guna2DataGridView1.Rows[n].Cells[1].Value = txtMedicineName.Text;
                        guna2DataGridView1.Rows[n].Cells[2].Value = txtExpireDate.Text;
                        guna2DataGridView1.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
                        guna2DataGridView1.Rows[n].Cells[4].Value = txtNoofUnits.Text;
                        guna2DataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;

                        totalAmount += int.Parse(txtTotalPrice.Text);

                        query = "UPDATE thuoc SET quantity = '" + newQuantity + "' where medicine_id= '" + txtMedicineID.Text + "'";
                        fn.setData(query, "Medicine Added.");
                    }
                    else
                    {
                        MessageBox.Show("Thuốc đã hết hàng. \n Chỉ còn " + quantity + " thuốc", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    clearAll();
                    UC_Pharmacist_SellMedicine_Load(this, null);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thuốc muốn mua", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected void clearAll()
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtExpireDate.ResetText();
            txtPricePerUnit.Clear();
            txtNoofUnits.Clear();
            txtTotalPrice.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = guna2DataGridView1.SelectedRows[0].Index;
                var valueID = guna2DataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                var noOfUnit = Int64.Parse(guna2DataGridView1.Rows[rowIndex].Cells[4].Value.ToString());

               

                query = "SELECT quantity FROM thuoc WHERE medicine_id = '" + valueID + "'";
                ds = fn.GetData(query);
                quantity = Int64.Parse(ds.Tables[0].Rows[0]["quantity"].ToString());
                newQuantity = quantity + noOfUnit;

                query = "UPDATE thuoc SET quantity = '" + newQuantity + "' WHERE medicine_id = '" + valueID + "'";
                fn.setData(query, "Đã xóa thuốc ra giỏ hàng");

                UC_Pharmacist_SellMedicine_Load(this, null);
            }
        }

        private void btnPurchasePrint_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.Rows.Count > 0)
            {
                // Confirmation with options for print settings
                DialogResult dialogResult = MessageBox.Show(
                 "Bạn muốn tùy chỉnh cài đặt in hay in trực tiếp?",
                  "Xác nhận in",
                  MessageBoxButtons.YesNoCancel,
                  MessageBoxIcon.Question
                );

                if (dialogResult == DialogResult.Yes)
                {
                    PrintDocument doc = new PrintDocument();
                    doc.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);
                    doc.PrintPage += new PrintPageEventHandler(this.OnPrintPage);
                    doc.Print();
                }
                else if (dialogResult == DialogResult.No)
                {
                    // Create a new Wisej.PrintDocument object with default settings
                    PrintDocument doc = new PrintDocument();
                    doc.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);
                    doc.PrintPage += new PrintPageEventHandler(this.OnPrintPage);
                    doc.Print();
                }
                else
                {
                    // User cancelled printing
                }
                guna2DataGridView1.Rows.Clear();
                totalAmount = 0;
            }
            else
            {
                MessageBox.Show("Không có thuốc nào trong giỏ hàng để in.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OnPrintPage(object sender, PrintPageEventArgs e)
        {
            // Define font and styles for the receipt
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font itemFont = new Font("Arial", 12, FontStyle.Regular);

            // Print shop name or logo (optional)
            // e.Graphics.DrawImage(/* Your logo image here */, new Point(50, 25));

            // Print shop name or title
            e.Graphics.DrawString("Hóa Đơn Của Bạn", headerFont, Brushes.Black, new Point(100, 50));

            // Print date and time
            e.Graphics.DrawString(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), itemFont, Brushes.Black, new Point(50, 80));

            // Print header row for items (Medicine Name, Expire Date, Price, Quantity, Total)
            int yPosition = 110;
            e.Graphics.DrawString("Medicine Name", itemFont, Brushes.Black, new Point(50, yPosition));
            e.Graphics.DrawString("Expire Date", itemFont, Brushes.Black, new Point(250, yPosition));
            e.Graphics.DrawString("Price", itemFont, Brushes.Black, new Point(350, yPosition));
            e.Graphics.DrawString("Qty", itemFont, Brushes.Black, new Point(420, yPosition));
            e.Graphics.DrawString("Total", itemFont, Brushes.Black, new Point(480, yPosition));
            yPosition += 15;

            // Print each item from the DataGridView
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                e.Graphics.DrawString(row.Cells[1].Value.ToString(), itemFont, Brushes.Black, new Point(50, yPosition));
                e.Graphics.DrawString(row.Cells[2].Value.ToString(), itemFont, Brushes.Black, new Point(250, yPosition));
                e.Graphics.DrawString(row.Cells[3].Value.ToString(), itemFont, Brushes.Black, new Point(350, yPosition));
                e.Graphics.DrawString(row.Cells[4].Value.ToString(), itemFont, Brushes.Black, new Point(420, yPosition));
                e.Graphics.DrawString(row.Cells[5].Value.ToString(), itemFont, Brushes.Black, new Point(480, yPosition));
                yPosition += 15;

                // Check for page break if content overflows
                if (yPosition >= e.PageBounds.Height - 40)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
        }
        int valueAmount;
        String valueID;
        Int64 noOfUnit;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueID = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfUnit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception) { }
        }
    }
}
