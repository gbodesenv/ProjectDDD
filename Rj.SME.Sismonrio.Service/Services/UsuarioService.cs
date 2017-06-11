namespace Rj.SME.Sismonrio.Service.Services
{
    using Domain.Contracts.Services;
    using Domain.Contracts.Infra.Data;
    using Domain.Contracts.Data.Repositories;
    using Domain.Entities;
    using Domain.Filters;
    using System;
    using System.Collections.Generic;

    public class UsuarioService : Service, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepositorio;

        public UsuarioService(IUnitOfWork uow) 
            : base(uow)
        {
        }

        public Usuario Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> Listar(UsuarioFilter filtro)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> ListarGrid(UsuarioFilter filtro)
        {
            throw new NotImplementedException();
        }

        public void Salvar(Usuario entidade)
        {
            throw new NotImplementedException();
        }

        public bool ValidarUsuario(string email, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
