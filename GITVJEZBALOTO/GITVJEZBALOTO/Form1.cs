using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITVJEZBALOTO
{
    public partial class Form1 : Form
    {
        Loto loto = new Loto();
        public Form1()
        {
            InitializeComponent();
            BtnOdigraj.Enabled = false;
        }

        private void BtnUplati_Click(object sender, EventArgs e)
        {
            bool ispravni = true;
            if (int.Parse(txtUplaceni1.Text) > 39 || int.Parse(txtUplaceni1.Text) < 1)
            {
                ispravni = false;
            }
            if (int.Parse(txtUplaceni2.Text) > 39 || int.Parse(txtUplaceni2.Text) < 1)
            {
                ispravni = false;
            }
            if (int.Parse(txtUplaceni3.Text) > 39 || int.Parse(txtUplaceni3.Text) < 1)
            {
                ispravni = false;
            }
            if (int.Parse(txtUplaceni4.Text) > 39 || int.Parse(txtUplaceni4.Text) < 1)
            {
                ispravni = false;
            }
            if (int.Parse(txtUplaceni5.Text) > 39 || int.Parse(txtUplaceni5.Text) < 1)
            {
                ispravni = false;
            }
            if (int.Parse(txtUplaceni6.Text) > 39 || int.Parse(txtUplaceni6.Text) < 1)
            {
                ispravni = false;
            }
            if (int.Parse(txtUplaceni7.Text) > 39 || int.Parse(txtUplaceni7.Text) < 1)
            {
                ispravni = false;
            }
            if (ispravni)
            {
                loto.SpremiUplaceneBrojeve(int.Parse(txtUplaceni1.Text), int.Parse(txtUplaceni2.Text), int.Parse(txtUplaceni3.Text), int.Parse(txtUplaceni4.Text), int.Parse(txtUplaceni5.Text), int.Parse(txtUplaceni6.Text), int.Parse(txtUplaceni7.Text));
                BtnOdigraj.Enabled = true;
            }
            else
            {
                MessageBox.Show("Doslo je do greske, pokusajte ponovo.");
            }
        }

        private void BtnOdigraj_Click(object sender, EventArgs e)
        {
            txtDobitni1.Text = loto.DobitniBrojevi[0].ToString();
            txtDobitni2.Text = loto.DobitniBrojevi[1].ToString();
            txtDobitni3.Text = loto.DobitniBrojevi[2].ToString();
            txtDobitni4.Text = loto.DobitniBrojevi[3].ToString();
            txtDobitni5.Text = loto.DobitniBrojevi[4].ToString();
            txtDobitni6.Text = loto.DobitniBrojevi[5].ToString();
            txtDobitni7.Text = loto.DobitniBrojevi[6].ToString();
            int brojPogodaka = 0;
            foreach (int broj in loto.UplaceniBrojevi)
            {
                if (loto.DobitniBrojevi.Contains(broj) == true)
                {
                    brojPogodaka++;
                }
            }
            lblBrojPogodakaaa.Text = brojPogodaka.ToString();
        }
    }
}
