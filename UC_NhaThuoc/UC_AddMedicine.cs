using System;
using System.Drawing;
using System.IO;
using System.Net;
using Wisej.Web;

namespace Pharmacy.UC_NhaThuoc
{
    public partial class UC_AddMedicine : Wisej.Web.UserControl
    {
        function fn = new function();
        String query;
        public UC_AddMedicine()
        {
            InitializeComponent();

            txtManufacturingDate.Format = DateTimePickerFormat.Custom;
            txtManufacturingDate.CustomFormat = "yyyy/MM/dd"; // Định dạng ngày tháng năm

            txtExpireDate.Format = DateTimePickerFormat.Custom;
            txtExpireDate.CustomFormat = "yyyy/MM/dd"; // Định dạng ngày tháng năm

            // Configure OpenFileDialog for image selection
            

        }

        public void clearAll()
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtQuanity.Clear();
            txtMedicineCate.ResetText();
            txtManufacturingDate.ResetText();
            txtExpireDate.ResetText();
            imageMedicine.ResetText();
            txtPrice.Clear();
            txtType.ResetBindings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String medicineImage = "";
            try
            {
                Upload fileUploader = new Upload();
                fileUploader.AllowedFileTypes = "image/jpg, image/jpeg, image/png";
                fileUploader.Uploaded += FileUploader_Uploaded;
                fileUploader.UploadFiles();
                medicineImage = fileUploader.ImageSource;
                imageMedicine.ImageSource = medicineImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FileUploader_Uploaded(object sender, UploadedEventArgs e)
        {
            if (e.Files.Count > 0)
            {
                var file = e.Files[0];
                var imageStream = file.InputStream;

                // Tải hình ảnh từ luồng
                var image = Image.FromStream(imageStream);
                imageMedicine.Image = image;
            }
            else
            {
                MessageBox.Show("Không có tệp nào được tải lên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtMedicineID.Text != "" && txtMedicineCate.Text != "" && txtMedicineName.Text != "" && txtQuanity.Text != "" && txtPrice.Text != "")
            {
                String image = imageMedicine.ImageSource;
                String medicine_ID = txtMedicineID.Text;
                String medicine_cate = txtMedicineCate.Text;
                String medicine_name = txtMedicineName.Text;
                String manufacturingdate = txtManufacturingDate.Text;
                String expireDate = txtExpireDate.Text;
                String medicine_Type = txtType.Text;
                Double quantity = Double.Parse(txtQuanity.Text);
                Double price = Double.Parse(txtPrice.Text);
                Double tax = String.IsNullOrEmpty(txtTax.Text) ? 0 : Double.Parse(txtTax.Text);
                Double discount = String.IsNullOrEmpty(txtDiscount.Text) ? 0 : Double.Parse(txtDiscount.Text);
                query = "insert into thuoc (medicine_image," +
                    "medicine_id," +
                    "medicine_category," +
                    "DonViTinh," +
                    "medicine_name," +
                    "manufacturing_date," +
                    "expire_date,quantity," +
                    "price_per_unit, " +
                    "tax, " +
                    "discount)" +
                    " values('" + image + "','" + medicine_ID + "','" + medicine_cate + "','" + medicine_Type + "','" + medicine_name + "','" + manufacturingdate + "','" + expireDate + "','" + quantity + "','" + price + "','" + tax + "','" + discount + "')";
                fn.setData(query, "Thêm thuốc Thành Công");
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
