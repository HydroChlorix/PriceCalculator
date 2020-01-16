using Project.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess
{
    public class UnitOfWork : IDisposable
    {
        private bool _disposed = false;

        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                _context.Dispose();
            }

            // Free any unmanaged objects here.
            _disposed = true;
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}
