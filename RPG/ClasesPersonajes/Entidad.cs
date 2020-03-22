using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RPG.ClasesPersonajes
{
    public enum GeneroEntidad { Masculino, Femenino, Desconocido}
    public enum ClaseFisicaEntidad { Arco, Espada, Lanza, Desconocido}
    public enum ClaseMagicaEntidad { Agua, Fuego, Planta, Desconocido}
    public abstract class Entidad
    {
        #region Region Variables
        protected string nombre;
        protected GeneroEntidad genero;
        protected ClaseFisicaEntidad clasefisica;
        protected ClaseMagicaEntidad clasemagica;
        protected int salud, saludmax, energia, energiamax, ataque, velocidad, experiencia, experienciamax, nivel, pocions, pocione, pocionr;
        protected int modifsalud, modifenergia, modifataque, modifvelocidad;
        protected bool defensa, vivo;
        #endregion

        #region Region Propiedades
      
        public string Nombre
        {
            get { return nombre; }
             set { nombre = value; }
        }
        public GeneroEntidad Genero
        {
            get { return genero; }
             set { genero = value; }
        }
        public ClaseFisicaEntidad ClaseFisica
        {
            get { return clasefisica; }
             set { clasefisica = value; }
        }
        public ClaseMagicaEntidad ClaseMagica
        {
            get { return clasemagica; }
             set { clasemagica = value; }
        }
        public int Salud
        {
            get { return salud+modifsalud; }
             set { salud = value; } //solo miembros de la clase pueden cambiarlo
        }
        public int SaludMax
        {
            get { return saludmax; }
            set { saludmax = value; } //solo miembros de la clase pueden cambiarlo
        }
        public int Energia
        {
            get { return energia + modifenergia; }
             set { energia = value; } //solo miembros de la clase pueden cambiarlo
        }
        public int EnergiaMax
        {
            get { return energiamax; }
            set { energiamax = value; } //solo miembros de la clase pueden cambiarlo
        }
        public int Ataque
        {
            get { return ataque + modifataque; }
             set { ataque = value; } //solo miembros de la clase pueden cambiarlo
        }
        public int Velocidad
        {
            get { return velocidad + modifvelocidad; }
             set { velocidad = value; } //solo miembros de la clase pueden cambiarlo
        }
        public int Experiencia
        {
            get { return experiencia; }
             set { experiencia = value; } //solo miembros de la clase pueden cambiarlo
        }
        public int PocionS
        {
            get { return pocions; }
            set { pocions = value; }
        }
        public int PocionE
        {
            get { return pocione; }
            set { pocione = value; }
        }
        public int PocionR
        {
            get { return pocionr; }
            set { pocionr = value; }
        }
        public int ExperienciaMax
        {
            get { return experienciamax; }
             set { experienciamax = value; } //solo miembros de la clase pueden cambiarlo
        }
        public int Nivel
        {
            get { return nivel; }
             set { nivel = value; } //solo miembros de la clase pueden cambiarlo
        }
        public bool Defensa
        {
            get { return defensa; }
            set { defensa = value; }
        }
        public bool Vivo
        {
            get { return vivo; }
            set { vivo = value; }
        }
        #endregion

        #region Region Constructor
        public Entidad()
        {
            Nombre = "";
            Genero = GeneroEntidad.Desconocido;
            ClaseFisica = ClaseFisicaEntidad.Desconocido;
            ClaseMagica = ClaseMagicaEntidad.Desconocido;
            Salud = 0;
            Energia = 0;
            Ataque = 0;
            Velocidad = 0;
            Experiencia = 0;
            ExperienciaMax = 0;
            Nivel = 0;
            Defensa = false;

        }
        #endregion

        #region Region Metodos
        public string MostrarDatos()
        {
            string datos;
            datos = String.Format("Nombre: {0}" +
                "\nGénero: {1}\nClase Física: {2}\nClase Mágica: {3}", Nombre, Genero.ToString(),
                ClaseFisica.ToString(), ClaseMagica.ToString());
            return datos;
        }
        #endregion
    }
}
