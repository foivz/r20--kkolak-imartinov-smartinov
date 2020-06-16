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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtZupanija
            // 
            this.txtZupanija.Location = new System.Drawing.Point(368, 122);
            this.txtZupanija.Name = "txtZupanija";
            this.txtZupanija.Size = new System.Drawing.Size(140, 20);
            this.txtZupanija.TabIndex = 18;
            // 
            // lblZupanija
            // 
            this.lblZupanija.AutoSize = true;
            this.lblZupanija.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZupanija.ForeColor = System.Drawing.Color.White;
            this.lblZupanija.Location = new System.Drawing.Point(365, 103);
            this.lblZupanija.Name = "lblZupanija";
            this.lblZupanija.Size = new System.Drawing.Size(67, 16);
            this.lblZupanija.TabIndex = 17;
            this.lblZupanija.Text = "Županija:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(190, 122);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(160, 20);
            this.txtAdresa.TabIndex = 16;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.ForeColor = System.Drawing.Color.White;
            this.lblAdresa.Location = new System.Drawing.Point(187, 103);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(57, 16);
            this.lblAdresa.TabIndex = 15;
            this.lblAdresa.Text = "Adresa:";
            // 
            // txtOdjel
            // 
            this.txtOdjel.Location = new System.Drawing.Point(74, 122);
            this.txtOdjel.Name = "txtOdjel";
            this.txtOdjel.Size = new System.Drawing.Size(100, 20);
            this.txtOdjel.TabIndex = 14;
            // 
            // lblOdjel
            // 
            this.lblOdjel.AutoSize = true;
            this.lblOdjel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdjel.ForeColor = System.Drawing.Color.White;
            this.lblOdjel.Location = new System.Drawing.Point(71, 103);
            this.lblOdjel.Name = "lblOdjel";
            this.lblOdjel.Size = new System.Drawing.Size(46, 16);
            this.lblOdjel.TabIndex = 13;
            this.lblOdjel.Text = "Odjel:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(190, 201);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 34);
            this.btnOdustani.TabIndex = 25;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(74, 201);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(110, 34);
            this.btnDodaj.TabIndex = 24;
            this.btnDodaj.Text = "Dodaj ured";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(70, 22);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(157, 22);
            this.lblNaslov.TabIndex = 26;
            this.lblNaslov.Text = "Dodaj novi ured";
            // 
            // frmDodavanjeUreda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(587, 285);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.txtZupanija);
            this.Controls.Add(this.lblZupanija);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.txtOdjel);
            this.Controls.Add(this.lblOdjel);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDodavanjeUreda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje ureda";
            this.Load += new System.EventHandler(this.frmDodavanjeUreda_Load);
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
        private System.Windows.Forms.Label lblNaslov;
    }
}