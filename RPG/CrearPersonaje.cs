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
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace RPG
{
    public partial class FrmCrearPersonaje : Form
    {
        public FrmCrearPersonaje()
        {
            InitializeComponent();
            pboxMasculino.Image = Image.FromFile("..\\..\\img\\Actor1-1 (2).png");
            pboxFemenino.Image = Image.FromFile("..\\..\\img\\Actor1-2 (2).png");
        }

        private void btnCrearPer_Click(object sender, EventArgs e)
        {
        //asegurarnos que se han puesto datos
            string nombre = txtbNombrePers.Text;
            GeneroEntidad generoEntidad;
            ClaseFisicaEntidad claseFisica;
            ClaseMagicaEntidad claseMagica;

            if (String.IsNullOrEmpty(txtbNombrePers.Text) || txtbNombrePers.Text[0] == ' ')
            {
                MessageBox.Show("Debes ingresar un nombre. \nEl nombre no puede empezar con espacio.");
                return;
            }
            if (this.rdbMasculino.Checked)
            {
                generoEntidad = GeneroEntidad.Masculino;
               // imagen = Image.FromFile("..\\..\\img\\Actor1-1 (2).png");
            }
            else if (this.rdbFemenino.Checked)
            {
                generoEntidad = GeneroEntidad.Femenino;
              //  imagen = Image.FromFile("..\\..\\img\\Actor1-2 (2).png");
            }
            else
            {
                MessageBox.Show("Debes seleccionar un género.");
                return;
            }

            if (this.cboxClaseFis.Text == "Arco")
                claseFisica = ClaseFisicaEntidad.Arco;
            else if (this.cboxClaseFis.Text == "Espada")
                claseFisica = ClaseFisicaEntidad.Espada;
            else if (this.cboxClaseFis.Text == "Lanza")
                claseFisica = ClaseFisicaEntidad.Lanza;
            else 
            {
                MessageBox.Show("Debes seleccionar una clase física.");
                return;
            }

            if (this.cboxClaseMag.Text == "Agua")
                claseMagica = ClaseMagicaEntidad.Agua;
            else if (this.cboxClaseMag.Text == "Fuego")
                claseMagica = ClaseMagicaEntidad.Fuego;
            else if (this.cboxClaseMag.Text == "Planta")
                claseMagica = ClaseMagicaEntidad.Planta;
            else
            {
                MessageBox.Show("Debes seleccionar una clase mágica.");
                return;
            }

            Protagonista jugador = new Protagonista(nombre, generoEntidad, claseFisica, claseMagica);
            Archivos.GuardarPersonaje(jugador);
            Estadisticas stats = new Estadisticas();
            stats.Show();
            this.Close();
        }
        
       
    }
}
