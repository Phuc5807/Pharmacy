using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using Wisej.Web;

namespace Pharmacy.UC_NhaThuoc
{
    public partial class UC_InvoiceManager : Wisej.Web.UserControl
    {
        function fn = new function();
        String query;
        public UC_InvoiceManager()
        {
            InitializeComponent();
        }
        private void UC_InvoiceManager_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            guna2DataGridView1.RowTemplate.Height = 100; // Adjust to the image size

            query = "select * from HOADON";
            setDataGridView(query);
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from HOADON where name_cus like '" + txtSearch.Text + "%'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            
        }
        private void setDataGridView(String query)
        {
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        String InvoiceID;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                InvoiceID = guna2DataGridView1.Rows[e.RowIndex].Cells["ID_HD"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(InvoiceID))
            {
                if (MessageBox.Show("Are You Sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from HOADON where ID_HD='" + InvoiceID + "'";
                    fn.setData(query, "Đã Xóa Hóa Đơn.");
                    UC_InvoiceManager_Load(this, null);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn Hóa Đơn để xóa.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void btnSync_Click(object sender, EventArgs e)
        {
        UC_InvoiceManager_Load(this, null);
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
            int yPosition = 110;
            int zPosition = 220;
            int tPosition = 330;
            e.Graphics.DrawString("Thời Gian Thanh Toán", itemFont, Brushes.Black, new Point(50, yPosition));
            e.Graphics.DrawString("Tên Khách Hàng", itemFont, Brushes.Black, new Point(250, yPosition));
            e.Graphics.DrawString("Số Lượng", itemFont, Brushes.Black, new Point(50, zPosition));
            e.Graphics.DrawString("Tổng Tiền", itemFont, Brushes.Black, new Point(200, zPosition));
            e.Graphics.DrawString("Giảm Giá", itemFont, Brushes.Black, new Point(350, zPosition));
            e.Graphics.DrawString("Thuế", itemFont, Brushes.Black, new Point(500, zPosition));
            e.Graphics.DrawString("Tổng Tiền Thanh Toán", itemFont, Brushes.Black, new Point(50, tPosition));
            e.Graphics.DrawString("Khách Hàng Thanh Toán", itemFont, Brushes.Black, new Point(400, yPosition));
            e.Graphics.DrawString("Số Tiền Thối", itemFont, Brushes.Black, new Point(250, tPosition));
            yPosition += 50;
            zPosition += 50;
            tPosition += 50;

            // Print each selected item from the DataGridView
            foreach (DataGridViewRow row in guna2DataGridView1.SelectedRows)
            {
                e.Graphics.DrawString(row.Cells["Time_HD"].Value.ToString(), itemFont, Brushes.Black, new Point(50, yPosition));
                e.Graphics.DrawString(row.Cells["name_cus"].Value.ToString(), itemFont, Brushes.Black, new Point(250, yPosition));
                e.Graphics.DrawString(row.Cells["quantity"].Value.ToString(), itemFont, Brushes.Black, new Point(50, zPosition));
                e.Graphics.DrawString(row.Cells["money_total_hd"].Value.ToString(), itemFont, Brushes.Black, new Point(200, zPosition));
                e.Graphics.DrawString(row.Cells["discount_money_hd"].Value.ToString(), itemFont, Brushes.Black, new Point(350, zPosition));
                e.Graphics.DrawString(row.Cells["tax_total_hd"].Value.ToString(), itemFont, Brushes.Black, new Point(500, zPosition));
                e.Graphics.DrawString(row.Cells["payout"].Value.ToString(), itemFont, Brushes.Black, new Point(50, tPosition));
                e.Graphics.DrawString(row.Cells["payout_cus"].Value.ToString(), itemFont, Brushes.Black, new Point(400, yPosition));
                e.Graphics.DrawString(row.Cells["excess_money"].Value.ToString(), itemFont, Brushes.Black, new Point(250, tPosition));
                yPosition += 50;
                zPosition += 50;
                tPosition += 50;


            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                // Confirmation with options for print settings
                DialogResult dialogResult = MessageBox.Show(
                    "Bạn muốn tùy chỉnh cài đặt in hay in trực tiếp?",
                    "Xác nhận in",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );

                if (dialogResult == DialogResult.Yes || dialogResult == DialogResult.No)
                {
                    PrintDocument doc = new PrintDocument();
                    doc.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);
                    doc.PrintPage += new PrintPageEventHandler(this.OnPrintPage);
                    doc.Print();
                }
                else
                {
                    // User cancelled printing
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn cột để in.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}        

