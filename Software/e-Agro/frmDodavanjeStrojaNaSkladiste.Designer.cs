namespace e_Agro
{
    partial class frmDodavanjeStrojaNaSkladiste
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.cmbStrojevi = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblSkladiste = new System.Windows.Forms.Label();
            this.lblStroj = new System.Windows.Forms.Label();
            this.cmbSkladiste = new System.Windows.Forms.ComboBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(23, 22);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(221, 22);
            this.lblNaslov.TabIndex = 36;
            this.lblNaslov.Text = "Dodaj stroj na skladište";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(314, 167);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(120, 34);
            this.btnOdustani.TabIndex = 35;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // cmbStrojevi
            // 
            this.cmbStrojevi.FormattingEnabled = true;
            this.cmbStrojevi.Location = new System.Drawing.Point(27, 104);
            this.cmbStrojevi.Name = "cmbStrojevi";
            this.cmbStrojevi.Size = new System.Drawing.Size(121, 21);
            this.cmbStrojevi.TabIndex = 33;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(27, 167);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(120, 34);
            this.btnDodaj.TabIndex = 32;
            this.btnDodaj.Text = "Dodaj ";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblSkladiste
            // 
            this.lblSkladiste.AutoSize = true;
            this.lblSkladiste.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkladiste.ForeColor = System.Drawing.Color.White;
            this.lblSkladiste.Location = new System.Drawing.Point(179, 84);
            this.lblSkladiste.Name = "lblSkladiste";
            this.lblSkladiste.Size = new System.Drawing.Size(67, 17);
            this.lblSkladiste.TabIndex = 31;
            this.lblSkladiste.Text = "Skladište:";
            // 
            // lblStroj
            // 
            this.lblStroj.AutoSize = true;
            this.lblStroj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStroj.ForeColor = System.Drawing.Color.White;
            this.lblStroj.Location = new System.Drawing.Point(24, 84);
            this.lblStroj.Name = "lblStroj";
            this.lblStroj.Size = new System.Drawing.Size(39, 17);
            this.lblStroj.TabIndex = 30;
            this.lblStroj.Text = "Stroj:";
            // 
            // cmbSkladiste
            // 
            this.cmbSkladiste.FormattingEnabled = true;
            this.cmbSkladiste.Location = new System.Drawing.Point(181, 104);
            this.cmbSkladiste.Name = "cmbSkladiste";
            this.cmbSkladiste.Size = new System.Drawing.Size(121, 21);
            this.cmbSkladiste.TabIndex = 33;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicina.ForeColor = System.Drawing.Color.White;
            this.lblKolicina.Location = new System.Drawing.Point(331, 84);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(63, 17);
            this.lblKolicina.TabIndex = 31;
            this.lblKolicina.Text = "Količina:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(334, 104);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 20);
            this.txtKolicina.TabIndex = 37;
            // 
            // frmDodavanjeStrojaNaSkladiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(540, 232);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.cmbSkladiste);
            this.Controls.Add(this.cmbStrojevi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblSkladiste);
            this.Controls.Add(this.lblStroj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDodavanjeStrojaNaSkladiste";
            this.Text = "frmDodavanjeStrojaNaSkladiste";
            this.Load += new System.EventHandler(this.frmDodavanjeStrojaNaSkladiste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ComboBox cmbStrojevi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblSkladiste;
        private System.Windows.Forms.Label lblStroj;
        private System.Windows.Forms.ComboBox cmbSkladiste;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox txtKolicina;
    }
}