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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dawid Urbaniak\nnr: 56525", "Autor projektu");
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zamknąć program?", "Potwierdź decyzję", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void btnUruchom_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
            this.Close();

        }
    }
}
