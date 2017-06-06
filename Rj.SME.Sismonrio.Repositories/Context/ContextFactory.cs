namespace Rj.SME.Sismonrio.Repositories.Context
{
    using System;
    using System.Data.Common;
    
    public sealed class ContextFactory : IContextFactory
    {
        private SismonrioContext _context;

        public ContextFactory()
        {
            _context = new SismonrioContext();
        }

        public SismonrioContext GetDbContext()
        {
            return _context;
        }

        public void SetInMemoryDbContext(DbConnection connection)
        {
            _context = new SismonrioContext(connection);
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                GC.SuppressFinalize(this);
            }
        }
    }
}
