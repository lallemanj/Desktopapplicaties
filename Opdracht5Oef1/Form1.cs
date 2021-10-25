using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht5Oef1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbTekst.Text == string.Empty)
            {
                MessageBox.Show("Geen tekst ingevuld");
               
            } else
            {
                tbTekst.ForeColor = Color.Red;
            }
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbTekst.Text == string.Empty)
            {
                MessageBox.Show("Geen tekst ingevuld");

            }
            else
            {
                tbTekst.ForeColor = Color.Green;
            }
        }

        private void blueCTRLBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbTekst.Text == string.Empty)
            {
                MessageBox.Show("Geen tekst ingevuld");

            }
            else
            {
                tbTekst.ForeColor = Color.Blue;
            }
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbTekst.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbTekst.BackColor = Color.Green;

        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbTekst.BackColor = Color.Blue;

        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbTekst.Font = new Font("Segoe", 6, FontStyle.Bold);
        }

        private void normalCTRLNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbTekst.Font = new Font("Segoe", 9, FontStyle.Bold);

        }

        private void largeCTRLLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbTekst.Font = new Font("Arial", 15, FontStyle.Bold);

        }
    }
}
