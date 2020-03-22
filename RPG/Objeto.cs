using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPG.ClasesPersonajes;

namespace RPG
{
    public partial class Objeto : Form
    {
        private Protagonista p;
        public Objeto(Protagonista p)
        {
            InitializeComponent();
            lblCantidadPS.Text = p.PocionS.ToString();
            lblCantidadPE.Text = p.PocionE.ToString();
            lblCantidadPR.Text = p.PocionR.ToString();
        }

        private void btnPSalud_Click(object sender, EventArgs e)
        {
            if (p.PocionS>=1&&p.Vivo)
            {
                p.Salud += p.SaludMax / 3;
                p.PocionS--;
                this.Close();
            }
            else if (p.PocionS<=0)
            {
                MessageBox.Show("No quedan pociondes de salud.");
            }
            else if (!p.Vivo)
            {
                MessageBox.Show("No se pueden usar pociondes de salud cuando estas debilitado.");
            }
            
        }

        private void btnPEnergia_Click(object sender, EventArgs e)
        {
            if (p.PocionE >= 1)
            {
                p.Energia += p.EnergiaMax / 3;
                p.PocionE--;
                this.Close();
            }
            else if(p.PocionE <= 0)
            {
                MessageBox.Show("No quedan pociondes de energía.");
            }
            else if (!p.Vivo)
            {
                MessageBox.Show("No se pueden usar pociondes de energía cuando estas debilitado.");
            }
            
        }

        private void btnPRevivir_Click(object sender, EventArgs e)
        {
            if (p.PocionR >= 1)
            {
                p.Salud += p.SaludMax / 4;
                p.Vivo = true;
                p.PocionR--;
                this.Close();
            }
            else
            {
                MessageBox.Show("No quedan pociones revivir.");
            }
            
        }
    }
}
