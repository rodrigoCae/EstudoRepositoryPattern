using DataAccess.Domain;
using DataAccess.Repository;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IClienteRepository : IRepository<TbCliente>
    {
        IEnumerable<TbCliente> GetClientesPorNome();
    }
}
