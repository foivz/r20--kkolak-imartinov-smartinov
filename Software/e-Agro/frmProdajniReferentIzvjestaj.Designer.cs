namespace e_Agro
{
    partial class frmProdajniReferentIzvjestaj
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
            this.lblDobavljac = new System.Windows.Forms.Label();
            this.cmbDobavljac = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(37, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(447, 22);
            this.lblNaslov.TabIndex = 11;
            this.lblNaslov.Text = "Prikaz strojeva koje smo nabavili od dobavljača";
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaz.Location = new System.Drawing.Point(41, 135);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(120, 34);
            this.btnPrikaz.TabIndex = 10;
            this.btnPrikaz.Text = "Prikaz izvještaja";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // lblDobavljac
            // 
            this.lblDobavljac.AutoSize = true;
            this.lblDobavljac.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobavljac.ForeColor = System.Drawing.Color.White;
            this.lblDobavljac.Location = new System.Drawing.Point(38, 65);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(123, 17);
            this.lblDobavljac.TabIndex = 9;
            this.lblDobavljac.Text = "Izbor dobavljača:";
            // 
            // cmbDobavljac
            // 
            this.cmbDobavljac.FormattingEnabled = true;
            this.cmbDobavljac.Location = new System.Drawing.Point(41, 85);
            this.cmbDobavljac.Name = "cmbDobavljac";
            this.cmbDobavljac.Size = new System.Drawing.Size(195, 21);
            this.cmbDobavljac.TabIndex = 8;
            // 
            // frmProdajniReferentIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(549, 196);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnPrikaz);
            this.Controls.Add(this.lblDobavljac);
            this.Controls.Add(this.cmbDobavljac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProdajniReferentIzvjestaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz dobavljača strojeva";
            this.Load += new System.EventHandler(this.frmProdajniReferentIzvjestaj_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProdajniReferentIzvjestaj_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.Label lblDobavljac;
        private System.Windows.Forms.ComboBox cmbDobavljac;
    }
}