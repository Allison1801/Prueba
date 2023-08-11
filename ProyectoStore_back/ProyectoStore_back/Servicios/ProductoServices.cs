using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using ProyectoStore_back.Data;
using ProyectoStore_back.Modelo;

namespace ProyectoStore_back.Servicios
{
    public class ProductoServices
    {
        private readonly AppDBContext _dbContext;
        public ProductoServices(AppDBContext dbContext)
        {

            _dbContext = dbContext;
        }


        public async Task<List<Producto>> ObtenerProductosAsync()
        {
            return await _dbContext.Producto.ToListAsync(); // Ajusta esto al DbSet en tu contexto
        }
    }
}
