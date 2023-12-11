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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPuzzle1_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Po zatwierdzeniu komunikatu gra się rozpocznie i zacznie mierzyć czas. Czy jesteś gotowy na rozpoczęcie gry?", "Rozpoczęcie gry", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Zagraj jeżeli będziesz gotowy");
            }
            
        }

        private void btnZamknij2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zamknąć program?", "Potwierdź decyzję", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void btnPuzzle2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Po zatwierdzeniu komunikatu gra się rozpocznie i zacznie mierzyć czas. Czy jesteś gotowy na rozpoczęcie gry?", "Rozpoczęcie gry", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form5 f5 = new Form5();
                f5.ShowDialog();
            }
            else
            {
                MessageBox.Show("Zagraj jeżeli będziesz gotowy");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Ranking_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
