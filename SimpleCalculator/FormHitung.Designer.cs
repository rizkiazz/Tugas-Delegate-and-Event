
namespace SimpleCalculator
{
    partial class FormHitung
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
            this.textBoxNilaiA = new System.Windows.Forms.TextBox();
            this.textBoxNilaiB = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxOperasi = new System.Windows.Forms.ComboBox();
            this.labelOperasi = new System.Windows.Forms.Label();
            this.labelNilaiA = new System.Windows.Forms.Label();
            this.labelNilaiB = new System.Windows.Forms.Label();
            this.buttonProses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNilaiA
            // 
            this.textBoxNilaiA.Location = new System.Drawing.Point(103, 44);
            this.textBoxNilaiA.Name = "textBoxNilaiA";
            this.textBoxNilaiA.Size = new System.Drawing.Size(161, 20);
            this.textBoxNilaiA.TabIndex = 0;
            // 
            // textBoxNilaiB
            // 
            this.textBoxNilaiB.Location = new System.Drawing.Point(103, 79);
            this.textBoxNilaiB.Name = "textBoxNilaiB";
            this.textBoxNilaiB.Size = new System.Drawing.Size(161, 20);
            this.textBoxNilaiB.TabIndex = 1;
            // 
            // comboBoxOperasi
            // 
            this.comboBoxOperasi.FormattingEnabled = true;
            this.comboBoxOperasi.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.comboBoxOperasi.Location = new System.Drawing.Point(103, 12);
            this.comboBoxOperasi.Name = "comboBoxOperasi";
            this.comboBoxOperasi.Size = new System.Drawing.Size(161, 21);
            this.comboBoxOperasi.TabIndex = 2;
            // 
            // labelOperasi
            // 
            this.labelOperasi.AutoSize = true;
            this.labelOperasi.Location = new System.Drawing.Point(37, 12);
            this.labelOperasi.Name = "labelOperasi";
            this.labelOperasi.Size = new System.Drawing.Size(43, 13);
            this.labelOperasi.TabIndex = 3;
            this.labelOperasi.Text = "Operasi";
            // 
            // labelNilaiA
            // 
            this.labelNilaiA.AutoSize = true;
            this.labelNilaiA.Location = new System.Drawing.Point(37, 47);
            this.labelNilaiA.Name = "labelNilaiA";
            this.labelNilaiA.Size = new System.Drawing.Size(37, 13);
            this.labelNilaiA.TabIndex = 3;
            this.labelNilaiA.Text = "Nilai A";
            // 
            // labelNilaiB
            // 
            this.labelNilaiB.AutoSize = true;
            this.labelNilaiB.Location = new System.Drawing.Point(37, 79);
            this.labelNilaiB.Name = "labelNilaiB";
            this.labelNilaiB.Size = new System.Drawing.Size(37, 13);
            this.labelNilaiB.TabIndex = 3;
            this.labelNilaiB.Text = "Nilai B";
            // 
            // buttonProses
            // 
            this.buttonProses.Location = new System.Drawing.Point(202, 126);
            this.buttonProses.Name = "buttonProses";
            this.buttonProses.Size = new System.Drawing.Size(62, 20);
            this.buttonProses.TabIndex = 4;
            this.buttonProses.Text = "Proses";
            this.buttonProses.UseVisualStyleBackColor = true;
            this.buttonProses.Click += new System.EventHandler(this.buttonProses_Click);
            // 
            // FormHitung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 183);
            this.Controls.Add(this.buttonProses);
            this.Controls.Add(this.labelNilaiB);
            this.Controls.Add(this.labelNilaiA);
            this.Controls.Add(this.labelOperasi);
            this.Controls.Add(this.comboBoxOperasi);
            this.Controls.Add(this.textBoxNilaiB);
            this.Controls.Add(this.textBoxNilaiA);
            this.Name = "FormHitung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHitung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNilaiA;
        private System.Windows.Forms.MaskedTextBox textBoxNilaiB;
        private System.Windows.Forms.ComboBox comboBoxOperasi;
        private System.Windows.Forms.Label labelOperasi;
        private System.Windows.Forms.Label labelNilaiA;
        private System.Windows.Forms.Label labelNilaiB;
        private System.Windows.Forms.Button buttonProses;
    }
}