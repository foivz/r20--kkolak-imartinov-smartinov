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
            this.cbDobavljac = new System.Windows.Forms.ComboBox();
            this.lblDobavljac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(117, 76);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(121, 20);
            this.txtCijena.TabIndex = 49;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(64, 79);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(39, 13);
            this.lblKolicina.TabIndex = 48;
            this.lblKolicina.Text = "Cijena:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(204, 145);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 51;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(28, 134);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 34);
            this.btnDodaj.TabIndex = 50;
            this.btnDodaj.Text = "Dodaj narudžbu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.Location = new System.Drawing.Point(117, 22);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(121, 21);
            this.cbDobavljac.TabIndex = 54;
            // 
            // lblDobavljac
            // 
            this.lblDobavljac.AutoSize = true;
            this.lblDobavljac.Location = new System.Drawing.Point(53, 25);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(58, 13);
            this.lblDobavljac.TabIndex = 53;
            this.lblDobavljac.Text = "Dobavljač:";
            // 
            // frmDodavanjeNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 178);
            this.Controls.Add(this.cbDobavljac);
            this.Controls.Add(this.lblDobavljac);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Name = "frmDodavanjeNarudzbi";
            this.Text = "Dodavanje narudžbi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cbDobavljac;
        private System.Windows.Forms.Label lblDobavljac;
    }
}