namespace ProyectoStore_back.Modelo
{
    public interface IJwtService
    {
        string GenerateToken(Usuario usuario);
    }

}
