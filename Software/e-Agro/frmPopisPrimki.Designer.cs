namespace e_Agro
{
    partial class frmPopisPrimki
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvPrimke = new System.Windows.Forms.DataGridView();
            this.dgvStavkeNaPrimci = new System.Windows.Forms.DataGridView();
            this.btnDodajStrojNaPrimku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNaPrimci)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(342, 8);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(73, 23);
            this.lblNaslov.TabIndex = 27;
            this.lblNaslov.Text = "Primke";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Location = new System.Drawing.Point(304, 38);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(140, 37);
            this.btnAzuriraj.TabIndex = 26;
            this.btnAzuriraj.Text = "Ažuriraj primku";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(158, 38);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(140, 37);
            this.btnObrisi.TabIndex = 25;
            this.btnObrisi.Text = "Obriši primku";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(12, 38);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(140, 37);
            this.btnDodaj.TabIndex = 24;
            this.btnDodaj.Text = "Dodaj primku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(618, 54);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 21);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.Text = "Unesite riječ za pretragu...";
            // 
            // dgvPrimke
            // 
            this.dgvPrimke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimke.Location = new System.Drawing.Point(12, 81);
            this.dgvPrimke.Name = "dgvPrimke";
            this.dgvPrimke.Size = new System.Drawing.Size(776, 258);
            this.dgvPrimke.TabIndex = 21;
            this.dgvPrimke.SelectionChanged += new System.EventHandler(this.dgvPrimke_SelectionChanged);
            // 
            // dgvStavkeNaPrimci
            // 
            this.dgvStavkeNaPrimci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeNaPrimci.Location = new System.Drawing.Point(12, 345);
            this.dgvStavkeNaPrimci.Name = "dgvStavkeNaPrimci";
            this.dgvStavkeNaPrimci.Size = new System.Drawing.Size(776, 258);
            this.dgvStavkeNaPrimci.TabIndex = 28;
            // 
            // btnDodajStrojNaPrimku
            // 
            this.btnDodajStrojNaPrimku.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajStrojNaPrimku.Location = new System.Drawing.Point(12, 609);
            this.btnDodajStrojNaPrimku.Name = "btnDodajStrojNaPrimku";
            this.btnDodajStrojNaPrimku.Size = new System.Drawing.Size(140, 54);
            this.btnDodajStrojNaPrimku.TabIndex = 29;
            this.btnDodajStrojNaPrimku.Text = "Dodaj stroj na primku";
            this.btnDodajStrojNaPrimku.UseVisualStyleBackColor = true;
            this.btnDodajStrojNaPrimku.Click += new System.EventHandler(this.btnDodajStrojNaPrimku_Click);
            // 
            // frmPopisPrimki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(795, 670);
            this.Controls.Add(this.btnDodajStrojNaPrimku);
            this.Controls.Add(this.dgvStavkeNaPrimci);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvPrimke);
            this.Name = "frmPopisPrimki";
            this.Text = "frmPrimka";
            this.Load += new System.EventHandler(this.frmPopisPrimki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNaPrimci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvPrimke;
        private System.Windows.Forms.DataGridView dgvStavkeNaPrimci;
        private System.Windows.Forms.Button btnDodajStrojNaPrimku;
    }
}