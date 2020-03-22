using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ClasesPersonajes
{
    public class Enemigo : Entidad
    {
        private Random r;
        private Random s;
        public Enemigo(int nivel) : base()
        {
            r = new Random();
            s = new Random();
            int cf = r.Next(1, 3);
            int cm = s.Next(1, 3);
            Nombre = "";
            Genero = GeneroEntidad.Desconocido;
            switch (cf)
            {
                case 1:
                    ClaseFisica = ClaseFisicaEntidad.Espada;
                    break;
                case 2:
                    ClaseFisica = ClaseFisicaEntidad.Arco;
                    break;
                case 3:
                    ClaseFisica = ClaseFisicaEntidad.Lanza;
                    break;
                default:
                    break;
            }
            switch (cm)
            {
                case 1:
                    ClaseMagica = ClaseMagicaEntidad.Agua;
                    break;
                case 2:
                    ClaseMagica = ClaseMagicaEntidad.Fuego;
                    break;
                case 3:
                    ClaseMagica = ClaseMagicaEntidad.Planta;
                    break;
                default:
                    break;
            }
            ClaseMagica = clasemagica;
            SaludMax = 30*(nivel/2);
            Salud = SaludMax;
            EnergiaMax = 10000;
            Energia = EnergiaMax;
            Ataque = 7*nivel;
            Velocidad = 5*nivel;
            Nivel = nivel;
            ExperienciaMax = 10000;
            Experiencia = 0;
            Defensa = false;
            Vivo = true;
        }
        public void Atacar(Protagonista p)
        {
            if ((ClaseFisica == ClaseFisicaEntidad.Arco && p.ClaseFisica == ClaseFisicaEntidad.Espada) ||
                (ClaseFisica == ClaseFisicaEntidad.Espada && p.ClaseFisica == ClaseFisicaEntidad.Lanza) ||
                (ClaseFisica == ClaseFisicaEntidad.Lanza && p.ClaseFisica == ClaseFisicaEntidad.Arco))
            {
                p.Salud -= Ataque * 2;
            }
            else if ((ClaseFisica == ClaseFisicaEntidad.Espada && p.ClaseFisica == ClaseFisicaEntidad.Arco) ||
                 (ClaseFisica == ClaseFisicaEntidad.Lanza && p.ClaseFisica == ClaseFisicaEntidad.Espada) ||
                 (ClaseFisica == ClaseFisicaEntidad.Arco && p.ClaseFisica == ClaseFisicaEntidad.Lanza))
            {
                p.Salud -= Ataque / 2;
            }
            else if (ClaseFisica == p.ClaseFisica)
            {
                p.Salud -= Ataque;
            }
        }
        public void Habilidad(Protagonista p)
        {
            Random r = new Random();
            Random s = new Random();
            int tipo = r.Next(1, 2);
            int potencia = r.Next(2, 4);
            if (tipo == 1)
            {
                if ((ClaseFisica == ClaseFisicaEntidad.Arco && p.ClaseFisica == ClaseFisicaEntidad.Espada) ||
                (ClaseFisica == ClaseFisicaEntidad.Espada && p.ClaseFisica == ClaseFisicaEntidad.Lanza) ||
                (ClaseFisica == ClaseFisicaEntidad.Lanza && p.ClaseFisica == ClaseFisicaEntidad.Arco))
                {
                    p.Salud -= (Ataque * 2)+(potencia*Nivel);
                }
                else if ((ClaseFisica == ClaseFisicaEntidad.Espada && p.ClaseFisica == ClaseFisicaEntidad.Arco) ||
                     (ClaseFisica == ClaseFisicaEntidad.Lanza && p.ClaseFisica == ClaseFisicaEntidad.Espada) ||
                     (ClaseFisica == ClaseFisicaEntidad.Arco && p.ClaseFisica == ClaseFisicaEntidad.Lanza))
                {
                    p.Salud -= (Ataque / 2) + (potencia * Nivel);
                }
                else if (ClaseFisica == p.ClaseFisica)
                {
                    p.Salud -= Ataque + (potencia * Nivel);
                }
            }
            else if (tipo == 2)
            {
                if ((ClaseMagica == ClaseMagicaEntidad.Agua && p.ClaseMagica == ClaseMagicaEntidad.Fuego) ||
                    (ClaseMagica == ClaseMagicaEntidad.Fuego && p.ClaseMagica == ClaseMagicaEntidad.Planta) ||
                    (ClaseMagica == ClaseMagicaEntidad.Planta && p.ClaseMagica == ClaseMagicaEntidad.Agua))
                {
                    p.Salud -= (Ataque * 2) + (potencia * Nivel);                   
                }
                else if ((ClaseMagica == ClaseMagicaEntidad.Fuego && p.ClaseMagica == ClaseMagicaEntidad.Agua) ||
                    (ClaseMagica == ClaseMagicaEntidad.Planta && p.ClaseMagica == ClaseMagicaEntidad.Fuego) ||
                    (ClaseMagica == ClaseMagicaEntidad.Agua && p.ClaseMagica == ClaseMagicaEntidad.Planta))
                {
                    p.Salud -= (Ataque / 2) + (potencia * Nivel);                  
                }
                else if (ClaseMagica == p.ClaseMagica)
                {
                    p.Salud -= Ataque + (potencia * p.Nivel);                   
                }
            }
        }
    }
}
