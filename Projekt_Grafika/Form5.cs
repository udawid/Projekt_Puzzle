using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Timers;

namespace Projekt_Grafika
{
    public partial class Form5 : Form
    {
        string connectionString = @"Persist Security Info=False;Integrated Security = true; Initial Catalog = Ranking; server=DESKTOP-NN6FPVO";
        System.Timers.Timer t;
        int h, m, s;
        public Form5()
        {
            InitializeComponent();
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
            t.Start();
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() => {
                s += 1;
                if (s == 60 || s > 60)
                {
                    s = 0;
                    m = m+1;
                }
                if (m == 60)
                {
                    m = 0;
                    h +=1;
                }
                txtWynik.Text=string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }
        #region Ruch
        private void chwycenie(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button b = sender as Button;
                b.Tag = e.Location;
            }
        }
        private void przesuniecie(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button b = sender as Button;
                b.Left += e.X - ((Point)b.Tag).X;
                b.Top += e.Y - ((Point)b.Tag).Y;
            }
        }
        private void wciagniecie(object sender, MouseEventArgs e)
        {
            int a = 35, /*b = 50*/ c = 135;
            #region Pole1
            if (btnPuzzle1.Left - a < btnSprawdz1.Left + a & btnPuzzle1.Top - a < btnSprawdz1.Top)
                btnPuzzle1.Location = new Point(14, 12);
            if (btnPuzzle2.Left - a < btnSprawdz1.Left & btnPuzzle2.Top - a < btnSprawdz1.Top)
                btnPuzzle2.Location = new Point(14, 12);
            if (btnPuzzle3.Left - a < btnSprawdz1.Left & btnPuzzle3.Top - a < btnSprawdz1.Top)
                btnPuzzle3.Location = new Point(14, 12);
            if (btnPuzzle4.Left - a < btnSprawdz1.Left & btnPuzzle4.Top - a < btnSprawdz1.Top)
                btnPuzzle4.Location = new Point(14, 12);
            if (btnPuzzle5.Left - a < btnSprawdz1.Left & btnPuzzle5.Top - a < btnSprawdz1.Top)
                btnPuzzle5.Location = new Point(14, 12);
            if (btnPuzzle6.Left - a < btnSprawdz1.Left & btnPuzzle6.Top - a < btnSprawdz1.Top)
                btnPuzzle6.Location = new Point(14, 12);
            if (btnPuzzle7.Left - a < btnSprawdz1.Left & btnPuzzle7.Top - a < btnSprawdz1.Top)
                btnPuzzle7.Location = new Point(14, 12);
            if (btnPuzzle8.Left - a < btnSprawdz1.Left & btnPuzzle8.Top - a < btnSprawdz1.Top)
                btnPuzzle8.Location = new Point(14, 12);
            #endregion
            #region Pole2
            if (btnPuzzle1.Left > btnSprawdz1.Right - a & btnPuzzle1.Left < btnSprawdz3.Left - c & btnPuzzle1.Bottom < btnSprawdz6.Top + a)
                btnPuzzle1.Location = new Point(176, 12);
            if (btnPuzzle2.Left > btnSprawdz1.Right - a & btnPuzzle2.Left < btnSprawdz3.Left - c & btnPuzzle2.Bottom < btnSprawdz6.Top + a)
                btnPuzzle2.Location = new Point(176, 12);
            if (btnPuzzle3.Left > btnSprawdz1.Right - a & btnPuzzle3.Left < btnSprawdz3.Left - c & btnPuzzle3.Bottom < btnSprawdz6.Top + a)
                btnPuzzle3.Location = new Point(176, 12);
            if (btnPuzzle4.Left > btnSprawdz1.Right - a & btnPuzzle4.Left < btnSprawdz3.Left - c & btnPuzzle4.Bottom < btnSprawdz6.Top + a)
                btnPuzzle4.Location = new Point(176, 12);
            if (btnPuzzle5.Left > btnSprawdz1.Right - a & btnPuzzle5.Left < btnSprawdz3.Left - c & btnPuzzle5.Bottom < btnSprawdz6.Top + a)
                btnPuzzle5.Location = new Point(176, 12);
            if (btnPuzzle6.Left > btnSprawdz1.Right - a & btnPuzzle6.Left < btnSprawdz3.Left - c & btnPuzzle6.Bottom < btnSprawdz6.Top + a)
                btnPuzzle6.Location = new Point(176, 12);
            if (btnPuzzle7.Left > btnSprawdz1.Right - a & btnPuzzle7.Left < btnSprawdz3.Left - c & btnPuzzle7.Bottom < btnSprawdz6.Top + a)
                btnPuzzle7.Location = new Point(176, 12);
            if (btnPuzzle8.Left > btnSprawdz1.Right - a & btnPuzzle8.Left < btnSprawdz3.Left - c & btnPuzzle8.Bottom < btnSprawdz6.Top + a)
                btnPuzzle8.Location = new Point(176, 12);
            #endregion
            #region Pole3
            if (btnPuzzle1.Left > btnSprawdz2.Right - a & btnPuzzle1.Left < btnSprawdz4.Left - c & btnPuzzle1.Bottom < btnSprawdz7.Top + a)
                btnPuzzle1.Location = new Point(338, 12);
            if (btnPuzzle2.Left > btnSprawdz2.Right - a & btnPuzzle2.Left < btnSprawdz4.Left - c & btnPuzzle2.Bottom < btnSprawdz7.Top + a)
                btnPuzzle2.Location = new Point(338, 12);
            if (btnPuzzle3.Left > btnSprawdz2.Right - a & btnPuzzle3.Left < btnSprawdz4.Left - c & btnPuzzle3.Bottom < btnSprawdz7.Top + a)
                btnPuzzle3.Location = new Point(338, 12);
            if (btnPuzzle4.Left > btnSprawdz2.Right - a & btnPuzzle4.Left < btnSprawdz4.Left - c & btnPuzzle4.Bottom < btnSprawdz7.Top + a)
                btnPuzzle4.Location = new Point(338, 12);
            if (btnPuzzle5.Left > btnSprawdz2.Right - a & btnPuzzle5.Left < btnSprawdz4.Left - c & btnPuzzle5.Bottom < btnSprawdz7.Top + a)
                btnPuzzle5.Location = new Point(338, 12);
            if (btnPuzzle6.Left > btnSprawdz2.Right - a & btnPuzzle6.Left < btnSprawdz4.Left - c & btnPuzzle6.Bottom < btnSprawdz7.Top + a)
                btnPuzzle6.Location = new Point(338, 12);
            if (btnPuzzle7.Left > btnSprawdz2.Right - a & btnPuzzle7.Left < btnSprawdz4.Left - c & btnPuzzle7.Bottom < btnSprawdz7.Top + a)
                btnPuzzle7.Location = new Point(338, 12);
            if (btnPuzzle8.Left > btnSprawdz2.Right - a & btnPuzzle8.Left < btnSprawdz4.Left - c & btnPuzzle8.Bottom < btnSprawdz7.Top + a)
                btnPuzzle8.Location = new Point(338, 12);
            #endregion
            #region Pole4
            if (btnPuzzle1.Left < btnSprawdz4.Right - c & btnPuzzle1.Left > btnSprawdz3.Right - a & btnPuzzle1.Bottom < btnSprawdz8.Top + a)
                btnPuzzle1.Location = new Point(500, 12);
            if (btnPuzzle2.Left < btnSprawdz4.Right - c & btnPuzzle2.Left > btnSprawdz3.Right - a & btnPuzzle2.Bottom < btnSprawdz8.Top + a)
                btnPuzzle2.Location = new Point(500, 12);
            if (btnPuzzle3.Left < btnSprawdz4.Right - c & btnPuzzle3.Left > btnSprawdz3.Right - a & btnPuzzle3.Bottom < btnSprawdz8.Top + a)
                btnPuzzle3.Location = new Point(500, 12);
            if (btnPuzzle4.Left < btnSprawdz4.Right - c & btnPuzzle4.Left > btnSprawdz3.Right - a & btnPuzzle4.Bottom < btnSprawdz8.Top + a)
                btnPuzzle4.Location = new Point(500, 12);
            if (btnPuzzle5.Left < btnSprawdz4.Right - c & btnPuzzle5.Left > btnSprawdz3.Right - a & btnPuzzle5.Bottom < btnSprawdz8.Top + a)
                btnPuzzle5.Location = new Point(500, 12);
            if (btnPuzzle6.Left < btnSprawdz4.Right - c & btnPuzzle6.Left > btnSprawdz3.Right - a & btnPuzzle6.Bottom < btnSprawdz8.Top + a)
                btnPuzzle6.Location = new Point(500, 12);
            if (btnPuzzle7.Left < btnSprawdz4.Right - c & btnPuzzle7.Left > btnSprawdz3.Right - a & btnPuzzle7.Bottom < btnSprawdz8.Top + a)
                btnPuzzle7.Location = new Point(500, 12);
            if (btnPuzzle8.Left < btnSprawdz4.Right - c & btnPuzzle8.Left > btnSprawdz3.Right - a & btnPuzzle8.Bottom < btnSprawdz8.Top + a)
                btnPuzzle8.Location = new Point(500, 12);
            #endregion
            #region Pole5
            if (btnPuzzle1.Left < btnSprawdz5.Left + a & btnPuzzle1.Top > btnSprawdz5.Top - a & btnPuzzle1.Bottom < btnTlo.Bottom)
                btnPuzzle1.Location = new Point(14, 218);
            if (btnPuzzle2.Left < btnSprawdz5.Left + a & btnPuzzle2.Top > btnSprawdz5.Top - a & btnPuzzle2.Bottom < btnTlo.Bottom)
                btnPuzzle2.Location = new Point(14, 218);
            if (btnPuzzle3.Left < btnSprawdz5.Left + a & btnPuzzle3.Top > btnSprawdz5.Top - a & btnPuzzle3.Bottom < btnTlo.Bottom)
                btnPuzzle3.Location = new Point(14, 218);
            if (btnPuzzle4.Left < btnSprawdz5.Left + a & btnPuzzle4.Top > btnSprawdz5.Top - a & btnPuzzle4.Bottom < btnTlo.Bottom)
                btnPuzzle4.Location = new Point(14, 218);
            if (btnPuzzle5.Left < btnSprawdz5.Left + a & btnPuzzle5.Top > btnSprawdz5.Top - a & btnPuzzle5.Bottom < btnTlo.Bottom)
                btnPuzzle5.Location = new Point(14, 218);
            if (btnPuzzle6.Left < btnSprawdz5.Left + a & btnPuzzle6.Top > btnSprawdz5.Top - a & btnPuzzle6.Bottom < btnTlo.Bottom)
                btnPuzzle6.Location = new Point(14, 218);
            if (btnPuzzle7.Left < btnSprawdz5.Left + a & btnPuzzle7.Top > btnSprawdz5.Top - a & btnPuzzle7.Bottom < btnTlo.Bottom)
                btnPuzzle7.Location = new Point(14, 218);
            if (btnPuzzle8.Left < btnSprawdz5.Left + a & btnPuzzle8.Top > btnSprawdz5.Top - a & btnPuzzle8.Bottom < btnTlo.Bottom)
                btnPuzzle8.Location = new Point(14, 218);
            #endregion
            #region Pole6
            if (btnPuzzle1.Left > btnSprawdz5.Right - a & btnPuzzle1.Left < btnSprawdz7.Left - c & btnPuzzle1.Top > btnSprawdz2.Bottom - a & btnPuzzle1.Bottom < btnTlo.Bottom)
                btnPuzzle1.Location = new Point(176, 218);
            if (btnPuzzle2.Left > btnSprawdz5.Right - a & btnPuzzle2.Left < btnSprawdz7.Left - c & btnPuzzle2.Top > btnSprawdz2.Bottom - a & btnPuzzle2.Bottom < btnTlo.Bottom)
                btnPuzzle2.Location = new Point(176, 218);
            if (btnPuzzle3.Left > btnSprawdz5.Right - a & btnPuzzle3.Left < btnSprawdz7.Left - c & btnPuzzle3.Top > btnSprawdz2.Bottom - a & btnPuzzle3.Bottom < btnTlo.Bottom)
                btnPuzzle3.Location = new Point(176, 218);
            if (btnPuzzle4.Left > btnSprawdz5.Right - a & btnPuzzle4.Left < btnSprawdz7.Left - c & btnPuzzle4.Top > btnSprawdz2.Bottom - a & btnPuzzle4.Bottom < btnTlo.Bottom)
                btnPuzzle4.Location = new Point(176, 218);
            if (btnPuzzle5.Left > btnSprawdz5.Right - a & btnPuzzle5.Left < btnSprawdz7.Left - c & btnPuzzle5.Top > btnSprawdz2.Bottom - a & btnPuzzle5.Bottom < btnTlo.Bottom)
                btnPuzzle5.Location = new Point(176, 218);
            if (btnPuzzle6.Left > btnSprawdz5.Right - a & btnPuzzle6.Left < btnSprawdz7.Left - c & btnPuzzle6.Top > btnSprawdz2.Bottom - a & btnPuzzle6.Bottom < btnTlo.Bottom)
                btnPuzzle6.Location = new Point(176, 218);
            if (btnPuzzle7.Left > btnSprawdz5.Right - a & btnPuzzle7.Left < btnSprawdz7.Left - c & btnPuzzle7.Top > btnSprawdz2.Bottom - a & btnPuzzle7.Bottom < btnTlo.Bottom)
                btnPuzzle7.Location = new Point(176, 218);
            if (btnPuzzle8.Left > btnSprawdz5.Right - a & btnPuzzle8.Left < btnSprawdz7.Left - c & btnPuzzle8.Top > btnSprawdz2.Bottom - a & btnPuzzle8.Bottom < btnTlo.Bottom)
                btnPuzzle8.Location = new Point(176, 218);
            #endregion
            #region Pole7
            if (btnPuzzle1.Left > btnSprawdz6.Right - a & btnPuzzle1.Left < btnSprawdz8.Left - c & btnPuzzle1.Top > btnSprawdz3.Bottom - a & btnPuzzle1.Bottom < btnTlo.Bottom)
                btnPuzzle1.Location = new Point(338, 218);
            if (btnPuzzle2.Left > btnSprawdz6.Right - a & btnPuzzle2.Left < btnSprawdz8.Left - c & btnPuzzle2.Top > btnSprawdz3.Bottom - a & btnPuzzle2.Bottom < btnTlo.Bottom)
                btnPuzzle2.Location = new Point(338, 218);
            if (btnPuzzle3.Left > btnSprawdz6.Right - a & btnPuzzle3.Left < btnSprawdz8.Left - c & btnPuzzle3.Top > btnSprawdz3.Bottom - a & btnPuzzle3.Bottom < btnTlo.Bottom)
                btnPuzzle3.Location = new Point(338, 218);
            if (btnPuzzle4.Left > btnSprawdz6.Right - a & btnPuzzle4.Left < btnSprawdz8.Left - c & btnPuzzle4.Top > btnSprawdz3.Bottom - a & btnPuzzle4.Bottom < btnTlo.Bottom)
                btnPuzzle4.Location = new Point(338, 218);
            if (btnPuzzle5.Left > btnSprawdz6.Right - a & btnPuzzle5.Left < btnSprawdz8.Left - c & btnPuzzle5.Top > btnSprawdz3.Bottom - a & btnPuzzle5.Bottom < btnTlo.Bottom)
                btnPuzzle5.Location = new Point(338, 218);
            if (btnPuzzle6.Left > btnSprawdz6.Right - a & btnPuzzle6.Left < btnSprawdz8.Left - c & btnPuzzle6.Top > btnSprawdz3.Bottom - a & btnPuzzle6.Bottom < btnTlo.Bottom)
                btnPuzzle6.Location = new Point(338, 218);
            if (btnPuzzle7.Left > btnSprawdz6.Right - a & btnPuzzle7.Left < btnSprawdz8.Left - c & btnPuzzle7.Top > btnSprawdz3.Bottom - a & btnPuzzle7.Bottom < btnTlo.Bottom)
                btnPuzzle7.Location = new Point(338, 218);
            if (btnPuzzle8.Left > btnSprawdz6.Right - a & btnPuzzle8.Left < btnSprawdz8.Left - c & btnPuzzle8.Top > btnSprawdz3.Bottom - a & btnPuzzle8.Bottom < btnTlo.Bottom)
                btnPuzzle8.Location = new Point(338, 218);
            #endregion
            #region Pole6
            if (btnPuzzle1.Left < btnSprawdz8.Right - c & btnPuzzle1.Left > btnSprawdz7.Right - a & btnPuzzle1.Top > btnSprawdz4.Bottom - a & btnPuzzle1.Bottom < btnTlo.Bottom)
                btnPuzzle1.Location = new Point(500, 218);
            if (btnPuzzle2.Left < btnSprawdz8.Right - c & btnPuzzle2.Left > btnSprawdz7.Right - a & btnPuzzle2.Top > btnSprawdz4.Bottom - a & btnPuzzle2.Bottom < btnTlo.Bottom)
                btnPuzzle2.Location = new Point(500, 218);
            if (btnPuzzle3.Left < btnSprawdz8.Right - c & btnPuzzle3.Left > btnSprawdz7.Right - a & btnPuzzle3.Top > btnSprawdz4.Bottom - a & btnPuzzle3.Bottom < btnTlo.Bottom)
                btnPuzzle3.Location = new Point(500, 218);
            if (btnPuzzle4.Left < btnSprawdz8.Right - c & btnPuzzle4.Left > btnSprawdz7.Right - a & btnPuzzle4.Top > btnSprawdz4.Bottom - a & btnPuzzle4.Bottom < btnTlo.Bottom)
                btnPuzzle4.Location = new Point(500, 218);
            if (btnPuzzle5.Left < btnSprawdz8.Right - c & btnPuzzle5.Left > btnSprawdz7.Right - a & btnPuzzle5.Top > btnSprawdz4.Bottom - a & btnPuzzle5.Bottom < btnTlo.Bottom)
                btnPuzzle5.Location = new Point(500, 218);
            if (btnPuzzle6.Left < btnSprawdz8.Right - c & btnPuzzle6.Left > btnSprawdz7.Right - a & btnPuzzle6.Top > btnSprawdz4.Bottom - a & btnPuzzle6.Bottom < btnTlo.Bottom)
                btnPuzzle6.Location = new Point(500, 218);
            if (btnPuzzle7.Left < btnSprawdz8.Right - c & btnPuzzle7.Left > btnSprawdz7.Right - a & btnPuzzle7.Top > btnSprawdz4.Bottom - a & btnPuzzle7.Bottom < btnTlo.Bottom)
                btnPuzzle7.Location = new Point(500, 218);
            if (btnPuzzle8.Left < btnSprawdz8.Right - c & btnPuzzle8.Left > btnSprawdz7.Right - a & btnPuzzle8.Top > btnSprawdz4.Bottom - a & btnPuzzle8.Bottom < btnTlo.Bottom)
                btnPuzzle8.Location = new Point(500, 218);
            #endregion
        }
        #endregion
        /*
        private void btnZaslona1_Click(object sender, EventArgs e)
        {

        }
        */ //Poprzedni kod

        private void btnPuzzle1_Click(object sender, EventArgs e)
        {

        }
        /*
        private void btnZaslona1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                Button b1 = sender as Button;
                b1.Tag = e.Location;
            }
            chwycenie(sender, e);
            btnPuzzle1.BackgroundImage = Projekt_Grafika.Properties.Resources._1_1;
        }

        private void btnZaslona1_MouseMove(object sender, MouseEventArgs e)
        {
            przesuniecie(sender, e);
            btnPuzzle1.BackgroundImage = null;
        }
        */ //Poprzedni kod
        private void btnPuzzle1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                Button b1 = sender as Button;
                b1.Tag = e.Location;
            }
            chwycenie(sender, e);
            btnPuzzle1.BackgroundImage = null;
        }

        private void btnPuzzle1_MouseMove(object sender, MouseEventArgs e)
        {
            przesuniecie(sender, e);
            wciagniecie(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m = m + 1;
            if (btnPuzzle1.Location == btnOdkryj.Location)
            {
                btnPuzzle1.BackgroundImage = Projekt_Grafika.Properties.Resources._1_1;
            }
            if (btnPuzzle2.Location == btnOdkryj.Location)
            {
                btnPuzzle2.BackgroundImage = Projekt_Grafika.Properties.Resources._2_1;
            }
            if (btnPuzzle3.Location == btnOdkryj.Location)
            {
                btnPuzzle3.BackgroundImage = Projekt_Grafika.Properties.Resources._3_1;
            }
            if (btnPuzzle4.Location == btnOdkryj.Location)
            {
                btnPuzzle4.BackgroundImage = Projekt_Grafika.Properties.Resources._4_1;
            }
            if (btnPuzzle5.Location == btnOdkryj.Location)
            {
                btnPuzzle5.BackgroundImage = Projekt_Grafika.Properties.Resources._1_2;
            }
            if (btnPuzzle6.Location == btnOdkryj.Location)
            {
                btnPuzzle6.BackgroundImage = Projekt_Grafika.Properties.Resources._2_2;
            }
            if (btnPuzzle7.Location == btnOdkryj.Location)
            {
                btnPuzzle7.BackgroundImage = Projekt_Grafika.Properties.Resources._3_2;
            }
            if (btnPuzzle8.Location == btnOdkryj.Location)
            {
                btnPuzzle8.BackgroundImage = Projekt_Grafika.Properties.Resources._4_2;
            }
        }

        private void btnPuzzle2_Click(object sender, EventArgs e)
        {

        }

        private void btnPuzzle2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                Button b2 = sender as Button;
                b2.Tag = e.Location;
            }
            chwycenie(sender, e);
            btnPuzzle2.BackgroundImage = null;
        }

        private void btnPuzzle2_MouseMove(object sender, MouseEventArgs e)
        {
            przesuniecie(sender, e);
            wciagniecie(sender, e);
        }

        private void btnPuzzle3_Click(object sender, EventArgs e)
        {

        }

        private void btnPuzzle3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                Button b3 = sender as Button;
                b3.Tag = e.Location;
            }
            chwycenie(sender, e);
            btnPuzzle3.BackgroundImage = null;
        }

        private void btnPuzzle3_MouseMove(object sender, MouseEventArgs e)
        {
            przesuniecie(sender, e);
            wciagniecie(sender, e);
        }

        private void btnPuzzle4_Click(object sender, EventArgs e)
        {

        }

        private void btnPuzzle4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                Button b4 = sender as Button;
                b4.Tag = e.Location;
            }
            chwycenie(sender, e);
            btnPuzzle4.BackgroundImage = null;
        }

        private void btnPuzzle4_MouseMove(object sender, MouseEventArgs e)
        {
            przesuniecie(sender, e);
            wciagniecie(sender, e);
        }

        private void btnPuzzle5_Click(object sender, EventArgs e)
        {

        }

        private void btnPuzzle5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                Button b5 = sender as Button;
                b5.Tag = e.Location;
            }
            chwycenie(sender, e);
            btnPuzzle5.BackgroundImage = null;
        }

        private void btnPuzzle5_MouseMove(object sender, MouseEventArgs e)
        {
            przesuniecie(sender, e);
            wciagniecie(sender, e);
        }

        private void btnPuzzle6_Click(object sender, EventArgs e)
        {

        }

        private void btnPuzzle6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                Button b6 = sender as Button;
                b6.Tag = e.Location;
            }
            chwycenie(sender, e);
            btnPuzzle6.BackgroundImage = null;
        }

        private void btnPuzzle6_MouseMove(object sender, MouseEventArgs e)
        {
            przesuniecie(sender, e);
            wciagniecie(sender, e);
        }

        private void btnPuzzle7_Click(object sender, EventArgs e)
        {

        }

        private void btnPuzzle7_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                Button b7 = sender as Button;
                b7.Tag = e.Location;
            }
            chwycenie(sender, e);
            btnPuzzle7.BackgroundImage = null;
        }

        private void btnPuzzle7_MouseMove(object sender, MouseEventArgs e)
        {
            przesuniecie(sender, e);
            wciagniecie(sender, e);
        }

        private void btnPuzzle8_Click(object sender, EventArgs e)
        {

        }

        private void btnPuzzle8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                Button b8 = sender as Button;
                b8.Tag = e.Location;
            }
            chwycenie(sender, e);
            btnPuzzle8.BackgroundImage = null;
        }

        private void btnPuzzle8_MouseMove(object sender, MouseEventArgs e)
        {
            przesuniecie(sender, e);
            wciagniecie(sender, e);
        }

        public void SprawdzLokalizacje()
        {
            if (btnPuzzle1.Location == btnSprawdz1.Location & btnPuzzle2.Location == btnSprawdz2.Location & btnPuzzle3.Location == btnSprawdz3.Location &
               btnPuzzle4.Location == btnSprawdz4.Location & btnPuzzle5.Location == btnSprawdz5.Location & btnPuzzle6.Location == btnSprawdz6.Location &
               btnPuzzle7.Location == btnSprawdz7.Location & btnPuzzle8.Location == btnSprawdz8.Location)
            {
                t.Stop();
                MessageBox.Show("Wygrałeś");
                picObrazek.Visible = true;
                btnSpawdz2.Visible = false;
                lblGratuluje.Visible = true;
                txtImie.Visible = true;
                btnZapisz.Visible = true;
            }
            else
            {
                MessageBox.Show("Gra wymaga dużej precyzji, sprawdź jeszcze raz wszystkie puzzle. Powodzenia!", "Uwaga!");
                s = s + 5;
            }
            string Wynik = txtWynik.Text;
            //string imie = txtImie.Text;

        }

        private void btnSpawdz2_Click(object sender, EventArgs e)
        {
            SprawdzLokalizacje();
        }

        private void btnOdkryjWszystkie_Click(object sender, EventArgs e)
        {
            m = m + 5;
            btnPuzzle1.BackgroundImage = Projekt_Grafika.Properties.Resources._1_1;
            btnPuzzle2.BackgroundImage = Projekt_Grafika.Properties.Resources._2_1;
            btnPuzzle3.BackgroundImage = Projekt_Grafika.Properties.Resources._3_1;
            btnPuzzle4.BackgroundImage = Projekt_Grafika.Properties.Resources._4_1;
            btnPuzzle5.BackgroundImage = Projekt_Grafika.Properties.Resources._1_2;
            btnPuzzle6.BackgroundImage = Projekt_Grafika.Properties.Resources._2_2;
            btnPuzzle7.BackgroundImage = Projekt_Grafika.Properties.Resources._3_2;
            btnPuzzle8.BackgroundImage = Projekt_Grafika.Properties.Resources._4_2;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlCon = new SqlConnection(connectionString))
            {
                SqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("UserADD", SqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Imie", txtImie.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Czas", txtWynik.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Zostałeś dodany do rankingu");
                btnZapisz.Visible=false;
            }
        }

        private void txtImie_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            t.Close();
            this.Close();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zamknąć program?", "Potwierdź decyzję", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close(); 
                t.Close();
        }
    }
}
