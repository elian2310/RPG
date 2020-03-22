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
    public partial class Habilidad : Form
    {
        Protagonista p;
        Enemigo f;
        public Habilidad(Protagonista p, Enemigo f)
        {
            InitializeComponent();
            this.p = p;
            this.f = f;
        }

        private void btnHFDebil_Click(object sender, EventArgs e)
        {
            if ((p.ClaseFisica == ClaseFisicaEntidad.Arco && f.ClaseFisica == ClaseFisicaEntidad.Espada) ||
               (p.ClaseFisica == ClaseFisicaEntidad.Espada && f.ClaseFisica == ClaseFisicaEntidad.Lanza) ||
               (p.ClaseFisica == ClaseFisicaEntidad.Lanza && f.ClaseFisica == ClaseFisicaEntidad.Arco))
            {
                f.Salud -= (p.Ataque * 2)+(2*p.Nivel);
                p.Salud -= (p.SaludMax / 100) * 5;
            }
            else if ((p.ClaseFisica == ClaseFisicaEntidad.Espada && f.ClaseFisica == ClaseFisicaEntidad.Arco) ||
                 (p.ClaseFisica == ClaseFisicaEntidad.Lanza && f.ClaseFisica == ClaseFisicaEntidad.Espada) ||
                 (p.ClaseFisica == ClaseFisicaEntidad.Arco && f.ClaseFisica == ClaseFisicaEntidad.Lanza))
            {
                f.Salud -= (p.Ataque / 2)+(2*p.Nivel);
                p.Salud -= (p.SaludMax / 100) * 5;
            }
            else if (p.ClaseFisica == f.ClaseFisica)
            {
                f.Salud -= p.Ataque+(2*p.Nivel);
                p.Salud -= (p.SaludMax / 100) * 5;
            }
            this.Close();
        }

        private void btnHFMedia_Click(object sender, EventArgs e)
        {
            if ((p.ClaseFisica == ClaseFisicaEntidad.Arco && f.ClaseFisica == ClaseFisicaEntidad.Espada) ||
               (p.ClaseFisica == ClaseFisicaEntidad.Espada && f.ClaseFisica == ClaseFisicaEntidad.Lanza) ||
               (p.ClaseFisica == ClaseFisicaEntidad.Lanza && f.ClaseFisica == ClaseFisicaEntidad.Arco))
            {
                f.Salud -= (p.Ataque * 2) + (3 * p.Nivel);
                p.Salud -= (p.SaludMax / 100) * 13;
            }
            else if ((p.ClaseFisica == ClaseFisicaEntidad.Espada && f.ClaseFisica == ClaseFisicaEntidad.Arco) ||
                 (p.ClaseFisica == ClaseFisicaEntidad.Lanza && f.ClaseFisica == ClaseFisicaEntidad.Espada) ||
                 (p.ClaseFisica == ClaseFisicaEntidad.Arco && f.ClaseFisica == ClaseFisicaEntidad.Lanza))
            {
                f.Salud -= (p.Ataque / 2) + (3 * p.Nivel);
                p.Salud -= (p.SaludMax / 100) * 13;
            }
            else if (p.ClaseFisica == f.ClaseFisica)
            {
                f.Salud -= p.Ataque + (3 * p.Nivel);
                p.Salud -= (p.SaludMax / 100) * 13;
            }
            this.Close();
        }

        private void btnHFFuerte_Click(object sender, EventArgs e)
        {
            if ((p.ClaseFisica == ClaseFisicaEntidad.Arco && f.ClaseFisica == ClaseFisicaEntidad.Espada) ||
               (p.ClaseFisica == ClaseFisicaEntidad.Espada && f.ClaseFisica == ClaseFisicaEntidad.Lanza) ||
               (p.ClaseFisica == ClaseFisicaEntidad.Lanza && f.ClaseFisica == ClaseFisicaEntidad.Arco))
            {
                f.Salud -= (p.Ataque * 2) + (4 * p.Nivel);
                p.Salud -= (p.SaludMax / 100) * 21;
            }
            else if ((p.ClaseFisica == ClaseFisicaEntidad.Espada && f.ClaseFisica == ClaseFisicaEntidad.Arco) ||
                 (p.ClaseFisica == ClaseFisicaEntidad.Lanza && f.ClaseFisica == ClaseFisicaEntidad.Espada) ||
                 (p.ClaseFisica == ClaseFisicaEntidad.Arco && f.ClaseFisica == ClaseFisicaEntidad.Lanza))
            {
                f.Salud -= (p.Ataque / 2) + (4 * p.Nivel);
                p.Salud -= (p.SaludMax / 100) * 21;
            }
            else if (p.ClaseFisica == f.ClaseFisica)
            {
                f.Salud -= p.Ataque + (4 * p.Nivel);
                p.Salud -= (p.SaludMax / 100) * 21;
            }
            this.Close();
        }

        private void btnHMDebil_Click(object sender, EventArgs e)
        {
            if (p.Energia >= 4)
            {
                if ((p.ClaseMagica == ClaseMagicaEntidad.Agua && f.ClaseMagica == ClaseMagicaEntidad.Fuego) ||
                    (p.ClaseMagica == ClaseMagicaEntidad.Fuego && f.ClaseMagica == ClaseMagicaEntidad.Planta) ||
                    (p.ClaseMagica == ClaseMagicaEntidad.Planta && f.ClaseMagica == ClaseMagicaEntidad.Agua))
                {
                    f.Salud -= (p.Ataque * 2) + (2 * p.Nivel);
                    p.Energia -= 4;
                }
                else if ((p.ClaseMagica == ClaseMagicaEntidad.Fuego && f.ClaseMagica == ClaseMagicaEntidad.Agua) ||
                    (p.ClaseMagica == ClaseMagicaEntidad.Planta && f.ClaseMagica == ClaseMagicaEntidad.Fuego) ||
                    (p.ClaseMagica == ClaseMagicaEntidad.Agua && f.ClaseMagica == ClaseMagicaEntidad.Planta))
                {
                    f.Salud -= (p.Ataque / 2) + (2 * p.Nivel);
                    p.Energia -= 4;
                }
                else if (p.ClaseMagica == f.ClaseMagica)
                {
                    f.Salud -= p.Ataque + (2 * p.Nivel);
                    p.Energia -= 4;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay energía suficiente");
            }
            
        }

        private void btnHMMedia_Click(object sender, EventArgs e)
        {
            if (p.Energia >= 8)
            {
                if ((p.ClaseMagica == ClaseMagicaEntidad.Agua && f.ClaseMagica == ClaseMagicaEntidad.Fuego) ||
                   (p.ClaseMagica == ClaseMagicaEntidad.Fuego && f.ClaseMagica == ClaseMagicaEntidad.Planta) ||
                   (p.ClaseMagica == ClaseMagicaEntidad.Planta && f.ClaseMagica == ClaseMagicaEntidad.Agua))
                {
                    f.Salud -= (p.Ataque * 2) + (3 * p.Nivel);

                }
                else if ((p.ClaseMagica == ClaseMagicaEntidad.Fuego && f.ClaseMagica == ClaseMagicaEntidad.Agua) ||
                    (p.ClaseMagica == ClaseMagicaEntidad.Planta && f.ClaseMagica == ClaseMagicaEntidad.Fuego) ||
                    (p.ClaseMagica == ClaseMagicaEntidad.Agua && f.ClaseMagica == ClaseMagicaEntidad.Planta))
                {
                    f.Salud -= (p.Ataque / 2) + (3 * p.Nivel);
                }
                else if (p.ClaseMagica == f.ClaseMagica)
                {
                    f.Salud -= p.Ataque + (3 * p.Nivel);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay energía suficiente");
            }
        }

        private void btnHMFuerte_Click(object sender, EventArgs e)
        {
            if (p.Energia >= 12)
            {
                if ((p.ClaseMagica == ClaseMagicaEntidad.Agua && f.ClaseMagica == ClaseMagicaEntidad.Fuego) ||
                   (p.ClaseMagica == ClaseMagicaEntidad.Fuego && f.ClaseMagica == ClaseMagicaEntidad.Planta) ||
                   (p.ClaseMagica == ClaseMagicaEntidad.Planta && f.ClaseMagica == ClaseMagicaEntidad.Agua))
                {
                    f.Salud -= (p.Ataque * 2) + (4 * p.Nivel);
                }
                else if ((p.ClaseMagica == ClaseMagicaEntidad.Fuego && f.ClaseMagica == ClaseMagicaEntidad.Agua) ||
                    (p.ClaseMagica == ClaseMagicaEntidad.Planta && f.ClaseMagica == ClaseMagicaEntidad.Fuego) ||
                    (p.ClaseMagica == ClaseMagicaEntidad.Agua && f.ClaseMagica == ClaseMagicaEntidad.Planta))
                {
                    f.Salud -= (p.Ataque / 2) + (4 * p.Nivel);
                }
                else if (p.ClaseMagica == f.ClaseMagica)
                {
                    f.Salud -= p.Ataque + (4 * p.Nivel);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay energía suficiente");
            }
        }

        private void btnHCDebil_Click(object sender, EventArgs e)
        {
            p.Salud += p.SaludMax / 4;
            this.Close();
        }

        private void btnHCMedia_Click(object sender, EventArgs e)
        {
            p.Salud += p.SaludMax / 2;
            this.Close();
        }

        private void btnHCCompleta_Click(object sender, EventArgs e)
        {
            p.Salud = p.SaludMax;
            this.Close();
        }
    }
}
