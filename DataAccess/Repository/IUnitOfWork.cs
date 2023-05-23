using DataAccess.Domain;

namespace DataAccess.Repository
{
    public interface IUnitOfWork
    {
        IRepository<TbCliente> ClienteRepository { get; }
        void Commit();
    }
}
