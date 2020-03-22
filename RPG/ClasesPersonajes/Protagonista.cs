using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RPG.ClasesPersonajes
{
    public class Protagonista : Entidad
    {
        public Protagonista() :base()
        {
        }
        public Protagonista(string nombre, GeneroEntidad genero, ClaseFisicaEntidad clasefisica, ClaseMagicaEntidad clasemagica) : base()
        {
            Nombre = nombre;
            Genero = genero;
            ClaseFisica = clasefisica;
            ClaseMagica = clasemagica;
            SaludMax = 15;
            Salud = SaludMax;
            EnergiaMax = 20;
            Energia = EnergiaMax;
            Ataque = 5;
            Velocidad = 5;
            Nivel = 1;
            ExperienciaMax = 20;
            Experiencia = 0;
            PocionS = 0;
            PocionE = 0;
            PocionR = 0;
            Defensa = false;
            Vivo = true;
        }
        public void Atacar(Enemigo e)
        {
           if ((ClaseFisica == ClaseFisicaEntidad.Arco && e.ClaseFisica == ClaseFisicaEntidad.Espada)||
                (ClaseFisica == ClaseFisicaEntidad.Espada && e.ClaseFisica == ClaseFisicaEntidad.Lanza)||
                (ClaseFisica == ClaseFisicaEntidad.Lanza && e.ClaseFisica == ClaseFisicaEntidad.Arco))
            {
                e.Salud -= Ataque * 2;
            }
           else if ((ClaseFisica == ClaseFisicaEntidad.Espada && e.ClaseFisica == ClaseFisicaEntidad.Arco) ||
                (ClaseFisica == ClaseFisicaEntidad.Lanza && e.ClaseFisica == ClaseFisicaEntidad.Espada) ||
                (ClaseFisica == ClaseFisicaEntidad.Arco && e.ClaseFisica == ClaseFisicaEntidad.Lanza))
            {
                e.Salud -= Ataque / 2;
            }
           else if (ClaseFisica==e.ClaseFisica)
            {
                e.Salud -= Ataque;
            }
        }
        public void Habilidad(Enemigo e)
        {

        }
        public void Defender()
        {
            Defensa = true;
        }
    }
}
