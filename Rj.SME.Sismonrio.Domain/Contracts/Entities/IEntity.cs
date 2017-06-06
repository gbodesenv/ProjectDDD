using System;
namespace Rj.SME.Sismonrio.Domain.Contracts
{
    public interface IEntity : ICloneable
    {
        int Id { get; set; }
        bool Excluido { get; set; }

        void Validate();
    }
}
