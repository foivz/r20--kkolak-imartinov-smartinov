namespace e_Agro
{
    partial class frmDodavanjePrimke
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
            this.lblKreirao = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbKreirao = new System.Windows.Forms.ComboBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKreirao
            // 
            this.lblKreirao.AutoSize = true;
            this.lblKreirao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKreirao.ForeColor = System.Drawing.Color.White;
            this.lblKreirao.Location = new System.Drawing.Point(43, 87);
            this.lblKreirao.Name = "lblKreirao";
            this.lblKreirao.Size = new System.Drawing.Size(57, 17);
            this.lblKreirao.TabIndex = 38;
            this.lblKreirao.Text = "Kreirao:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(181, 178);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 34);
            this.btnOdustani.TabIndex = 43;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(42, 178);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(120, 34);
            this.btnDodaj.TabIndex = 42;
            this.btnDodaj.Text = "Dodaj primku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbKreirao
            // 
            this.cmbKreirao.FormattingEnabled = true;
            this.cmbKreirao.Location = new System.Drawing.Point(42, 107);
            this.cmbKreirao.Name = "cmbKreirao";
            this.cmbKreirao.Size = new System.Drawing.Size(121, 21);
            this.cmbKreirao.TabIndex = 48;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(38, 24);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(184, 22);
            this.lblNaslov.TabIndex = 49;
            this.lblNaslov.Text = "Dodaj novu primku";
            // 
            // frmDodavanjePrimke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(304, 229);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.cmbKreirao);
            this.Controls.Add(this.lblKreirao);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDodavanjePrimke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje primke";
            this.Load += new System.EventHandler(this.frmDodavanjePrimke_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDodavanjePrimke_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKreirao;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbKreirao;
        private System.Windows.Forms.Label lblNaslov;
    }
}