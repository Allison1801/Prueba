using Microsoft.AspNetCore.Mvc;
using ProyectoStore_back.Servicios;
using System.Threading.Tasks;
using System;
using ProyectoStore_back.Data;

namespace ProyectoStore_back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly ProductoServices _productoService;

        public ProductosController(AppDBContext dbContext)
        { 
            _productoService = new ProductoServices(dbContext);
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetProductosAsync()
        {
            try
            {
                var productos = await _productoService.ObtenerProductosAsync();
                return Ok(productos);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
               
            }
        }
    }
}
