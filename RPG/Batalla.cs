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
    public partial class Batalla : Form
    {
        private SpritePersonaje sprite;
        private Protagonista[] equipo;
        private Enemigo f;
        private Random r;
        public Batalla(Protagonista[] equipo, SpritePersonaje sprite)
        {
            InitializeComponent();
            r = new Random();            
            this.equipo = equipo;
            int nivenemigo = equipo[0].Nivel + r.Next(1, 5);
            Enemigo f = new Enemigo(nivenemigo);
        }
        
        private void btnatacar_Click(object sender, EventArgs e)
        {
            equipo[i].Atacar();
        }

        private void btnhabilidad_Click(object sender, EventArgs e)
        {
            Habilidad habilidad = new Habilidad(equipo[i], f);
            habilidad.Show();

        }

        private void btnobjeto_Click(object sender, EventArgs e)
        {
            equipo[i].Objeto();
        }

        private void btndefensa_Click(object sender, EventArgs e)
        {
            equipo[i].Defender();
        }

        private void btnescapar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int escape = r.Next(1, 10);
            if (escape<=4)
            {

            }
            else
            {
                MessageBox.Show("El intento de escape ha fallado.");
            }
        }
        private void Comenzar()
        {
            bool fin_turno = false;
            bool fin_batalla = false;
            bool gameover = false;
        }
    }
}
