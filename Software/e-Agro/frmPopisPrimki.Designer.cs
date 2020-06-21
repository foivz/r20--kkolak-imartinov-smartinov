namespace e_Agro
{
    partial class frmPopisPrimki
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvPrimke = new System.Windows.Forms.DataGridView();
            this.dgvStavkeNaPrimci = new System.Windows.Forms.DataGridView();
            this.btnDodajStroj = new System.Windows.Forms.Button();
            this.lblNaslovStavke = new System.Windows.Forms.Label();
            this.btnIspisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNaPrimci)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(250, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(73, 23);
            this.lblNaslov.TabIndex = 27;
            this.lblNaslov.Text = "Primke";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Location = new System.Drawing.Point(382, 227);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(174, 37);
            this.btnAzuriraj.TabIndex = 26;
            this.btnAzuriraj.Text = "Ažuriraj primku";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(382, 155);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(174, 37);
            this.btnObrisi.TabIndex = 25;
            this.btnObrisi.Text = "Obriši primku";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(382, 83);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(174, 37);
            this.btnDodaj.TabIndex = 24;
            this.btnDodaj.Text = "Dodaj primku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvPrimke
            // 
            this.dgvPrimke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrimke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrimke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimke.Location = new System.Drawing.Point(12, 81);
            this.dgvPrimke.Name = "dgvPrimke";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrimke.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrimke.Size = new System.Drawing.Size(345, 258);
            this.dgvPrimke.TabIndex = 21;
            this.dgvPrimke.SelectionChanged += new System.EventHandler(this.dgvPrimke_SelectionChanged);
            // 
            // dgvStavkeNaPrimci
            // 
            this.dgvStavkeNaPrimci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStavkeNaPrimci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStavkeNaPrimci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeNaPrimci.Location = new System.Drawing.Point(12, 429);
            this.dgvStavkeNaPrimci.Name = "dgvStavkeNaPrimci";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStavkeNaPrimci.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStavkeNaPrimci.Size = new System.Drawing.Size(544, 258);
            this.dgvStavkeNaPrimci.TabIndex = 28;
            // 
            // btnDodajStroj
            // 
            this.btnDodajStroj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajStroj.Location = new System.Drawing.Point(12, 693);
            this.btnDodajStroj.Name = "btnDodajStroj";
            this.btnDodajStroj.Size = new System.Drawing.Size(140, 54);
            this.btnDodajStroj.TabIndex = 29;
            this.btnDodajStroj.Text = "Dodaj stroj na primku";
            this.btnDodajStroj.UseVisualStyleBackColor = true;
            this.btnDodajStroj.Click += new System.EventHandler(this.btnDodajStroj_Click);
            // 
            // lblNaslovStavke
            // 
            this.lblNaslovStavke.AutoSize = true;
            this.lblNaslovStavke.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslovStavke.ForeColor = System.Drawing.Color.White;
            this.lblNaslovStavke.Location = new System.Drawing.Point(191, 403);
            this.lblNaslovStavke.Name = "lblNaslovStavke";
            this.lblNaslovStavke.Size = new System.Drawing.Size(166, 23);
            this.lblNaslovStavke.TabIndex = 30;
            this.lblNaslovStavke.Text = "Stavke na primci";
            // 
            // btnIspisi
            // 
            this.btnIspisi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIspisi.Location = new System.Drawing.Point(382, 304);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(174, 37);
            this.btnIspisi.TabIndex = 31;
            this.btnIspisi.Text = "Ispiši odabranu primku";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // frmPopisPrimki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(570, 759);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.lblNaslovStavke);
            this.Controls.Add(this.btnDodajStroj);
            this.Controls.Add(this.dgvStavkeNaPrimci);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvPrimke);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPopisPrimki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis primki";
            this.Load += new System.EventHandler(this.frmPopisPrimki_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPopisPrimki_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNaPrimci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvPrimke;
        private System.Windows.Forms.DataGridView dgvStavkeNaPrimci;
        private System.Windows.Forms.Button btnDodajStroj;
        private System.Windows.Forms.Label lblNaslovStavke;
        private System.Windows.Forms.Button btnIspisi;
    }
}