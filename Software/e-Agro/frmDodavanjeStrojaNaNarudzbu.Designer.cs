namespace e_Agro
{
    partial class frmDodavanjeStrojaNaNarudzbu
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
            this.lblStroj = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbStrojevi = new System.Windows.Forms.ComboBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStroj
            // 
            this.lblStroj.AutoSize = true;
            this.lblStroj.Location = new System.Drawing.Point(12, 24);
            this.lblStroj.Name = "lblStroj";
            this.lblStroj.Size = new System.Drawing.Size(31, 13);
            this.lblStroj.TabIndex = 0;
            this.lblStroj.Text = "Stroj:";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(209, 24);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(47, 13);
            this.lblKolicina.TabIndex = 1;
            this.lblKolicina.Text = "Količina:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(12, 96);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(140, 48);
            this.btnDodaj.TabIndex = 25;
            this.btnDodaj.Text = "Dodaj stroj na narudžbu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbStrojevi
            // 
            this.cmbStrojevi.FormattingEnabled = true;
            this.cmbStrojevi.Location = new System.Drawing.Point(49, 16);
            this.cmbStrojevi.Name = "cmbStrojevi";
            this.cmbStrojevi.Size = new System.Drawing.Size(121, 21);
            this.cmbStrojevi.TabIndex = 26;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(262, 17);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 20);
            this.txtKolicina.TabIndex = 27;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(195, 96);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(140, 48);
            this.btnOdustani.TabIndex = 28;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // frmDodavanjeStrojaNaNarudzbu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 161);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.cmbStrojevi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblStroj);
            this.Name = "frmDodavanjeStrojaNaNarudzbu";
            this.Text = "frmDodavanjeStrojaNaNarudzbu";
            this.Load += new System.EventHandler(this.frmDodavanjeStrojaNaNarudzbu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStroj;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbStrojevi;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Button btnOdustani;
    }
}