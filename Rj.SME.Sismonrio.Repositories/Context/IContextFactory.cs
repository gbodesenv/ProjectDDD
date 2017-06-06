using System;
using System.Data.Common;

namespace Rj.SME.Sismonrio.Repositories.Context
{
    public interface IContextFactory : IDisposable
    {
        SismonrioContext GetDbContext();
        void SetInMemoryDbContext(DbConnection connection);
    }
}