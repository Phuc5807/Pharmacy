using Pharmacy.UC_NhaThuoc;
using System;
using Wisej.Web;

namespace Pharmacy
{
    public partial class QuanLy : Form
    {
        UC_AddMedicine addMedicine = new UC_AddMedicine();
        UC_MedicineCate cateMedicine = new UC_MedicineCate();
        UC_MedicineList listMedicine = new UC_MedicineList();
        UC_UpdateMedicine updateMedicine = new UC_UpdateMedicine();
        UC_InvoiceManager invoiceManager = new UC_InvoiceManager();
        public QuanLy()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Show
            panel3.Controls.Add(addMedicine);
            addMedicine.Show();
            //Hide
            cateMedicine.Hide();
            listMedicine.Hide();
            updateMedicine.Hide();
            invoiceManager.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //Show
            panel3.Controls.Add(listMedicine);
            listMedicine.Show();
            //Hide
            addMedicine.Hide();
            cateMedicine.Hide();
            updateMedicine.Hide();
            invoiceManager.Hide();
        }

        private void btnCate_Click(object sender, EventArgs e)
        {
            //Show
            panel3.Controls.Add(cateMedicine);
            cateMedicine.Show();
            //Hide
            addMedicine.Hide();
            listMedicine.Hide();
            updateMedicine.Hide();
            invoiceManager.Hide();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //Show
            panel3.Controls.Add(updateMedicine);
            updateMedicine.Show();
            //Hide
            listMedicine.Hide();
            addMedicine.Hide();
            cateMedicine.Hide();
            invoiceManager.Hide();
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
            panel3.Controls.Add(invoiceManager);
            invoiceManager.Show();
            //Hide
            listMedicine.Hide();
            addMedicine.Hide();
            cateMedicine.Hide();
            updateMedicine.Hide();
        }
    }
}
