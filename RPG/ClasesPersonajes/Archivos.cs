using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace RPG.ClasesPersonajes
{
    class Archivos
    {
        private static string SettingsFolder
        {
            get
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                folder = Path.Combine(folder, "RPG Proyecto Final");
                folder = Path.Combine(folder, "SettingsPersonaje");
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                return folder;
            }
        }
        private static string JugadorSettingsFile
        {
            get
            {
                return Path.Combine(SettingsFolder, "Jugador.xml");
            }
        }
        private static Protagonista DefaultSettings
        {
            get
            {
                return new Protagonista
                {
                    Nombre = "",
                    Genero = GeneroEntidad.Desconocido,
                    ClaseFisica = ClaseFisicaEntidad.Desconocido,
                    ClaseMagica = ClaseMagicaEntidad.Desconocido,
                    Ataque = 0,
                    Salud = 0,
                    Energia = 0,
                    Velocidad = 0,
                };
            }
        }
        public static void GuardarPersonaje(Protagonista usuario)
        {
            using (Stream stream = File.Create(JugadorSettingsFile))
            {
                XmlSerializer ser = new XmlSerializer(usuario.GetType());
                ser.Serialize(stream, usuario);
            }
        }
        public static Protagonista CargarPersonaje()
        {
            if (!File.Exists(JugadorSettingsFile))
                return DefaultSettings;
            using (Stream stream = File.OpenRead(JugadorSettingsFile))
            {
                XmlSerializer ser = new XmlSerializer(typeof(Protagonista));
                return (Protagonista)ser.Deserialize(stream);
            }
        }
    }
}
