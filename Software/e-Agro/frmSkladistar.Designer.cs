namespace e_Agro
{
    partial class frmSkladistar
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
            this.btnOtpremnica = new System.Windows.Forms.Button();
            this.btnPrimka = new System.Windows.Forms.Button();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOtpremnica
            // 
            this.btnOtpremnica.Location = new System.Drawing.Point(38, 50);
            this.btnOtpremnica.Name = "btnOtpremnica";
            this.btnOtpremnica.Size = new System.Drawing.Size(75, 23);
            this.btnOtpremnica.TabIndex = 0;
            this.btnOtpremnica.Text = "Otpremnica";
            this.btnOtpremnica.UseVisualStyleBackColor = true;
            // 
            // btnPrimka
            // 
            this.btnPrimka.Location = new System.Drawing.Point(187, 50);
            this.btnPrimka.Name = "btnPrimka";
            this.btnPrimka.Size = new System.Drawing.Size(75, 23);
            this.btnPrimka.TabIndex = 1;
            this.btnPrimka.Text = "Primka";
            this.btnPrimka.UseVisualStyleBackColor = true;
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(317, 36);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(97, 51);
            this.btnIzvjestaj.TabIndex = 2;
            this.btnIzvjestaj.Text = "Izradi izvještaj stanja na skladištu";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            // 
            // frmSkladistar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 128);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.btnPrimka);
            this.Controls.Add(this.btnOtpremnica);
            this.Name = "frmSkladistar";
            this.Text = "frmSkladistar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOtpremnica;
        private System.Windows.Forms.Button btnPrimka;
        private System.Windows.Forms.Button btnIzvjestaj;
    }
}