using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CranjeKvadrata_Domaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen olovka = new Pen(Color.Black, 1);

            float stranica = 50;

            g.DrawLine(olovka, e.X - stranica / 2, e.Y - stranica / 2, e.X + stranica / 2, e.Y - stranica / 2);
            g.DrawLine(olovka, e.X - stranica / 2, e.Y + stranica / 2, e.X + stranica / 2, e.Y + stranica / 2);

            g.DrawLine(olovka, e.X - stranica / 2, e.Y - stranica / 2, e.X + stranica / 2, e.Y + stranica / 2);
            g.DrawLine(olovka, e.X - stranica / 2, e.Y + stranica / 2, e.X + stranica / 2, e.Y - stranica / 2);

            g.DrawLine(olovka, e.X - stranica / 2, e.Y - stranica / 2, e.X - stranica / 2, e.Y + stranica / 2);
            g.DrawLine(olovka, e.X + stranica / 2, e.Y - stranica / 2, e.X + stranica / 2, e.Y + stranica / 2);
        }
    }
}
