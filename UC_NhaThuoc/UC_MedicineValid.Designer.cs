﻿namespace Pharmacy.UC_NhaThuoc
{
    partial class UC_MedicineValid
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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.txtCheck = new Wisej.Web.ComboBox();
            this.guna2DataGridView1 = new Wisej.Web.DataGridView();
            this.SetLabel = new Wisej.Web.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kiểm Tra Hạn Sử Dụng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(382, 195);
            this.label2.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kiểm Tra";
            // 
            // txtCheck
            // 
            this.txtCheck.BackColor = System.Drawing.Color.Transparent;
            this.txtCheck.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.txtCheck.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCheck.ForeColor = System.Drawing.Color.Black;
            this.txtCheck.ItemHeight = 30;
            this.txtCheck.Items.AddRange(new object[] {
            "Thuốc Còn Hạn Sử Dụng",
            "Thuốc Hết Hạn Sử Dụng",
            "Tất Cả Thuốc"});
            this.txtCheck.Location = new System.Drawing.Point(386, 232);
            this.txtCheck.Margin = new Wisej.Web.Padding(4, 5, 4, 5);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(596, 30);
            this.txtCheck.TabIndex = 4;
            this.txtCheck.SelectedIndexChanged += new System.EventHandler(this.txtCheck_SelectedIndexChanged);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = Wisej.Web.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle2.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle2.WrapMode = Wisej.Web.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.Location = new System.Drawing.Point(63, 365);
            this.guna2DataGridView1.Margin = new Wisej.Web.Padding(4, 5, 4, 5);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1426, 655);
            this.guna2DataGridView1.TabIndex = 5;
            // 
            // SetLabel
            // 
            this.SetLabel.AutoSize = true;
            this.SetLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SetLabel.Location = new System.Drawing.Point(58, 303);
            this.SetLabel.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
            this.SetLabel.Name = "SetLabel";
            this.SetLabel.Size = new System.Drawing.Size(207, 28);
            this.SetLabel.TabIndex = 6;
            this.SetLabel.Text = "Trạng Thái Thuốc";
            // 
            // UC_MedicineValid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1512, 1031);
            this.Controls.Add(this.SetLabel);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.txtCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new Wisej.Web.Padding(4, 5, 4, 5);
            this.Name = "UC_MedicineValid";
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

        #endregion
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
        private Wisej.Web.ComboBox txtCheck;
        private Wisej.Web.DataGridView guna2DataGridView1;
        private Wisej.Web.Label SetLabel;

    }
}