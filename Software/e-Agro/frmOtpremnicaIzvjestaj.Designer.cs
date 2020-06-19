namespace e_Agro
{
    partial class frmOtpremnicaIzvjestaj
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvOtpremnica = new Microsoft.Reporting.WinForms.ReportViewer();
            this.otpremnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavke_na_otpremniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.katalog_strojevaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.otpremnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_na_otpremniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalog_strojevaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvOtpremnica
            // 
            this.rvOtpremnica.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsOtpremnica";
            reportDataSource1.Value = this.otpremnicaBindingSource;
            reportDataSource2.Name = "dsStavkeNaOtpremnici";
            reportDataSource2.Value = this.stavke_na_otpremniciBindingSource;
            reportDataSource3.Name = "dsKorisnik";
            reportDataSource3.Value = this.korisnikBindingSource;
            reportDataSource4.Name = "dsStroj";
            reportDataSource4.Value = this.katalog_strojevaBindingSource;
            this.rvOtpremnica.LocalReport.DataSources.Add(reportDataSource1);
            this.rvOtpremnica.LocalReport.DataSources.Add(reportDataSource2);
            this.rvOtpremnica.LocalReport.DataSources.Add(reportDataSource3);
            this.rvOtpremnica.LocalReport.DataSources.Add(reportDataSource4);
            this.rvOtpremnica.LocalReport.ReportEmbeddedResource = "e_Agro.rptOtpremnica.rdlc";
            this.rvOtpremnica.Location = new System.Drawing.Point(0, 0);
            this.rvOtpremnica.Name = "rvOtpremnica";
            this.rvOtpremnica.ServerReport.BearerToken = null;
            this.rvOtpremnica.Size = new System.Drawing.Size(800, 450);
            this.rvOtpremnica.TabIndex = 0;
            // 
            // otpremnicaBindingSource
            // 
            this.otpremnicaBindingSource.DataSource = typeof(e_Agro.otpremnica);
            // 
            // stavke_na_otpremniciBindingSource
            // 
            this.stavke_na_otpremniciBindingSource.DataSource = typeof(e_Agro.stavke_na_otpremnici);
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(e_Agro.korisnik);
            // 
            // katalog_strojevaBindingSource
            // 
            this.katalog_strojevaBindingSource.DataSource = typeof(e_Agro.katalog_strojeva);
            // 
            // frmOtpremnicaIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvOtpremnica);
            this.Name = "frmOtpremnicaIzvjestaj";
            this.Text = "frmOtpremnicaIzvjestaj";
            this.Load += new System.EventHandler(this.frmOtpremnicaIzvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otpremnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_na_otpremniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalog_strojevaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvOtpremnica;
        private System.Windows.Forms.BindingSource otpremnicaBindingSource;
        private System.Windows.Forms.BindingSource stavke_na_otpremniciBindingSource;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.BindingSource katalog_strojevaBindingSource;
    }
}