using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolko_i_krzyzyk
{
    public partial class Form1 : Form
    {
        private bool ruch;
        private int ruchIlosc = 0;

        private void sprawdz()
        {
            bool znalezionoZwyciezce = false;

            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && a1.Text != "")
                znalezionoZwyciezce = true;
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && b1.Text != "")
                znalezionoZwyciezce = true;
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && c1.Text != "")
                znalezionoZwyciezce = true;

            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && b1.Text != "")
                znalezionoZwyciezce = true;
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && b2.Text != "")
                znalezionoZwyciezce = true;
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && b3.Text != "")
                znalezionoZwyciezce = true;

            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && a1.Text != "")
                znalezionoZwyciezce = true;
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && b2.Text != "")
                znalezionoZwyciezce = true;

            if (znalezionoZwyciezce)
            {
                string zwyciezca = "";
                if (ruch)
                    zwyciezca = "O";
                else
                    zwyciezca = "X";
                MessageBox.Show("Zwycięzcą jest " + zwyciezca + "! Kliknij OK aby wyczyścić planszę.");
            }
            else if (ruchIlosc == 9)
            {
                MessageBox.Show("Jest remis! Kliknij OK aby wyczyścić planszę.");
            }
            
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void a1_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            if (ruch == true)
                przycisk.Text = "X";
            else
                przycisk.Text = "O";

            ruch = !ruch;
            ruchIlosc++;
            przycisk.Enabled = false;
            sprawdz();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            if (ruch == true)
                przycisk.Text = "X";
            else
                przycisk.Text = "O";

            ruch = !ruch;
            ruchIlosc++;
            przycisk.Enabled = false;
            sprawdz();
        }

        private void c1_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            if (ruch == true)
                przycisk.Text = "X";
            else
                przycisk.Text = "O";

            ruch = !ruch;
            ruchIlosc++;
            przycisk.Enabled = false;
            sprawdz();
        }

        private void a2_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            if (ruch == true)
                przycisk.Text = "X";
            else
                przycisk.Text = "O";

            ruch = !ruch;
            ruchIlosc++;
            przycisk.Enabled = false;
            sprawdz();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            if (ruch == true)
                przycisk.Text = "X";
            else
                przycisk.Text = "O";

            ruch = !ruch;
            ruchIlosc++;
            przycisk.Enabled = false;
            sprawdz();
        }

        private void c2_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            if (ruch == true)
                przycisk.Text = "X";
            else
                przycisk.Text = "O";

            ruch = !ruch;
            ruchIlosc++;
            przycisk.Enabled = false;
            sprawdz();
        }

        private void a3_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            if (ruch == true)
                przycisk.Text = "X";
            else
                przycisk.Text = "O";

            ruch = !ruch;
            ruchIlosc++;
            przycisk.Enabled = false;
            sprawdz();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            if (ruch == true)
                przycisk.Text = "X";
            else
                przycisk.Text = "O";

            ruch = !ruch;
            ruchIlosc++;
            przycisk.Enabled = false;
            sprawdz();
        }

        private void c3_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            if (ruch == true)
                przycisk.Text = "X";
            else
                przycisk.Text = "O";

            ruch = !ruch;
            ruchIlosc++;
            przycisk.Enabled = false;
            sprawdz();
        }

        private void wyczysc_Click(object sender, EventArgs e)
        {
            czysc();
        }
        private void czysc()
        {
            foreach (Control przycisk in Controls.OfType<Button>())
            {
                przycisk.Enabled = true;
                przycisk.Text = "";
            }

            ruchIlosc = 0;
            ruch = true;

            wyczysc.Text = "Wyczyść";
        }
    }
}
