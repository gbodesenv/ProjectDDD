namespace Rj.SME.Sismonrio.Service.Services
{
    using Domain.Contracts.Services;
    using Domain.Contracts.Infra.Data;
    using Domain.Contracts.Data.Repositories;

    public class UsuarioService : Service, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepositorio;

        public UsuarioService(IUnitOfWork uow) 
            : base(uow)
        {
        }






    }
}
