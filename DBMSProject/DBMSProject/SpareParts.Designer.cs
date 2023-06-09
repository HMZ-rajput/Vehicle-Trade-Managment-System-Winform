namespace DBMSProject
{
    partial class SpareParts
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Namelbl = new System.Windows.Forms.Label();
            this.costlbl = new System.Windows.Forms.Label();
            this.desclbl = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.desctxt = new System.Windows.Forms.TextBox();
            this.costtxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.idlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spare Parts";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(106, 353);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete Part";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(106, 311);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update Part";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(106, 271);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Add Part";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(292, 72);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(435, 304);
            this.dataGridView.TabIndex = 15;
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(9, 109);
            this.Namelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(63, 13);
            this.Namelbl.TabIndex = 16;
            this.Namelbl.Text = "Part Name: ";
            // 
            // costlbl
            // 
            this.costlbl.AutoSize = true;
            this.costlbl.Location = new System.Drawing.Point(9, 177);
            this.costlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costlbl.Name = "costlbl";
            this.costlbl.Size = new System.Drawing.Size(56, 13);
            this.costlbl.TabIndex = 17;
            this.costlbl.Text = "Part Cost: ";
            // 
            // desclbl
            // 
            this.desclbl.AutoSize = true;
            this.desclbl.Location = new System.Drawing.Point(9, 143);
            this.desclbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.desclbl.Name = "desclbl";
            this.desclbl.Size = new System.Drawing.Size(88, 13);
            this.desclbl.TabIndex = 18;
            this.desclbl.Text = "Part Description: ";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(128, 106);
            this.nametxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(134, 20);
            this.nametxt.TabIndex = 19;
            this.nametxt.Text = "Enter Part Name";
            // 
            // desctxt
            // 
            this.desctxt.Location = new System.Drawing.Point(128, 141);
            this.desctxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(134, 20);
            this.desctxt.TabIndex = 20;
            this.desctxt.Text = "Enter Part Description";
            // 
            // costtxt
            // 
            this.costtxt.Location = new System.Drawing.Point(128, 177);
            this.costtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.costtxt.Name = "costtxt";
            this.costtxt.Size = new System.Drawing.Size(134, 20);
            this.costtxt.TabIndex = 21;
            this.costtxt.Text = "Enter Part Cost";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(128, 72);
            this.idtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(134, 20);
            this.idtxt.TabIndex = 23;
            this.idtxt.Text = "Enter Part ID";
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Location = new System.Drawing.Point(9, 76);
            this.idlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(46, 13);
            this.idlbl.TabIndex = 22;
            this.idlbl.Text = "Part ID: ";
            // 
            // SpareParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(748, 414);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.costtxt);
            this.Controls.Add(this.desctxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.desclbl);
            this.Controls.Add(this.costlbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SpareParts";
            this.Text = "SpareParts";
            this.Load += new System.EventHandler(this.SpareParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label costlbl;
        private System.Windows.Forms.Label desclbl;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox desctxt;
        private System.Windows.Forms.TextBox costtxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label idlbl;
    }
}