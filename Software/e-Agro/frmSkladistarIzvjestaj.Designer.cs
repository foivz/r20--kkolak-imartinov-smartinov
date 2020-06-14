namespace e_Agro
{
    partial class frmSkladistarIzvjestaj
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
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.lblSkladiste = new System.Windows.Forms.Label();
            this.cmbSkladiste = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblNaslov.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(12, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(252, 22);
            this.lblNaslov.TabIndex = 15;
            this.lblNaslov.Text = "Prikaz strojeva na skladištu";
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaz.Location = new System.Drawing.Point(16, 135);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(120, 34);
            this.btnPrikaz.TabIndex = 14;
            this.btnPrikaz.Text = "Prikaz izvještaja";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // lblSkladiste
            // 
            this.lblSkladiste.AutoSize = true;
            this.lblSkladiste.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkladiste.ForeColor = System.Drawing.Color.White;
            this.lblSkladiste.Location = new System.Drawing.Point(13, 65);
            this.lblSkladiste.Name = "lblSkladiste";
            this.lblSkladiste.Size = new System.Drawing.Size(102, 17);
            this.lblSkladiste.TabIndex = 13;
            this.lblSkladiste.Text = "Izbor skladišta:";
            // 
            // cmbSkladiste
            // 
            this.cmbSkladiste.FormattingEnabled = true;
            this.cmbSkladiste.Location = new System.Drawing.Point(16, 85);
            this.cmbSkladiste.Name = "cmbSkladiste";
            this.cmbSkladiste.Size = new System.Drawing.Size(121, 21);
            this.cmbSkladiste.TabIndex = 12;
            // 
            // frmSkladistarIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(350, 209);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnPrikaz);
            this.Controls.Add(this.lblSkladiste);
            this.Controls.Add(this.cmbSkladiste);
            this.Name = "frmSkladistarIzvjestaj";
            this.Text = "frmSkladistarIzvjestaj";
            this.Load += new System.EventHandler(this.frmSkladistarIzvjestaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.Label lblSkladiste;
        private System.Windows.Forms.ComboBox cmbSkladiste;
    }
}