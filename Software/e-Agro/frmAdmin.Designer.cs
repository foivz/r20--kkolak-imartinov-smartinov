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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.btnKorisnik = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelZaposlenik = new System.Windows.Forms.Panel();
            this.btnUred = new System.Windows.Forms.Button();
            this.btnSkladiste = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelZaposlenik.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKorisnik
            // 
            this.btnKorisnik.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnKorisnik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKorisnik.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKorisnik.ForeColor = System.Drawing.Color.White;
            this.btnKorisnik.Image = ((System.Drawing.Image)(resources.GetObject("btnKorisnik.Image")));
            this.btnKorisnik.Location = new System.Drawing.Point(0, 0);
            this.btnKorisnik.Name = "btnKorisnik";
            this.btnKorisnik.Size = new System.Drawing.Size(217, 125);
            this.btnKorisnik.TabIndex = 3;
            this.btnKorisnik.Text = "Korisnik";
            this.btnKorisnik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKorisnik.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKorisnik.UseVisualStyleBackColor = false;
            this.btnKorisnik.Click += new System.EventHandler(this.btnKorisnik_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUred);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelZaposlenik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 125);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnKorisnik);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(423, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 125);
            this.panel2.TabIndex = 1;
            // 
            // panelZaposlenik
            // 
            this.panelZaposlenik.Controls.Add(this.btnSkladiste);
            this.panelZaposlenik.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelZaposlenik.Location = new System.Drawing.Point(0, 0);
            this.panelZaposlenik.Name = "panelZaposlenik";
            this.panelZaposlenik.Size = new System.Drawing.Size(217, 125);
            this.panelZaposlenik.TabIndex = 0;
            // 
            // btnUred
            // 
            this.btnUred.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUred.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUred.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUred.ForeColor = System.Drawing.Color.White;
            this.btnUred.Image = ((System.Drawing.Image)(resources.GetObject("btnUred.Image")));
            this.btnUred.Location = new System.Drawing.Point(217, 0);
            this.btnUred.Name = "btnUred";
            this.btnUred.Size = new System.Drawing.Size(206, 125);
            this.btnUred.TabIndex = 0;
            this.btnUred.Text = "Ured";
            this.btnUred.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUred.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUred.UseVisualStyleBackColor = false;
            this.btnUred.Click += new System.EventHandler(this.btnUred_Click);
            // 
            // btnSkladiste
            // 
            this.btnSkladiste.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSkladiste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSkladiste.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkladiste.ForeColor = System.Drawing.Color.White;
            this.btnSkladiste.Image = ((System.Drawing.Image)(resources.GetObject("btnSkladiste.Image")));
            this.btnSkladiste.Location = new System.Drawing.Point(0, 0);
            this.btnSkladiste.Name = "btnSkladiste";
            this.btnSkladiste.Size = new System.Drawing.Size(217, 125);
            this.btnSkladiste.TabIndex = 0;
            this.btnSkladiste.Text = "Skladište";
            this.btnSkladiste.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSkladiste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSkladiste.UseVisualStyleBackColor = false;
            this.btnSkladiste.Click += new System.EventHandler(this.btnSkladiste_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(640, 126);
            this.Controls.Add(this.panel1);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelZaposlenik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKorisnik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelZaposlenik;
        private System.Windows.Forms.Button btnUred;
        private System.Windows.Forms.Button btnSkladiste;
    }
}