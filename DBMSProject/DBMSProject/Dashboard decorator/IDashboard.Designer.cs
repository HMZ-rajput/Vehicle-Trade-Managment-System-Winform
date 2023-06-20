namespace DBMSProject
{
    partial class IDashboard
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
        public virtual void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDashboard));
            this.BuyPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buylbl = new System.Windows.Forms.Label();
            this.boughtlbl = new System.Windows.Forms.Label();
            this.RepairPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.repairlbl = new System.Windows.Forms.Label();
            this.repaircountlbl = new System.Windows.Forms.Label();
            this.SoldPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.soldlbl = new System.Windows.Forms.Label();
            this.soldcountlbl = new System.Windows.Forms.Label();
            this.greetinglbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.vendorpanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.vendorlbl = new System.Windows.Forms.Label();
            this.vendorcountlbl = new System.Windows.Forms.Label();
            this.partspanel = new System.Windows.Forms.Panel();
            this.avgpartlbl = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.avgcountbl = new System.Windows.Forms.Label();
            this.custpanel = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.custlbl = new System.Windows.Forms.Label();
            this.custcountlbl = new System.Windows.Forms.Label();
            this.emppanel = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.emplbl = new System.Windows.Forms.Label();
            this.empcountlbl = new System.Windows.Forms.Label();
            this.techpanel = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.techlbl = new System.Windows.Forms.Label();
            this.techcountlbl = new System.Windows.Forms.Label();
            this.losspanel = new System.Windows.Forms.Panel();
            this.Losslbl = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.topsellpanel = new System.Windows.Forms.Panel();
            this.topselllbl = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.profitpanel = new System.Windows.Forms.Panel();
            this.profitlbl = new System.Windows.Forms.Label();
            this.profitamt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.citylbl = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.carpaneltimer = new System.Windows.Forms.Timer(this.components);
            this.BuyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.RepairPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SoldPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.vendorpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.partspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.custpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.emppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.techpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.losspanel.SuspendLayout();
            this.topsellpanel.SuspendLayout();
            this.profitpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuyPanel
            // 
            this.BuyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.BuyPanel.Controls.Add(this.pictureBox1);
            this.BuyPanel.Controls.Add(this.buylbl);
            this.BuyPanel.Controls.Add(this.boughtlbl);
            this.BuyPanel.Location = new System.Drawing.Point(76, 119);
            this.BuyPanel.Name = "BuyPanel";
            this.BuyPanel.Size = new System.Drawing.Size(293, 126);
            this.BuyPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buylbl
            // 
            this.buylbl.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.buylbl.AutoSize = true;
            this.buylbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buylbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buylbl.Location = new System.Drawing.Point(14, 14);
            this.buylbl.Name = "buylbl";
            this.buylbl.Size = new System.Drawing.Size(145, 25);
            this.buylbl.TabIndex = 1;
            this.buylbl.Text = "Vehicles Bought";
            // 
            // boughtlbl
            // 
            this.boughtlbl.AutoSize = true;
            this.boughtlbl.BackColor = System.Drawing.Color.Transparent;
            this.boughtlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boughtlbl.Font = new System.Drawing.Font("Segoe UI", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boughtlbl.Location = new System.Drawing.Point(4, 26);
            this.boughtlbl.Name = "boughtlbl";
            this.boughtlbl.Size = new System.Drawing.Size(65, 89);
            this.boughtlbl.TabIndex = 1;
            this.boughtlbl.Text = "-";
            // 
            // RepairPanel
            // 
            this.RepairPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.RepairPanel.Controls.Add(this.pictureBox2);
            this.RepairPanel.Controls.Add(this.repairlbl);
            this.RepairPanel.Controls.Add(this.repaircountlbl);
            this.RepairPanel.Location = new System.Drawing.Point(76, 266);
            this.RepairPanel.Name = "RepairPanel";
            this.RepairPanel.Size = new System.Drawing.Size(293, 126);
            this.RepairPanel.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(191, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // repairlbl
            // 
            this.repairlbl.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.repairlbl.AutoSize = true;
            this.repairlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repairlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairlbl.Location = new System.Drawing.Point(14, 14);
            this.repairlbl.Name = "repairlbl";
            this.repairlbl.Size = new System.Drawing.Size(158, 25);
            this.repairlbl.TabIndex = 1;
            this.repairlbl.Text = "Vehicles Repaired";
            // 
            // repaircountlbl
            // 
            this.repaircountlbl.AutoSize = true;
            this.repaircountlbl.BackColor = System.Drawing.Color.Transparent;
            this.repaircountlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repaircountlbl.Font = new System.Drawing.Font("Segoe UI", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repaircountlbl.Location = new System.Drawing.Point(4, 26);
            this.repaircountlbl.Name = "repaircountlbl";
            this.repaircountlbl.Size = new System.Drawing.Size(65, 89);
            this.repaircountlbl.TabIndex = 1;
            this.repaircountlbl.Text = "-";
            // 
            // SoldPanel
            // 
            this.SoldPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.SoldPanel.Controls.Add(this.pictureBox3);
            this.SoldPanel.Controls.Add(this.soldlbl);
            this.SoldPanel.Controls.Add(this.soldcountlbl);
            this.SoldPanel.Location = new System.Drawing.Point(76, 413);
            this.SoldPanel.Name = "SoldPanel";
            this.SoldPanel.Size = new System.Drawing.Size(293, 126);
            this.SoldPanel.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(191, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // soldlbl
            // 
            this.soldlbl.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.soldlbl.AutoSize = true;
            this.soldlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soldlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldlbl.Location = new System.Drawing.Point(14, 14);
            this.soldlbl.Name = "soldlbl";
            this.soldlbl.Size = new System.Drawing.Size(121, 25);
            this.soldlbl.TabIndex = 1;
            this.soldlbl.Text = "Vehicles Sold";
            // 
            // soldcountlbl
            // 
            this.soldcountlbl.AutoSize = true;
            this.soldcountlbl.BackColor = System.Drawing.Color.Transparent;
            this.soldcountlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soldcountlbl.Font = new System.Drawing.Font("Segoe UI", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldcountlbl.Location = new System.Drawing.Point(4, 26);
            this.soldcountlbl.Name = "soldcountlbl";
            this.soldcountlbl.Size = new System.Drawing.Size(65, 89);
            this.soldcountlbl.TabIndex = 1;
            this.soldcountlbl.Text = "-";
            // 
            // greetinglbl
            // 
            this.greetinglbl.AutoSize = true;
            this.greetinglbl.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetinglbl.ForeColor = System.Drawing.Color.White;
            this.greetinglbl.Location = new System.Drawing.Point(67, 42);
            this.greetinglbl.Name = "greetinglbl";
            this.greetinglbl.Size = new System.Drawing.Size(265, 50);
            this.greetinglbl.TabIndex = 5;
            this.greetinglbl.Text = "Good evening";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(71, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Day, Month Date";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // vendorpanel
            // 
            this.vendorpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.vendorpanel.Controls.Add(this.pictureBox4);
            this.vendorpanel.Controls.Add(this.vendorlbl);
            this.vendorpanel.Controls.Add(this.vendorcountlbl);
            this.vendorpanel.Location = new System.Drawing.Point(394, 119);
            this.vendorpanel.Name = "vendorpanel";
            this.vendorpanel.Size = new System.Drawing.Size(136, 126);
            this.vendorpanel.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(90, 78);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // vendorlbl
            // 
            this.vendorlbl.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.vendorlbl.AutoSize = true;
            this.vendorlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vendorlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorlbl.Location = new System.Drawing.Point(7, 12);
            this.vendorlbl.Name = "vendorlbl";
            this.vendorlbl.Size = new System.Drawing.Size(81, 25);
            this.vendorlbl.TabIndex = 1;
            this.vendorlbl.Text = "Vendors";
            // 
            // vendorcountlbl
            // 
            this.vendorcountlbl.AutoSize = true;
            this.vendorcountlbl.BackColor = System.Drawing.Color.Transparent;
            this.vendorcountlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vendorcountlbl.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorcountlbl.Location = new System.Drawing.Point(3, 37);
            this.vendorcountlbl.Name = "vendorcountlbl";
            this.vendorcountlbl.Size = new System.Drawing.Size(46, 62);
            this.vendorcountlbl.TabIndex = 1;
            this.vendorcountlbl.Text = "-";
            this.vendorcountlbl.Click += new System.EventHandler(this.label9_Click);
            // 
            // partspanel
            // 
            this.partspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.partspanel.Controls.Add(this.avgpartlbl);
            this.partspanel.Controls.Add(this.pictureBox5);
            this.partspanel.Controls.Add(this.avgcountbl);
            this.partspanel.Location = new System.Drawing.Point(394, 413);
            this.partspanel.Name = "partspanel";
            this.partspanel.Size = new System.Drawing.Size(293, 126);
            this.partspanel.TabIndex = 4;
            // 
            // avgpartlbl
            // 
            this.avgpartlbl.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.avgpartlbl.AutoSize = true;
            this.avgpartlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avgpartlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgpartlbl.Location = new System.Drawing.Point(14, 14);
            this.avgpartlbl.Name = "avgpartlbl";
            this.avgpartlbl.Size = new System.Drawing.Size(171, 25);
            this.avgpartlbl.TabIndex = 8;
            this.avgpartlbl.Text = "Average Parts / Car";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(191, 21);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(80, 79);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // avgcountbl
            // 
            this.avgcountbl.AutoSize = true;
            this.avgcountbl.BackColor = System.Drawing.Color.Transparent;
            this.avgcountbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avgcountbl.Font = new System.Drawing.Font("Segoe UI", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgcountbl.Location = new System.Drawing.Point(4, 26);
            this.avgcountbl.Name = "avgcountbl";
            this.avgcountbl.Size = new System.Drawing.Size(65, 89);
            this.avgcountbl.TabIndex = 1;
            this.avgcountbl.Text = "-";
            // 
            // custpanel
            // 
            this.custpanel.BackColor = System.Drawing.Color.Black;
            this.custpanel.Controls.Add(this.pictureBox6);
            this.custpanel.Controls.Add(this.custlbl);
            this.custpanel.Controls.Add(this.custcountlbl);
            this.custpanel.Location = new System.Drawing.Point(551, 119);
            this.custpanel.Name = "custpanel";
            this.custpanel.Size = new System.Drawing.Size(136, 126);
            this.custpanel.TabIndex = 5;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(90, 78);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(37, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // custlbl
            // 
            this.custlbl.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.custlbl.AutoSize = true;
            this.custlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.custlbl.Location = new System.Drawing.Point(7, 12);
            this.custlbl.Name = "custlbl";
            this.custlbl.Size = new System.Drawing.Size(101, 25);
            this.custlbl.TabIndex = 1;
            this.custlbl.Text = "Customers";
            // 
            // custcountlbl
            // 
            this.custcountlbl.AutoSize = true;
            this.custcountlbl.BackColor = System.Drawing.Color.Transparent;
            this.custcountlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custcountlbl.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custcountlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.custcountlbl.Location = new System.Drawing.Point(3, 37);
            this.custcountlbl.Name = "custcountlbl";
            this.custcountlbl.Size = new System.Drawing.Size(46, 62);
            this.custcountlbl.TabIndex = 1;
            this.custcountlbl.Text = "-";
            // 
            // emppanel
            // 
            this.emppanel.BackColor = System.Drawing.Color.Black;
            this.emppanel.Controls.Add(this.pictureBox7);
            this.emppanel.Controls.Add(this.emplbl);
            this.emppanel.Controls.Add(this.empcountlbl);
            this.emppanel.Location = new System.Drawing.Point(394, 266);
            this.emppanel.Name = "emppanel";
            this.emppanel.Size = new System.Drawing.Size(136, 126);
            this.emppanel.TabIndex = 7;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(90, 78);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(37, 37);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // emplbl
            // 
            this.emplbl.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.emplbl.AutoSize = true;
            this.emplbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emplbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.emplbl.Location = new System.Drawing.Point(7, 12);
            this.emplbl.Name = "emplbl";
            this.emplbl.Size = new System.Drawing.Size(101, 25);
            this.emplbl.TabIndex = 1;
            this.emplbl.Text = "Employees";
            // 
            // empcountlbl
            // 
            this.empcountlbl.AutoSize = true;
            this.empcountlbl.BackColor = System.Drawing.Color.Transparent;
            this.empcountlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empcountlbl.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empcountlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.empcountlbl.Location = new System.Drawing.Point(3, 37);
            this.empcountlbl.Name = "empcountlbl";
            this.empcountlbl.Size = new System.Drawing.Size(46, 62);
            this.empcountlbl.TabIndex = 1;
            this.empcountlbl.Text = "-";
            // 
            // techpanel
            // 
            this.techpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.techpanel.Controls.Add(this.pictureBox8);
            this.techpanel.Controls.Add(this.techlbl);
            this.techpanel.Controls.Add(this.techcountlbl);
            this.techpanel.Location = new System.Drawing.Point(551, 266);
            this.techpanel.Name = "techpanel";
            this.techpanel.Size = new System.Drawing.Size(136, 126);
            this.techpanel.TabIndex = 6;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(90, 78);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(37, 37);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 2;
            this.pictureBox8.TabStop = false;
            // 
            // techlbl
            // 
            this.techlbl.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.techlbl.AutoSize = true;
            this.techlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.techlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techlbl.Location = new System.Drawing.Point(7, 12);
            this.techlbl.Name = "techlbl";
            this.techlbl.Size = new System.Drawing.Size(105, 25);
            this.techlbl.TabIndex = 1;
            this.techlbl.Text = "Technicians";
            // 
            // techcountlbl
            // 
            this.techcountlbl.AutoSize = true;
            this.techcountlbl.BackColor = System.Drawing.Color.Transparent;
            this.techcountlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.techcountlbl.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techcountlbl.Location = new System.Drawing.Point(-1, 37);
            this.techcountlbl.Name = "techcountlbl";
            this.techcountlbl.Size = new System.Drawing.Size(46, 62);
            this.techcountlbl.TabIndex = 1;
            this.techcountlbl.Text = "-";
            // 
            // losspanel
            // 
            this.losspanel.BackColor = System.Drawing.Color.Black;
            this.losspanel.Controls.Add(this.Losslbl);
            this.losspanel.Controls.Add(this.label19);
            this.losspanel.Location = new System.Drawing.Point(711, 119);
            this.losspanel.Name = "losspanel";
            this.losspanel.Size = new System.Drawing.Size(293, 126);
            this.losspanel.TabIndex = 3;
            // 
            // Losslbl
            // 
            this.Losslbl.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.Losslbl.AutoSize = true;
            this.Losslbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Losslbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Losslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.Losslbl.Location = new System.Drawing.Point(14, 14);
            this.Losslbl.Name = "Losslbl";
            this.Losslbl.Size = new System.Drawing.Size(181, 25);
            this.Losslbl.TabIndex = 1;
            this.Losslbl.Text = "Total Repair Charges";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label19.Location = new System.Drawing.Point(3, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(290, 67);
            this.label19.TabIndex = 1;
            this.label19.Text = "$00000000";
            // 
            // topsellpanel
            // 
            this.topsellpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.topsellpanel.Controls.Add(this.topselllbl);
            this.topsellpanel.Controls.Add(this.label21);
            this.topsellpanel.Location = new System.Drawing.Point(711, 266);
            this.topsellpanel.Name = "topsellpanel";
            this.topsellpanel.Size = new System.Drawing.Size(293, 126);
            this.topsellpanel.TabIndex = 4;
            // 
            // topselllbl
            // 
            this.topselllbl.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.topselllbl.AutoSize = true;
            this.topselllbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topselllbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topselllbl.Location = new System.Drawing.Point(14, 14);
            this.topselllbl.Name = "topselllbl";
            this.topselllbl.Size = new System.Drawing.Size(168, 25);
            this.topselllbl.TabIndex = 1;
            this.topselllbl.Text = "Top Selling Vehicle";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(8, 41);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(182, 45);
            this.label21.TabIndex = 1;
            this.label21.Text = "Initializing";
            // 
            // profitpanel
            // 
            this.profitpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.profitpanel.Controls.Add(this.profitlbl);
            this.profitpanel.Controls.Add(this.profitamt);
            this.profitpanel.Location = new System.Drawing.Point(711, 413);
            this.profitpanel.Name = "profitpanel";
            this.profitpanel.Size = new System.Drawing.Size(293, 126);
            this.profitpanel.TabIndex = 8;
            // 
            // profitlbl
            // 
            this.profitlbl.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.profitlbl.AutoSize = true;
            this.profitlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profitlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitlbl.Location = new System.Drawing.Point(14, 14);
            this.profitlbl.Name = "profitlbl";
            this.profitlbl.Size = new System.Drawing.Size(147, 25);
            this.profitlbl.TabIndex = 1;
            this.profitlbl.Text = "Total Profit/Loss";
            // 
            // profitamt
            // 
            this.profitamt.AutoSize = true;
            this.profitamt.BackColor = System.Drawing.Color.Transparent;
            this.profitamt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profitamt.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitamt.Location = new System.Drawing.Point(3, 34);
            this.profitamt.Name = "profitamt";
            this.profitamt.Size = new System.Drawing.Size(290, 67);
            this.profitamt.TabIndex = 1;
            this.profitamt.Text = "$00000000";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // citylbl
            // 
            this.citylbl.AutoSize = true;
            this.citylbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citylbl.ForeColor = System.Drawing.Color.White;
            this.citylbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.citylbl.Location = new System.Drawing.Point(911, 54);
            this.citylbl.Name = "citylbl";
            this.citylbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.citylbl.Size = new System.Drawing.Size(89, 31);
            this.citylbl.TabIndex = 10;
            this.citylbl.Text = "Karachi";
            this.citylbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.ForeColor = System.Drawing.Color.White;
            this.timelbl.Location = new System.Drawing.Point(891, 25);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(109, 31);
            this.timelbl.TabIndex = 11;
            this.timelbl.Text = "00:00 AM";
            // 
            // carpaneltimer
            // 
            this.carpaneltimer.Interval = 1000;
            this.carpaneltimer.Tick += new System.EventHandler(this.carpaneltimer_Tick);
            // 
            // IDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1083, 576);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.citylbl);
            this.Controls.Add(this.profitpanel);
            this.Controls.Add(this.topsellpanel);
            this.Controls.Add(this.losspanel);
            this.Controls.Add(this.emppanel);
            this.Controls.Add(this.custpanel);
            this.Controls.Add(this.techpanel);
            this.Controls.Add(this.partspanel);
            this.Controls.Add(this.vendorpanel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.greetinglbl);
            this.Controls.Add(this.SoldPanel);
            this.Controls.Add(this.RepairPanel);
            this.Controls.Add(this.BuyPanel);
            this.Name = "IDashboard";
            this.Text = "Dashboard";
            this.BuyPanel.ResumeLayout(false);
            this.BuyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.RepairPanel.ResumeLayout(false);
            this.RepairPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SoldPanel.ResumeLayout(false);
            this.SoldPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.vendorpanel.ResumeLayout(false);
            this.vendorpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.partspanel.ResumeLayout(false);
            this.partspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.custpanel.ResumeLayout(false);
            this.custpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.emppanel.ResumeLayout(false);
            this.emppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.techpanel.ResumeLayout(false);
            this.techpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.losspanel.ResumeLayout(false);
            this.losspanel.PerformLayout();
            this.topsellpanel.ResumeLayout(false);
            this.topsellpanel.PerformLayout();
            this.profitpanel.ResumeLayout(false);
            this.profitpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel BuyPanel;
        protected System.Windows.Forms.Label buylbl;
        protected System.Windows.Forms.Label boughtlbl;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Panel RepairPanel;
        protected System.Windows.Forms.PictureBox pictureBox2;
        protected System.Windows.Forms.Label repairlbl;
        protected System.Windows.Forms.Label repaircountlbl;
        protected System.Windows.Forms.Panel SoldPanel;
        protected System.Windows.Forms.PictureBox pictureBox3;
        protected System.Windows.Forms.Label soldlbl;
        protected System.Windows.Forms.Label soldcountlbl;
        protected System.Windows.Forms.Label greetinglbl;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Panel vendorpanel;
        protected System.Windows.Forms.PictureBox pictureBox4;
        protected System.Windows.Forms.Label vendorlbl;
        protected System.Windows.Forms.Label vendorcountlbl;
        protected System.Windows.Forms.Panel partspanel;
        protected System.Windows.Forms.PictureBox pictureBox5;
        protected System.Windows.Forms.Label avgcountbl;
        protected System.Windows.Forms.Panel custpanel;
        protected System.Windows.Forms.PictureBox pictureBox6;
        protected System.Windows.Forms.Label custlbl;
        protected System.Windows.Forms.Label custcountlbl;
        protected System.Windows.Forms.Panel emppanel;
        protected System.Windows.Forms.PictureBox pictureBox7;
        protected System.Windows.Forms.Label emplbl;
        protected System.Windows.Forms.Label empcountlbl;
        protected System.Windows.Forms.Panel techpanel;
        protected System.Windows.Forms.PictureBox pictureBox8;
        protected System.Windows.Forms.Label techlbl;
        protected System.Windows.Forms.Label techcountlbl;
        protected System.Windows.Forms.Label avgpartlbl;
        protected System.Windows.Forms.Panel losspanel;
        protected System.Windows.Forms.Label Losslbl;
        protected System.Windows.Forms.Label label19;
        protected System.Windows.Forms.Panel topsellpanel;
        protected System.Windows.Forms.Label topselllbl;
        protected System.Windows.Forms.Label label21;
        protected System.Windows.Forms.Panel profitpanel;
        protected System.Windows.Forms.Label profitlbl;
        protected System.Windows.Forms.Label profitamt;
        protected System.Windows.Forms.Timer timer1;
        protected System.Windows.Forms.Label citylbl;
        protected System.Windows.Forms.Label timelbl;
        protected System.Windows.Forms.Timer carpaneltimer;
    }
}