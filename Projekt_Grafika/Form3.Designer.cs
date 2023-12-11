namespace Projekt_Grafika
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPuzzle1 = new System.Windows.Forms.Button();
            this.btnZamknij2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPuzzle2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Ranking = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 36F);
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz grę";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPuzzle1
            // 
            this.btnPuzzle1.Font = new System.Drawing.Font("Rubik", 9.75F);
            this.btnPuzzle1.Location = new System.Drawing.Point(3, 3);
            this.btnPuzzle1.Name = "btnPuzzle1";
            this.btnPuzzle1.Size = new System.Drawing.Size(208, 149);
            this.btnPuzzle1.TabIndex = 1;
            this.btnPuzzle1.Text = "Puzzle\r\nPoziom łatwy";
            this.btnPuzzle1.UseVisualStyleBackColor = true;
            this.btnPuzzle1.Click += new System.EventHandler(this.btnPuzzle1_Click);
            // 
            // btnZamknij2
            // 
            this.btnZamknij2.Font = new System.Drawing.Font("Rubik", 9.75F);
            this.btnZamknij2.Location = new System.Drawing.Point(184, 413);
            this.btnZamknij2.Name = "btnZamknij2";
            this.btnZamknij2.Size = new System.Drawing.Size(75, 23);
            this.btnZamknij2.TabIndex = 2;
            this.btnZamknij2.Text = "Zamknij";
            this.btnZamknij2.UseVisualStyleBackColor = true;
            this.btnZamknij2.Click += new System.EventHandler(this.btnZamknij2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnPuzzle1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPuzzle2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(428, 311);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(217, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 143);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnPuzzle2
            // 
            this.btnPuzzle2.Font = new System.Drawing.Font("Rubik", 9.75F);
            this.btnPuzzle2.Location = new System.Drawing.Point(3, 158);
            this.btnPuzzle2.Name = "btnPuzzle2";
            this.btnPuzzle2.Size = new System.Drawing.Size(208, 150);
            this.btnPuzzle2.TabIndex = 3;
            this.btnPuzzle2.Text = "Puzzle\r\nPoziom trudny";
            this.btnPuzzle2.UseVisualStyleBackColor = true;
            this.btnPuzzle2.Click += new System.EventHandler(this.btnPuzzle2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 156);
            this.label3.TabIndex = 4;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Ranking
            // 
            this.Ranking.Font = new System.Drawing.Font("Rubik", 9.75F);
            this.Ranking.Location = new System.Drawing.Point(184, 384);
            this.Ranking.Name = "Ranking";
            this.Ranking.Size = new System.Drawing.Size(75, 23);
            this.Ranking.TabIndex = 4;
            this.Ranking.Text = "Ranking";
            this.Ranking.UseVisualStyleBackColor = true;
            this.Ranking.Click += new System.EventHandler(this.Ranking_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 448);
            this.Controls.Add(this.Ranking);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnZamknij2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Główne Menu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPuzzle1;
        private System.Windows.Forms.Button btnZamknij2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Ranking;
        private System.Windows.Forms.Button btnPuzzle2;
        private System.Windows.Forms.Label label3;
    }
}