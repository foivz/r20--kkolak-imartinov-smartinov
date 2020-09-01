namespace e_Agro
{
    partial class frmNarudzbaGraf
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartDobavljac = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartStrojNarudzbe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.katalogstrojevaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartDobavljac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStrojNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalogstrojevaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDobavljac
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDobavljac.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDobavljac.Legends.Add(legend1);
            this.chartDobavljac.Location = new System.Drawing.Point(28, 12);
            this.chartDobavljac.Name = "chartDobavljac";
            this.chartDobavljac.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Stroj";
            this.chartDobavljac.Series.Add(series1);
            this.chartDobavljac.Size = new System.Drawing.Size(742, 334);
            this.chartDobavljac.TabIndex = 4;
            this.chartDobavljac.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Popis strojeva i njihove cijene";
            this.chartDobavljac.Titles.Add(title1);
            // 
            // chartStrojNarudzbe
            // 
            chartArea2.Name = "ChartArea1";
            this.chartStrojNarudzbe.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStrojNarudzbe.Legends.Add(legend2);
            this.chartStrojNarudzbe.Location = new System.Drawing.Point(28, 409);
            this.chartStrojNarudzbe.Name = "chartStrojNarudzbe";
            this.chartStrojNarudzbe.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "StrojNarudzbe";
            this.chartStrojNarudzbe.Series.Add(series2);
            this.chartStrojNarudzbe.Size = new System.Drawing.Size(742, 334);
            this.chartStrojNarudzbe.TabIndex = 5;
            this.chartStrojNarudzbe.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Popis strojeva i njihove cijene za odabranu narudžbu";
            this.chartStrojNarudzbe.Titles.Add(title2);
            // 
            // katalogstrojevaBindingSource
            // 
            this.katalogstrojevaBindingSource.DataSource = typeof(e_Agro.katalog_strojeva);
            // 
            // frmNarudzbaGraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 768);
            this.Controls.Add(this.chartStrojNarudzbe);
            this.Controls.Add(this.chartDobavljac);
            this.Name = "frmNarudzbaGraf";
            this.Text = "frmNarudzbaGraf";
            this.Load += new System.EventHandler(this.frmNarudzbaGraf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDobavljac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStrojNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalogstrojevaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDobavljac;
        private System.Windows.Forms.BindingSource katalogstrojevaBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStrojNarudzbe;
    }
}