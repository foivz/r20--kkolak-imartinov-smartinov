namespace e_Agro
{
    partial class frmProdajniReferent
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
            this.btnStrojevi = new System.Windows.Forms.Button();
            this.btnPonuda = new System.Windows.Forms.Button();
            this.btnKlijent = new System.Windows.Forms.Button();
            this.btnGraf = new System.Windows.Forms.Button();
            this.btnDobavljac = new System.Windows.Forms.Button();
            this.btnIzvjestja = new System.Windows.Forms.Button();
            this.btnNarudzba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStrojevi
            // 
            this.btnStrojevi.Location = new System.Drawing.Point(1, 4);
            this.btnStrojevi.Name = "btnStrojevi";
            this.btnStrojevi.Size = new System.Drawing.Size(75, 40);
            this.btnStrojevi.TabIndex = 0;
            this.btnStrojevi.Text = "Katalog strojeva";
            this.btnStrojevi.UseVisualStyleBackColor = true;
            this.btnStrojevi.Click += new System.EventHandler(this.btnStrojevi_Click);
            // 
            // btnPonuda
            // 
            this.btnPonuda.Location = new System.Drawing.Point(1, 64);
            this.btnPonuda.Name = "btnPonuda";
            this.btnPonuda.Size = new System.Drawing.Size(75, 23);
            this.btnPonuda.TabIndex = 1;
            this.btnPonuda.Text = "Ponuda";
            this.btnPonuda.UseVisualStyleBackColor = true;
            this.btnPonuda.Click += new System.EventHandler(this.btnPonuda_Click);
            // 
            // btnKlijent
            // 
            this.btnKlijent.Location = new System.Drawing.Point(312, 4);
            this.btnKlijent.Name = "btnKlijent";
            this.btnKlijent.Size = new System.Drawing.Size(68, 23);
            this.btnKlijent.TabIndex = 2;
            this.btnKlijent.Text = "Klijent";
            this.btnKlijent.UseVisualStyleBackColor = true;
            this.btnKlijent.Click += new System.EventHandler(this.btnKlijent_Click);
            // 
            // btnGraf
            // 
            this.btnGraf.Location = new System.Drawing.Point(305, 64);
            this.btnGraf.Name = "btnGraf";
            this.btnGraf.Size = new System.Drawing.Size(75, 23);
            this.btnGraf.TabIndex = 3;
            this.btnGraf.Text = "Graf";
            this.btnGraf.UseVisualStyleBackColor = true;
            this.btnGraf.Click += new System.EventHandler(this.btnGraf_Click);
            // 
            // btnDobavljac
            // 
            this.btnDobavljac.Location = new System.Drawing.Point(153, 64);
            this.btnDobavljac.Name = "btnDobavljac";
            this.btnDobavljac.Size = new System.Drawing.Size(75, 23);
            this.btnDobavljac.TabIndex = 4;
            this.btnDobavljac.Text = "Dobavljač";
            this.btnDobavljac.UseVisualStyleBackColor = true;
            this.btnDobavljac.Click += new System.EventHandler(this.btnDobavljac_Click);
            // 
            // btnIzvjestja
            // 
            this.btnIzvjestja.Location = new System.Drawing.Point(153, 4);
            this.btnIzvjestja.Name = "btnIzvjestja";
            this.btnIzvjestja.Size = new System.Drawing.Size(75, 37);
            this.btnIzvjestja.TabIndex = 5;
            this.btnIzvjestja.Text = "Izvještaj dobavljača";
            this.btnIzvjestja.UseVisualStyleBackColor = true;
            this.btnIzvjestja.Click += new System.EventHandler(this.btnIzvjestja_Click);
            // 
            // btnNarudzba
            // 
            this.btnNarudzba.Location = new System.Drawing.Point(1, 119);
            this.btnNarudzba.Name = "btnNarudzba";
            this.btnNarudzba.Size = new System.Drawing.Size(75, 23);
            this.btnNarudzba.TabIndex = 6;
            this.btnNarudzba.Text = "Narudžba";
            this.btnNarudzba.UseVisualStyleBackColor = true;
            this.btnNarudzba.Click += new System.EventHandler(this.btnNarudzba_Click);
            // 
            // frmProdajniReferent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 181);
            this.Controls.Add(this.btnNarudzba);
            this.Controls.Add(this.btnIzvjestja);
            this.Controls.Add(this.btnDobavljac);
            this.Controls.Add(this.btnGraf);
            this.Controls.Add(this.btnKlijent);
            this.Controls.Add(this.btnPonuda);
            this.Controls.Add(this.btnStrojevi);
            this.Name = "frmProdajniReferent";
            this.Text = "frmProdajniReferent";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStrojevi;
        private System.Windows.Forms.Button btnPonuda;
        private System.Windows.Forms.Button btnKlijent;
        private System.Windows.Forms.Button btnGraf;
        private System.Windows.Forms.Button btnDobavljac;
        private System.Windows.Forms.Button btnIzvjestja;
        private System.Windows.Forms.Button btnNarudzba;
    }
}