using Pharmacy.Properties;
using System.Reflection.Emit;
using System.Resources;
using Wisej.Web;

namespace Pharmacy.UC_Admin
{
    partial class UC_AddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej.NET Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddUser));
            this.Label1 = new Wisej.Web.Label();
            this.Label2 = new Wisej.Web.Label();
            this.Label3 = new Wisej.Web.Label();
            this.Label4 = new Wisej.Web.Label();
            this.Label5 = new Wisej.Web.Label();
            this.Label6 = new Wisej.Web.Label();
            this.Label7 = new Wisej.Web.Label();
            this.Label8 = new Wisej.Web.Label();
            this.txtUserRole = new Wisej.Web.ComboBox();
            this.txtName = new Wisej.Web.TextBox();
            this.txtMobileNo = new Wisej.Web.TextBox();
            this.txtEmail = new Wisej.Web.TextBox();
            this.txtUserName = new Wisej.Web.TextBox();
            this.txtPassword = new Wisej.Web.TextBox();
            this.txtDOB = new Wisej.Web.DateTimePicker();
            this.btnSignUp = new Wisej.Web.Button();
            this.btnReset = new Wisej.Web.Button();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.label9 = new Wisej.Web.Label();
            this.panel1 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.Label0 = new Wisej.Web.Label();
            this.label10 = new Wisej.Web.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 18);
            this.Label1.TabIndex = 22;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(218, 196);
            this.Label2.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(215, 28);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Vai Trò Người Dùng";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label3.Location = new System.Drawing.Point(222, 307);
            this.Label3.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(119, 28);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Họ Và Tên";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label4.Location = new System.Drawing.Point(226, 441);
            this.Label4.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(115, 28);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Ngày Sinh";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label5.Location = new System.Drawing.Point(218, 522);
            this.Label5.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(156, 28);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Số Điện Thoại";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label6.Location = new System.Drawing.Point(856, 187);
            this.Label6.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(65, 28);
            this.Label6.TabIndex = 5;
            this.Label6.Text = "Email";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label7.Location = new System.Drawing.Point(856, 307);
            this.Label7.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(114, 28);
            this.Label7.TabIndex = 6;
            this.Label7.Text = "Tài Khoản";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label8.Location = new System.Drawing.Point(857, 465);
            this.Label8.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(107, 28);
            this.Label8.TabIndex = 7;
            this.Label8.Text = "Mật Khẩu";
            // 
            // txtUserRole
            // 
            this.txtUserRole.BackColor = System.Drawing.Color.Transparent;
            this.txtUserRole.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.txtUserRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserRole.ForeColor = System.Drawing.Color.Black;
            this.txtUserRole.ItemHeight = 30;
            this.txtUserRole.Items.AddRange(new object[] {
            "Administrator",
            "Quan Ly",
            "Nhan Vien"});
            this.txtUserRole.Location = new System.Drawing.Point(222, 234);
            this.txtUserRole.Margin = new Wisej.Web.Padding(4, 5, 4, 5);
            this.txtUserRole.Name = "txtUserRole";
            this.txtUserRole.Size = new System.Drawing.Size(404, 34);
            this.txtUserRole.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Cursor = Wisej.Web.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(222, 346);
            this.txtName.Margin = new Wisej.Web.Padding(6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(404, 34);
            this.txtName.TabIndex = 9;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Cursor = Wisej.Web.Cursors.IBeam;
            this.txtMobileNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMobileNo.ForeColor = System.Drawing.Color.Black;
            this.txtMobileNo.Location = new System.Drawing.Point(222, 572);
            this.txtMobileNo.Margin = new Wisej.Web.Padding(6);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(404, 34);
            this.txtMobileNo.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = Wisej.Web.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(860, 234);
            this.txtEmail.Margin = new Wisej.Web.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(404, 34);
            this.txtEmail.TabIndex = 11;
            // 
            // txtUserName
            // 
            this.txtUserName.Cursor = Wisej.Web.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(859, 355);
            this.txtUserName.Margin = new Wisej.Web.Padding(6);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(404, 34);
            this.txtUserName.TabIndex = 12;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = Wisej.Web.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.txtPassword.Location = new System.Drawing.Point(861, 515);
            this.txtPassword.Margin = new Wisej.Web.Padding(6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(404, 34);
            this.txtPassword.TabIndex = 13;
            // 
            // txtDOB
            // 
            this.txtDOB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDOB.Location = new System.Drawing.Point(364, 426);
            this.txtDOB.Margin = new Wisej.Web.Padding(4, 5, 4, 5);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(262, 30);
            this.txtDOB.TabIndex = 14;
            this.txtDOB.Value = new System.DateTime(2024, 5, 20, 19, 32, 41, 452);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(0, 118, 255);
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Image = ((System.Drawing.Image)(resources.GetObject("btnSignUp.Image")));
            this.btnSignUp.Location = new System.Drawing.Point(529, 689);
            this.btnSignUp.Margin = new Wisej.Web.Padding(4, 5, 4, 5);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(205, 82);
            this.btnSignUp.TabIndex = 16;
            this.btnSignUp.Text = "Đăng Ký";
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(0, 118, 255);
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(773, 689);
            this.btnReset.Margin = new Wisej.Web.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(242, 82);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Cài Đặt Lại";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1286, 326);
            this.pictureBox1.Margin = new Wisej.Web.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 102);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            this.label9.Location = new System.Drawing.Point(591, 792);
            this.label9.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(577, 28);
            this.label9.TabIndex = 19;
            this.label9.Text = "Kiểm Tra Lại Vai Trò Người Dùng Trước Khi Đăng Ký !";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(0, 118, 255);
            this.panel1.Location = new System.Drawing.Point(705, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 514);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            // 
            // Label0
            // 
            this.Label0.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.Label0.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label0.Location = new System.Drawing.Point(0, 0);
            this.Label0.Margin = new Wisej.Web.Padding(4, 5, 4, 5);
            this.Label0.Name = "Label0";
            this.Label0.Size = new System.Drawing.Size(404, 1080);
            this.Label0.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(20, 25);
            this.label10.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(378, 54);
            this.label10.TabIndex = 23;
            this.label10.Text = "Thêm Người Dùng";
            // 
            // UC_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUserRole);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Margin = new Wisej.Web.Padding(4, 5, 4, 5);
            this.Name = "UC_AddUser";
            this.Size = new System.Drawing.Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Wisej.Web.Panel panel2;
        internal Wisej.Web.Label Label1;
        internal Wisej.Web.Label Label2;
        internal Wisej.Web.Label Label3;
        internal Wisej.Web.Label Label4;
        internal Wisej.Web.Label Label5;
        internal Wisej.Web.Label Label6;
        internal Wisej.Web.Label Label7;
        internal Wisej.Web.Label Label8;
        internal Wisej.Web.ComboBox txtUserRole;
        internal Wisej.Web.TextBox txtName;
        internal Wisej.Web.TextBox txtMobileNo;
        internal Wisej.Web.TextBox txtEmail;
        internal Wisej.Web.TextBox txtUserName;
        internal Wisej.Web.TextBox txtPassword;
        internal Wisej.Web.DateTimePicker txtDOB;
        internal Wisej.Web.Button btnSignUp;
        internal Wisej.Web.Button btnReset;
        private PictureBox pictureBox1;
        internal Wisej.Web.Label label9;
        private Panel panel1;
        internal Wisej.Web.Label Label0;
        private Wisej.Web.Label label10;
    }
}