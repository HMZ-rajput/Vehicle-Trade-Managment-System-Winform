namespace DBMSProject
{
    partial class RepairCar
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
            this.vehicleCB = new System.Windows.Forms.ComboBox();
            this.partCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.completeRepairBtn = new System.Windows.Forms.Button();
            this.repairDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.descTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chargesTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdIDTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.repairDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleCB
            // 
            this.vehicleCB.BackColor = System.Drawing.Color.Black;
            this.vehicleCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicleCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleCB.ForeColor = System.Drawing.Color.Yellow;
            this.vehicleCB.FormattingEnabled = true;
            this.vehicleCB.Location = new System.Drawing.Point(94, 127);
            this.vehicleCB.Name = "vehicleCB";
            this.vehicleCB.Size = new System.Drawing.Size(121, 26);
            this.vehicleCB.TabIndex = 11;
            this.vehicleCB.SelectedIndexChanged += new System.EventHandler(this.vehicleChanged);
            // 
            // partCB
            // 
            this.partCB.BackColor = System.Drawing.Color.Black;
            this.partCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partCB.ForeColor = System.Drawing.Color.Yellow;
            this.partCB.FormattingEnabled = true;
            this.partCB.Location = new System.Drawing.Point(94, 42);
            this.partCB.Name = "partCB";
            this.partCB.Size = new System.Drawing.Size(122, 26);
            this.partCB.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label6.Location = new System.Drawing.Point(40, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Part";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label3.Location = new System.Drawing.Point(18, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Vehicle";
            // 
            // quantityTB
            // 
            this.quantityTB.BackColor = System.Drawing.Color.Black;
            this.quantityTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTB.ForeColor = System.Drawing.Color.Yellow;
            this.quantityTB.Location = new System.Drawing.Point(372, 48);
            this.quantityTB.Name = "quantityTB";
            this.quantityTB.Size = new System.Drawing.Size(122, 22);
            this.quantityTB.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label2.Location = new System.Drawing.Point(281, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Quantity";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(692, 155);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(96, 28);
            this.deleteBtn.TabIndex = 21;
            this.deleteBtn.Text = "Delete Part";
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
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.Location = new System.Drawing.Point(590, 155);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(96, 28);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Update Part";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(488, 155);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(96, 28);
            this.addBtn.TabIndex = 20;
            this.addBtn.Text = "Add Part";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // completeRepairBtn
            // 
            this.completeRepairBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.completeRepairBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.completeRepairBtn.FlatAppearance.BorderSize = 0;
            this.completeRepairBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeRepairBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeRepairBtn.ForeColor = System.Drawing.Color.Black;
            this.completeRepairBtn.Location = new System.Drawing.Point(632, 100);
            this.completeRepairBtn.Name = "completeRepairBtn";
            this.completeRepairBtn.Size = new System.Drawing.Size(156, 28);
            this.completeRepairBtn.TabIndex = 22;
            this.completeRepairBtn.Text = "Mark as Repaired";
            this.completeRepairBtn.UseVisualStyleBackColor = false;
            this.completeRepairBtn.Click += new System.EventHandler(this.completeRepairBtn_Click);
            // 
            // repairDGV
            // 
            this.repairDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.repairDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            this.repairDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.repairDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.repairDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.repairDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.repairDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.repairDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            this.repairDGV.Location = new System.Drawing.Point(28, 213);
            this.repairDGV.Name = "repairDGV";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.repairDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.repairDGV.RowHeadersVisible = false;
            this.repairDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.repairDGV.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.repairDGV.Size = new System.Drawing.Size(760, 225);
            this.repairDGV.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label1.Location = new System.Drawing.Point(281, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Description";
            // 
            // descTB
            // 
            this.descTB.BackColor = System.Drawing.Color.Black;
            this.descTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descTB.ForeColor = System.Drawing.Color.Yellow;
            this.descTB.Location = new System.Drawing.Point(372, 83);
            this.descTB.Name = "descTB";
            this.descTB.Size = new System.Drawing.Size(122, 22);
            this.descTB.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label4.Location = new System.Drawing.Point(281, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Charges";
            // 
            // chargesTB
            // 
            this.chargesTB.BackColor = System.Drawing.Color.Black;
            this.chargesTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chargesTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargesTB.ForeColor = System.Drawing.Color.Yellow;
            this.chargesTB.Location = new System.Drawing.Point(372, 118);
            this.chargesTB.Name = "chargesTB";
            this.chargesTB.Size = new System.Drawing.Size(240, 22);
            this.chargesTB.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label5.Location = new System.Drawing.Point(3, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Repair ID";
            // 
            // rdIDTB
            // 
            this.rdIDTB.BackColor = System.Drawing.Color.Black;
            this.rdIDTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rdIDTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdIDTB.ForeColor = System.Drawing.Color.Yellow;
            this.rdIDTB.Location = new System.Drawing.Point(94, 83);
            this.rdIDTB.Name = "rdIDTB";
            this.rdIDTB.Size = new System.Drawing.Size(122, 22);
            this.rdIDTB.TabIndex = 29;
            // 
            // RepairCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(812, 468);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdIDTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chargesTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descTB);
            this.Controls.Add(this.repairDGV);
            this.Controls.Add(this.completeRepairBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantityTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.partCB);
            this.Controls.Add(this.vehicleCB);
            this.Name = "RepairCar";
            this.Text = "RepairCar";
            this.Load += new System.EventHandler(this.RepairCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repairDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox vehicleCB;
        private System.Windows.Forms.ComboBox partCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button completeRepairBtn;
        private System.Windows.Forms.DataGridView repairDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox chargesTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rdIDTB;
    }
}