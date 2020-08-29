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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartDobavljac = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartDobavljac)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDobavljac
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDobavljac.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDobavljac.Legends.Add(legend1);
            this.chartDobavljac.Location = new System.Drawing.Point(25, 104);
            this.chartDobavljac.Name = "chartDobavljac";
            this.chartDobavljac.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Dobavljač";
            this.chartDobavljac.Series.Add(series1);
            this.chartDobavljac.Size = new System.Drawing.Size(742, 334);
            this.chartDobavljac.TabIndex = 4;
            this.chartDobavljac.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Naručivanje od dobavljača";
            this.chartDobavljac.Titles.Add(title1);
            // 
            // frmNarudzbaGraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartDobavljac);
            this.Name = "frmNarudzbaGraf";
            this.Text = "frmNarudzbaGraf";
            this.Load += new System.EventHandler(this.frmNarudzbaGraf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDobavljac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDobavljac;
    }
}