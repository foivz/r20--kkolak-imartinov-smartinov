﻿namespace e_Agro
{
    partial class frmSkladistar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSkladistar));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOtpremnica = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPrimka = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnStrojeviNaSkladistu = new System.Windows.Forms.Button();
            this.msIzbornik = new System.Windows.Forms.MenuStrip();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.msIzbornik.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOtpremnica);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(600, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 102);
            this.panel2.TabIndex = 0;
            // 
            // btnOtpremnica
            // 
            this.btnOtpremnica.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnOtpremnica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOtpremnica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtpremnica.ForeColor = System.Drawing.Color.White;
            this.btnOtpremnica.Image = ((System.Drawing.Image)(resources.GetObject("btnOtpremnica.Image")));
            this.btnOtpremnica.Location = new System.Drawing.Point(0, 0);
            this.btnOtpremnica.Name = "btnOtpremnica";
            this.btnOtpremnica.Size = new System.Drawing.Size(200, 102);
            this.btnOtpremnica.TabIndex = 0;
            this.btnOtpremnica.Text = "Otpremnica";
            this.btnOtpremnica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOtpremnica.UseVisualStyleBackColor = false;
            this.btnOtpremnica.Click += new System.EventHandler(this.btnOtpremnica_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPrimka);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(400, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 102);
            this.panel3.TabIndex = 1;
            // 
            // btnPrimka
            // 
            this.btnPrimka.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrimka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrimka.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimka.ForeColor = System.Drawing.Color.White;
            this.btnPrimka.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimka.Image")));
            this.btnPrimka.Location = new System.Drawing.Point(0, 0);
            this.btnPrimka.Name = "btnPrimka";
            this.btnPrimka.Size = new System.Drawing.Size(200, 102);
            this.btnPrimka.TabIndex = 1;
            this.btnPrimka.Text = "Primka";
            this.btnPrimka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrimka.UseVisualStyleBackColor = false;
            this.btnPrimka.Click += new System.EventHandler(this.btnPrimka_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnIzvjestaj);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 102);
            this.panel4.TabIndex = 2;
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIzvjestaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIzvjestaj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzvjestaj.ForeColor = System.Drawing.Color.White;
            this.btnIzvjestaj.Image = ((System.Drawing.Image)(resources.GetObject("btnIzvjestaj.Image")));
            this.btnIzvjestaj.Location = new System.Drawing.Point(0, 0);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(200, 102);
            this.btnIzvjestaj.TabIndex = 2;
            this.btnIzvjestaj.Text = "Izvještaj stanja na skladištu";
            this.btnIzvjestaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIzvjestaj.UseVisualStyleBackColor = false;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 102);
            this.panel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnStrojeviNaSkladistu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 102);
            this.panel5.TabIndex = 3;
            // 
            // btnStrojeviNaSkladistu
            // 
            this.btnStrojeviNaSkladistu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnStrojeviNaSkladistu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStrojeviNaSkladistu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStrojeviNaSkladistu.ForeColor = System.Drawing.Color.White;
            this.btnStrojeviNaSkladistu.Image = ((System.Drawing.Image)(resources.GetObject("btnStrojeviNaSkladistu.Image")));
            this.btnStrojeviNaSkladistu.Location = new System.Drawing.Point(0, 0);
            this.btnStrojeviNaSkladistu.Name = "btnStrojeviNaSkladistu";
            this.btnStrojeviNaSkladistu.Size = new System.Drawing.Size(200, 102);
            this.btnStrojeviNaSkladistu.TabIndex = 4;
            this.btnStrojeviNaSkladistu.Text = "Strojevi na skladištu";
            this.btnStrojeviNaSkladistu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStrojeviNaSkladistu.UseVisualStyleBackColor = false;
            this.btnStrojeviNaSkladistu.Click += new System.EventHandler(this.btnStrojeviNaSkladistu_Click);
            // 
            // msIzbornik
            // 
            this.msIzbornik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odjavaToolStripMenuItem});
            this.msIzbornik.Location = new System.Drawing.Point(0, 0);
            this.msIzbornik.Name = "msIzbornik";
            this.msIzbornik.Size = new System.Drawing.Size(800, 24);
            this.msIzbornik.TabIndex = 5;
            this.msIzbornik.Text = "menuStrip1";
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // frmSkladistar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 128);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.msIzbornik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.msIzbornik;
            this.Name = "frmSkladistar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSkladistar";
            this.Load += new System.EventHandler(this.frmSkladistar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSkladistar_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.msIzbornik.ResumeLayout(false);
            this.msIzbornik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOtpremnica;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPrimka;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStrojeviNaSkladistu;
        private System.Windows.Forms.Button btnIzvjestaj;
        private System.Windows.Forms.MenuStrip msIzbornik;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
    }
}