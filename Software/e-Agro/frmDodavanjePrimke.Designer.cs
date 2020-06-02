namespace e_Agro
{
    partial class frmDodavanjePrimke
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
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblKreirao = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cbKreirao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(92, 95);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(121, 20);
            this.txtCijena.TabIndex = 47;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(43, 98);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(39, 13);
            this.lblCijena.TabIndex = 46;
            this.lblCijena.Text = "Cijena:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(92, 60);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(121, 20);
            this.txtKolicina.TabIndex = 45;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(35, 63);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(47, 13);
            this.lblKolicina.TabIndex = 44;
            this.lblKolicina.Text = "Količina:";
            // 
            // lblKreirao
            // 
            this.lblKreirao.AutoSize = true;
            this.lblKreirao.Location = new System.Drawing.Point(39, 26);
            this.lblKreirao.Name = "lblKreirao";
            this.lblKreirao.Size = new System.Drawing.Size(43, 13);
            this.lblKreirao.TabIndex = 38;
            this.lblKreirao.Text = "Kreirao:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(167, 134);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 43;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 128);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 34);
            this.btnDodaj.TabIndex = 42;
            this.btnDodaj.Text = "Dodaj primku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // cbKreirao
            // 
            this.cbKreirao.FormattingEnabled = true;
            this.cbKreirao.Location = new System.Drawing.Point(92, 23);
            this.cbKreirao.Name = "cbKreirao";
            this.cbKreirao.Size = new System.Drawing.Size(121, 21);
            this.cbKreirao.TabIndex = 48;
            // 
            // frmDodavanjePrimke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 169);
            this.Controls.Add(this.cbKreirao);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblKreirao);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Name = "frmDodavanjePrimke";
            this.Text = "Dodavanje primke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblKreirao;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cbKreirao;
    }
}