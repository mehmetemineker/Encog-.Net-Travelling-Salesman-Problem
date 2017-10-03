namespace GA.GSP
{
    partial class FormMain
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
            this.ButtonRandomGenerate = new System.Windows.Forms.Button();
            this.ButtonSolve = new System.Windows.Forms.Button();
            this.panelBoard = new System.Windows.Forms.Panel();
            this.numericUpDownCityCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCityCount)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRandomGenerate
            // 
            this.ButtonRandomGenerate.Location = new System.Drawing.Point(124, 481);
            this.ButtonRandomGenerate.Name = "ButtonRandomGenerate";
            this.ButtonRandomGenerate.Size = new System.Drawing.Size(213, 36);
            this.ButtonRandomGenerate.TabIndex = 0;
            this.ButtonRandomGenerate.Text = "Rastgele Şehir Konumları Üret";
            this.ButtonRandomGenerate.UseVisualStyleBackColor = true;
            this.ButtonRandomGenerate.Click += new System.EventHandler(this.ButtonRandomGenerate_Click);
            // 
            // ButtonSolve
            // 
            this.ButtonSolve.Location = new System.Drawing.Point(343, 481);
            this.ButtonSolve.Name = "ButtonSolve";
            this.ButtonSolve.Size = new System.Drawing.Size(213, 36);
            this.ButtonSolve.TabIndex = 1;
            this.ButtonSolve.Text = "Çöz";
            this.ButtonSolve.UseVisualStyleBackColor = true;
            this.ButtonSolve.Click += new System.EventHandler(this.ButtonSolve_Click);
            // 
            // panelBoard
            // 
            this.panelBoard.BackColor = System.Drawing.Color.Black;
            this.panelBoard.ForeColor = System.Drawing.Color.White;
            this.panelBoard.Location = new System.Drawing.Point(12, 12);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(882, 463);
            this.panelBoard.TabIndex = 3;
            // 
            // numericUpDownCityCount
            // 
            this.numericUpDownCityCount.Location = new System.Drawing.Point(12, 497);
            this.numericUpDownCityCount.Name = "numericUpDownCityCount";
            this.numericUpDownCityCount.Size = new System.Drawing.Size(106, 20);
            this.numericUpDownCityCount.TabIndex = 4;
            this.numericUpDownCityCount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Şehir Sayısı:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownCityCount);
            this.Controls.Add(this.panelBoard);
            this.Controls.Add(this.ButtonSolve);
            this.Controls.Add(this.ButtonRandomGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gezgin Satıcı Problemi - Genetik Algoritma";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCityCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonRandomGenerate;
        private System.Windows.Forms.Button ButtonSolve;
        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.NumericUpDown numericUpDownCityCount;
        private System.Windows.Forms.Label label1;
    }
}

