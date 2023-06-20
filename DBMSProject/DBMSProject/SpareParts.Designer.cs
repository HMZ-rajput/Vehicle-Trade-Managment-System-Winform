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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.idlbl = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.desctxt = new System.Windows.Forms.TextBox();
            this.costtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.desclbl = new System.Windows.Forms.Label();
            this.costlbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idtxt
            // 
            this.idtxt.BackColor = System.Drawing.Color.Black;
            this.idtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idtxt.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.idtxt.ForeColor = System.Drawing.Color.Yellow;
            this.idtxt.Location = new System.Drawing.Point(139, 44);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(154, 20);
            this.idtxt.TabIndex = 26;
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.idlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.idlbl.Location = new System.Drawing.Point(73, 44);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(53, 20);
            this.idlbl.TabIndex = 34;
            this.idlbl.Text = "Part ID";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            this.dataGridView.Location = new System.Drawing.Point(28, 213);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.Size = new System.Drawing.Size(760, 225);
            this.dataGridView.TabIndex = 33;
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
            this.deleteBtn.Location = new System.Drawing.Point(692, 155);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(96, 28);
            this.deleteBtn.TabIndex = 32;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
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
            this.updateBtn.Location = new System.Drawing.Point(590, 155);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(96, 28);
            this.updateBtn.TabIndex = 31;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(488, 155);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(96, 28);
            this.addBtn.TabIndex = 30;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // desctxt
            // 
            this.desctxt.BackColor = System.Drawing.Color.Black;
            this.desctxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.desctxt.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.desctxt.ForeColor = System.Drawing.Color.Yellow;
            this.desctxt.Location = new System.Drawing.Point(139, 110);
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(154, 20);
            this.desctxt.TabIndex = 29;
            // 
            // costtxt
            // 
            this.costtxt.BackColor = System.Drawing.Color.Black;
            this.costtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costtxt.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.costtxt.ForeColor = System.Drawing.Color.Yellow;
            this.costtxt.Location = new System.Drawing.Point(478, 110);
            this.costtxt.Name = "costtxt";
            this.costtxt.Size = new System.Drawing.Size(154, 20);
            this.costtxt.TabIndex = 28;
            // 
            // nametxt
            // 
            this.nametxt.BackColor = System.Drawing.Color.Black;
            this.nametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nametxt.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.nametxt.ForeColor = System.Drawing.Color.Yellow;
            this.nametxt.Location = new System.Drawing.Point(478, 44);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(154, 20);
            this.nametxt.TabIndex = 27;
            // 
            // desclbl
            // 
            this.desclbl.AutoSize = true;
            this.desclbl.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.desclbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.desclbl.Location = new System.Drawing.Point(12, 110);
            this.desclbl.Name = "desclbl";
            this.desclbl.Size = new System.Drawing.Size(114, 20);
            this.desclbl.TabIndex = 35;
            this.desclbl.Text = "Part Description";
            // 
            // costlbl
            // 
            this.costlbl.AutoSize = true;
            this.costlbl.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.costlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.costlbl.Location = new System.Drawing.Point(381, 110);
            this.costlbl.Name = "costlbl";
            this.costlbl.Size = new System.Drawing.Size(67, 20);
            this.costlbl.TabIndex = 25;
            this.costlbl.Text = "Part Cost";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.Namelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.Namelbl.Location = new System.Drawing.Point(381, 44);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(78, 20);
            this.Namelbl.TabIndex = 24;
            this.Namelbl.Text = "Part Name";
            // 
            // SpareParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(812, 468);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.desctxt);
            this.Controls.Add(this.costtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.desclbl);
            this.Controls.Add(this.costlbl);
            this.Controls.Add(this.Namelbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SpareParts";
            this.Text = "SpareParts";
            this.Load += new System.EventHandler(this.SpareParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox desctxt;
        private System.Windows.Forms.TextBox costtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label desclbl;
        private System.Windows.Forms.Label costlbl;
        private System.Windows.Forms.Label Namelbl;
    }
}