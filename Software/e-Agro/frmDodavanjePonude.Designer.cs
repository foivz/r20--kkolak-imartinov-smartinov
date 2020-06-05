namespace e_Agro
{
    partial class frmDodavanjePonude
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
            this.lblDatumKreiranja = new System.Windows.Forms.Label();
            this.dtpDatumKreiranja = new System.Windows.Forms.DateTimePicker();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblKreirao = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblKlijent = new System.Windows.Forms.Label();
            this.cbKlijent = new System.Windows.Forms.ComboBox();
            this.cbKreirao = new System.Windows.Forms.ComboBox();
            this.lblNaslovPonuda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDatumKreiranja
            // 
            this.lblDatumKreiranja.AutoSize = true;
            this.lblDatumKreiranja.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumKreiranja.ForeColor = System.Drawing.Color.White;
            this.lblDatumKreiranja.Location = new System.Drawing.Point(37, 214);
            this.lblDatumKreiranja.Name = "lblDatumKreiranja";
            this.lblDatumKreiranja.Size = new System.Drawing.Size(116, 17);
            this.lblDatumKreiranja.TabIndex = 49;
            this.lblDatumKreiranja.Text = "Datum kreiranja:";
            // 
            // dtpDatumKreiranja
            // 
            this.dtpDatumKreiranja.Location = new System.Drawing.Point(40, 234);
            this.dtpDatumKreiranja.Name = "dtpDatumKreiranja";
            this.dtpDatumKreiranja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumKreiranja.TabIndex = 48;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(311, 163);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(121, 20);
            this.txtCijena.TabIndex = 47;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCijena.ForeColor = System.Drawing.Color.White;
            this.lblCijena.Location = new System.Drawing.Point(308, 143);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(54, 17);
            this.lblCijena.TabIndex = 46;
            this.lblCijena.Text = "Cijena:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(174, 163);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(121, 20);
            this.txtKolicina.TabIndex = 45;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicina.ForeColor = System.Drawing.Color.White;
            this.lblKolicina.Location = new System.Drawing.Point(171, 143);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(63, 17);
            this.lblKolicina.TabIndex = 44;
            this.lblKolicina.Text = "Količina:";
            // 
            // lblKreirao
            // 
            this.lblKreirao.AutoSize = true;
            this.lblKreirao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKreirao.ForeColor = System.Drawing.Color.White;
            this.lblKreirao.Location = new System.Drawing.Point(37, 73);
            this.lblKreirao.Name = "lblKreirao";
            this.lblKreirao.Size = new System.Drawing.Size(57, 17);
            this.lblKreirao.TabIndex = 38;
            this.lblKreirao.Text = "Kreirao:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(174, 366);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 34);
            this.btnOdustani.TabIndex = 43;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(40, 366);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(120, 34);
            this.btnDodaj.TabIndex = 42;
            this.btnDodaj.Text = "Dodaj ponudu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(40, 163);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(121, 20);
            this.txtNaziv.TabIndex = 51;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.Color.White;
            this.lblNaziv.Location = new System.Drawing.Point(37, 143);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(48, 17);
            this.lblNaziv.TabIndex = 50;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblKlijent
            // 
            this.lblKlijent.AutoSize = true;
            this.lblKlijent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlijent.ForeColor = System.Drawing.Color.White;
            this.lblKlijent.Location = new System.Drawing.Point(37, 291);
            this.lblKlijent.Name = "lblKlijent";
            this.lblKlijent.Size = new System.Drawing.Size(50, 17);
            this.lblKlijent.TabIndex = 52;
            this.lblKlijent.Text = "Klijent:";
            // 
            // cbKlijent
            // 
            this.cbKlijent.FormattingEnabled = true;
            this.cbKlijent.Location = new System.Drawing.Point(40, 311);
            this.cbKlijent.Name = "cbKlijent";
            this.cbKlijent.Size = new System.Drawing.Size(121, 21);
            this.cbKlijent.TabIndex = 53;
            // 
            // cbKreirao
            // 
            this.cbKreirao.FormattingEnabled = true;
            this.cbKreirao.Location = new System.Drawing.Point(40, 93);
            this.cbKreirao.Name = "cbKreirao";
            this.cbKreirao.Size = new System.Drawing.Size(121, 21);
            this.cbKreirao.TabIndex = 55;
            // 
            // lblNaslovPonuda
            // 
            this.lblNaslovPonuda.AutoSize = true;
            this.lblNaslovPonuda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslovPonuda.ForeColor = System.Drawing.Color.White;
            this.lblNaslovPonuda.Location = new System.Drawing.Point(36, 23);
            this.lblNaslovPonuda.Name = "lblNaslovPonuda";
            this.lblNaslovPonuda.Size = new System.Drawing.Size(194, 22);
            this.lblNaslovPonuda.TabIndex = 56;
            this.lblNaslovPonuda.Text = "Dodaj novu ponudu";
            // 
            // frmDodavanjePonude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(482, 428);
            this.Controls.Add(this.lblNaslovPonuda);
            this.Controls.Add(this.cbKreirao);
            this.Controls.Add(this.cbKlijent);
            this.Controls.Add(this.lblKlijent);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblDatumKreiranja);
            this.Controls.Add(this.dtpDatumKreiranja);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblKreirao);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Name = "frmDodavanjePonude";
            this.Text = "Dodavanje ponude";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatumKreiranja;
        private System.Windows.Forms.DateTimePicker dtpDatumKreiranja;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblKreirao;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblKlijent;
        private System.Windows.Forms.ComboBox cbKlijent;
        private System.Windows.Forms.ComboBox cbKreirao;
        private System.Windows.Forms.Label lblNaslovPonuda;
    }
}