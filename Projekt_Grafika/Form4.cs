using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Grafika
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'rankingDataSet1.Wynik2' . Możesz go przenieść lub usunąć.
            this.wynik2TableAdapter.Fill(this.rankingDataSet1.Wynik2);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'rankingDataSet.Wynik' . Możesz go przenieść lub usunąć.
            this.wynikTableAdapter.Fill(this.rankingDataSet.Wynik);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.wynikTableAdapter.FillBy(this.rankingDataSet.Wynik);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fill1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.wynik2TableAdapter.Fill1(this.rankingDataSet1.Wynik2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            label3.Visible = true;
            label2.Visible = false;
            fillByToolStripButton.Visible = false;
            fill1ToolStripButton.Visible =true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            label3.Visible = false;
            button2.Visible = false;
            label2.Visible= true;
            fillByToolStripButton.Visible=true;
            fill1ToolStripButton.Visible =false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
