using DataAccess.Domain;
using DataAccess.Repository;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class ClienteBusinessLogic : IDisposable
    {
        UnitOfWork _uow;
        public ClienteBusinessLogic(UnitOfWork uow)
        {
            _uow = uow;
        }

        public ClienteBusinessLogic()
        {
            _uow = new UnitOfWork();
        }

        public IEnumerable<TbCliente> ListarClientes()
        {
            return _uow.ClienteRepository.Get();
        }

        public void AdicionarCliente(TbCliente cli)
        {
            _uow.ClienteRepository.Add(cli);
            _uow.Commit();
        }

        public void ExcluirCliente(TbCliente cli)
        {
            _uow.ClienteRepository.Delete(cli);
            _uow.Commit();
        }

        public void AlterarCliente(TbCliente cli)
        {
            _uow.ClienteRepository.Update(cli);
            _uow.Commit();
        }

        public TbCliente GetClientePorId(int codigo)
        {
            return _uow.ClienteRepository.GetById(c => c.Id == codigo);
        }

        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}
