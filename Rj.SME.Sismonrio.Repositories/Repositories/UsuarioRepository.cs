namespace Rj.SME.Sismonrio.Repositories.Repositories
{
    using Domain.Filters;
    using Domain.Entities;
    using Domain.Contracts.Data.Repositories;
    using Context;
    using Global;

    public class UsuarioRepository : Repository<Usuario, UsuarioFilter>, IUsuarioRepository
    {
        public UsuarioRepository(IContextFactory dbContextFactory)
            : base(dbContextFactory)
        {
        }
    }
}
