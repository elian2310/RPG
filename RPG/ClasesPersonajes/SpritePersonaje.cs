using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace RPG.ClasesPersonajes
{
    public class SpritePersonaje
    {
        private int dinero;
        private double mitad;
        private double altoe;
        private double anchoe;
        private double x;
        private double y;
        private int torres;
        private Image i;
        private Protagonista p;

        public SpritePersonaje(Protagonista p,double altoe, double anchoe)
        {
            dinero = 0;
            torres = 0;
            this.mitad = Math.Min(anchoe, altoe) / 50;
            this.altoe = altoe;
            this.anchoe = anchoe;
            this.x = anchoe / 2;
            this.y = altoe / 2;
            if (p.Genero.ToString() == "Masculino")
                i = Image.FromFile("..\\..\\img\\SpriteMAbj.png");
            else if (p.Genero.ToString() == "Femenino")
                i = Image.FromFile("..\\..\\img\\SpriteFAbj.png");
        }
        public void MoverArr()
        {
            if (p.Genero.ToString() == "Masculino")
                i = Image.FromFile("..\\..\\img\\SpriteMArr.png");
            else if (p.Genero.ToString() == "Femenino")
                i = Image.FromFile("..\\..\\img\\SpriteFArr.png");
            y -= 5;
        }
        public void MoverAbj()
        {
            if (p.Genero.ToString() == "Masculino")
                i = Image.FromFile("..\\..\\img\\SpriteMAbj.png");
            else if (p.Genero.ToString() == "Femenino")
                i = Image.FromFile("..\\..\\img\\SpriteFAbr.png");
            y += 5;
        }
        public void MoverIzq()
        {
            if (p.Genero.ToString() == "Masculino")
                i = Image.FromFile("..\\..\\img\\SpriteMIzq.png");
            else if (p.Genero.ToString() == "Femenino")
                i = Image.FromFile("..\\..\\img\\SpriteFIzq.png");
            x -= 5;
        }
        public void MoverDer()
        {
            if (p.Genero.ToString() == "Masculino")
                i = Image.FromFile("..\\..\\img\\SpriteMDer.png");
            else if (p.Genero.ToString() == "Femenino")
                i = Image.FromFile("..\\..\\img\\SpriteFDer.png");
            x += 5;
        }
        public void Dibujar(Graphics graphics)
        {
            graphics.DrawImage(i, (int)(x - mitad), (int)(y - mitad), (int)(mitad), (int)(2 * mitad));
        }
        public Image getImage()
        {
            return i;
        }
    }
}
