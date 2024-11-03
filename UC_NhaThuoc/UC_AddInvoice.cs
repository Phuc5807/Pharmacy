using System;
using Wisej.Web;

namespace Pharmacy.UC_NhaThuoc
{
    public partial class UC_AddInvoice : Wisej.Web.UserControl
    {
        function fn = new function();
        String query;
        public UC_AddInvoice()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
           txtInvoiceID.Clear();
           txtInvoiceTime.ResetBindings();
           txtTotalPrice.Clear();
           txtExcessMoney.Clear();
           txtQuanity.Clear();
           txtDiscount.Clear();
           txtTax.Clear();
           txtTotalInvoice.Clear();
           txtNameStaff.Clear();
           txtNameCustomer.Clear();
           txtMobileNumber.Clear();
           txtCustomerPay.Clear();

        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            if (txtInvoiceID.Text != ""
                && txtInvoiceTime.Text != ""
                && txtTotalPrice.Text != ""
                && txtExcessMoney.Text != ""
                && txtQuanity.Text != ""
                && txtDiscount.Text != ""
                && txtTax.Text != ""
                && txtTotalInvoice.Text != ""
                && txtNameStaff.Text != ""
                && txtNameCustomer.Text != ""
                && txtMobileNumber.Text != ""
                && txtCustomerPay.Text != "")
            {
                String invoice_ID = txtInvoiceID.Text;
                String invoice_Time = txtInvoiceTime.Text;
                String totalPrice = txtTotalPrice.Text;
                String excessMoney = txtExcessMoney.Text;
                Int64 quantity = Int64.Parse(txtQuanity.Text);
                Double tax = Double.Parse(txtTax.Text);
                Double discount = Double.Parse(txtDiscount.Text);
                Double totalInvoice = Double.Parse(txtTotalInvoice.Text);
                String name_staff = txtNameStaff.Text;
                String name_customer = txtNameCustomer.Text;
                String mobileNumber = txtMobileNumber.Text;
                Double customer_pay = Double.Parse(txtCustomerPay.Text);

                query = "insert into HOADON (ID_HD, Time_HD, payout, excess_money, quantity, tax_total_hd, discount_money_hd, money_total_hd, name_staff, name_cus, phone_number, payout_cus)" +
                    " values('" + invoice_ID
                    + "','"
                    + invoice_Time
                    + "','"
                    + totalPrice
                    + "','"
                    + excessMoney
                    + "','"
                    + quantity
                    + "','"
                    + tax
                    + "','"
                    + discount
                    + "','"
                    + totalInvoice
                    + "','"
                    + name_staff
                    + "','"
                    + name_customer
                    + "','"
                    + mobileNumber
                    + "','"
                    + customer_pay + "')";

                fn.setData(query, "Thêm hóa Đơn Thành Công");
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ dữ liệu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
