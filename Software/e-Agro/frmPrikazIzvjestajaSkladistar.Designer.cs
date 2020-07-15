namespace e_Agro
{
    partial class frmPrikazIzvjestajaSkladistar
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
            this.katalog_strojevaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladisteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpvSkladisteStrojevi = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.katalog_strojevaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladisteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // katalog_strojevaBindingSource
            // 
            this.katalog_strojevaBindingSource.DataSource = typeof(e_Agro.katalog_strojeva);
            // 
            // skladisteBindingSource
            // 
            this.skladisteBindingSource.DataSource = typeof(e_Agro.skladiste);
            // 
            // rpvSkladisteStrojevi
            // 
            this.rpvSkladisteStrojevi.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsStroj";
            reportDataSource1.Value = this.katalog_strojevaBindingSource;
            reportDataSource2.Name = "dsSkladiste";
            reportDataSource2.Value = this.skladisteBindingSource;
            reportDataSource3.Name = "dsStrojNaSkladistu";
            reportDataSource3.Value = this.katalog_strojevaBindingSource;
            this.rpvSkladisteStrojevi.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvSkladisteStrojevi.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvSkladisteStrojevi.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvSkladisteStrojevi.LocalReport.ReportEmbeddedResource = "e_Agro.rptStrojeviNaSkladistu.rdlc";
            this.rpvSkladisteStrojevi.Location = new System.Drawing.Point(0, 0);
            this.rpvSkladisteStrojevi.Name = "rpvSkladisteStrojevi";
            this.rpvSkladisteStrojevi.ServerReport.BearerToken = null;
            this.rpvSkladisteStrojevi.Size = new System.Drawing.Size(800, 450);
            this.rpvSkladisteStrojevi.TabIndex = 0;
            // 
            // frmPrikazIzvjestajaSkladistar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvSkladisteStrojevi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPrikazIzvjestajaSkladistar";
            this.Text = "Prikaz strojeva na skladištu";
            this.Load += new System.EventHandler(this.frmSkladistarIzvjestaj_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrikazIzvjestajaSkladistar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.katalog_strojevaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladisteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvSkladisteStrojevi;
        private System.Windows.Forms.BindingSource katalog_strojevaBindingSource;
        private System.Windows.Forms.BindingSource skladisteBindingSource;
    }
}