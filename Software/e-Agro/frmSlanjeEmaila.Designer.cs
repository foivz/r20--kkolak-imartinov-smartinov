namespace e_Agro
{
    partial class frmSlanjeEmaila
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrivitak = new System.Windows.Forms.Label();
            this.rtxtSadrzaj = new System.Windows.Forms.RichTextBox();
            this.txtZa = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.lnkDodajPrivitak = new System.Windows.Forms.LinkLabel();
            this.fdPrivitak = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Za:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Naslov:";
            // 
            // lblPrivitak
            // 
            this.lblPrivitak.AutoSize = true;
            this.lblPrivitak.Location = new System.Drawing.Point(66, 193);
            this.lblPrivitak.Name = "lblPrivitak";
            this.lblPrivitak.Size = new System.Drawing.Size(45, 13);
            this.lblPrivitak.TabIndex = 3;
            this.lblPrivitak.Text = "Privitak;";
            // 
            // rtxtSadrzaj
            // 
            this.rtxtSadrzaj.Location = new System.Drawing.Point(134, 231);
            this.rtxtSadrzaj.Name = "rtxtSadrzaj";
            this.rtxtSadrzaj.Size = new System.Drawing.Size(520, 366);
            this.rtxtSadrzaj.TabIndex = 5;
            this.rtxtSadrzaj.Text = "";
            // 
            // txtZa
            // 
            this.txtZa.Location = new System.Drawing.Point(134, 40);
            this.txtZa.Name = "txtZa";
            this.txtZa.Size = new System.Drawing.Size(520, 20);
            this.txtZa.TabIndex = 6;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(134, 84);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(520, 20);
            this.txtCC.TabIndex = 7;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(134, 140);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(520, 20);
            this.txtNaslov.TabIndex = 8;
            // 
            // btnOdustani
            // 
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOdustani.Location = new System.Drawing.Point(569, 617);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(85, 35);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPosalji
            // 
            this.btnPosalji.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPosalji.Location = new System.Drawing.Point(134, 617);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(85, 35);
            this.btnPosalji.TabIndex = 9;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // lnkDodajPrivitak
            // 
            this.lnkDodajPrivitak.AutoSize = true;
            this.lnkDodajPrivitak.LinkColor = System.Drawing.Color.White;
            this.lnkDodajPrivitak.Location = new System.Drawing.Point(131, 193);
            this.lnkDodajPrivitak.Name = "lnkDodajPrivitak";
            this.lnkDodajPrivitak.Size = new System.Drawing.Size(72, 13);
            this.lnkDodajPrivitak.TabIndex = 10;
            this.lnkDodajPrivitak.TabStop = true;
            this.lnkDodajPrivitak.Text = "Dodaj privitak";
            this.lnkDodajPrivitak.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDodajPrivitak_LinkClicked);
            // 
            // fdPrivitak
            // 
            this.fdPrivitak.FileName = "openFileDialog1";
            // 
            // frmSlanjeEmaila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(685, 674);
            this.Controls.Add(this.lnkDodajPrivitak);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.txtZa);
            this.Controls.Add(this.rtxtSadrzaj);
            this.Controls.Add(this.lblPrivitak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmSlanjeEmaila";
            this.Text = "Slanje e-maila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrivitak;
        private System.Windows.Forms.RichTextBox rtxtSadrzaj;
        private System.Windows.Forms.TextBox txtZa;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.LinkLabel lnkDodajPrivitak;
        private System.Windows.Forms.OpenFileDialog fdPrivitak;
    }
}