using Microsoft.AspNetCore.Mvc;
using ProyectoStore_back.Data;
using ProyectoStore_back.Servicios;
using System.Threading.Tasks;
using System;
using ProyectoStore_back.Modelo;

namespace ProyectoStore_back.Controllers
{

    [ApiController]
    [Route("api/usuarios")]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuariosServices _usuarioService;
        //private readonly JwtService _jwtService;

        public  UsuariosController(UsuariosServices usuarioService)
        {
            //_usuarioService = new UsuariosServices(dbContext);
            _usuarioService = usuarioService;

        }


        //[HttpGet]
        //public async Task<IActionResult> ObtenerUsuarioPorCredenciales(string correo, string contrasena)
        //{

        //    try
        //    {
        //        var usuario = await _usuarioService.ObtenerUsuarioPorCredenciales(correo, contrasena);

        //        if (usuario != null)
        //        {
        //            return Ok(usuario);
        //        }
        //        else
        //        {
        //            return NotFound();
        //        }
        //    }
        //    catch (InvalidOperationException ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        [HttpPost]
        public async Task<IActionResult> ObtenerUsuarioPorCredenciales([FromBody] Credenciales credenciales)
        {
            if (credenciales == null || string.IsNullOrEmpty(credenciales.Correo) || string.IsNullOrEmpty(credenciales.Contrasena))
            {
                return BadRequest("Ingrese las credenciales");
            }

            try
            {
                var usuario = await _usuarioService.ObtenerUsuarioPorCredenciales(credenciales.Correo, credenciales.Contrasena);

                if (usuario != null)
                {
                    return Ok(usuario);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }



    }
}
