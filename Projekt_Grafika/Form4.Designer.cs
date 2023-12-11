namespace Projekt_Grafika
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wynikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rankingDataSet = new Projekt_Grafika.RankingDataSet();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.wynikTableAdapter = new Projekt_Grafika.RankingDataSetTableAdapters.WynikTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fill1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fill1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wynik2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rankingDataSet1 = new Projekt_Grafika.RankingDataSet1();
            this.wynik2TableAdapter = new Projekt_Grafika.RankingDataSet1TableAdapters.Wynik2TableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankingDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.fill1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wynik2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankingDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 48F);
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ranking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 20.25F);
            this.label2.Location = new System.Drawing.Point(159, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Poziom łatwy";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieDataGridViewTextBoxColumn,
            this.czasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wynikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(131, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(244, 430);
            this.dataGridView1.TabIndex = 2;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // czasDataGridViewTextBoxColumn
            // 
            this.czasDataGridViewTextBoxColumn.DataPropertyName = "czas";
            this.czasDataGridViewTextBoxColumn.HeaderText = "czas";
            this.czasDataGridViewTextBoxColumn.Name = "czasDataGridViewTextBoxColumn";
            this.czasDataGridViewTextBoxColumn.ReadOnly = true;
            this.czasDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // wynikBindingSource
            // 
            this.wynikBindingSource.DataMember = "Wynik";
            this.wynikBindingSource.DataSource = this.rankingDataSet;
            // 
            // rankingDataSet
            // 
            this.rankingDataSet.DataSetName = "RankingDataSet";
            this.rankingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 592);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(504, 25);
            this.fillByToolStrip.TabIndex = 3;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(101, 22);
            this.fillByToolStripButton.Text = "Odśwież Ranking";
            this.fillByToolStripButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // wynikTableAdapter
            // 
            this.wynikTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Poziom trudny";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieDataGridViewTextBoxColumn1,
            this.czasDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.wynik2BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(131, 142);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(244, 430);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.Visible = false;
            // 
            // fill1ToolStrip
            // 
            this.fill1ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fill1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fill1ToolStripButton});
            this.fill1ToolStrip.Location = new System.Drawing.Point(0, 567);
            this.fill1ToolStrip.Name = "fill1ToolStrip";
            this.fill1ToolStrip.Size = new System.Drawing.Size(504, 25);
            this.fill1ToolStrip.TabIndex = 6;
            this.fill1ToolStrip.Text = "fill1ToolStrip";
            // 
            // fill1ToolStripButton
            // 
            this.fill1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fill1ToolStripButton.Name = "fill1ToolStripButton";
            this.fill1ToolStripButton.Size = new System.Drawing.Size(101, 22);
            this.fill1ToolStripButton.Text = "Odśwież Ranking";
            this.fill1ToolStripButton.Visible = false;
            this.fill1ToolStripButton.Click += new System.EventHandler(this.fill1ToolStripButton_Click);
            // 
            // imieDataGridViewTextBoxColumn1
            // 
            this.imieDataGridViewTextBoxColumn1.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn1.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn1.Name = "imieDataGridViewTextBoxColumn1";
            // 
            // czasDataGridViewTextBoxColumn1
            // 
            this.czasDataGridViewTextBoxColumn1.DataPropertyName = "Czas";
            this.czasDataGridViewTextBoxColumn1.HeaderText = "Czas";
            this.czasDataGridViewTextBoxColumn1.Name = "czasDataGridViewTextBoxColumn1";
            // 
            // wynik2BindingSource
            // 
            this.wynik2BindingSource.DataMember = "Wynik2";
            this.wynik2BindingSource.DataSource = this.rankingDataSet1;
            // 
            // rankingDataSet1
            // 
            this.rankingDataSet1.DataSetName = "RankingDataSet1";
            this.rankingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wynik2TableAdapter
            // 
            this.wynik2TableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 20.25F);
            this.label3.Location = new System.Drawing.Point(159, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Poziom trudny";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Poziom Łatwy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 617);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fill1ToolStrip);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Ranking";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankingDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.fill1ToolStrip.ResumeLayout(false);
            this.fill1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wynik2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankingDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RankingDataSet rankingDataSet;
        private System.Windows.Forms.BindingSource wynikBindingSource;
        private RankingDataSetTableAdapters.WynikTableAdapter wynikTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn czasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private RankingDataSet1 rankingDataSet1;
        private System.Windows.Forms.BindingSource wynik2BindingSource;
        private RankingDataSet1TableAdapters.Wynik2TableAdapter wynik2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn czasDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStrip fill1ToolStrip;
        private System.Windows.Forms.ToolStripButton fill1ToolStripButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}