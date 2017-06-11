namespace Rj.SME.Sismonrio.Domain.Contracts.Data.Repositories
{   
    using Entities;
    using Filters;
    using Global;

    public interface IUsuarioRepository : IRepository<Usuario, UsuarioFilter>
    {
        bool ValidarUsuario(string email, string senha);
    }
}
