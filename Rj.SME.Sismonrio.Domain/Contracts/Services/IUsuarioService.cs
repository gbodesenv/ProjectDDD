using System.Collections.Generic;
namespace Rj.SME.Sismonrio.Domain.Contracts.Services
{
    using Entities;
    using Filters;
    public interface IUsuarioService
    {        
        Usuario Buscar(int id);
        IEnumerable<Usuario> Listar(UsuarioFilter filtro);
        IEnumerable<Usuario> ListarGrid(UsuarioFilter filtro);
        bool ValidarUsuario(string email, string senha);

        void Salvar(Usuario entidade);
        void Excluir(int id);
    }
}
