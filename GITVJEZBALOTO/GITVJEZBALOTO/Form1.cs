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
            }
        }
    }
}
