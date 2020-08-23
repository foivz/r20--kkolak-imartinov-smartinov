namespace e_Agro
{
    partial class frmPrikazIzvjestajaProdajniRefrent
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
            this.dobavljacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.katalog_strojevaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpvDobavljacStrojeva = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalog_strojevaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dobavljacBindingSource
            // 
            this.dobavljacBindingSource.DataSource = typeof(e_Agro.dobavljac);
            // 
            // katalog_strojevaBindingSource
            // 
            this.katalog_strojevaBindingSource.DataSource = typeof(e_Agro.katalog_strojeva);
            // 
            // rpvDobavljacStrojeva
            // 
            this.rpvDobavljacStrojeva.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsDobavljac";
            reportDataSource1.Value = this.dobavljacBindingSource;
            reportDataSource2.Name = "dsStrojevi";
            reportDataSource2.Value = this.katalog_strojevaBindingSource;
            this.rpvDobavljacStrojeva.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvDobavljacStrojeva.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvDobavljacStrojeva.LocalReport.ReportEmbeddedResource = "e_Agro.rptDobavljaciStrojeva.rdlc";
            this.rpvDobavljacStrojeva.Location = new System.Drawing.Point(0, 0);
            this.rpvDobavljacStrojeva.Name = "rpvDobavljacStrojeva";
            this.rpvDobavljacStrojeva.ServerReport.BearerToken = null;
            this.rpvDobavljacStrojeva.Size = new System.Drawing.Size(800, 450);
            this.rpvDobavljacStrojeva.TabIndex = 0;
            // 
            // frmPrikazIzvjestajaProdajniRefrent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvDobavljacStrojeva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPrikazIzvjestajaProdajniRefrent";
            this.Text = "Prikaz izvještaja prodaje";
            this.Load += new System.EventHandler(this.frmPrikazIzvjestajaProdajniRefrent_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrikazIzvjestajaProdajniRefrent_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalog_strojevaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvDobavljacStrojeva;
        private System.Windows.Forms.BindingSource dobavljacBindingSource;
        private System.Windows.Forms.BindingSource katalog_strojevaBindingSource;
    }
}