namespace e_Agro
{
    partial class frmPopisOtpremnica
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvOtpremnice = new System.Windows.Forms.DataGridView();
            this.dgvStavkeNaOtpremnici = new System.Windows.Forms.DataGridView();
            this.btnDodajStroj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtpremnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNaOtpremnici)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(306, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(121, 23);
            this.lblNaslov.TabIndex = 27;
            this.lblNaslov.Text = "Otpremnice";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Location = new System.Drawing.Point(324, 65);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(150, 37);
            this.btnAzuriraj.TabIndex = 26;
            this.btnAzuriraj.Text = "Ažuriraj otpremnicu";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(168, 65);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(150, 37);
            this.btnObrisi.TabIndex = 25;
            this.btnObrisi.Text = "Obriši otpremnicu";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(12, 65);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(150, 37);
            this.btnDodaj.TabIndex = 24;
            this.btnDodaj.Text = "Dodaj otpremnicu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvOtpremnice
            // 
            this.dgvOtpremnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtpremnice.Location = new System.Drawing.Point(12, 108);
            this.dgvOtpremnice.Name = "dgvOtpremnice";
            this.dgvOtpremnice.Size = new System.Drawing.Size(679, 267);
            this.dgvOtpremnice.TabIndex = 21;
            this.dgvOtpremnice.SelectionChanged += new System.EventHandler(this.dgvOtpremnice_SelectionChanged);
            // 
            // dgvStavkeNaOtpremnici
            // 
            this.dgvStavkeNaOtpremnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeNaOtpremnici.Location = new System.Drawing.Point(12, 427);
            this.dgvStavkeNaOtpremnici.Name = "dgvStavkeNaOtpremnici";
            this.dgvStavkeNaOtpremnici.Size = new System.Drawing.Size(679, 201);
            this.dgvStavkeNaOtpremnici.TabIndex = 28;
            // 
            // btnDodajStroj
            // 
            this.btnDodajStroj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajStroj.Location = new System.Drawing.Point(12, 634);
            this.btnDodajStroj.Name = "btnDodajStroj";
            this.btnDodajStroj.Size = new System.Drawing.Size(150, 43);
            this.btnDodajStroj.TabIndex = 29;
            this.btnDodajStroj.Text = "Dodaj stroj na otpremnicu";
            this.btnDodajStroj.UseVisualStyleBackColor = true;
            this.btnDodajStroj.Click += new System.EventHandler(this.btnDodajStroj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(267, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Stavke na otpremnici";
            // 
            // frmPopisOtpremnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(801, 689);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajStroj);
            this.Controls.Add(this.dgvStavkeNaOtpremnici);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvOtpremnice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPopisOtpremnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis otpremnica";
            this.Load += new System.EventHandler(this.frmPopisOtpremnica_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtpremnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNaOtpremnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvOtpremnice;
        private System.Windows.Forms.DataGridView dgvStavkeNaOtpremnici;
        private System.Windows.Forms.Button btnDodajStroj;
        private System.Windows.Forms.Label label1;
    }
}