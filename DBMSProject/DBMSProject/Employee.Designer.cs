namespace DBMSProject
{
    partial class Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.idTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeDGV = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.addressLB = new System.Windows.Forms.Label();
            this.phoneLB = new System.Windows.Forms.Label();
            this.nameLB = new System.Windows.Forms.Label();
            this.commisionTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passTB = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // idTB
            // 
            this.idTB.BackColor = System.Drawing.Color.Black;
            this.idTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.idTB.ForeColor = System.Drawing.Color.Yellow;
            this.idTB.Location = new System.Drawing.Point(201, 35);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(154, 20);
            this.idTB.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label2.Location = new System.Drawing.Point(27, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Employee ID";
            // 
            // employeeDGV
            // 
            this.employeeDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            this.employeeDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.employeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.employeeDGV.Location = new System.Drawing.Point(28, 213);
            this.employeeDGV.Name = "employeeDGV";
            this.employeeDGV.RowHeadersVisible = false;
            this.employeeDGV.RowHeadersWidth = 51;
            this.employeeDGV.Size = new System.Drawing.Size(760, 225);
            this.employeeDGV.TabIndex = 23;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(692, 179);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(96, 28);
            this.deleteBtn.TabIndex = 22;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.Location = new System.Drawing.Point(590, 179);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(96, 28);
            this.updateBtn.TabIndex = 21;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(488, 179);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(96, 28);
            this.addBtn.TabIndex = 20;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addressTB
            // 
            this.addressTB.BackColor = System.Drawing.Color.Black;
            this.addressTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.addressTB.ForeColor = System.Drawing.Color.Yellow;
            this.addressTB.Location = new System.Drawing.Point(201, 82);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(154, 20);
            this.addressTB.TabIndex = 19;
            // 
            // phoneTB
            // 
            this.phoneTB.BackColor = System.Drawing.Color.Black;
            this.phoneTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.phoneTB.ForeColor = System.Drawing.Color.Yellow;
            this.phoneTB.Location = new System.Drawing.Point(520, 82);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(154, 20);
            this.phoneTB.TabIndex = 18;
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.Color.Black;
            this.nameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.nameTB.ForeColor = System.Drawing.Color.Yellow;
            this.nameTB.Location = new System.Drawing.Point(520, 37);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(154, 20);
            this.nameTB.TabIndex = 17;
            // 
            // addressLB
            // 
            this.addressLB.AutoSize = true;
            this.addressLB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.addressLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.addressLB.Location = new System.Drawing.Point(27, 82);
            this.addressLB.Name = "addressLB";
            this.addressLB.Size = new System.Drawing.Size(62, 20);
            this.addressLB.TabIndex = 16;
            this.addressLB.Text = "Address";
            // 
            // phoneLB
            // 
            this.phoneLB.AutoSize = true;
            this.phoneLB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.phoneLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.phoneLB.Location = new System.Drawing.Point(428, 82);
            this.phoneLB.Name = "phoneLB";
            this.phoneLB.Size = new System.Drawing.Size(50, 20);
            this.phoneLB.TabIndex = 15;
            this.phoneLB.Text = "Phone";
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.nameLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.nameLB.Location = new System.Drawing.Point(428, 35);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(49, 20);
            this.nameLB.TabIndex = 14;
            this.nameLB.Text = "Name";
            // 
            // commisionTB
            // 
            this.commisionTB.BackColor = System.Drawing.Color.Black;
            this.commisionTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commisionTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.commisionTB.ForeColor = System.Drawing.Color.Yellow;
            this.commisionTB.Location = new System.Drawing.Point(201, 128);
            this.commisionTB.Name = "commisionTB";
            this.commisionTB.Size = new System.Drawing.Size(154, 20);
            this.commisionTB.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label3.Location = new System.Drawing.Point(27, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Commision Percentage";
            // 
            // passTB
            // 
            this.passTB.BackColor = System.Drawing.Color.Black;
            this.passTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.passTB.ForeColor = System.Drawing.Color.Yellow;
            this.passTB.Location = new System.Drawing.Point(520, 127);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(154, 20);
            this.passTB.TabIndex = 29;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.passwordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.passwordLbl.Location = new System.Drawing.Point(428, 127);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(70, 20);
            this.passwordLbl.TabIndex = 28;
            this.passwordLbl.Text = "Password";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(812, 468);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.commisionTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employeeDGV);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.addressLB);
            this.Controls.Add(this.phoneLB);
            this.Controls.Add(this.nameLB);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView employeeDGV;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label addressLB;
        private System.Windows.Forms.Label phoneLB;
        private System.Windows.Forms.Label nameLB;
        private System.Windows.Forms.TextBox commisionTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Label passwordLbl;
    }
}