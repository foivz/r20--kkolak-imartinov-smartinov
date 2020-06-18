namespace e_Agro
{
    partial class frmPonudaIzvjestaj
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
            this.ponudaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavke_na_ponudiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvPonuda = new Microsoft.Reporting.WinForms.ReportViewer();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.katalog_strojevaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ponudaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_na_ponudiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalog_strojevaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ponudaBindingSource
            // 
            this.ponudaBindingSource.DataSource = typeof(e_Agro.ponuda);
            // 
            // stavke_na_ponudiBindingSource
            // 
            this.stavke_na_ponudiBindingSource.DataSource = typeof(e_Agro.stavke_na_ponudi);
            // 
            // rvPonuda
            // 
            this.rvPonuda.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsPonuda";
            reportDataSource1.Value = this.ponudaBindingSource;
            reportDataSource2.Name = "dsStavkeNaPonudi";
            reportDataSource2.Value = this.stavke_na_ponudiBindingSource;
            reportDataSource3.Name = "dsKorisnik";
            reportDataSource3.Value = this.korisnikBindingSource;
            reportDataSource4.Name = "dsStroj";
            reportDataSource4.Value = this.katalog_strojevaBindingSource;
            this.rvPonuda.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPonuda.LocalReport.DataSources.Add(reportDataSource2);
            this.rvPonuda.LocalReport.DataSources.Add(reportDataSource3);
            this.rvPonuda.LocalReport.DataSources.Add(reportDataSource4);
            this.rvPonuda.LocalReport.ReportEmbeddedResource = "e_Agro.rptPonuda.rdlc";
            this.rvPonuda.Location = new System.Drawing.Point(0, 0);
            this.rvPonuda.Name = "rvPonuda";
            this.rvPonuda.ServerReport.BearerToken = null;
            this.rvPonuda.Size = new System.Drawing.Size(800, 450);
            this.rvPonuda.TabIndex = 0;
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(e_Agro.korisnik);
            // 
            // katalog_strojevaBindingSource
            // 
            this.katalog_strojevaBindingSource.DataSource = typeof(e_Agro.katalog_strojeva);
            // 
            // frmPonudaIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvPonuda);
            this.Name = "frmPonudaIzvjestaj";
            this.Text = "frmPonudaIzvjestaj";
            this.Load += new System.EventHandler(this.frmPonudaIzvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ponudaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_na_ponudiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalog_strojevaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvPonuda;
        private System.Windows.Forms.BindingSource ponudaBindingSource;
        private System.Windows.Forms.BindingSource stavke_na_ponudiBindingSource;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.BindingSource katalog_strojevaBindingSource;
    }
}