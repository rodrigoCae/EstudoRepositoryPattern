using DataAccess.Context;
using DataAccess.Domain;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BusinessLogic
{
    public class ClienteRepository : IRepository<TbCliente>, IClienteRepository
    {
        AppDbContext _context;
        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(TbCliente entity)
        {
            _context.TbClientes.Add(entity);
        }

        public void Delete(TbCliente entity)
        {
            _context.TbClientes.Remove(entity);
        }

        public IEnumerable<TbCliente> Get()
        {
            return _context.TbClientes.ToList();
        }

        public IEnumerable<TbCliente> Get(Expression<Func<TbCliente, bool>> predicate)
        {
            return _context.TbClientes.Where(predicate);
        }

        public TbCliente GetById(Expression<Func<TbCliente, bool>> predicate)
        {
            return _context.TbClientes.FirstOrDefault(predicate);
        }

        public IEnumerable<TbCliente> GetClientesPorNome()
        {
            return Get().OrderBy(c => c.Nome).ToList();
        }

        public void Update(TbCliente entity)
        {
            _context.TbClientes.Update(entity);
        }
    }
}
