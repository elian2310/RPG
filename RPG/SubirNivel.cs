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
    public partial class SubirNivel : Form
    {
        private Protagonista p;
        private int puntos;
        public SubirNivel(Protagonista p)
        {
            InitializeComponent();
            this.p = p;
            puntos = 3;
            lblNombre.Text = p.Nombre;
            lblPuntos.Text = "Puntos disponibles: " + puntos.ToString();
            lblSaludMax.Text = p.SaludMax.ToString();
            lblEnergiaMax.Text = p.EnergiaMax.ToString();
            lblAtk.Text = p.Ataque.ToString();
            lblVel.Text = p.Velocidad.ToString();
        }

        private void btnSubirSM_Click(object sender, EventArgs e)
        {
            p.SaludMax++;
            puntos--;
            if (puntos <= 0)
                this.Close();
        }

        private void btnSubirAtk_Click(object sender, EventArgs e)
        {
            p.Ataque++;
            puntos--;
            if (puntos <= 0)
                this.Close();
        }

        private void btnSubirEM_Click(object sender, EventArgs e)
        {
            p.EnergiaMax++;
            puntos--;
            if (puntos <= 0)
                this.Close();
        }

        private void btnSubirVel_Click(object sender, EventArgs e)
        {
            p.Velocidad++;
            puntos--;
            if (puntos <= 0)
                this.Close();
        }
    }
}
