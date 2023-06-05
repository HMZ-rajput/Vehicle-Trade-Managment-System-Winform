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
            this.label1.Location = new System.Drawing.Point(467, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spare Parts";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(141, 435);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 28);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete Part";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(141, 383);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(100, 28);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update Part";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(141, 333);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 28);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Add Part";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(390, 88);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(580, 374);
            this.dataGridView.TabIndex = 15;
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(12, 134);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(77, 16);
            this.Namelbl.TabIndex = 16;
            this.Namelbl.Text = "Part Name: ";
            // 
            // costlbl
            // 
            this.costlbl.AutoSize = true;
            this.costlbl.Location = new System.Drawing.Point(12, 218);
            this.costlbl.Name = "costlbl";
            this.costlbl.Size = new System.Drawing.Size(67, 16);
            this.costlbl.TabIndex = 17;
            this.costlbl.Text = "Part Cost: ";
            // 
            // desclbl
            // 
            this.desclbl.AutoSize = true;
            this.desclbl.Location = new System.Drawing.Point(12, 176);
            this.desclbl.Name = "desclbl";
            this.desclbl.Size = new System.Drawing.Size(108, 16);
            this.desclbl.TabIndex = 18;
            this.desclbl.Text = "Part Description: ";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(170, 131);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(178, 22);
            this.nametxt.TabIndex = 19;
            this.nametxt.Text = "Enter Part Name";
            // 
            // desctxt
            // 
            this.desctxt.Location = new System.Drawing.Point(170, 173);
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(178, 22);
            this.desctxt.TabIndex = 20;
            this.desctxt.Text = "Enter Part Description";
            // 
            // costtxt
            // 
            this.costtxt.Location = new System.Drawing.Point(170, 218);
            this.costtxt.Name = "costtxt";
            this.costtxt.Size = new System.Drawing.Size(178, 22);
            this.costtxt.TabIndex = 21;
            this.costtxt.Text = "Enter Part Cost";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(170, 88);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(178, 22);
            this.idtxt.TabIndex = 23;
            this.idtxt.Text = "Enter Part ID";
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Location = new System.Drawing.Point(12, 94);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(53, 16);
            this.idlbl.TabIndex = 22;
            this.idlbl.Text = "Part ID: ";
            // 
            // SpareParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 510);
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