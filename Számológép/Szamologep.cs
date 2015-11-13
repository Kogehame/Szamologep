using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Számológép
{
    public partial class Szamologep : Form
    {
        int osszeg = 0;
        string muvelet = "0";
        int db = 0;
        public Szamologep()
        {
            InitializeComponent();
            kimenet.Text = Convert.ToString(osszeg);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gomb1_Click(object sender, EventArgs e)
        {
            if (db==0)
            {
                muvelet = gomb1.Text;
            }
            db = db + 1;
        }

        private void gomb2_Click(object sender, EventArgs e)
        {
            if (db == 0)
            {
                muvelet = gomb2.Text;
            }
            db = db + 1;
        }

        private void gomb3_Click(object sender, EventArgs e)
        {
            if (db == 0)
            {
                muvelet = gomb3.Text;
            }
            db = db + 1;
        }

        private void gomb4_Click(object sender, EventArgs e)
        {
            if (db == 0)
            {
                muvelet = gomb4.Text;
            }
            db = db + 1;
        }

        private void gomb5_Click(object sender, EventArgs e)
        {
            if (db == 0)
            {
                muvelet = gomb5.Text;
            }
            db = db + 1;
        }

        private void gomb6_Click(object sender, EventArgs e)
        {
            if (db == 0)
            {
                muvelet = gomb6.Text;
            }
            db = db + 1;
        }

        private void gomb7_Click(object sender, EventArgs e)
        {
            if (db == 0)
            {
                muvelet = gomb7.Text;
            }
            db = db + 1;
        }

        private void gomb8_Click(object sender, EventArgs e)
        {
            if (db == 0)
            {
                muvelet = gomb8.Text;
            }
            db = db + 1;
        }

        private void gomb9_Click(object sender, EventArgs e)
        {
            if (db == 0)
            {
                muvelet = gomb9.Text;
            }
            db = db + 1;
        }

        private void gomb0_Click(object sender, EventArgs e)
        {
            if (db == 0)
            {
                muvelet = gomb0.Text;
            }
            db = db + 1;
        }

        private void vesszo_Click(object sender, EventArgs e)
        {
            if (db == 0)
            {
                muvelet = muvelet + vesszo.Text;
            }
            db = db + 1;
        }
    }
}
