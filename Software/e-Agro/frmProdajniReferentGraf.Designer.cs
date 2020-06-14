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
            this.label1 = new System.Windows.Forms.Label();
            this.chartProdaja = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdaja)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Graf uspješnosti";
            // 
            // chartProdaja
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProdaja.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProdaja.Legends.Add(legend1);
            this.chartProdaja.Location = new System.Drawing.Point(12, 108);
            this.chartProdaja.Name = "chartProdaja";
            this.chartProdaja.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Vrsta stroja";
            this.chartProdaja.Series.Add(series1);
            this.chartProdaja.Size = new System.Drawing.Size(827, 334);
            this.chartProdaja.TabIndex = 3;
            this.chartProdaja.Text = "chart1";
            // 
            // frmProdajniReferentGraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(855, 454);
            this.Controls.Add(this.chartProdaja);
            this.Controls.Add(this.label1);
            this.Name = "frmProdajniReferentGraf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graf profita i prodaje";
            this.Load += new System.EventHandler(this.frmProdajniReferentGraf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProdaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdaja;
    }
}