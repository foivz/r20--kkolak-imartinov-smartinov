namespace e_Agro
{
    partial class frmDodavanjeDobavljaca
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
            this.txtTekuciRacun = new System.Windows.Forms.TextBox();
            this.lblTekuciRacun = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTekuciRacun
            // 
            this.txtTekuciRacun.Location = new System.Drawing.Point(107, 100);
            this.txtTekuciRacun.Name = "txtTekuciRacun";
            this.txtTekuciRacun.Size = new System.Drawing.Size(100, 20);
            this.txtTekuciRacun.TabIndex = 41;
            // 
            // lblTekuciRacun
            // 
            this.lblTekuciRacun.AutoSize = true;
            this.lblTekuciRacun.Location = new System.Drawing.Point(28, 103);
            this.lblTekuciRacun.Name = "lblTekuciRacun";
            this.lblTekuciRacun.Size = new System.Drawing.Size(73, 13);
            this.lblTekuciRacun.TabIndex = 40;
            this.lblTekuciRacun.Text = "Tekući račun:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(107, 63);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 39;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(58, 66);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(43, 13);
            this.lblAdresa.TabIndex = 38;
            this.lblAdresa.Text = "Adresa:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(107, 23);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 37;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(64, 26);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 36;
            this.lblNaziv.Text = "Naziv:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(188, 143);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 43;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 137);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 34);
            this.btnDodaj.TabIndex = 42;
            this.btnDodaj.Text = "Dodaj dobavljača";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmDodavanjeDobavljaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 197);
            this.Controls.Add(this.txtTekuciRacun);
            this.Controls.Add(this.lblTekuciRacun);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Name = "frmDodavanjeDobavljaca";
            this.Text = "Dodavanje dobavljača";
            this.Load += new System.EventHandler(this.frmDodavanjeDobavljaca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTekuciRacun;
        private System.Windows.Forms.Label lblTekuciRacun;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
    }
}