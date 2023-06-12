namespace DBMSProject
{
    partial class Vendors
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nameLB = new System.Windows.Forms.Label();
            this.phoneLB = new System.Windows.Forms.Label();
            this.addressLB = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.vendorDGV = new System.Windows.Forms.DataGridView();
            this.idTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.nameLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.nameLB.Location = new System.Drawing.Point(382, 50);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(49, 20);
            this.nameLB.TabIndex = 1;
            this.nameLB.Text = "Name";
            // 
            // phoneLB
            // 
            this.phoneLB.AutoSize = true;
            this.phoneLB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.phoneLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.phoneLB.Location = new System.Drawing.Point(381, 102);
            this.phoneLB.Name = "phoneLB";
            this.phoneLB.Size = new System.Drawing.Size(50, 20);
            this.phoneLB.TabIndex = 2;
            this.phoneLB.Text = "Phone";
            // 
            // addressLB
            // 
            this.addressLB.AutoSize = true;
            this.addressLB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.addressLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.addressLB.Location = new System.Drawing.Point(24, 102);
            this.addressLB.Name = "addressLB";
            this.addressLB.Size = new System.Drawing.Size(62, 20);
            this.addressLB.TabIndex = 13;
            this.addressLB.Text = "Address";
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.nameTB.ForeColor = System.Drawing.Color.White;
            this.nameTB.Location = new System.Drawing.Point(478, 54);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(154, 20);
            this.nameTB.TabIndex = 4;
            this.nameTB.Text = "Enter Name";
            // 
            // phoneTB
            // 
            this.phoneTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.phoneTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.phoneTB.ForeColor = System.Drawing.Color.White;
            this.phoneTB.Location = new System.Drawing.Point(478, 102);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(154, 20);
            this.phoneTB.TabIndex = 5;
            this.phoneTB.Text = "Enter Phone";
            // 
            // addressTB
            // 
            this.addressTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.addressTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.addressTB.ForeColor = System.Drawing.Color.White;
            this.addressTB.Location = new System.Drawing.Point(117, 104);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(154, 20);
            this.addressTB.TabIndex = 6;
            this.addressTB.Text = "Enter Address";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(488, 155);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(96, 28);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.Location = new System.Drawing.Point(590, 155);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(96, 28);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(692, 155);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(96, 28);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // vendorDGV
            // 
            this.vendorDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vendorDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            this.vendorDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vendorDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.vendorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vendorDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.vendorDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            this.vendorDGV.Location = new System.Drawing.Point(28, 213);
            this.vendorDGV.Name = "vendorDGV";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vendorDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.vendorDGV.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vendorDGV.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.vendorDGV.Size = new System.Drawing.Size(760, 225);
            this.vendorDGV.TabIndex = 10;
            // 
            // idTB
            // 
            this.idTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.idTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.idTB.ForeColor = System.Drawing.Color.White;
            this.idTB.Location = new System.Drawing.Point(117, 53);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(154, 20);
            this.idTB.TabIndex = 4;
            this.idTB.Text = "Enter Vendor ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label2.Location = new System.Drawing.Point(49, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID";
            // 
            // Vendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(812, 468);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vendorDGV);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.addressLB);
            this.Controls.Add(this.phoneLB);
            this.Controls.Add(this.nameLB);
            this.Name = "Vendors";
            this.Text = "Vendors";
            this.Load += new System.EventHandler(this.Vendors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLB;
        private System.Windows.Forms.Label phoneLB;
        private System.Windows.Forms.Label addressLB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView vendorDGV;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label label2;
    }
}