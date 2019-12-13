using System;

namespace _12_11
{
    partial class UtasSzerkesztes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UtasSzerkesztes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKod = new System.Windows.Forms.TextBox();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.rtbCim = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiTorles = new System.Windows.Forms.ToolStripMenuItem();
            this.üresŰrlapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utas kód:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cím:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jelentkezés:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbKod
            // 
            this.tbKod.Location = new System.Drawing.Point(118, 33);
            this.tbKod.Name = "tbKod";
            this.tbKod.ReadOnly = true;
            this.tbKod.Size = new System.Drawing.Size(100, 20);
            this.tbKod.TabIndex = 4;
            this.tbKod.TextChanged += new System.EventHandler(this.tbKod_TextChanged);
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(118, 67);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(263, 20);
            this.tbNev.TabIndex = 5;
            // 
            // rtbCim
            // 
            this.rtbCim.Location = new System.Drawing.Point(118, 105);
            this.rtbCim.Name = "rtbCim";
            this.rtbCim.Size = new System.Drawing.Size(263, 118);
            this.rtbCim.TabIndex = 6;
            this.rtbCim.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 237);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keresésToolStripMenuItem,
            this.mentésToolStripMenuItem,
            this.TsmiTorles,
            this.üresŰrlapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(384, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(167, 289);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Image = global::_12_11.Properties.Resources.keres;
            this.keresésToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(160, 61);
            this.keresésToolStripMenuItem.Text = "Keresés";
            this.keresésToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.keresésToolStripMenuItem.Click += new System.EventHandler(this.KeresésToolStripMenuItem_Click);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Image = global::_12_11.Properties.Resources.ment;
            this.mentésToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(160, 61);
            this.mentésToolStripMenuItem.Text = "Mentés";
            this.mentésToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mentésToolStripMenuItem.Click += new System.EventHandler(this.MentésToolStripMenuItem_Click);
            // 
            // TsmiTorles
            // 
            this.TsmiTorles.Enabled = false;
            this.TsmiTorles.Image = global::_12_11.Properties.Resources.delete;
            this.TsmiTorles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsmiTorles.Name = "TsmiTorles";
            this.TsmiTorles.Size = new System.Drawing.Size(160, 61);
            this.TsmiTorles.Text = "Törlés";
            this.TsmiTorles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsmiTorles.Click += new System.EventHandler(this.TörlésToolStripMenuItem_Click);
            // 
            // üresŰrlapToolStripMenuItem
            // 
            this.üresŰrlapToolStripMenuItem.Image = global::_12_11.Properties.Resources.ures;
            this.üresŰrlapToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.üresŰrlapToolStripMenuItem.Name = "üresŰrlapToolStripMenuItem";
            this.üresŰrlapToolStripMenuItem.Size = new System.Drawing.Size(160, 61);
            this.üresŰrlapToolStripMenuItem.Text = "Üres Űrlap";
            this.üresŰrlapToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // UtasSzerkesztes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 289);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rtbCim);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.tbKod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UtasSzerkesztes";
            this.Text = "UtasSzerkesztes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tbKod_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKod;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.RichTextBox rtbCim;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmiTorles;
        private System.Windows.Forms.ToolStripMenuItem üresŰrlapToolStripMenuItem;
    }
}