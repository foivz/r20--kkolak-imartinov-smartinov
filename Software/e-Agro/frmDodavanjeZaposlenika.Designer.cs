namespace e_Agro
{
    partial class frmDodavanjeZaposlenika
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
            this.lblIme = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtTekuciRacun = new System.Windows.Forms.TextBox();
            this.lblTekuci = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.gbRadnoMjesto = new System.Windows.Forms.GroupBox();
            this.cbRadnoMjesto = new System.Windows.Forms.ComboBox();
            this.rbSkladiste = new System.Windows.Forms.RadioButton();
            this.rbUred = new System.Windows.Forms.RadioButton();
            this.cbKorisnickiRacun = new System.Windows.Forms.ComboBox();
            this.lblKorisnickiRacun = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.gbRadnoMjesto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(78, 34);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(111, 31);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 1;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(111, 71);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 3;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(58, 74);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "Prezime:";
            // 
            // txtTekuciRacun
            // 
            this.txtTekuciRacun.Location = new System.Drawing.Point(111, 114);
            this.txtTekuciRacun.Name = "txtTekuciRacun";
            this.txtTekuciRacun.Size = new System.Drawing.Size(100, 20);
            this.txtTekuciRacun.TabIndex = 5;
            // 
            // lblTekuci
            // 
            this.lblTekuci.AutoSize = true;
            this.lblTekuci.Location = new System.Drawing.Point(32, 117);
            this.lblTekuci.Name = "lblTekuci";
            this.lblTekuci.Size = new System.Drawing.Size(73, 13);
            this.lblTekuci.TabIndex = 4;
            this.lblTekuci.Text = "Tekući račun:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(111, 163);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 7;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(62, 166);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(43, 13);
            this.lblAdresa.TabIndex = 6;
            this.lblAdresa.Text = "Adresa:";
            // 
            // gbRadnoMjesto
            // 
            this.gbRadnoMjesto.Controls.Add(this.cbRadnoMjesto);
            this.gbRadnoMjesto.Controls.Add(this.rbSkladiste);
            this.gbRadnoMjesto.Controls.Add(this.rbUred);
            this.gbRadnoMjesto.Location = new System.Drawing.Point(73, 202);
            this.gbRadnoMjesto.Name = "gbRadnoMjesto";
            this.gbRadnoMjesto.Size = new System.Drawing.Size(228, 70);
            this.gbRadnoMjesto.TabIndex = 8;
            this.gbRadnoMjesto.TabStop = false;
            this.gbRadnoMjesto.Text = "Radno mjesto";
            // 
            // cbRadnoMjesto
            // 
            this.cbRadnoMjesto.FormattingEnabled = true;
            this.cbRadnoMjesto.Location = new System.Drawing.Point(97, 29);
            this.cbRadnoMjesto.Name = "cbRadnoMjesto";
            this.cbRadnoMjesto.Size = new System.Drawing.Size(121, 21);
            this.cbRadnoMjesto.TabIndex = 2;
            // 
            // rbSkladiste
            // 
            this.rbSkladiste.AutoSize = true;
            this.rbSkladiste.Location = new System.Drawing.Point(7, 43);
            this.rbSkladiste.Name = "rbSkladiste";
            this.rbSkladiste.Size = new System.Drawing.Size(68, 17);
            this.rbSkladiste.TabIndex = 1;
            this.rbSkladiste.TabStop = true;
            this.rbSkladiste.Text = "Skladište";
            this.rbSkladiste.UseVisualStyleBackColor = true;
            // 
            // rbUred
            // 
            this.rbUred.AutoSize = true;
            this.rbUred.Location = new System.Drawing.Point(7, 20);
            this.rbUred.Name = "rbUred";
            this.rbUred.Size = new System.Drawing.Size(48, 17);
            this.rbUred.TabIndex = 0;
            this.rbUred.TabStop = true;
            this.rbUred.Text = "Ured";
            this.rbUred.UseVisualStyleBackColor = true;
            // 
            // cbKorisnickiRacun
            // 
            this.cbKorisnickiRacun.FormattingEnabled = true;
            this.cbKorisnickiRacun.Location = new System.Drawing.Point(111, 278);
            this.cbKorisnickiRacun.Name = "cbKorisnickiRacun";
            this.cbKorisnickiRacun.Size = new System.Drawing.Size(121, 21);
            this.cbKorisnickiRacun.TabIndex = 9;
            // 
            // lblKorisnickiRacun
            // 
            this.lblKorisnickiRacun.AutoSize = true;
            this.lblKorisnickiRacun.Location = new System.Drawing.Point(20, 281);
            this.lblKorisnickiRacun.Name = "lblKorisnickiRacun";
            this.lblKorisnickiRacun.Size = new System.Drawing.Size(85, 13);
            this.lblKorisnickiRacun.TabIndex = 10;
            this.lblKorisnickiRacun.Text = "Korisnički račun:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 326);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 34);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj zaposlenika";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(226, 332);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // frmDodavanjeZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 370);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblKorisnickiRacun);
            this.Controls.Add(this.cbKorisnickiRacun);
            this.Controls.Add(this.gbRadnoMjesto);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.txtTekuciRacun);
            this.Controls.Add(this.lblTekuci);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblIme);
            this.Name = "frmDodavanjeZaposlenika";
            this.Text = "Dodavanje zaposlenika";
            this.gbRadnoMjesto.ResumeLayout(false);
            this.gbRadnoMjesto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtTekuciRacun;
        private System.Windows.Forms.Label lblTekuci;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.GroupBox gbRadnoMjesto;
        private System.Windows.Forms.ComboBox cbRadnoMjesto;
        private System.Windows.Forms.RadioButton rbSkladiste;
        private System.Windows.Forms.RadioButton rbUred;
        private System.Windows.Forms.ComboBox cbKorisnickiRacun;
        private System.Windows.Forms.Label lblKorisnickiRacun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
    }
}