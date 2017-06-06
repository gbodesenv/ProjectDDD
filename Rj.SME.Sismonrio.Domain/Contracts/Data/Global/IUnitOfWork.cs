namespace Rj.SME.Sismonrio.Domain.Contracts.Infra.Data
{
    using System.Data.Entity;

    public interface IUnitOfWork
    {
        DbContextTransaction BeginTransaction();
        void RollbackTransaction();
        void CommitTransaction();
        void Commit();
        DbContextTransaction GetTransactionAtiva();
    }
}
