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
            this.cbDobavljac = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Location = new System.Drawing.Point(82, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(230, 13);
            this.lblNaslov.TabIndex = 11;
            this.lblNaslov.Text = "Prikaz strojeva koje smo nabavili od dobavljača";
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Location = new System.Drawing.Point(143, 119);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(97, 30);
            this.btnPrikaz.TabIndex = 10;
            this.btnPrikaz.Text = "Prikaz izvještaja";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            // 
            // lblDobavljac
            // 
            this.lblDobavljac.AutoSize = true;
            this.lblDobavljac.Location = new System.Drawing.Point(11, 69);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(88, 13);
            this.lblDobavljac.TabIndex = 9;
            this.lblDobavljac.Text = "Izbor dobavljača:";
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.Location = new System.Drawing.Point(105, 66);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(121, 21);
            this.cbDobavljac.TabIndex = 8;
            // 
            // frmProdajniReferentIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 171);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnPrikaz);
            this.Controls.Add(this.lblDobavljac);
            this.Controls.Add(this.cbDobavljac);
            this.Name = "frmProdajniReferentIzvjestaj";
            this.Text = "frmProdajniReferentIzvjestaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.Label lblDobavljac;
        private System.Windows.Forms.ComboBox cbDobavljac;
    }
}