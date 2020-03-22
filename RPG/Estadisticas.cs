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
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            Protagonista jugador = new Protagonista();
            jugador = Archivos.CargarPersonaje();
            lblnombre.Text = jugador.Nombre;
            lblgenero.Text = jugador.Genero.ToString();
            lblclasefis.Text = jugador.ClaseFisica.ToString();
            lblclasemag.Text = jugador.ClaseMagica.ToString();
            if (jugador.Genero.ToString() == "Masculino")
                pbPersonaje.Image = Image.FromFile("..\\..\\img\\Actor1-1 (2).png");
            else if (jugador.Genero.ToString() == "Femenino")
                pbPersonaje.Image = Image.FromFile("..\\..\\img\\Actor1-2 (2).png");

        }

        private void btnhecho_Click(object sender, EventArgs e)
        {
            Equipo equipo = new Equipo();
            equipo.Show();
            this.Close();
        }

        private void btncambiar_Click(object sender, EventArgs e)
        {
            FrmCrearPersonaje crearpersonaje = new FrmCrearPersonaje();
            crearpersonaje.Show();
            this.Close();
        }
    }
}
