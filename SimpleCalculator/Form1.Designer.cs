
namespace SimpleCalculator
{
    partial class FrmHasilHitung
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
            this.groupBoxHasil = new System.Windows.Forms.GroupBox();
            this.listBoxHasil = new System.Windows.Forms.ListBox();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.groupBoxHasil.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHasil
            // 
            this.groupBoxHasil.Controls.Add(this.listBoxHasil);
            this.groupBoxHasil.Location = new System.Drawing.Point(12, 12);
            this.groupBoxHasil.Name = "groupBoxHasil";
            this.groupBoxHasil.Size = new System.Drawing.Size(470, 294);
            this.groupBoxHasil.TabIndex = 0;
            this.groupBoxHasil.TabStop = false;
            this.groupBoxHasil.Text = "[ Hasil ]";
            // 
            // listBoxHasil
            // 
            this.listBoxHasil.FormattingEnabled = true;
            this.listBoxHasil.Location = new System.Drawing.Point(6, 19);
            this.listBoxHasil.Name = "listBoxHasil";
            this.listBoxHasil.Size = new System.Drawing.Size(458, 264);
            this.listBoxHasil.TabIndex = 0;
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(12, 321);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(470, 25);
            this.buttonProcess.TabIndex = 1;
            this.buttonProcess.Text = "Proses";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // FrmHasilHitung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 369);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.groupBoxHasil);
            this.Name = "FrmHasilHitung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasil Perhitungan";
            this.groupBoxHasil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHasil;
        private System.Windows.Forms.ListBox listBoxHasil;
        private System.Windows.Forms.Button buttonProcess;
    }
}

