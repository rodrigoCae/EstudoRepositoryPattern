using DataAccess.Context;
using DataAccess.Domain;
using System;

namespace DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public AppDbContext _context;
        private Repository<TbCliente> _clienteRepository;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public UnitOfWork()
        {
            _context = new AppDbContext();
        }

        public IRepository<TbCliente> ClienteRepository
        {
            get
            {
                return _clienteRepository = _clienteRepository ?? new Repository<TbCliente>(_context);
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
