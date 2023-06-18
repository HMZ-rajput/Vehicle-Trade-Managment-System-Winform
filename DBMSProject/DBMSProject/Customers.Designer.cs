namespace DBMSProject
{
    partial class Customers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.idTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vendorDGV = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.addressLB = new System.Windows.Forms.Label();
            this.phoneLB = new System.Windows.Forms.Label();
            this.nameLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // idTB
            // 
            this.idTB.BackColor = System.Drawing.Color.Black;
            this.idTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.idTB.ForeColor = System.Drawing.Color.Yellow;
            this.idTB.Location = new System.Drawing.Point(156, 65);
            this.idTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(205, 24);
            this.idTB.TabIndex = 28;
            this.idTB.Text = "Enter Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label2.Location = new System.Drawing.Point(65, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "ID";
            // 
            // vendorDGV
            // 
            this.vendorDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vendorDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            this.vendorDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vendorDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.vendorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vendorDGV.DefaultCellStyle = dataGridViewCellStyle10;
            this.vendorDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            this.vendorDGV.Location = new System.Drawing.Point(37, 262);
            this.vendorDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vendorDGV.Name = "vendorDGV";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vendorDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.vendorDGV.RowHeadersVisible = false;
            this.vendorDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vendorDGV.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.vendorDGV.Size = new System.Drawing.Size(1013, 277);
            this.vendorDGV.TabIndex = 35;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(923, 191);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(128, 34);
            this.deleteBtn.TabIndex = 34;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.Location = new System.Drawing.Point(787, 191);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(128, 34);
            this.updateBtn.TabIndex = 33;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click_1);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(651, 191);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(128, 34);
            this.addBtn.TabIndex = 32;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // addressTB
            // 
            this.addressTB.BackColor = System.Drawing.Color.Black;
            this.addressTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.addressTB.ForeColor = System.Drawing.Color.Yellow;
            this.addressTB.Location = new System.Drawing.Point(156, 126);
            this.addressTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(205, 24);
            this.addressTB.TabIndex = 31;
            this.addressTB.Text = "Enter Address";
            // 
            // phoneTB
            // 
            this.phoneTB.BackColor = System.Drawing.Color.Black;
            this.phoneTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.phoneTB.ForeColor = System.Drawing.Color.Yellow;
            this.phoneTB.Location = new System.Drawing.Point(629, 126);
            this.phoneTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(205, 24);
            this.phoneTB.TabIndex = 30;
            this.phoneTB.Text = "Enter Phone";
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.Color.Black;
            this.nameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.nameTB.ForeColor = System.Drawing.Color.Yellow;
            this.nameTB.Location = new System.Drawing.Point(629, 62);
            this.nameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(205, 24);
            this.nameTB.TabIndex = 29;
            this.nameTB.Text = "Enter Name";
            // 
            // addressLB
            // 
            this.addressLB.AutoSize = true;
            this.addressLB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.addressLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.addressLB.Location = new System.Drawing.Point(32, 126);
            this.addressLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLB.Name = "addressLB";
            this.addressLB.Size = new System.Drawing.Size(77, 25);
            this.addressLB.TabIndex = 37;
            this.addressLB.Text = "Address";
            // 
            // phoneLB
            // 
            this.phoneLB.AutoSize = true;
            this.phoneLB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.phoneLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.phoneLB.Location = new System.Drawing.Point(500, 126);
            this.phoneLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLB.Name = "phoneLB";
            this.phoneLB.Size = new System.Drawing.Size(62, 25);
            this.phoneLB.TabIndex = 27;
            this.phoneLB.Text = "Phone";
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.nameLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.nameLB.Location = new System.Drawing.Point(500, 62);
            this.nameLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(59, 25);
            this.nameLB.TabIndex = 26;
            this.nameLB.Text = "Name";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1083, 576);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView vendorDGV;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label addressLB;
        private System.Windows.Forms.Label phoneLB;
        private System.Windows.Forms.Label nameLB;
    }
}