using Pharmacy.UC_NhaThuoc;
using System;
using Wisej.Web;

namespace Pharmacy
{
    public partial class NhanVien : Form
    {
        UC_MedicineList listMedicine=new UC_MedicineList();
        UC_MedicineCate cateMedicine=new UC_MedicineCate();
        UC_MedicineValid validMedicine=new UC_MedicineValid();
        UC_SellMedicine sellMedicine=new UC_SellMedicine();
        UC_InvoiceManager invoiceManager = new UC_InvoiceManager();
        UC_AddInvoice addInvoice=new UC_AddInvoice();
        public NhanVien()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //Show
            panel2.Controls.Add(listMedicine);
            listMedicine.Show();
            //Hide
            cateMedicine.Hide();
            validMedicine.Hide();
            sellMedicine.Hide();
            invoiceManager.Hide();
            addInvoice.Hide();
        }

        private void btnCate_Click(object sender, EventArgs e)
        {
            //Show
            panel2.Controls.Add(cateMedicine);
            cateMedicine.Show();
            //Hide
            listMedicine.Hide();
            validMedicine.Hide();
            sellMedicine.Hide();
            invoiceManager.Hide();
            addInvoice.Hide();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Show
            panel2.Controls.Add(validMedicine);
            validMedicine.Show();
            //Hide
            listMedicine.Hide();
            cateMedicine.Hide();
            sellMedicine.Hide();
            invoiceManager.Hide();
            addInvoice.Hide();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            //Show
            panel2.Controls.Add(sellMedicine);
            sellMedicine.Show();
            //Hide
            listMedicine.Hide();
            cateMedicine.Hide();
            validMedicine.Hide();
            invoiceManager.Hide();
            addInvoice.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Window1 fm = new Window1();
            fm.Show();
            this.Hide();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            //Show
            panel2.Controls.Add(invoiceManager);
            invoiceManager.Show();
            //Hide
            listMedicine.Hide();
            sellMedicine.Hide();
            cateMedicine.Hide();
            validMedicine.Hide();
            addInvoice.Hide();
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            //Show
            panel2.Controls.Add(addInvoice);
            addInvoice.Show();
            //Hide
            listMedicine.Hide();
            sellMedicine.Hide();
            cateMedicine.Hide();
            validMedicine.Hide();
            invoiceManager.Hide();
        }
    }
}
