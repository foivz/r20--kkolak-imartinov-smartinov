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
            this.lblKreirao = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblKlijent = new System.Windows.Forms.Label();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.cmbKreirao = new System.Windows.Forms.ComboBox();
            this.lblNaslov = new System.Windows.Forms.Label();
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
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
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
            // cmbKlijent
            // 
            this.cmbKlijent.FormattingEnabled = true;
            this.cmbKlijent.Location = new System.Drawing.Point(40, 311);
            this.cmbKlijent.Name = "cmbKlijent";
            this.cmbKlijent.Size = new System.Drawing.Size(121, 21);
            this.cmbKlijent.TabIndex = 53;
            // 
            // cmbKreirao
            // 
            this.cmbKreirao.FormattingEnabled = true;
            this.cmbKreirao.Location = new System.Drawing.Point(40, 93);
            this.cmbKreirao.Name = "cmbKreirao";
            this.cmbKreirao.Size = new System.Drawing.Size(121, 21);
            this.cmbKreirao.TabIndex = 55;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(36, 23);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(194, 22);
            this.lblNaslov.TabIndex = 56;
            this.lblNaslov.Text = "Dodaj novu ponudu";
            // 
            // frmDodavanjePonude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(482, 428);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.cmbKreirao);
            this.Controls.Add(this.cmbKlijent);
            this.Controls.Add(this.lblKlijent);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblDatumKreiranja);
            this.Controls.Add(this.dtpDatumKreiranja);
            this.Controls.Add(this.lblKreirao);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDodavanjePonude";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje ponude";
            this.Load += new System.EventHandler(this.frmDodavanjePonude_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDodavanjePonude_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatumKreiranja;
        private System.Windows.Forms.DateTimePicker dtpDatumKreiranja;
        private System.Windows.Forms.Label lblKreirao;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblKlijent;
        private System.Windows.Forms.ComboBox cmbKlijent;
        private System.Windows.Forms.ComboBox cmbKreirao;
        private System.Windows.Forms.Label lblNaslov;
    }
}