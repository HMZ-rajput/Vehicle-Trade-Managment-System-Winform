namespace DBMSProject
{
    partial class Home
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
            this.vehicleBtn = new System.Windows.Forms.Button();
            this.vendorBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.technicianBtn = new System.Windows.Forms.Button();
            this.repairBtn = new System.Windows.Forms.Button();
            this.sparepartBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.sellBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home";
            // 
            // vehicleBtn
            // 
            this.vehicleBtn.Location = new System.Drawing.Point(96, 176);
            this.vehicleBtn.Name = "vehicleBtn";
            this.vehicleBtn.Size = new System.Drawing.Size(75, 23);
            this.vehicleBtn.TabIndex = 2;
            this.vehicleBtn.Text = "Vehicle";
            this.vehicleBtn.UseVisualStyleBackColor = true;
            this.vehicleBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // vendorBtn
            // 
            this.vendorBtn.Location = new System.Drawing.Point(222, 176);
            this.vendorBtn.Name = "vendorBtn";
            this.vendorBtn.Size = new System.Drawing.Size(90, 23);
            this.vendorBtn.TabIndex = 3;
            this.vendorBtn.Text = "Vendor";
            this.vendorBtn.UseVisualStyleBackColor = true;
            this.vendorBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.Location = new System.Drawing.Point(377, 176);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(75, 23);
            this.customerBtn.TabIndex = 4;
            this.customerBtn.Text = "Customer";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // technicianBtn
            // 
            this.technicianBtn.Location = new System.Drawing.Point(535, 176);
            this.technicianBtn.Name = "technicianBtn";
            this.technicianBtn.Size = new System.Drawing.Size(75, 23);
            this.technicianBtn.TabIndex = 5;
            this.technicianBtn.Text = "Technician";
            this.technicianBtn.UseVisualStyleBackColor = true;
            this.technicianBtn.Click += new System.EventHandler(this.technicianBtn_Click);
            // 
            // repairBtn
            // 
            this.repairBtn.Location = new System.Drawing.Point(96, 238);
            this.repairBtn.Name = "repairBtn";
            this.repairBtn.Size = new System.Drawing.Size(75, 23);
            this.repairBtn.TabIndex = 6;
            this.repairBtn.Text = "Repair";
            this.repairBtn.UseVisualStyleBackColor = true;
            this.repairBtn.Click += new System.EventHandler(this.repairBtn_Click);
            // 
            // sparepartBtn
            // 
            this.sparepartBtn.Location = new System.Drawing.Point(222, 238);
            this.sparepartBtn.Name = "sparepartBtn";
            this.sparepartBtn.Size = new System.Drawing.Size(75, 23);
            this.sparepartBtn.TabIndex = 7;
            this.sparepartBtn.Text = "Spare Parts";
            this.sparepartBtn.UseVisualStyleBackColor = true;
            this.sparepartBtn.Click += new System.EventHandler(this.sparepartBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(377, 238);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(75, 23);
            this.reportBtn.TabIndex = 8;
            this.reportBtn.Text = "Report";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // sellBtn
            // 
            this.sellBtn.Location = new System.Drawing.Point(535, 238);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(75, 23);
            this.sellBtn.TabIndex = 9;
            this.sellBtn.Text = "Sell";
            this.sellBtn.UseVisualStyleBackColor = true;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.sparepartBtn);
            this.Controls.Add(this.repairBtn);
            this.Controls.Add(this.technicianBtn);
            this.Controls.Add(this.customerBtn);
            this.Controls.Add(this.vendorBtn);
            this.Controls.Add(this.vehicleBtn);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vehicleBtn;
        private System.Windows.Forms.Button vendorBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button technicianBtn;
        private System.Windows.Forms.Button repairBtn;
        private System.Windows.Forms.Button sparepartBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button sellBtn;
    }
}

