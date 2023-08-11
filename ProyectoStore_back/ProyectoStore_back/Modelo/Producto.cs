using System;

namespace ProyectoStore_back.Modelo
{
    public class Producto
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public string estado { get; set; }
        public string detalle { get; set; }
        public string imagen { get; set; }
    }
}