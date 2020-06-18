namespace e_Agro
{
    partial class frmPrimkaIzvjestaj
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
            this.primkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavke_na_primciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvPrimka = new Microsoft.Reporting.WinForms.ReportViewer();
            this.katalog_strojevaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.primkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_na_primciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalog_strojevaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // primkaBindingSource
            // 
            this.primkaBindingSource.DataSource = typeof(e_Agro.primka);
            // 
            // stavke_na_primciBindingSource
            // 
            this.stavke_na_primciBindingSource.DataSource = typeof(e_Agro.stavke_na_primci);
            // 
            // rvPrimka
            // 
            this.rvPrimka.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsPrimka";
            reportDataSource1.Value = this.primkaBindingSource;
            reportDataSource2.Name = "dsStavkeNaPrimci";
            reportDataSource2.Value = this.stavke_na_primciBindingSource;
            reportDataSource3.Name = "dsStroj";
            reportDataSource3.Value = this.katalog_strojevaBindingSource;
            reportDataSource4.Name = "dsKorisnik";
            reportDataSource4.Value = this.korisnikBindingSource;
            this.rvPrimka.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPrimka.LocalReport.DataSources.Add(reportDataSource2);
            this.rvPrimka.LocalReport.DataSources.Add(reportDataSource3);
            this.rvPrimka.LocalReport.DataSources.Add(reportDataSource4);
            this.rvPrimka.LocalReport.ReportEmbeddedResource = "e_Agro.rptPrimka.rdlc";
            this.rvPrimka.Location = new System.Drawing.Point(0, 0);
            this.rvPrimka.Name = "rvPrimka";
            this.rvPrimka.ServerReport.BearerToken = null;
            this.rvPrimka.Size = new System.Drawing.Size(800, 450);
            this.rvPrimka.TabIndex = 0;
            // 
            // katalog_strojevaBindingSource
            // 
            this.katalog_strojevaBindingSource.DataSource = typeof(e_Agro.katalog_strojeva);
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(e_Agro.korisnik);
            // 
            // frmPrimkaIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvPrimka);
            this.Name = "frmPrimkaIzvjestaj";
            this.Text = "frmPrimkaIzvjestaj";
            this.Load += new System.EventHandler(this.frmPrimkaIzvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.primkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_na_primciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalog_strojevaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvPrimka;
        private System.Windows.Forms.BindingSource primkaBindingSource;
        private System.Windows.Forms.BindingSource stavke_na_primciBindingSource;
        private System.Windows.Forms.BindingSource katalog_strojevaBindingSource;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
    }
}