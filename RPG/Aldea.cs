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
    public partial class Aldea : Form
    {
        private Protagonista[] equipo;
        private SpritePersonaje sprite;
        public Aldea(Protagonista[] equipo)
        {
            InitializeComponent();
            this.equipo = equipo;
            sprite = new SpritePersonaje(equipo[0], pbEscenarioA.Height, pbEscenarioA.Width);
            pbTienda.Image = Image.FromFile("..\\..\\img\\House.png");
            pbTorre1.Image = Image.FromFile("..\\..\\img\\Torre.png");
            pbTorre2.Image = Image.FromFile("..\\..\\img\\Torre.png");
            pbTorre3.Image = Image.FromFile("..\\..\\img\\Torre.png");
            pbCastillo.Image = Image.FromFile("..\\..\\img\\Castillo.png");
        }

        private void pbEscenarioA_Paint(object sender, PaintEventArgs e)
        {
            sprite.Dibujar(e.Graphics);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    sprite.MoverArr();
                    pbEscenarioA.Invalidate();
                    return true;
                case Keys.Down:
                    sprite.MoverAbj();
                    pbEscenarioA.Invalidate();
                    return true;
                case Keys.Left:
                    sprite.MoverIzq();
                    pbEscenarioA.Invalidate();
                    return true;
                case Keys.Right:
                    sprite.MoverDer();
                    pbEscenarioA.Invalidate();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void Colision()
        {
            if (sprite.getImage().GetBounds(ref sprite.g)
        }
    }
}
