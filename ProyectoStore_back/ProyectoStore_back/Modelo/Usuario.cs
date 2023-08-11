using System.Data;
using System.Globalization;

namespace ProyectoStore_back.Modelo
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }

        public string correo { get; set; }
        public string contrseña { get; set; }

    }
}
