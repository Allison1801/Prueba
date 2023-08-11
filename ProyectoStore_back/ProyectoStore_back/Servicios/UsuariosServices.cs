using Azure;
using Microsoft.EntityFrameworkCore;
using ProyectoStore_back.Data;
using System.Threading.Tasks;
using System;
using ProyectoStore_back.Modelo;

namespace ProyectoStore_back.Servicios
{


    public class UsuariosServices
    {
        private readonly AppDBContext _dbContext;
        private readonly IJwtService _jwtService;
        public UsuariosServices(AppDBContext dbContext)
        {
            _dbContext = dbContext;
          


        }



        //Listar Usuarios
        public async Task<Responsive> ListarUsuariosAsync()
        {
            var responsive = new Responsive();

            try
            {
                var usuarios = await _dbContext.Usuario.ToListAsync();

                responsive.Code = "0001";
                responsive.Message = "Operación exitosa";
                responsive.Data = usuarios;

                
            }
            catch (Exception ex)
            {
                responsive.Code = "002";
                responsive.Message = "Credenciales inválidas";
            }
            return responsive;
        }

       

        public async Task<Responsive> ObtenerUsuarioPorCredenciales(string correo, string contrasena)
        {
            var responsive = new Responsive();

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasena))
            {
                responsive.Code = "000";
                responsive.Message = "Ingrese las credenciales";
                return responsive;
            }

            try
            {
                var usuario = await _dbContext.Usuario.FirstOrDefaultAsync(u => u.correo == correo && u.contrseña == contrasena);

                if (usuario != null)
                {
                    responsive.Code = "001";
                    responsive.Message = "Operación exitosa";
                    responsive.Data = usuario;

                    // Generar el token
                    //responsive.Token = _jwtService.GenerateToken(usuario);

                }
                else
                {
                    responsive.Code = "002";
                    responsive.Message = "Credenciales inválida";
                }
            }
            catch (Exception ex)
            {
                responsive.Code = "01";
                responsive.Message = "Error al obtener el usuario por credenciales";

            }

            return responsive;
        }

    }
}
