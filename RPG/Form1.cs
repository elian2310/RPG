using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class FrmMenuPrin : Form
    {
        public FrmMenuPrin()
        {
            InitializeComponent();
        }

        private void FrmMenuPrin_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevaPar_Click(object sender, EventArgs e)
        {
            FrmCrearPersonaje crearpersonaje = new FrmCrearPersonaje();
            crearpersonaje.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
