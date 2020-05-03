namespace e_Agro
{
    partial class frmProdajniReferentGraf
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
            this.chartProdaja = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPrikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdaja)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProdaja
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProdaja.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProdaja.Legends.Add(legend1);
            this.chartProdaja.Location = new System.Drawing.Point(12, 223);
            this.chartProdaja.Name = "chartProdaja";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProdaja.Series.Add(series1);
            this.chartProdaja.Size = new System.Drawing.Size(831, 300);
            this.chartProdaja.TabIndex = 0;
            this.chartProdaja.Text = "chart1";
            this.chartProdaja.Visible = false;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(330, 12);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikaži graf";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            // 
            // frmProdajniReferentGraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 535);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.chartProdaja);
            this.Name = "frmProdajniReferentGraf";
            this.Text = "frmProdajniReferentGraf";
            ((System.ComponentModel.ISupportInitialize)(this.chartProdaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdaja;
        private System.Windows.Forms.Button btnPrikazi;
    }
}