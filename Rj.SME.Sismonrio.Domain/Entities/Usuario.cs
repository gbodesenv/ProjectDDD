using Rj.SME.Sismonrio.Domain.Contracts;

namespace Rj.SME.Sismonrio.Domain.Entities
{
    public class Usuario : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public bool Excluido { get; set; }

        public void Validate()
        {
            //var validationResultsManager = new ValidationResultsManager();

            //// Required

            //// Optional
            //if (validationResultsManager.HasError)
            //    validationResultsManager.ThrowBusinessValidationError();
        }

        // Clona os dados da entidade
        public object Clone()
        {
            var entidade = new Usuario();
            entidade.Nome = this.Nome;
            return entidade;
        }
    }

}
