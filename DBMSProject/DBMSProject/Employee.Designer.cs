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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.employeeDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // idTB
            // 
            this.idTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.idTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.idTB.ForeColor = System.Drawing.Color.White;
            this.idTB.Location = new System.Drawing.Point(186, 49);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(154, 20);
            this.idTB.TabIndex = 25;
            this.idTB.Text = "Enter ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID";
            // 
            // employeeDGV
            // 
            this.employeeDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            this.employeeDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.employeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeDGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.employeeDGV.Location = new System.Drawing.Point(28, 213);
            this.employeeDGV.Name = "employeeDGV";
            this.employeeDGV.RowHeadersVisible = false;
            this.employeeDGV.Size = new System.Drawing.Size(760, 225);
            this.employeeDGV.TabIndex = 23;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(692, 155);
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
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.Location = new System.Drawing.Point(590, 155);
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
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(488, 155);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(96, 28);
            this.addBtn.TabIndex = 20;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addressTB
            // 
            this.addressTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.addressTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.addressTB.ForeColor = System.Drawing.Color.White;
            this.addressTB.Location = new System.Drawing.Point(186, 96);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(154, 20);
            this.addressTB.TabIndex = 19;
            this.addressTB.Text = "Enter Address";
            // 
            // phoneTB
            // 
            this.phoneTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.phoneTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.phoneTB.ForeColor = System.Drawing.Color.White;
            this.phoneTB.Location = new System.Drawing.Point(520, 96);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(154, 20);
            this.phoneTB.TabIndex = 18;
            this.phoneTB.Text = "Enter Phone Number";
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.nameTB.ForeColor = System.Drawing.Color.White;
            this.nameTB.Location = new System.Drawing.Point(520, 50);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(154, 20);
            this.nameTB.TabIndex = 17;
            this.nameTB.Text = "Enter Name";
            // 
            // addressLB
            // 
            this.addressLB.AutoSize = true;
            this.addressLB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.addressLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.addressLB.Location = new System.Drawing.Point(12, 96);
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
            this.phoneLB.Location = new System.Drawing.Point(428, 96);
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
            this.nameLB.Location = new System.Drawing.Point(428, 49);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(49, 20);
            this.nameLB.TabIndex = 14;
            this.nameLB.Text = "Name";
            // 
            // commisionTB
            // 
            this.commisionTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.commisionTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commisionTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.commisionTB.ForeColor = System.Drawing.Color.White;
            this.commisionTB.Location = new System.Drawing.Point(186, 141);
            this.commisionTB.Name = "commisionTB";
            this.commisionTB.Size = new System.Drawing.Size(154, 20);
            this.commisionTB.TabIndex = 27;
            this.commisionTB.Text = "Commision Percentage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Commision Percentage";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(812, 468);
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
    }
}