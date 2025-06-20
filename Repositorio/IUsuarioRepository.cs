namespace SLN_USUARIOS_ANGULAR.Repositorio
{
    public interface IUsuarioRepository
    {
        Task InsertarUsuarioAsync(UsuarioDTO usuario);
    }
}
