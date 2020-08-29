namespace e_Agro
{
    partial class frmNarudzbaIzvjestaj
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.narudzbaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.katalog_strojevaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalog_strojevaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Narudzba";
            reportDataSource1.Value = this.narudzbaBindingSource;
            reportDataSource2.Name = "Stavke";
            reportDataSource2.Value = this.katalog_strojevaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "e_Agro.rptNarudzba.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(775, 670);
            this.reportViewer1.TabIndex = 0;
            // 
            // narudzbaBindingSource
            // 
            this.narudzbaBindingSource.DataSource = typeof(e_Agro.narudzba);
            // 
            // katalog_strojevaBindingSource
            // 
            this.katalog_strojevaBindingSource.DataSource = typeof(e_Agro.katalog_strojeva);
            // 
            // frmNarudzbaIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(775, 670);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmNarudzbaIzvjestaj";
            this.Text = "frmNarudzbaIzvjestaj";
            this.Load += new System.EventHandler(this.frmNarudzbaIzvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalog_strojevaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource narudzbaBindingSource;
        private System.Windows.Forms.BindingSource katalog_strojevaBindingSource;
    }
}