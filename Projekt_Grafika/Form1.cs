using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Projekt_Grafika
{
    public partial class Form1 : Form
    {
        #region BazaDanych i Timer
        string connectionString = @"Persist Security Info=False;Integrated Security = true; Initial Catalog = Ranking; server=DESKTOP-NN6FPVO";
        System.Timers.Timer t;
        int h, m, s;
        public Form1()
        {
            InitializeComponent();
            //if (MessageBox.Show("Po zatwierdzeniu komunikatu gra się rozpocznie i zacznie mierzyć czas. Czy jesteś gotowy na rozpoczęcie gry?", "Rozpoczęcie gry", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
                t = new System.Timers.Timer();
                t.Interval = 1000;
                t.Elapsed += OnTimeEvent;
                t.Start();

           // }
/*            else
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
                this.Close();

            }*/
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
        #endregion
        #region ruch
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
            int a = 15, /*b = 50*/ c = 135;
            #region Pole1
            if (cmdPrzycisk1.Left - a < sprBtn1.Left & cmdPrzycisk1.Top - a < sprBtn1.Top)
                cmdPrzycisk1.Location = new Point(183, 54);
            if (cmdPrzycisk2.Left - a < sprBtn1.Left & cmdPrzycisk2.Top - a < sprBtn1.Top)
                cmdPrzycisk2.Location = new Point(183, 54);
            if (cmdPrzycisk3.Left - a < sprBtn1.Left & cmdPrzycisk3.Top - a < sprBtn1.Top)
                cmdPrzycisk3.Location = new Point(183, 54);
            if (cmdPrzycisk4.Left - a < sprBtn1.Left & cmdPrzycisk4.Top - a < sprBtn1.Top)
                cmdPrzycisk4.Location = new Point(183, 54);
            if (cmdPrzycisk5.Left - a < sprBtn1.Left & cmdPrzycisk5.Top - a < sprBtn1.Top)
                cmdPrzycisk5.Location = new Point(183, 54);
            if (cmdPrzycisk6.Left - a < sprBtn1.Left & cmdPrzycisk6.Top - a < sprBtn1.Top)
                cmdPrzycisk6.Location = new Point(183, 54);
            if (cmdPrzycisk7.Left - a < sprBtn1.Left & cmdPrzycisk7.Top - a < sprBtn1.Top)
                cmdPrzycisk7.Location = new Point(183, 54);
            if (cmdPrzycisk8.Left - a < sprBtn1.Left & cmdPrzycisk8.Top - a < sprBtn1.Top)
                cmdPrzycisk8.Location = new Point(183, 54);
            if (cmdPrzycisk9.Left - a < sprBtn1.Left & cmdPrzycisk9.Top - a < sprBtn1.Top)
                cmdPrzycisk9.Location = new Point(183, 54);
            #endregion
            #region Pole2
            if (cmdPrzycisk1.Left > sprBtn1.Right - a & cmdPrzycisk1.Left < sprBtn3.Left - c & cmdPrzycisk1.Bottom < sprBtn5.Top + a)
                cmdPrzycisk1.Location = new Point(347, 54);
            if (cmdPrzycisk2.Left > sprBtn1.Right - a & cmdPrzycisk2.Left < sprBtn3.Left - c & cmdPrzycisk2.Bottom < sprBtn5.Top + a)
                cmdPrzycisk2.Location = new Point(347, 54);
            if (cmdPrzycisk3.Left > sprBtn1.Right - a & cmdPrzycisk3.Left < sprBtn3.Left - c & cmdPrzycisk3.Bottom < sprBtn5.Top + a)
                cmdPrzycisk3.Location = new Point(347, 54);
            if (cmdPrzycisk4.Left > sprBtn1.Right - a & cmdPrzycisk4.Left < sprBtn3.Left - c & cmdPrzycisk4.Bottom < sprBtn5.Top + a)
                cmdPrzycisk4.Location = new Point(347, 54);
            if (cmdPrzycisk5.Left > sprBtn1.Right - a & cmdPrzycisk5.Left < sprBtn3.Left - c & cmdPrzycisk5.Bottom < sprBtn5.Top + a)
                cmdPrzycisk5.Location = new Point(347, 54);
            if (cmdPrzycisk6.Left > sprBtn1.Right - a & cmdPrzycisk6.Left < sprBtn3.Left - c & cmdPrzycisk6.Bottom < sprBtn5.Top + a)
                cmdPrzycisk6.Location = new Point(347, 54);
            if (cmdPrzycisk7.Left > sprBtn1.Right - a & cmdPrzycisk7.Left < sprBtn3.Left - c & cmdPrzycisk7.Bottom < sprBtn5.Top + a)
                cmdPrzycisk7.Location = new Point(347, 54);
            if (cmdPrzycisk8.Left > sprBtn1.Right - a & cmdPrzycisk8.Left < sprBtn3.Left - c & cmdPrzycisk8.Bottom < sprBtn5.Top + a)
                cmdPrzycisk8.Location = new Point(347, 54);
            if (cmdPrzycisk9.Left > sprBtn1.Right - a & cmdPrzycisk9.Left < sprBtn3.Left - c & cmdPrzycisk9.Bottom < sprBtn5.Top + a)
                cmdPrzycisk9.Location = new Point(347, 54);

            #endregion
            #region Pole3
            if (cmdPrzycisk1.Left < sprBtn3.Right - c & cmdPrzycisk1.Left > sprBtn2.Right - a & cmdPrzycisk1.Bottom < sprBtn6.Top + a)
                cmdPrzycisk1.Location = new Point(511, 54);
            if (cmdPrzycisk2.Left < sprBtn3.Right - c & cmdPrzycisk2.Left > sprBtn2.Right - a & cmdPrzycisk2.Bottom < sprBtn6.Top + a)
                cmdPrzycisk2.Location = new Point(511, 54);
            if (cmdPrzycisk3.Left < sprBtn3.Right - c & cmdPrzycisk3.Left > sprBtn2.Right - a & cmdPrzycisk3.Bottom < sprBtn6.Top + a)
                cmdPrzycisk3.Location = new Point(511, 54);
            if (cmdPrzycisk4.Left < sprBtn3.Right - c & cmdPrzycisk4.Left > sprBtn2.Right - a & cmdPrzycisk4.Bottom < sprBtn6.Top + a)
                cmdPrzycisk4.Location = new Point(511, 54);
            if (cmdPrzycisk5.Left < sprBtn3.Right - c & cmdPrzycisk5.Left > sprBtn2.Right - a & cmdPrzycisk5.Bottom < sprBtn6.Top + a)
                cmdPrzycisk5.Location = new Point(511, 54);
            if (cmdPrzycisk6.Left < sprBtn3.Right - c & cmdPrzycisk6.Left > sprBtn2.Right - a & cmdPrzycisk6.Bottom < sprBtn6.Top + a)
                cmdPrzycisk6.Location = new Point(511, 54);
            if (cmdPrzycisk7.Left < sprBtn3.Right - c & cmdPrzycisk7.Left > sprBtn2.Right - a & cmdPrzycisk7.Bottom < sprBtn6.Top + a)
                cmdPrzycisk7.Location = new Point(511, 54);
            if (cmdPrzycisk8.Left < sprBtn3.Right - c & cmdPrzycisk8.Left > sprBtn2.Right - a & cmdPrzycisk8.Bottom < sprBtn6.Top + a)
                cmdPrzycisk8.Location = new Point(511, 54);
            if (cmdPrzycisk9.Left < sprBtn3.Right - c & cmdPrzycisk9.Left > sprBtn2.Right - a & cmdPrzycisk9.Bottom < sprBtn6.Top + a)
                cmdPrzycisk9.Location = new Point(511, 54);
            #endregion
            #region Pole4
            if (cmdPrzycisk1.Left < sprBtn4.Left + a & cmdPrzycisk1.Top > sprBtn4.Top - a & cmdPrzycisk1.Bottom < sprBtn7.Top)
                cmdPrzycisk1.Location = new Point(183, 206);
            if (cmdPrzycisk2.Left < sprBtn4.Left + a & cmdPrzycisk2.Top > sprBtn4.Top - a & cmdPrzycisk2.Bottom < sprBtn7.Top)
                cmdPrzycisk2.Location = new Point(183, 206);
            if (cmdPrzycisk3.Left < sprBtn4.Left + a & cmdPrzycisk3.Top > sprBtn4.Top - a & cmdPrzycisk3.Bottom < sprBtn7.Top)
                cmdPrzycisk3.Location = new Point(183, 206);
            if (cmdPrzycisk4.Left < sprBtn4.Left + a & cmdPrzycisk4.Top > sprBtn4.Top - a & cmdPrzycisk4.Bottom < sprBtn7.Top)
                cmdPrzycisk4.Location = new Point(183, 206);
            if (cmdPrzycisk5.Left < sprBtn4.Left + a & cmdPrzycisk5.Top > sprBtn4.Top - a & cmdPrzycisk5.Bottom < sprBtn7.Top)
                cmdPrzycisk5.Location = new Point(183, 206);
            if (cmdPrzycisk6.Left < sprBtn4.Left + a & cmdPrzycisk6.Top > sprBtn4.Top - a & cmdPrzycisk6.Bottom < sprBtn7.Top)
                cmdPrzycisk6.Location = new Point(183, 206);
            if (cmdPrzycisk7.Left < sprBtn4.Left + a & cmdPrzycisk7.Top > sprBtn4.Top - a & cmdPrzycisk7.Bottom < sprBtn7.Top)
                cmdPrzycisk7.Location = new Point(183, 206);
            if (cmdPrzycisk8.Left < sprBtn4.Left + a & cmdPrzycisk8.Top > sprBtn4.Top - a & cmdPrzycisk8.Bottom < sprBtn7.Top)
                cmdPrzycisk8.Location = new Point(183, 206);
            if (cmdPrzycisk9.Left < sprBtn4.Left + a & cmdPrzycisk9.Top > sprBtn4.Top - a & cmdPrzycisk9.Bottom < sprBtn7.Top)
                cmdPrzycisk9.Location = new Point(183, 206);
            #endregion
            #region Pole5
            if (cmdPrzycisk1.Left > sprBtn4.Right - a & cmdPrzycisk1.Left < sprBtn6.Left - c & cmdPrzycisk1.Top > sprBtn2.Bottom - a & cmdPrzycisk1.Bottom < sprBtn8.Top + a)
                cmdPrzycisk1.Location = new Point(347, 206);
            if (cmdPrzycisk2.Left > sprBtn4.Right - a & cmdPrzycisk2.Left < sprBtn6.Left - c & cmdPrzycisk2.Top > sprBtn2.Bottom - a & cmdPrzycisk2.Bottom < sprBtn8.Top + a)
                cmdPrzycisk2.Location = new Point(347, 206);
            if (cmdPrzycisk3.Left > sprBtn4.Right - a & cmdPrzycisk3.Left < sprBtn6.Left - c & cmdPrzycisk3.Top > sprBtn2.Bottom - a & cmdPrzycisk3.Bottom < sprBtn8.Top + a)
                cmdPrzycisk3.Location = new Point(347, 206);
            if (cmdPrzycisk4.Left > sprBtn4.Right - a & cmdPrzycisk4.Left < sprBtn6.Left - c & cmdPrzycisk4.Top > sprBtn2.Bottom - a & cmdPrzycisk4.Bottom < sprBtn8.Top + a)
                cmdPrzycisk4.Location = new Point(347, 206);
            if (cmdPrzycisk5.Left > sprBtn4.Right - a & cmdPrzycisk5.Left < sprBtn6.Left - c & cmdPrzycisk5.Top > sprBtn2.Bottom - a & cmdPrzycisk5.Bottom < sprBtn8.Top + a)
                cmdPrzycisk5.Location = new Point(347, 206);
            if (cmdPrzycisk6.Left > sprBtn4.Right - a & cmdPrzycisk6.Left < sprBtn6.Left - c & cmdPrzycisk6.Top > sprBtn2.Bottom - a & cmdPrzycisk6.Bottom < sprBtn8.Top + a)
                cmdPrzycisk6.Location = new Point(347, 206);
            if (cmdPrzycisk7.Left > sprBtn4.Right - a & cmdPrzycisk7.Left < sprBtn6.Left - c & cmdPrzycisk7.Top > sprBtn2.Bottom - a & cmdPrzycisk7.Bottom < sprBtn8.Top + a)
                cmdPrzycisk7.Location = new Point(347, 206);
            if (cmdPrzycisk8.Left > sprBtn4.Right - a & cmdPrzycisk8.Left < sprBtn6.Left - c & cmdPrzycisk8.Top > sprBtn2.Bottom - a & cmdPrzycisk8.Bottom < sprBtn8.Top + a)
                cmdPrzycisk8.Location = new Point(347, 206);
            if (cmdPrzycisk9.Left > sprBtn4.Right - a & cmdPrzycisk9.Left < sprBtn6.Left - c & cmdPrzycisk9.Top > sprBtn2.Bottom - a & cmdPrzycisk9.Bottom < sprBtn8.Top + a)
                cmdPrzycisk9.Location = new Point(347, 206);
            #endregion
            #region Pole6
            if (cmdPrzycisk1.Left < sprBtn6.Right - c & cmdPrzycisk1.Left > sprBtn5.Right - a & cmdPrzycisk1.Top > sprBtn3.Bottom - a & cmdPrzycisk1.Bottom < sprBtn9.Top + a)
                cmdPrzycisk1.Location = new Point(511, 206);
            if (cmdPrzycisk2.Left < sprBtn6.Right - c & cmdPrzycisk2.Left > sprBtn5.Right - a & cmdPrzycisk2.Top > sprBtn3.Bottom - a & cmdPrzycisk2.Bottom < sprBtn9.Top + a)
                cmdPrzycisk2.Location = new Point(511, 206);
            if (cmdPrzycisk3.Left < sprBtn6.Right - c & cmdPrzycisk3.Left > sprBtn5.Right - a & cmdPrzycisk3.Top > sprBtn3.Bottom - a & cmdPrzycisk3.Bottom < sprBtn9.Top + a)
                cmdPrzycisk3.Location = new Point(511, 206);
            if (cmdPrzycisk4.Left < sprBtn6.Right - c & cmdPrzycisk4.Left > sprBtn5.Right - a & cmdPrzycisk4.Top > sprBtn3.Bottom - a & cmdPrzycisk4.Bottom < sprBtn9.Top + a)
                cmdPrzycisk4.Location = new Point(511, 206);
            if (cmdPrzycisk5.Left < sprBtn6.Right - c & cmdPrzycisk5.Left > sprBtn5.Right - a & cmdPrzycisk5.Top > sprBtn3.Bottom - a & cmdPrzycisk5.Bottom < sprBtn9.Top + a)
                cmdPrzycisk5.Location = new Point(511, 206);
            if (cmdPrzycisk6.Left < sprBtn6.Right - c & cmdPrzycisk6.Left > sprBtn5.Right - a & cmdPrzycisk6.Top > sprBtn3.Bottom - a & cmdPrzycisk6.Bottom < sprBtn9.Top + a)
                cmdPrzycisk6.Location = new Point(511, 206);
            if (cmdPrzycisk7.Left < sprBtn6.Right - c & cmdPrzycisk7.Left > sprBtn5.Right - a & cmdPrzycisk7.Top > sprBtn3.Bottom - a & cmdPrzycisk7.Bottom < sprBtn9.Top + a)
                cmdPrzycisk7.Location = new Point(511, 206);
            if (cmdPrzycisk8.Left < sprBtn6.Right - c & cmdPrzycisk8.Left > sprBtn5.Right - a & cmdPrzycisk8.Top > sprBtn3.Bottom - a & cmdPrzycisk8.Bottom < sprBtn9.Top + a)
                cmdPrzycisk8.Location = new Point(511, 206);
            if (cmdPrzycisk9.Left < sprBtn6.Right - c & cmdPrzycisk9.Left > sprBtn5.Right - a & cmdPrzycisk9.Top > sprBtn3.Bottom - a & cmdPrzycisk9.Bottom < sprBtn9.Top + a)
                cmdPrzycisk9.Location = new Point(511, 206);
            #endregion
            #region Pole7
            if (cmdPrzycisk1.Left < sprBtn7.Left + a & cmdPrzycisk1.Top > sprBtn4.Bottom - a)
                cmdPrzycisk1.Location = new Point(183, 358);
            if (cmdPrzycisk2.Left < sprBtn7.Left + a & cmdPrzycisk2.Top > sprBtn4.Bottom - a)
                cmdPrzycisk2.Location = new Point(183, 358);
            if (cmdPrzycisk3.Left < sprBtn7.Left + a & cmdPrzycisk3.Top > sprBtn4.Bottom - a)
                cmdPrzycisk3.Location = new Point(183, 358);
            if (cmdPrzycisk4.Left < sprBtn7.Left + a & cmdPrzycisk4.Top > sprBtn4.Bottom - a)
                cmdPrzycisk4.Location = new Point(183, 358);
            if (cmdPrzycisk5.Left < sprBtn7.Left + a & cmdPrzycisk5.Top > sprBtn4.Bottom - a)
                cmdPrzycisk5.Location = new Point(183, 358);
            if (cmdPrzycisk6.Left < sprBtn7.Left + a & cmdPrzycisk6.Top > sprBtn4.Bottom - a)
                cmdPrzycisk6.Location = new Point(183, 358);
            if (cmdPrzycisk7.Left < sprBtn7.Left + a & cmdPrzycisk7.Top > sprBtn4.Bottom - a)
                cmdPrzycisk7.Location = new Point(183, 358);
            if (cmdPrzycisk8.Left < sprBtn7.Left + a & cmdPrzycisk8.Top > sprBtn4.Bottom - a)
                cmdPrzycisk8.Location = new Point(183, 358);
            if (cmdPrzycisk9.Left < sprBtn7.Left + a & cmdPrzycisk9.Top > sprBtn4.Bottom - a)
                cmdPrzycisk9.Location = new Point(183, 358);
            #endregion
            #region Pole8
            if (cmdPrzycisk1.Left > sprBtn7.Right - a & cmdPrzycisk1.Left < sprBtn9.Left - c & cmdPrzycisk1.Top > sprBtn5.Bottom - a)
                cmdPrzycisk1.Location = new Point(347, 358);
            if (cmdPrzycisk2.Left > sprBtn7.Right - a & cmdPrzycisk2.Left < sprBtn9.Left - c & cmdPrzycisk2.Top > sprBtn5.Bottom - a)
                cmdPrzycisk2.Location = new Point(347, 358);
            if (cmdPrzycisk3.Left > sprBtn7.Right - a & cmdPrzycisk3.Left < sprBtn9.Left - c & cmdPrzycisk3.Top > sprBtn5.Bottom - a)
                cmdPrzycisk3.Location = new Point(347, 358);
            if (cmdPrzycisk4.Left > sprBtn7.Right - a & cmdPrzycisk4.Left < sprBtn9.Left - c & cmdPrzycisk4.Top > sprBtn5.Bottom - a)
                cmdPrzycisk4.Location = new Point(347, 358);
            if (cmdPrzycisk5.Left > sprBtn7.Right - a & cmdPrzycisk5.Left < sprBtn9.Left - c & cmdPrzycisk5.Top > sprBtn5.Bottom - a)
                cmdPrzycisk5.Location = new Point(347, 358);
            if (cmdPrzycisk6.Left > sprBtn7.Right - a & cmdPrzycisk6.Left < sprBtn9.Left - c & cmdPrzycisk6.Top > sprBtn5.Bottom - a)
                cmdPrzycisk6.Location = new Point(347, 358);
            if (cmdPrzycisk7.Left > sprBtn7.Right - a & cmdPrzycisk7.Left < sprBtn9.Left - c & cmdPrzycisk7.Top > sprBtn5.Bottom - a)
                cmdPrzycisk7.Location = new Point(347, 358);
            if (cmdPrzycisk8.Left > sprBtn7.Right - a & cmdPrzycisk8.Left < sprBtn9.Left - c & cmdPrzycisk8.Top > sprBtn5.Bottom - a)
                cmdPrzycisk8.Location = new Point(347, 358);
            if (cmdPrzycisk9.Left > sprBtn7.Right - a & cmdPrzycisk9.Left < sprBtn9.Left - c & cmdPrzycisk9.Top > sprBtn5.Bottom - a)
                cmdPrzycisk9.Location = new Point(347, 358);
            #endregion
            #region Pole9
            if (cmdPrzycisk1.Left < sprBtn9.Right - c & cmdPrzycisk1.Left > sprBtn8.Right - a & cmdPrzycisk1.Top > sprBtn6.Bottom - a)
                cmdPrzycisk1.Location = new Point(511, 358);
            if (cmdPrzycisk2.Left < sprBtn9.Right - c & cmdPrzycisk2.Left > sprBtn8.Right - a & cmdPrzycisk2.Top > sprBtn6.Bottom - a)
                cmdPrzycisk2.Location = new Point(511, 358);
            if (cmdPrzycisk3.Left < sprBtn9.Right - c & cmdPrzycisk3.Left > sprBtn8.Right - a & cmdPrzycisk3.Top > sprBtn6.Bottom - a)
                cmdPrzycisk3.Location = new Point(511, 358);
            if (cmdPrzycisk4.Left < sprBtn9.Right - c & cmdPrzycisk4.Left > sprBtn8.Right - a & cmdPrzycisk4.Top > sprBtn6.Bottom - a)
                cmdPrzycisk4.Location = new Point(511, 358);
            if (cmdPrzycisk5.Left < sprBtn9.Right - c & cmdPrzycisk5.Left > sprBtn8.Right - a & cmdPrzycisk5.Top > sprBtn6.Bottom - a)
                cmdPrzycisk5.Location = new Point(511, 358);
            if (cmdPrzycisk6.Left < sprBtn9.Right - c & cmdPrzycisk6.Left > sprBtn8.Right - a & cmdPrzycisk6.Top > sprBtn6.Bottom - a)
                cmdPrzycisk6.Location = new Point(511, 358);
            if (cmdPrzycisk7.Left < sprBtn9.Right - c & cmdPrzycisk7.Left > sprBtn8.Right - a & cmdPrzycisk7.Top > sprBtn6.Bottom - a)
                cmdPrzycisk7.Location = new Point(511, 358);
            if (cmdPrzycisk8.Left < sprBtn9.Right - c & cmdPrzycisk8.Left > sprBtn8.Right - a & cmdPrzycisk8.Top > sprBtn6.Bottom - a)
                cmdPrzycisk8.Location = new Point(511, 358);
            if (cmdPrzycisk9.Left < sprBtn9.Right - c & cmdPrzycisk9.Left > sprBtn8.Right - a & cmdPrzycisk9.Top > sprBtn6.Bottom - a)
                cmdPrzycisk9.Location = new Point(511, 358);
            #endregion
        }
        #endregion
        #region Click,MouseDown,MouseMove
        private void cmdPrzycisk1_Click(object sender, EventArgs e)
        {
                        
        }

        private void cmdPrzycisk1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                Button b1 = sender as Button;
                b1.Tag = e.Location;
            }
            chwycenie(sender, e);

        }

        private void cmdPrzycisk1_MouseMove(object sender, MouseEventArgs e)
        {
            przesuniecie(sender, e);
            wciagniecie(sender, e);
        }

        private void cmdPrzycisk2_Click(object sender, EventArgs e)
        {

        }

        private void cmdPrzycisk2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                Button b1 = sender as Button;
                b1.Tag = e.Location;
            }
            chwycenie(sender, e);
        }

        private void cmdPrzycisk2_MouseMove(object sender, MouseEventArgs e)
        {
            przesuniecie(sender, e);
            wciagniecie(sender, e);
        }

        private void cmdPrzycisk3_Click(object sender, EventArgs e)
        {

        }

        private void cmdPrzycisk3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                Button b1 = sender as Button;
                b1.Tag = e.Location;
            }
            chwycenie(sender, e);
        }

        private void cmdPrzycisk3_MouseMove(object sender, MouseEventArgs e)
        {
            przesuniecie(sender, e);
            wciagniecie(sender, e);
        }

        private void cmdPrzycisk4_Click(object sender, EventArgs e)
        {

        }

        private void cmdPrzycisk4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                Button b1 = sender as Button;
                b1.Tag = e.Location;
            }
            chwycenie(sender, e);
        }

        private void cmdPrzycisk4_MouseMove(object sender, MouseEventArgs e)
        {
            przesuniecie(sender, e);
            wciagniecie(sender, e);
        }

        private void cmdPrzycisk5_Click(object sender, EventArgs e)
        {

        }

        private void cmdPrzycisk5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                Button b1 = sender as Button;
                b1.Tag = e.Location;
            }
            chwycenie(sender, e);
        }

        private void cmdPrzycisk5_MouseMove(object sender, MouseEventArgs e)
        {
            przesuniecie(sender, e);
            wciagniecie(sender, e);
        }

        private void cmdPrzycisk6_Click(object sender, EventArgs e)
        {

        }

        private void cmdPrzycisk6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                Button b1 = sender as Button;
                b1.Tag = e.Location;
            }
            chwycenie(sender, e);
        }

        private void cmdPrzycisk6_MouseMove(object sender, MouseEventArgs e)
        {
            przesuniecie(sender, e);
            wciagniecie(sender, e);
        }

        private void cmdPrzycisk7_Click(object sender, EventArgs e)
        {

        }

        private void cmdPrzycisk7_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                Button b1 = sender as Button;
                b1.Tag = e.Location;
            }
            chwycenie(sender, e);
        }

        private void cmdPrzycisk7_MouseMove(object sender, MouseEventArgs e)
        {
            przesuniecie(sender, e);
            wciagniecie(sender, e);
        }

        private void cmdPrzycisk8_Click(object sender, EventArgs e)
        {

        }

        private void cmdPrzycisk8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                Button b1 = sender as Button;
                b1.Tag = e.Location;
            }
            chwycenie(sender, e);
        }

        private void cmdPrzycisk8_MouseMove(object sender, MouseEventArgs e)
        {
            przesuniecie(sender, e);
            wciagniecie(sender, e);
        }

        private void cmdPrzycisk9_Click(object sender, EventArgs e)
        {

        }

        private void cmdPrzycisk9_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                Button b1 = sender as Button;
                b1.Tag = e.Location;
                SprawdzLokalizacje();
            }
            chwycenie(sender, e);
        }

        private void cmdPrzycisk9_MouseMove(object sender, MouseEventArgs e)
        {
            przesuniecie(sender, e);
            wciagniecie(sender, e);
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlCon = new SqlConnection(connectionString))
            {
                SqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("WynikADD", SqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@imie", txtImie.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@czas", txtWynik.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Zostałeś dodany do rankingu");
                btnZapisz.Visible=false;
            }
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            t.Close();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            picGotowe.Visible = true;
            btnUkryj.Visible = true;
            s = s + 10;
        }

        private void btnUkryj_Click(object sender, EventArgs e)
        {
            picGotowe.Visible = false;
            btnUkryj.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zamknąć program?", "Potwierdź decyzję", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        public void SprawdzLokalizacje()
        {
            if(cmdPrzycisk1.Location == sprBtn1.Location & cmdPrzycisk2.Location == sprBtn2.Location & cmdPrzycisk3.Location == sprBtn3.Location &
               cmdPrzycisk4.Location == sprBtn4.Location & cmdPrzycisk5.Location == sprBtn5.Location & cmdPrzycisk6.Location == sprBtn6.Location &
               cmdPrzycisk7.Location == sprBtn7.Location & cmdPrzycisk8.Location == sprBtn8.Location & cmdPrzycisk9.Location == sprBtn9.Location)
            {
                t.Stop();
                MessageBox.Show("Wygrałeś");
                btnSprawdz.Visible=false;
                btnZapisz.Visible=true;
                txtImie.Visible=true;
                lblGratuluje.Visible=true;
                picGotowe.Visible=true;
            }
            else
            {
                MessageBox.Show("Gra wymaga dużej precyzji, sprawdź jeszcze raz wszystkie puzzle. Powodzenia!", "Uwaga!");
                s = s + 5;
            }
            string Wynik = txtWynik.Text;
            string imie = txtImie.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SprawdzLokalizacje();
        }
    }
}
