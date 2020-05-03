namespace e_Agro
{
    partial class frmAdmin
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
            this.btnZaposlenik = new System.Windows.Forms.Button();
            this.btnSkladiste = new System.Windows.Forms.Button();
            this.btnUred = new System.Windows.Forms.Button();
            this.btnKorisnik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZaposlenik
            // 
            this.btnZaposlenik.Location = new System.Drawing.Point(233, 23);
            this.btnZaposlenik.Name = "btnZaposlenik";
            this.btnZaposlenik.Size = new System.Drawing.Size(75, 23);
            this.btnZaposlenik.TabIndex = 0;
            this.btnZaposlenik.Text = "Zaposlenik";
            this.btnZaposlenik.UseVisualStyleBackColor = true;
            // 
            // btnSkladiste
            // 
            this.btnSkladiste.Location = new System.Drawing.Point(67, 124);
            this.btnSkladiste.Name = "btnSkladiste";
            this.btnSkladiste.Size = new System.Drawing.Size(75, 23);
            this.btnSkladiste.TabIndex = 1;
            this.btnSkladiste.Text = "Skladište";
            this.btnSkladiste.UseVisualStyleBackColor = true;
            // 
            // btnUred
            // 
            this.btnUred.Location = new System.Drawing.Point(233, 124);
            this.btnUred.Name = "btnUred";
            this.btnUred.Size = new System.Drawing.Size(75, 23);
            this.btnUred.TabIndex = 2;
            this.btnUred.Text = "Ured";
            this.btnUred.UseVisualStyleBackColor = true;
            // 
            // btnKorisnik
            // 
            this.btnKorisnik.Location = new System.Drawing.Point(67, 23);
            this.btnKorisnik.Name = "btnKorisnik";
            this.btnKorisnik.Size = new System.Drawing.Size(75, 23);
            this.btnKorisnik.TabIndex = 3;
            this.btnKorisnik.Text = "Korisnik";
            this.btnKorisnik.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 184);
            this.Controls.Add(this.btnKorisnik);
            this.Controls.Add(this.btnUred);
            this.Controls.Add(this.btnSkladiste);
            this.Controls.Add(this.btnZaposlenik);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZaposlenik;
        private System.Windows.Forms.Button btnSkladiste;
        private System.Windows.Forms.Button btnUred;
        private System.Windows.Forms.Button btnKorisnik;
    }
}