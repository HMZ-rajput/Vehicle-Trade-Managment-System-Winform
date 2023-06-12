namespace DBMSProject
{
    partial class Vehicles
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.makeTB = new System.Windows.Forms.TextBox();
            this.modelTB = new System.Windows.Forms.TextBox();
            this.yearTB = new System.Windows.Forms.TextBox();
            this.mileageTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.vehicleDGV = new System.Windows.Forms.DataGridView();
            this.idTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vendorCB = new System.Windows.Forms.ComboBox();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label1.Location = new System.Drawing.Point(239, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label3.Location = new System.Drawing.Point(38, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label4.Location = new System.Drawing.Point(225, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mileage";
            // 
            // makeTB
            // 
            this.makeTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.makeTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.makeTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeTB.ForeColor = System.Drawing.Color.White;
            this.makeTB.Location = new System.Drawing.Point(286, 49);
            this.makeTB.Name = "makeTB";
            this.makeTB.Size = new System.Drawing.Size(106, 20);
            this.makeTB.TabIndex = 5;
            this.makeTB.Text = "Enter Make";
            // 
            // modelTB
            // 
            this.modelTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.modelTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modelTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTB.ForeColor = System.Drawing.Color.White;
            this.modelTB.Location = new System.Drawing.Point(76, 102);
            this.modelTB.Name = "modelTB";
            this.modelTB.Size = new System.Drawing.Size(106, 20);
            this.modelTB.TabIndex = 6;
            this.modelTB.Text = "Enter Model";
            // 
            // yearTB
            // 
            this.yearTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.yearTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTB.ForeColor = System.Drawing.Color.White;
            this.yearTB.Location = new System.Drawing.Point(76, 155);
            this.yearTB.Name = "yearTB";
            this.yearTB.Size = new System.Drawing.Size(106, 20);
            this.yearTB.TabIndex = 8;
            this.yearTB.Text = "Enter Year";
            // 
            // mileageTB
            // 
            this.mileageTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mileageTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mileageTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mileageTB.ForeColor = System.Drawing.Color.White;
            this.mileageTB.Location = new System.Drawing.Point(286, 102);
            this.mileageTB.Name = "mileageTB";
            this.mileageTB.Size = new System.Drawing.Size(106, 20);
            this.mileageTB.TabIndex = 7;
            this.mileageTB.Text = "Enter Mileage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vehicle";
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
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add Car";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
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
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update Car";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
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
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Delete Car";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // vehicleDGV
            // 
            this.vehicleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            this.vehicleDGV.Location = new System.Drawing.Point(28, 213);
            this.vehicleDGV.Name = "vehicleDGV";
            this.vehicleDGV.RowHeadersWidth = 51;
            this.vehicleDGV.Size = new System.Drawing.Size(760, 225);
            this.vehicleDGV.TabIndex = 12;
            this.vehicleDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehicleDGV_CellContentClick);
            // 
            // idTB
            // 
            this.idTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.idTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTB.ForeColor = System.Drawing.Color.White;
            this.idTB.Location = new System.Drawing.Point(76, 50);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(106, 20);
            this.idTB.TabIndex = 4;
            this.idTB.Text = "Enter Car ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label6.Location = new System.Drawing.Point(49, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID";
            // 
            // vendorCB
            // 
            this.vendorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vendorCB.FormattingEnabled = true;
            this.vendorCB.Location = new System.Drawing.Point(488, 48);
            this.vendorCB.Name = "vendorCB";
            this.vendorCB.Size = new System.Drawing.Size(121, 26);
            this.vendorCB.TabIndex = 10;
            // 
            // priceTB
            // 
            this.priceTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.priceTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTB.ForeColor = System.Drawing.Color.White;
            this.priceTB.Location = new System.Drawing.Point(286, 155);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(106, 20);
            this.priceTB.TabIndex = 9;
            this.priceTB.Text = "Enter Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label7.Location = new System.Drawing.Point(244, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Price";
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(812, 468);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vendorCB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vehicleDGV);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mileageTB);
            this.Controls.Add(this.yearTB);
            this.Controls.Add(this.modelTB);
            this.Controls.Add(this.makeTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Vehicles";
            this.Text = "Vehicles";
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox makeTB;
        private System.Windows.Forms.TextBox modelTB;
        private System.Windows.Forms.TextBox yearTB;
        private System.Windows.Forms.TextBox mileageTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView vehicleDGV;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox vendorCB;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label label7;
    }
}