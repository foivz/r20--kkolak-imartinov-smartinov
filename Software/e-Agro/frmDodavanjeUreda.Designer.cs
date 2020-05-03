namespace e_Agro
{
    partial class frmDodavanjeUreda
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
            this.txtZupanija = new System.Windows.Forms.TextBox();
            this.lblZupanija = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtOdjel = new System.Windows.Forms.TextBox();
            this.lblOdjel = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtZupanija
            // 
            this.txtZupanija.Location = new System.Drawing.Point(110, 95);
            this.txtZupanija.Name = "txtZupanija";
            this.txtZupanija.Size = new System.Drawing.Size(100, 20);
            this.txtZupanija.TabIndex = 18;
            // 
            // lblZupanija
            // 
            this.lblZupanija.AutoSize = true;
            this.lblZupanija.Location = new System.Drawing.Point(53, 98);
            this.lblZupanija.Name = "lblZupanija";
            this.lblZupanija.Size = new System.Drawing.Size(51, 13);
            this.lblZupanija.TabIndex = 17;
            this.lblZupanija.Text = "Županija:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(110, 52);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 16;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(61, 55);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(43, 13);
            this.lblAdresa.TabIndex = 15;
            this.lblAdresa.Text = "Adresa:";
            // 
            // txtOdjel
            // 
            this.txtOdjel.Location = new System.Drawing.Point(110, 12);
            this.txtOdjel.Name = "txtOdjel";
            this.txtOdjel.Size = new System.Drawing.Size(100, 20);
            this.txtOdjel.TabIndex = 14;
            // 
            // lblOdjel
            // 
            this.lblOdjel.AutoSize = true;
            this.lblOdjel.Location = new System.Drawing.Point(70, 15);
            this.lblOdjel.Name = "lblOdjel";
            this.lblOdjel.Size = new System.Drawing.Size(34, 13);
            this.lblOdjel.TabIndex = 13;
            this.lblOdjel.Text = "Odjel:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(231, 140);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 25;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 134);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 34);
            this.btnDodaj.TabIndex = 24;
            this.btnDodaj.Text = "Dodaj ured";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // frmDodavanjeUreda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 177);
            this.Controls.Add(this.txtZupanija);
            this.Controls.Add(this.lblZupanija);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.txtOdjel);
            this.Controls.Add(this.lblOdjel);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Name = "frmDodavanjeUreda";
            this.Text = "Dodavanje ureda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtZupanija;
        private System.Windows.Forms.Label lblZupanija;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtOdjel;
        private System.Windows.Forms.Label lblOdjel;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
    }
}