namespace _12_11
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idegenvezetőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szállásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.útvonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.túraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTurak = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurak)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utasToolStripMenuItem,
            this.idegenvezetőToolStripMenuItem,
            this.szállásToolStripMenuItem,
            this.útvonalToolStripMenuItem,
            this.túraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 93);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // utasToolStripMenuItem
            // 
            this.utasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerkesztésToolStripMenuItem,
            this.keresésToolStripMenuItem});
            this.utasToolStripMenuItem.Image = global::_12_11.Properties.Resources.utas;
            this.utasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.utasToolStripMenuItem.Name = "utasToolStripMenuItem";
            this.utasToolStripMenuItem.Size = new System.Drawing.Size(76, 89);
            this.utasToolStripMenuItem.Text = "Utas";
            this.utasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // szerkesztésToolStripMenuItem
            // 
            this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
            this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.szerkesztésToolStripMenuItem.Text = "Szerkesztés";
            this.szerkesztésToolStripMenuItem.Click += new System.EventHandler(this.SzerkesztésToolStripMenuItem_Click);
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.keresésToolStripMenuItem.Text = "Keresés";
            this.keresésToolStripMenuItem.Click += new System.EventHandler(this.KeresésToolStripMenuItem_Click);
            // 
            // idegenvezetőToolStripMenuItem
            // 
            this.idegenvezetőToolStripMenuItem.Image = global::_12_11.Properties.Resources.idegenvezeto;
            this.idegenvezetőToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.idegenvezetőToolStripMenuItem.Name = "idegenvezetőToolStripMenuItem";
            this.idegenvezetőToolStripMenuItem.Size = new System.Drawing.Size(114, 89);
            this.idegenvezetőToolStripMenuItem.Text = "Idegenvezető";
            this.idegenvezetőToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // szállásToolStripMenuItem
            // 
            this.szállásToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szállásToolStripMenuItem.Image = global::_12_11.Properties.Resources.szallas;
            this.szállásToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.szállásToolStripMenuItem.Name = "szállásToolStripMenuItem";
            this.szállásToolStripMenuItem.Size = new System.Drawing.Size(76, 89);
            this.szállásToolStripMenuItem.Text = "Szállás";
            this.szállásToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // útvonalToolStripMenuItem
            // 
            this.útvonalToolStripMenuItem.Image = global::_12_11.Properties.Resources.utvonal;
            this.útvonalToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.útvonalToolStripMenuItem.Name = "útvonalToolStripMenuItem";
            this.útvonalToolStripMenuItem.Size = new System.Drawing.Size(76, 89);
            this.útvonalToolStripMenuItem.Text = "Útvonal";
            this.útvonalToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // túraToolStripMenuItem
            // 
            this.túraToolStripMenuItem.Image = global::_12_11.Properties.Resources.tura;
            this.túraToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.túraToolStripMenuItem.Name = "túraToolStripMenuItem";
            this.túraToolStripMenuItem.Size = new System.Drawing.Size(76, 89);
            this.túraToolStripMenuItem.Text = "Túra";
            this.túraToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dgvTurak
            // 
            this.dgvTurak.AllowUserToAddRows = false;
            this.dgvTurak.AllowUserToDeleteRows = false;
            this.dgvTurak.AllowUserToResizeColumns = false;
            this.dgvTurak.AllowUserToResizeRows = false;
            this.dgvTurak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTurak.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTurak.Location = new System.Drawing.Point(15, 119);
            this.dgvTurak.Name = "dgvTurak";
            this.dgvTurak.RowHeadersVisible = false;
            this.dgvTurak.Size = new System.Drawing.Size(620, 150);
            this.dgvTurak.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "T_KÓD";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cél";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kezdet";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Vége";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Idegenvezető";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Szállás";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ár (ft)";
            this.Column7.Name = "Column7";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Túrák:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMa
            // 
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMa.Location = new System.Drawing.Point(12, 282);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(181, 23);
            this.lblMa.TabIndex = 3;
            this.lblMa.Text = "###ma###:";
            this.lblMa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 540);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTurak);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem utasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idegenvezetőToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szállásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem útvonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem túraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvTurak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMa;
    }
}

