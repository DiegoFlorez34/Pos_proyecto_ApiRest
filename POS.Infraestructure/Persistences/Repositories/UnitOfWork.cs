using POS.Infraestructure.Persistences.Context;
using POS.Infraestructure.Persistences.Interfaces;

namespace POS.Infraestructure.Persistences.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly POSContext _context;
        public ICategoryRepository Category  { get;private set; }

        public IUserRepository User { get; private set; }

        public IProviderRepository Provider { get; private set; }

        public UnitOfWork(POSContext context, IUserRepository user)
        {
            _context = context;
            Category = new CategoryRepository(_context);
            User = new UserRepository(_context);
            Provider = new ProviderRepository(_context);
            
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChange()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
