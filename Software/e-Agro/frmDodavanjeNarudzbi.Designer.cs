namespace e_Agro
{
    partial class frmDodavanjeNarudzbi
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
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbDobavljac = new System.Windows.Forms.ComboBox();
            this.lblDobavljac = new System.Windows.Forms.Label();
            this.lblNaslovNarudzba = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(36, 165);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(121, 20);
            this.txtCijena.TabIndex = 49;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicina.ForeColor = System.Drawing.Color.White;
            this.lblKolicina.Location = new System.Drawing.Point(33, 145);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(54, 17);
            this.lblKolicina.TabIndex = 48;
            this.lblKolicina.Text = "Cijena:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(190, 221);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 34);
            this.btnOdustani.TabIndex = 51;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(36, 221);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(130, 34);
            this.btnDodaj.TabIndex = 50;
            this.btnDodaj.Text = "Dodaj narudžbu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbDobavljac
            // 
            this.cmbDobavljac.FormattingEnabled = true;
            this.cmbDobavljac.Location = new System.Drawing.Point(36, 98);
            this.cmbDobavljac.Name = "cmbDobavljac";
            this.cmbDobavljac.Size = new System.Drawing.Size(121, 21);
            this.cmbDobavljac.TabIndex = 54;
            // 
            // lblDobavljac
            // 
            this.lblDobavljac.AutoSize = true;
            this.lblDobavljac.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobavljac.ForeColor = System.Drawing.Color.White;
            this.lblDobavljac.Location = new System.Drawing.Point(33, 78);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(80, 17);
            this.lblDobavljac.TabIndex = 53;
            this.lblDobavljac.Text = "Dobavljač:";
            // 
            // lblNaslovNarudzba
            // 
            this.lblNaslovNarudzba.AutoSize = true;
            this.lblNaslovNarudzba.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslovNarudzba.ForeColor = System.Drawing.Color.White;
            this.lblNaslovNarudzba.Location = new System.Drawing.Point(30, 33);
            this.lblNaslovNarudzba.Name = "lblNaslovNarudzba";
            this.lblNaslovNarudzba.Size = new System.Drawing.Size(209, 22);
            this.lblNaslovNarudzba.TabIndex = 55;
            this.lblNaslovNarudzba.Text = "Dodaj novu narudžbu";
            // 
            // frmDodavanjeNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(311, 267);
            this.Controls.Add(this.lblNaslovNarudzba);
            this.Controls.Add(this.cmbDobavljac);
            this.Controls.Add(this.lblDobavljac);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDodavanjeNarudzbi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje narudžbi";
            this.Load += new System.EventHandler(this.frmDodavanjeNarudzbi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbDobavljac;
        private System.Windows.Forms.Label lblDobavljac;
        private System.Windows.Forms.Label lblNaslovNarudzba;
    }
}