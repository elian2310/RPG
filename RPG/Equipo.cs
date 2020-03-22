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
    public partial class Equipo : Form
    {
        Protagonista[] equipo;
        Protagonista aliado1 = new Protagonista("Joseph", GeneroEntidad.Masculino, ClaseFisicaEntidad.Lanza, ClaseMagicaEntidad.Agua);
        Protagonista aliado2 = new Protagonista("Sylvia", GeneroEntidad.Femenino, ClaseFisicaEntidad.Arco, ClaseMagicaEntidad.Fuego);
        Protagonista aliado3 = new Protagonista("Lucía", GeneroEntidad.Femenino, ClaseFisicaEntidad.Lanza, ClaseMagicaEntidad.Agua);
        Protagonista aliado4 = new Protagonista("Julius", GeneroEntidad.Masculino, ClaseFisicaEntidad.Espada, ClaseMagicaEntidad.Fuego);
        Protagonista aliado5 = new Protagonista("Marie", GeneroEntidad.Femenino, ClaseFisicaEntidad.Espada, ClaseMagicaEntidad.Planta);
        public Equipo()
        {
            InitializeComponent();
            pbaliado1.Image = Image.FromFile("..\\..\\img\\Actor1-3.png");
            pbaliado2.Image = Image.FromFile("..\\..\\img\\Actor3-4.png");
            pbaliado3.Image = Image.FromFile("..\\..\\img\\Actor2-2.png");
            pbaliado4.Image = Image.FromFile("..\\..\\img\\Actor3-1.png");
            pbaliado5.Image = Image.FromFile("..\\..\\img\\Actor3-2.png");
        }

        private void Equipo_Load(object sender, EventArgs e)
        {
            
            lblnombrea1.Text = aliado1.Nombre;
            lblnombrea2.Text = aliado2.Nombre;
            lblnombrea3.Text = aliado3.Nombre;
            lblnombrea4.Text = aliado4.Nombre;
            lblnombrea5.Text = aliado5.Nombre;
            lblcfa1.Text = aliado1.ClaseFisica.ToString();
            lblcfa2.Text = aliado2.ClaseFisica.ToString();
            lblcfa3.Text = aliado3.ClaseFisica.ToString();
            lblcfa4.Text = aliado4.ClaseFisica.ToString();
            lblcfa5.Text = aliado5.ClaseFisica.ToString();
            lblcma1.Text = aliado1.ClaseMagica.ToString();
            lblcma2.Text = aliado2.ClaseMagica.ToString();
            lblcma3.Text = aliado3.ClaseMagica.ToString();
            lblcma4.Text = aliado4.ClaseMagica.ToString();
            lblcma5.Text = aliado5.ClaseMagica.ToString();
        }

        private void clbaliados_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && clbaliados.CheckedItems.Count >= 3)
                e.NewValue = CheckState.Unchecked;
        }

        private void btnhecho_Click(object sender, EventArgs e)
        {
            if (clbaliados.CheckedItems.Count < 3)
                MessageBox.Show("Debes escojer 3 aliados.");
            equipo = new Protagonista[4];
            Protagonista jugador = new Protagonista();
            jugador = Archivos.CargarPersonaje();
            equipo[0] = jugador;
            for (int i = 1; i < equipo.Length; i++)
            {
                if (clbaliados.GetItemCheckState(0) == CheckState.Checked && !equipo.Contains(aliado1))
                {
                    Archivos.GuardarPersonaje(aliado1);
                    equipo[i] = aliado1;
                }
                else if (clbaliados.GetItemCheckState(1) == CheckState.Checked && !equipo.Contains(aliado2))
                {
                    Archivos.GuardarPersonaje(aliado2);
                    equipo[i] = aliado2;
                }
                else if (clbaliados.GetItemCheckState(2) == CheckState.Checked && !equipo.Contains(aliado3))
                {
                    Archivos.GuardarPersonaje(aliado3);
                    equipo[i] = aliado3;
                }
                else if (clbaliados.GetItemCheckState(3) == CheckState.Checked && !equipo.Contains(aliado4))
                {
                    Archivos.GuardarPersonaje(aliado4);
                    equipo[i] = aliado4;
                }
                else if (clbaliados.GetItemCheckState(4) == CheckState.Checked && !equipo.Contains(aliado5))
                {
                    Archivos.GuardarPersonaje(aliado5);
                    equipo[i] = aliado5;
                }
            }
        }
    }

}
