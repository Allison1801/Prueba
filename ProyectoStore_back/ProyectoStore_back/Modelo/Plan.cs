using System;

namespace ProyectoStore_back.Modelo
{
    public class Plan
    {
        public int id {  get; set; }
        public String nombre { get; set; }
        public String icono { get; set; }
        public String descripcion { get; set; }
        public String valor { get; set; }
        public String frecuencia { get; set; }
        public int cantidad { get; set; }
    
    }
}
