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
            this.vehicleBtn = new System.Windows.Forms.Button();
            this.vendorBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.technicianBtn = new System.Windows.Forms.Button();
            this.repairBtn = new System.Windows.Forms.Button();
            this.sparepartBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.sellBtn = new System.Windows.Forms.Button();
            this.employeeBtn = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehicleBtn
            // 
            this.vehicleBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vehicleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicleBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleBtn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.vehicleBtn.Location = new System.Drawing.Point(0, 95);
            this.vehicleBtn.Name = "vehicleBtn";
            this.vehicleBtn.Size = new System.Drawing.Size(139, 45);
            this.vehicleBtn.TabIndex = 2;
            this.vehicleBtn.Text = "Vehicle";
            this.vehicleBtn.UseVisualStyleBackColor = false;
            this.vehicleBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // vendorBtn
            // 
            this.vendorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vendorBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorBtn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.vendorBtn.Location = new System.Drawing.Point(0, 139);
            this.vendorBtn.Name = "vendorBtn";
            this.vendorBtn.Size = new System.Drawing.Size(139, 45);
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
            this.repairBtn.Location = new System.Drawing.Point(237, 238);
            this.repairBtn.Name = "repairBtn";
            this.repairBtn.Size = new System.Drawing.Size(75, 23);
            this.repairBtn.TabIndex = 7;
            this.repairBtn.Text = "Repair";
            this.repairBtn.UseVisualStyleBackColor = true;
            this.repairBtn.Click += new System.EventHandler(this.repairBtn_Click);
            // 
            // sparepartBtn
            // 
            this.sparepartBtn.Location = new System.Drawing.Point(377, 238);
            this.sparepartBtn.Name = "sparepartBtn";
            this.sparepartBtn.Size = new System.Drawing.Size(75, 23);
            this.sparepartBtn.TabIndex = 8;
            this.sparepartBtn.Text = "Spare Parts";
            this.sparepartBtn.UseVisualStyleBackColor = true;
            this.sparepartBtn.Click += new System.EventHandler(this.sparepartBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(334, 319);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(75, 23);
            this.reportBtn.TabIndex = 10;
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
            // employeeBtn
            // 
            this.employeeBtn.Location = new System.Drawing.Point(194, 280);
            this.employeeBtn.Name = "employeeBtn";
            this.employeeBtn.Size = new System.Drawing.Size(75, 23);
            this.employeeBtn.TabIndex = 6;
            this.employeeBtn.Text = "Employee";
            this.employeeBtn.UseVisualStyleBackColor = true;
            this.employeeBtn.Click += new System.EventHandler(this.employeeBtn_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLeft.Controls.Add(this.panelLogo);
            this.panelLeft.Controls.Add(this.vehicleBtn);
            this.panelLeft.Controls.Add(this.vendorBtn);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(139, 496);
            this.panelLeft.TabIndex = 11;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTop.BackgroundImage = global::DBMSProject.Properties.Resources.download;
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(139, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(699, 96);
            this.panelTop.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(279, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLogo.BackgroundImage = global::DBMSProject.Properties.Resources.Blaze_Wheel_Logo;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(139, 96);
            this.panelLogo.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(838, 496);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.employeeBtn);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.sparepartBtn);
            this.Controls.Add(this.repairBtn);
            this.Controls.Add(this.technicianBtn);
            this.Controls.Add(this.customerBtn);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "Home";
            this.Text = "Form1";
            this.panelLeft.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button employeeBtn;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTop;
    }
}

