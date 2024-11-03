using System;

namespace Pharmacy.UC_Admin
{
    partial class UC_UpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_UpdateUser));
            this.label1 = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.txtUserRole = new Wisej.Web.ComboBox();
            this.label4 = new Wisej.Web.Label();
            this.txtName = new Wisej.Web.TextBox();
            this.txtEmail = new Wisej.Web.TextBox();
            this.label6 = new Wisej.Web.Label();
            this.txtMobileNo = new Wisej.Web.TextBox();
            this.label7 = new Wisej.Web.Label();
            this.txtPassword = new Wisej.Web.TextBox();
            this.label8 = new Wisej.Web.Label();
            this.btnUpdate = new Wisej.Web.Button();
            this.btnReset = new Wisej.Web.Button();
            this.label9 = new Wisej.Web.Label();
            this.txtUserName = new Wisej.Web.TextBox();
            this.label2 = new Wisej.Web.Label();
            this.btnSearch = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập Nhật Người Dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 210);
            this.label3.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vai Trò Người Dùng";
            // 
            // txtUserRole
            // 
            this.txtUserRole.BackColor = System.Drawing.Color.Transparent;
            this.txtUserRole.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.txtUserRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserRole.ForeColor = System.Drawing.Color.FromArgb(68, 88, 112);
            this.txtUserRole.ItemHeight = 30;
            this.txtUserRole.Items.AddRange(new object[] {
            "Administrator",
            "Quan Ly",
            "Nhan Vien"});
            this.txtUserRole.Location = new System.Drawing.Point(29, 275);
            this.txtUserRole.Margin = new Wisej.Web.Padding(4, 5, 4, 5);
            this.txtUserRole.Name = "txtUserRole";
            this.txtUserRole.Size = new System.Drawing.Size(502, 30);
            this.txtUserRole.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 356);
            this.label4.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Họ Và Tên";
            // 
            // txtName
            // 
            this.txtName.Cursor = Wisej.Web.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(29, 401);
            this.txtName.Margin = new Wisej.Web.Padding(6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(504, 30);
            this.txtName.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = Wisej.Web.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(936, 256);
            this.txtEmail.Margin = new Wisej.Web.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(504, 30);
            this.txtEmail.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(934, 210);
            this.label6.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Cursor = Wisej.Web.Cursors.IBeam;
            this.txtMobileNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMobileNo.Location = new System.Drawing.Point(30, 551);
            this.txtMobileNo.Margin = new Wisej.Web.Padding(6);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(504, 30);
            this.txtMobileNo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(26, 503);
            this.label7.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số Điện Thoại";
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = Wisej.Web.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(939, 528);
            this.txtPassword.Margin = new Wisej.Web.Padding(6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(504, 30);
            this.txtPassword.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(937, 479);
            this.label8.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mật Khẩu";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(0, 118, 255);
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(945, 639);
            this.btnUpdate.Margin = new Wisej.Web.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(219, 74);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(0, 118, 255);
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(1225, 639);
            this.btnReset.Margin = new Wisej.Web.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(219, 74);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Cài Đặt Lại";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(1038, 741);
            this.label9.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "*Kiểm tra lại thông tin trước khi cập nhật";
            // 
            // txtUserName
            // 
            this.txtUserName.Cursor = Wisej.Web.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.Location = new System.Drawing.Point(942, 401);
            this.txtUserName.Margin = new Wisej.Web.Padding(6);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(504, 30);
            this.txtUserName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(940, 356);
            this.label2.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tài Khoản";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(0, 118, 255);
            this.btnSearch.BorderStyle = Wisej.Web.BorderStyle.None;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(557, 404);
            this.btnSearch.Margin = new Wisej.Web.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 52);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // UC_UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new Wisej.Web.Padding(4, 5, 4, 5);
            this.Name = "UC_UpdateUser";
            this.Size = new System.Drawing.Size(1654, 1136);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    
        #endregion
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label3;
        private Wisej.Web.ComboBox txtUserRole;
        private Wisej.Web.Label label4;
        private Wisej.Web.TextBox txtName;
        private Wisej.Web.TextBox txtEmail;
        private Wisej.Web.Label label6;
        private Wisej.Web.TextBox txtMobileNo;
        private Wisej.Web.Label label7;
        private Wisej.Web.TextBox txtPassword;
        private Wisej.Web.Label label8;
        private Wisej.Web.Button btnUpdate;
        private Wisej.Web.Button btnReset;
        private Wisej.Web.Label label9;
        private Wisej.Web.TextBox txtUserName;
        private Wisej.Web.Label label2;
        private Wisej.Web.Button btnSearch;
    }

}

