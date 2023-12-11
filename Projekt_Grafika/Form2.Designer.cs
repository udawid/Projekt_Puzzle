namespace Projekt_Grafika
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAutor = new System.Windows.Forms.Button();
            this.btnUruchom = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 193);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(39, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 110);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grafika komputerowa\r\nSemestr IV\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAutor
            // 
            this.btnAutor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAutor.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAutor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAutor.Location = new System.Drawing.Point(219, 471);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Size = new System.Drawing.Size(133, 50);
            this.btnAutor.TabIndex = 2;
            this.btnAutor.Text = "Autor";
            this.btnAutor.UseVisualStyleBackColor = false;
            this.btnAutor.Click += new System.EventHandler(this.btnAutor_Click);
            // 
            // btnUruchom
            // 
            this.btnUruchom.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUruchom.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUruchom.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUruchom.Location = new System.Drawing.Point(387, 471);
            this.btnUruchom.Name = "btnUruchom";
            this.btnUruchom.Size = new System.Drawing.Size(133, 50);
            this.btnUruchom.TabIndex = 3;
            this.btnUruchom.Text = "Uruchom Projekt";
            this.btnUruchom.UseVisualStyleBackColor = false;
            this.btnUruchom.Click += new System.EventHandler(this.btnUruchom_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnZamknij.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnZamknij.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnZamknij.Location = new System.Drawing.Point(49, 471);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(133, 50);
            this.btnZamknij.TabIndex = 4;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = false;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 533);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnUruchom);
            this.Controls.Add(this.btnAutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Projekt - Dawid Urbaniak";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAutor;
        private System.Windows.Forms.Button btnUruchom;
        private System.Windows.Forms.Button btnZamknij;
    }
}