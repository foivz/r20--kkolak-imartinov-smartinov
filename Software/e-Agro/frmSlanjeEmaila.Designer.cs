namespace e_Agro
{
    partial class frmSlanjeEmaila
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
            this.lblZa = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblPrivitak = new System.Windows.Forms.Label();
            this.rtxtSadrzaj = new System.Windows.Forms.RichTextBox();
            this.txtZa = new System.Windows.Forms.TextBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.lnkDodajPrivitak = new System.Windows.Forms.LinkLabel();
            this.fdPrivitak = new System.Windows.Forms.OpenFileDialog();
            this.lblUputa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblZa
            // 
            this.lblZa.AutoSize = true;
            this.lblZa.Location = new System.Drawing.Point(66, 40);
            this.lblZa.Name = "lblZa";
            this.lblZa.Size = new System.Drawing.Size(23, 13);
            this.lblZa.TabIndex = 0;
            this.lblZa.Text = "Za:";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Location = new System.Drawing.Point(66, 93);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(43, 13);
            this.lblNaslov.TabIndex = 2;
            this.lblNaslov.Text = "Naslov:";
            // 
            // lblPrivitak
            // 
            this.lblPrivitak.AutoSize = true;
            this.lblPrivitak.Location = new System.Drawing.Point(66, 143);
            this.lblPrivitak.Name = "lblPrivitak";
            this.lblPrivitak.Size = new System.Drawing.Size(45, 13);
            this.lblPrivitak.TabIndex = 3;
            this.lblPrivitak.Text = "Privitak:";
            // 
            // rtxtSadrzaj
            // 
            this.rtxtSadrzaj.Location = new System.Drawing.Point(134, 181);
            this.rtxtSadrzaj.Name = "rtxtSadrzaj";
            this.rtxtSadrzaj.Size = new System.Drawing.Size(520, 366);
            this.rtxtSadrzaj.TabIndex = 5;
            this.rtxtSadrzaj.Text = "";
            // 
            // txtZa
            // 
            this.txtZa.Location = new System.Drawing.Point(134, 40);
            this.txtZa.Name = "txtZa";
            this.txtZa.Size = new System.Drawing.Size(520, 20);
            this.txtZa.TabIndex = 6;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(134, 90);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(520, 20);
            this.txtNaslov.TabIndex = 8;
            // 
            // btnOdustani
            // 
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOdustani.Location = new System.Drawing.Point(569, 565);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(85, 35);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPosalji
            // 
            this.btnPosalji.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPosalji.Location = new System.Drawing.Point(134, 565);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(85, 35);
            this.btnPosalji.TabIndex = 9;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // lnkDodajPrivitak
            // 
            this.lnkDodajPrivitak.AutoSize = true;
            this.lnkDodajPrivitak.LinkColor = System.Drawing.Color.White;
            this.lnkDodajPrivitak.Location = new System.Drawing.Point(131, 143);
            this.lnkDodajPrivitak.Name = "lnkDodajPrivitak";
            this.lnkDodajPrivitak.Size = new System.Drawing.Size(72, 13);
            this.lnkDodajPrivitak.TabIndex = 10;
            this.lnkDodajPrivitak.TabStop = true;
            this.lnkDodajPrivitak.Text = "Dodaj privitak";
            this.lnkDodajPrivitak.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDodajPrivitak_LinkClicked);
            // 
            // fdPrivitak
            // 
            this.fdPrivitak.FileName = "openFileDialog1";
            // 
            // lblUputa
            // 
            this.lblUputa.AutoSize = true;
            this.lblUputa.ForeColor = System.Drawing.Color.Orange;
            this.lblUputa.Location = new System.Drawing.Point(219, 143);
            this.lblUputa.Name = "lblUputa";
            this.lblUputa.Size = new System.Drawing.Size(296, 13);
            this.lblUputa.TabIndex = 11;
            this.lblUputa.Text = "Prije slanja poruke preuzmite ponudu koju ćete poslati klijentu";
            this.lblUputa.Visible = false;
            // 
            // frmSlanjeEmaila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(685, 610);
            this.Controls.Add(this.lblUputa);
            this.Controls.Add(this.lnkDodajPrivitak);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.txtZa);
            this.Controls.Add(this.rtxtSadrzaj);
            this.Controls.Add(this.lblPrivitak);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblZa);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSlanjeEmaila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slanje e-maila";
            this.Load += new System.EventHandler(this.frmSlanjeEmaila_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSlanjeEmaila_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZa;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblPrivitak;
        private System.Windows.Forms.RichTextBox rtxtSadrzaj;
        private System.Windows.Forms.TextBox txtZa;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.LinkLabel lnkDodajPrivitak;
        private System.Windows.Forms.OpenFileDialog fdPrivitak;
        private System.Windows.Forms.Label lblUputa;
    }
}