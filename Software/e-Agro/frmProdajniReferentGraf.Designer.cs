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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.chartProdaja = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdaja)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(12, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(154, 22);
            this.lblNaslov.TabIndex = 2;
            this.lblNaslov.Text = "Graf uspješnosti";
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
            this.Controls.Add(this.lblNaslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProdajniReferentGraf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graf profita i prodaje";
            this.Load += new System.EventHandler(this.frmProdajniReferentGraf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProdaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdaja;
    }
}